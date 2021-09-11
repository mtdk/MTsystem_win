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
    public partial class Frm_customerinfo : Form
    {
        public Frm_customerinfo()
        {
            InitializeComponent();
        }

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        DataSet ds_Classinfo = new DataSet();


        private void Frm_customerinfo_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmcustorminfo == "CLOSE" || frmShowstatus._Frmcustorminfo == null)
            {
                frmShowstatus._Frmcustorminfo = "OPEN";
                Cus_Classinfo_Query();
                NewCusid();
                CusInforResult();
                txt_cusName.Focus();
            }
        }

        private void Frm_customerinfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmcustorminfo = "CLOSE";
        }

        /// <summary>
        /// 生成新客户编号
        /// </summary>
        private void NewCusid()
        {
            try
            {
                int MaxID = 0;
                txt_cusName.Focus();
                string strsql = "SELECT id,Cus_id FROM customers ORDER BY id DESC LIMIT 1";
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(strsql, conn);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dr.Read();
                if (dr.HasRows)
                {
                    MaxID = Convert.ToInt32(dr["Cus_id"].ToString().Substring(1, 4).ToString());
                    MaxID++;
                    txt_cusId.Text = string.Format("C{0}", MaxID.ToString().PadLeft(4, '0'));
                }
                else
                {
                    MaxID = 1;
                    txt_cusId.Text = string.Format("C{0}", MaxID.ToString().PadLeft(4, '0'));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdb_CusInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_CusUpdate.Checked == true)
            {
                label8.Visible = true;
                txt_CusNameQuery.Visible = true;
                btn_Select.Visible = true;
                txt_cusId.Text = "";
                txt_CusNameQuery.Focus();
            }
            else
            {
                label8.Visible = false;
                txt_CusNameQuery.Visible = false;
                btn_Select.Visible = false;
                NewCusid();
            }
        }

        private void rdb_CusUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_CusUpdate.Checked == true)
            {
                label8.Visible = true;
                txt_CusNameQuery.Visible = true;
                btn_Select.Visible = true;
                txt_cusId.Text = "";
                txt_CusNameQuery.Focus();
            }
            else
            {
                label8.Visible = false;
                txt_CusNameQuery.Visible = false;
                btn_Select.Visible = false;
                NewCusid();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_cusId.Text.Trim().Length == 0)
            {
                MessageBox.Show("客户代码不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_cusName.Text.Trim().Length == 0)
            {
                MessageBox.Show("客户名称不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_cusName.Focus();
            }
            else
            {
                if (rdb_CusInsert.Checked == true)
                {
                    //状态为添加客户信息时执行
                    CusInfor_insert();
                }
                else
                {
                    //状态为更新客户信息时执行
                    CusInfo_update();
                }
            }
        }

        ///<summary>
        /// 客户归属检索
        ///</summary>
        private void Cus_Classinfo_Query()
        {
            string sqlstr = "SELECT Classification_id, Classification_name FROM cus_classification";
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
            msda.Fill(ds_Classinfo,"tb_Classinfo");
            cmb_Cus_classification.DataSource = ds_Classinfo.Tables["tb_Classinfo"];
            cmb_Cus_classification.DisplayMember = "Classification_name";
            cmb_Cus_classification.ValueMember = "Classification_id";
            msda.Dispose();
            conn.Close();
        }


        /// <summary>
        /// 客户信息添加
        /// </summary>
        private void CusInfor_insert()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                string strsql = "INSERT INTO `customers` VALUES(NULL,@Cus_id,@Cus_name,@Cus_add,@Cus_contact,@Cus_mobile,@Cus_telephone,@Cus_fax,NULL)";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = strsql;
                cmd.Parameters.AddWithValue("@Cus_id", txt_cusId.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_name", txt_cusName.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_add", txt_cusAdd.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_contact", txt_Contact.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_mobile", txt_MobilePhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_telephone", txt_Telephone.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_fax", txt_Fax.Text.Trim());
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
                    allClear();
                    ds_Queryresult.Clear();
                    CusInforResult();
                }
            }
        }

        /// <summary>
        /// 客户信息更新
        /// </summary>
        private void CusInfo_update()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                //string strsql = "INSERT INTO `customers` VALUES(NULL,@Cus_id,@Cus_name,@Cus_add,@Cus_contact,@Cus_mobile,@Cus_telephone,@Cus_fax,NULL)";

                string strsql = "UPDATE customers SET Cus_name = @Cus_name,Cus_add = @Cus_add,";
                strsql += "Cus_contact = @Cus_contact,Cus_mobile = @Cus_mobile,Cus_telephone = @Cus_telephone,Cus_fax = @Cus_fax";
                strsql += " WHERE Cus_id = @Cus_id";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = strsql;
                cmd.Parameters.AddWithValue("@Cus_id", txt_cusId.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_name", txt_cusName.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_add", txt_cusAdd.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_contact", txt_Contact.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_mobile", txt_MobilePhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_telephone", txt_Telephone.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_fax", txt_Fax.Text.Trim());
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
                    allClear();
                    ds_Queryresult.Clear();
                    CusInfoQuery();
                }
            }
        }

        /// <summary>
        /// 客户信息无条件检索
        /// </summary>
        private void CusInforResult()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();

            string sqlstr = "SELECT id AS 序号,Cus_id AS 编号,Cus_name AS 客户名称,Cus_add AS 客户地址,Cus_contact AS 联系人,";
            sqlstr+=" Cus_mobile AS 手机号码,Cus_telephone AS 电话号码,Cus_fax AS 传真号码 FROM customers";
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
            msda.Fill(ds_Queryresult, "resultTable");

            dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];
            dgv_cusinfo_preview.DataSource = dv_Queryresult.ToTable("resultTable");
            this.dgv_cusinfo_preview.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgv_cusinfo_preview.AutoResizeColumnHeadersHeight();
            conn.Close();
        }

        /// <summary>
        /// 客户信息条件检索
        /// </summary>
        private void CusInfoQuery()
        {
            if (txt_CusNameQuery.Text.Trim().Length == 0)
            {
                CusInforResult();
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                conn.Open();

                string sqlstr = "SELECT id AS 序号,Cus_id AS 编号,Cus_name AS 客户名称,Cus_add AS 客户地址,Cus_contact AS 联系人,";
                sqlstr += " Cus_mobile AS 手机号码,Cus_telephone AS 电话号码,Cus_fax AS 传真号码 FROM customers";
                sqlstr += " WHERE Cus_name LIKE '%" + txt_CusNameQuery.Text.Trim() + "%'";
                MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
                msda.Fill(ds_Queryresult, "resultTable");

                dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];
                dgv_cusinfo_preview.DataSource = dv_Queryresult.ToTable("resultTable");

                conn.Close();
            }
        }

        /// <summary>
        /// 清楚所有控件数据
        /// </summary>
        private void allClear()
        {
            if (rdb_CusInsert.Checked == true)
            {
                txt_cusId.Text = "";
                txt_cusName.Text = "";
                txt_Contact.Text = "";
                txt_cusAdd.Text = "";
                txt_MobilePhone.Text = "";
                txt_Telephone.Text = "";
                txt_Fax.Text = "";
                NewCusid();
            }
            else
            {
                txt_cusId.Text = "";
                txt_cusName.Text = "";
                txt_Contact.Text = "";
                txt_cusAdd.Text = "";
                txt_MobilePhone.Text = "";
                txt_Telephone.Text = "";
                txt_Fax.Text = "";
            }
        }

        private void dgv_cusinfo_preview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdb_CusUpdate.Checked == true)
            {
                if (dgv_cusinfo_preview.RowCount > 0)
                {
                    txt_cusId.Text = dgv_cusinfo_preview.SelectedCells[1].Value.ToString().Trim();
                    txt_cusName.Text = dgv_cusinfo_preview.SelectedCells[2].Value.ToString().Trim();
                    txt_cusAdd.Text = dgv_cusinfo_preview.SelectedCells[3].Value.ToString().Trim();
                    txt_Contact.Text = dgv_cusinfo_preview.SelectedCells[4].Value.ToString().Trim();
                    txt_MobilePhone.Text = dgv_cusinfo_preview.SelectedCells[5].Value.ToString().Trim();
                    txt_Telephone.Text = dgv_cusinfo_preview.SelectedCells[6].Value.ToString().Trim();
                    txt_Fax.Text = dgv_cusinfo_preview.SelectedCells[7].Value.ToString().Trim();
                }
                else
                {
                    MessageBox.Show("暂无可选数据！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            allClear();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            if (txt_CusNameQuery.Text.Trim().Length != 0)
            {
                //清除数据源
                ds_Queryresult.Clear();
                //执行条件查找
                CusInfoQuery();
            }
            else
            {
                //清除数据源
                ds_Queryresult.Clear();
                //执行无条件查找
                CusInforResult();
            }
        }

        private void txt_CusNameQuery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                e.Handled = true;
                if (txt_CusNameQuery.Text.Trim().Length != 0)
                {
                    //清除数据源
                    ds_Queryresult.Clear();
                    //执行条件查找
                    CusInfoQuery();
                }
                else
                {
                    //清除数据源
                    ds_Queryresult.Clear();
                    //执行无条件查找
                    CusInforResult();
                }
            }
        }

        private void dgv_cusinfo_preview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_cusinfo_preview.Rows.Count > 0)
            {
                if (rdb_CusInsert.Checked == true)
                {
                    
                    textBox7.Text = dgv_cusinfo_preview.SelectedCells[1].Value.ToString().Trim();
                    textBox6.Text = dgv_cusinfo_preview.SelectedCells[2].Value.ToString().Trim();
                    textBox5.Text = dgv_cusinfo_preview.SelectedCells[4].Value.ToString().Trim();
                    textBox4.Text = dgv_cusinfo_preview.SelectedCells[5].Value.ToString().Trim();
                    textBox3.Text = dgv_cusinfo_preview.SelectedCells[6].Value.ToString().Trim();
                    textBox2.Text = dgv_cusinfo_preview.SelectedCells[7].Value.ToString().Trim();
                    textBox1.Text = dgv_cusinfo_preview.SelectedCells[3].Value.ToString().Trim();
                }
            }
        }
    }
}
