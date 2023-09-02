using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MTsystem_win.allClass;

namespace MTsystem_win
{
    public partial class Frm_Supplier : Form
    {
        public Frm_Supplier()
        {
            InitializeComponent();
        }

        #region 窗体主项功能代码段

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        JudgeNumber jnum = new JudgeNumber();

        int MaxID = 0;  //新编号存储变量


        private void Frm_Supplier_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Fsup == "CLOSE" || frmShowstatus._Fsup == null)
            {
                frmShowstatus._Fsup = "OPEN";
                SupplierSelest();
                dgvSupplier.DataSource = dv_Queryresult.ToTable("tb_supplierinfor");
                dgvHeadTextSet();
            }
        }

        private void Frm_Supplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Fsup = "CLOSE";
        }

        #endregion

        #region 查询标签代码段

        private void txtSupplierName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnSelect.Focus();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text.Trim().Length == 0)
            {
                dgvSupplier.DataSource = null;
                dv_Queryresult.Table = ds_Queryresult.Tables["tb_supplierinfor"];
                dv_Queryresult.RowFilter = null;
                dgvSupplier.DataSource = dv_Queryresult.ToTable();
                dgvHeadTextSet();
            }
            else
            {
                dgvSupplier.DataSource = null;
                dv_Queryresult.Table = ds_Queryresult.Tables["tb_supplierinfor"];
                dv_Queryresult.RowFilter = "SupplierName like '%" + txtSupplierName.Text.Trim() + "%'";
                dgvSupplier.DataSource = dv_Queryresult.ToTable();
                dgvHeadTextSet();
            }
        }
        /// <summary>
        /// 供应商信息检索
        /// </summary>
        private void SupplierSelest()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();

            string sqlstr = "SELECT ID,SupplierID,SupplierName,SupplierFrdb,SupplierLinkMan,";
            sqlstr += "SupplierMobile,SupplierPhone,SupplierFax,SupplierAddress,SupplierZcAddress,";
            sqlstr += "SupplierClTime,SupplierZczj,SupplierYgs,SupplierQyxz,SupplierTgcplx,";
            sqlstr += "SupplierBank,SupplierBankAccountNumber,SupplierShouKuanZhangHu,";
            sqlstr += "SupplierPrompt FROM tb_supplierinfor ORDER BY ID ASC";
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
            msda.Fill(ds_Queryresult, "tb_supplierinfor");

            dv_Queryresult.Table = ds_Queryresult.Tables["tb_supplierinfor"];
            dgvSupplier.DataSource = dv_Queryresult.ToTable("tb_supplierinfor");
            conn.Close();
        }
        /// <summary>
        /// 供应商信息表样式设置
        /// </summary>
        private void dgvHeadTextSet()
        {
            this.dgvSupplier.Columns[0].HeaderText = "序号";
            this.dgvSupplier.Columns[1].HeaderText = "编号";
            this.dgvSupplier.Columns[2].HeaderText = "名称";
            this.dgvSupplier.Columns[2].Frozen = true;
            this.dgvSupplier.Columns[3].HeaderText = "法人代表";
            this.dgvSupplier.Columns[4].HeaderText = "联系人";
            this.dgvSupplier.Columns[5].HeaderText = "手机";
            this.dgvSupplier.Columns[6].HeaderText = "电话";
            this.dgvSupplier.Columns[7].HeaderText = "传真";
            this.dgvSupplier.Columns[8].HeaderText = "联系地址";
            this.dgvSupplier.Columns[9].HeaderText = "注册地址";
            this.dgvSupplier.Columns[10].HeaderText = "成立时间";
            this.dgvSupplier.Columns[11].HeaderText = "注册资金";
            this.dgvSupplier.Columns[12].HeaderText = "员工数";
            this.dgvSupplier.Columns[13].HeaderText = "企业类型";
            this.dgvSupplier.Columns[14].HeaderText = "提供产品类型";
            this.dgvSupplier.Columns[15].HeaderText = "开户行";
            this.dgvSupplier.Columns[16].HeaderText = "银行帐号";
            this.dgvSupplier.Columns[17].HeaderText = "收款账户";
            this.dgvSupplier.Columns[18].HeaderText = "付款期限";
        }

        #endregion

        #region 新增标签代码段

        private void btnNewID_Click(object sender, EventArgs e)
        {
            NewSupplierID();    //产生新编号方法
        }
        /// <summary>
        /// 产生供应商编号
        /// </summary>
        private void NewSupplierID()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            string sqlstr="SELECT SupplierID FROM tb_supplierinfor ORDER BY ID DESC LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dr.Read();
            try
            {
                if (dr.HasRows)
                {
                    MaxID = Convert.ToInt32(dr["SupplierID"].ToString().Substring(2, 4).ToString());    //获得当前最后编号
                    MaxID++;
                    lbSupplierIDA.Text = string.Format("SL{0}", MaxID.ToString().PadLeft(4, '0'));
                    txtSupplierNameA.Focus();
                }
                else
                {
                    MaxID = 1;
                    lbSupplierIDA.Text = string.Format("SL{0}", MaxID.ToString().PadLeft(4, '0'));
                    txtSupplierNameA.Focus();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            txtSupplierSkA.Text = txtSupplierNameA.Text.Trim();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lbSupplierIDA.Text == "请新增编号！")
            {
                MessageBox.Show("供应商还未编号，请新增编号！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNewID.Focus();
            }
            else if (txtSupplierNameA.Text.Trim().Length == 0)
            {
                MessageBox.Show("供应商名称还未填写，请填写！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplierNameA.Focus();
            }
            else if (txtSupplierPromptA.Text.Trim().Length == 0)
            {
                MessageBox.Show("付款期限未填写，请填写完整！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplierPromptA.Focus();
            }
            else
            {
                supplierInformInsert();
            }
        }

        /// <summary>
        /// 供应商系统编号是否已存在
        /// </summary>
        /// <param name="b">检索值</param>
        /// <returns>'true' or 'false'</returns>
        private static bool supidstatus(string b)
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            string sqlstr = "SELECT COUNT(*) AS total FROM tb_supplierinfor WHERE SupplierID = '" + b + "'";
            MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dr.Read();
            if (dr.HasRows)
            {
                if (dr["total"].ToString().Trim() == "0")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 供应商信息提交
        /// </summary>
        private void supplierInformInsert()
        {
            if (supidstatus(lbSupplierIDA.Text.Trim()))
            {
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string sqlstr = "INSERT INTO `tb_supplierinfor` VALUES(NULL,@SupplierID,@SupplierName,";
                    sqlstr += "@SupplierFrdb,@SupplierLinkMan,@SupplierMobile,@SupplierPhone,@SupplierFax,";
                    sqlstr += "@SupplierAddress,@SupplierZcAddress,@SupplierClTime,@SupplierZczj,@SupplierYgs,";
                    sqlstr += "@SupplierQyxz,@SupplierTgcplx,@SupplierBank,@SupplierBankAccountNumber,";
                    sqlstr += "@SupplierShouKuanZhangHu,@SupplierPrompt)";

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sqlstr;
                    cmd.Parameters.AddWithValue("@SupplierID", lbSupplierIDA.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierName", txtSupplierNameA.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierFrdb", txtfrdbA.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierLinkMan", txtSupplierManA.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierMobile", txtSupplierMobileA.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierPhone", txtSupplierPhoneA.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierFax", txtSupplierFaxA.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierAddress", txtSupplierAddA.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierZcAddress", txtzcaddressA.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierClTime", Convert.ToDateTime(dtpclTimeA.Value.ToShortDateString()));
                    cmd.Parameters.AddWithValue("@SupplierZczj", txtzczjA.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierYgs", txtygsA.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierQyxz", txtqyxzA.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierTgcplx", txtTgcplxA.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierShouKuanZhangHu", txtSupplierSkA.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierBank", txtSupplierKhA.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierBankAccountNumber", txtSupplierBkNumA.Text.Trim());
                    cmd.Parameters.AddWithValue("@SupplierPrompt", txtSupplierPromptA.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transaction.Rollback();
                    conn.Close();
                }
                finally
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        transaction.Commit();
                        conn.Close();
                        MessageBox.Show("数据已保存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        aControlClear();
                        SupplierSelest();
                        dgvHeadTextSet();
                    }
                }
            }
        }
        /// <summary>
        /// 清除控件数据
        /// </summary>
        private void aControlClear()
        {
            lbSupplierIDA.Text = "请新增编号！";
            txtSupplierNameA.Text = "";
            txtSupplierNameA.Focus();
            txtfrdbA.Text = "";
            txtSupplierManA.Text = "";
            txtSupplierMobileA.Text = "";
            txtSupplierPhoneA.Text = "";
            txtSupplierFaxA.Text = "";
            txtSupplierAddA.Text = "";
            txtzcaddressA.Text = "";
            dtpclTimeA.Value = Convert.ToDateTime("1990/1/1");
            txtzczjA.Text = "";
            txtygsA.Text = "";
            txtqyxzA.Text = "";
            txtTgcplxA.Text = "";
            txtSupplierSkA.Text = "";
            txtSupplierKhA.Text = "";
            txtSupplierBkNumA.Text = "";
            txtSupplierPromptA.Text = "款到发货";
        }

        private void btnCancelA_Click(object sender, EventArgs e)
        {
            aControlClear();
        }

        #endregion

        #region 修改标签代码段
        /// <summary>
        /// 供应商信息查询（修改）
        /// </summary>
        
        ///<summary>
        ///选择供应商并获得供应商信息
        ///</summary>
        private void lbSupplierIDB_DoubleClick(object sender, EventArgs e)
        {
            //Frm_SupplierForIndentPur frsfi = new Frm_SupplierForIndentPur();
            //frsfi.ShowDialog();
            //if (frsfi.SpID != null)
            //{
            //    lbSupplierIDB.Text = frsfi.SpID.Trim();
            //    txtSupplierNameB.Text = frsfi.SpName.Trim();
            //    txtfrdbB.Text = frsfi.Spfrdb.Trim();
            //    txtSupplierManB.Text = frsfi.SpMan.Trim();
            //    txtSupplierMobileB.Text = frsfi.SpMobilePhone.Trim();
            //    txtSupplierPhoneB.Text = frsfi.SpPhone.Trim();
            //    txtSupplierFaxB.Text = frsfi.SpFax.Trim();
            //    txtSupplierAddB.Text = frsfi.SpAddress.Trim();
            //    txtzcaddressB.Text = frsfi.SpZcAddress.Trim();
            //    if (frsfi.SpClTime == null || frsfi.SpClTime == "")
            //    {
            //    }
            //    else
            //    {
            //        dtpclTimeB.Value = Convert.ToDateTime(frsfi.SpClTime.Trim());
            //    }
            //    txtzczjB.Text = frsfi.SpZczj.Trim();
            //    txtygsB.Text = frsfi.SpYgs.Trim();
            //    txtqyxzB.Text = frsfi.SpQyxz.Trim();
            //    txtTgcplxB.Text = frsfi.SpTgcplx.Trim();
            //    txtSupplierSkB.Text = frsfi.SpSkzh.Trim();
            //    txtSupplierKhB.Text = frsfi.SpKhh.Trim();
            //    txtSupplierBkNumB.Text = frsfi.SpYhzh.Trim();
            //    txtSupplierPromptB.Text = frsfi.SpPro.Trim();
            //    txtTransportScores.Text = frsfi.SpYsfz.Trim();
            //    if (frsfi.SpRs == null || frsfi.SpRs == "")
            //    {
            //        lbReviewStateB.Text = "待评审";
            //    }
            //    else
            //    {
            //        lbReviewStateB.Text = frsfi.SpRs.Trim();
            //    }
            //}
        }

        private void btnSupplierUp_Click(object sender, EventArgs e)
        {
            if (lbSupplierIDB.Text.Trim() == "供应商编号")
            {
                MessageBox.Show("没有供应商编号，不能进行更新操作", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSupplierNameB.Text.Trim().Length == 0)
            {
                MessageBox.Show("供应商名称不能为空值！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplierNameB.Focus();
            }
            else if (txtSupplierPromptB.Text.Trim().Length == 0)
            {
                MessageBox.Show("付款期限不能为空值！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplierPromptB.Focus();
            }
            else if (txtTransportScores.Text.Trim() == String.Empty)
            {
                MessageBox.Show("运输分值不能为空值！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTransportScores.Focus();
            }
            else if (!jnum.ISNumeric(txtTransportScores.Text.Trim()))
            {
                MessageBox.Show("运输分值应为数值型数据！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTransportScores.Focus();
                txtTransportScores.SelectAll();
            }
            else
            {
                SupplierUp();
                //dvSelectListBind();
            }
        }
        /// <summary>
        /// 清除控件信息
        /// </summary>
        private void bControlClear()
        {
            lbSupplierIDB.Text = "供应商编号";
            txtSupplierNameB.Text = "";
            txtfrdbB.Text = "";
            txtSupplierManB.Text = "";
            txtSupplierMobileB.Text = "";
            txtSupplierPhoneB.Text = "";
            txtSupplierFaxB.Text = "";
            txtSupplierAddB.Text = "";
            txtzcaddressB.Text = "";
            dtpclTimeB.Value = Convert.ToDateTime("1990/1/1");
            txtzczjB.Text = "";
            txtygsB.Text = "";
            txtqyxzB.Text = "";
            txtTgcplxB.Text = "";
            txtSupplierSkB.Text = "";
            txtSupplierKhB.Text = "";
            txtSupplierBkNumB.Text = "";
            txtSupplierPromptB.Text = "";
            txtTransportScores.Text = "";
        }
        /// <summary>
        /// 供应商信息更新
        /// </summary>
        private void SupplierUp()
        {
            //SqlCommand cmd = new SqlCommand("Pr_SupplierInforUp", Sqlstr.GetCon());
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@SupplierID", SqlDbType.NVarChar, 255).Value = lbSupplierIDB.Text.Trim();
            //cmd.Parameters.Add("@SupplierName", SqlDbType.NVarChar, 255).Value = txtSupplierNameB.Text.Trim();
            //cmd.Parameters.Add("@SupplierFrdb", SqlDbType.NVarChar, 255).Value = txtfrdbB.Text.Trim();
            //cmd.Parameters.Add("@SupplierLinkMan", SqlDbType.NVarChar, 255).Value = txtSupplierManB.Text.Trim();
            //cmd.Parameters.Add("@SupplierMobile", SqlDbType.NVarChar, 255).Value = txtSupplierMobileB.Text.Trim();
            //cmd.Parameters.Add("@SupplierPhone", SqlDbType.NVarChar, 255).Value = txtSupplierPhoneB.Text.Trim();
            //cmd.Parameters.Add("@SupplierFax", SqlDbType.NVarChar, 255).Value = txtSupplierFaxB.Text.Trim();
            //cmd.Parameters.Add("@SupplierAddress", SqlDbType.NVarChar, 255).Value = txtSupplierAddB.Text.Trim();
            //cmd.Parameters.Add("@SupplierZcAddress", SqlDbType.NVarChar, 255).Value = txtzcaddressB.Text.Trim();
            //cmd.Parameters.Add("@SupplierClTime", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpclTimeB.Value.ToShortDateString());
            //cmd.Parameters.Add("@SupplierZczj", SqlDbType.NVarChar, 50).Value = txtzczjB.Text.Trim();
            //cmd.Parameters.Add("@SupplierYgs", SqlDbType.NVarChar, 50).Value = txtygsB.Text.Trim();
            //cmd.Parameters.Add("@SupplierQyxz", SqlDbType.NVarChar, 255).Value = txtqyxzB.Text.Trim();
            //cmd.Parameters.Add("@SupplierTgcplx", SqlDbType.NVarChar, 255).Value = txtTgcplxB.Text.Trim();
            //cmd.Parameters.Add("@SupplierShouKuanZhangHu", SqlDbType.NVarChar, 255).Value = txtSupplierSkB.Text.Trim();
            //cmd.Parameters.Add("@SupplierBank", SqlDbType.NVarChar, 255).Value = txtSupplierKhB.Text.Trim();
            //cmd.Parameters.Add("@SupplierBankAccountNumber", SqlDbType.NVarChar, 255).Value = txtSupplierBkNumB.Text.Trim();
            //cmd.Parameters.Add("@SupplierPrompt", SqlDbType.NVarChar, 50).Value = txtSupplierPromptB.Text.Trim();
            //cmd.Parameters.Add("@TransportScores", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTransportScores.Text.Trim());
            //cmd.Parameters.Add("@returnUp", SqlDbType.Int);
            //cmd.Parameters["@returnUp"].Direction = ParameterDirection.ReturnValue;
            //try
            //{
            //    cmd.ExecuteNonQuery();
            //}
            //catch (SqlException Ex)
            //{
            //    MessageBox.Show("数据未填加成功！" + Ex.Message, "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //finally
            //{
            //    Sqlstr.GetClose();
            //}

            //string tempReturnUp = cmd.Parameters["@returnUp"].Value.ToString();
            //cmd.Dispose();
            //switch (tempReturnUp)
            //{
            //    case"0":
            //        MessageBox.Show("数据修改完成！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        bControlClear();
            //        Ds.Clear();
            //        SupplierSelest();
            //        break;
            //    case"1":
            //        MessageBox.Show("数据未能修改！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        break;
            //}
        }

        private void btnCancelB_Click(object sender, EventArgs e)
        {
            bControlClear();
        }
        #endregion
    }
}
