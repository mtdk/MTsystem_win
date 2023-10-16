using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting;
using Microsoft.Reporting.WinForms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MTsystem_win.allClass;

namespace MTsystem_win
{
    public partial class Frm_OrderForm : Form
    {
        public Frm_OrderForm()
        {
            InitializeComponent();
        }

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        JudgeNumber JuNum = new JudgeNumber();

        ///<summary>
        ///最新单价
        /// </summary>
        static decimal NewPrice;
        /// <summary>
        /// 实际到货数
        /// </summary>
        static decimal sds;
        /// <summary>
        /// 应到数
        /// </summary>
        static decimal yds;
        /// <summary>
        /// 应到日期与实到日期比较后的结果
        /// </summary>
        static int Result;

        private void Frm_OrderForm_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmorderform == "CLOSE" || frmShowstatus._Frmorderform == null)
            {
                frmShowstatus._Frmorderform = "OPEN";
                dtpOrderDateB.Value = DateTime.Now;
                dtpRADateB.Value = DateTime.Now;
            }
        }

        private void Frm_OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmorderform = "CLOSE";
        }

        #region 采购订单代码段

        /// <summary>
        /// 产生新采购订单号
        /// </summary>
        private void NewIndentID()  //产生新订单号
        {
            string date;    //将当前系统日期变量转为字符串
            string OrderFormIDend;  //最后单号
            int IDendLenght;    //单号长度
            string Date;       //将单号中的日期部分转为字符串
            long MaxID;
            date = DateTime.Now.Year.ToString();
            date += DateTime.Now.Month.ToString().PadLeft(2, '0');
            date += DateTime.Now.Day.ToString().PadLeft(2, '0');
            string sqlstr="SELECT OrderFormID FROM tb_orderformmain ORDER BY ID DESC LIMIT 1";
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dr.Read();
            try
            {
                if (dr.HasRows)
                {
                    OrderFormIDend = dr["OrderFormID"].ToString();
                    IDendLenght = (OrderFormIDend.Length);
                    Date = OrderFormIDend.Substring(0, OrderFormIDend.Length - 3).ToString();                    
                    if (Convert.ToInt32(OrderFormIDend.Substring(8, 3).ToString()) < 999)
                    {
                        if (Date == date)
                        {
                            MaxID = Convert.ToInt64(OrderFormIDend);
                            MaxID++;
                            lbIndentIDB.Text = MaxID.ToString();
                        }
                        else
                        {
                            lbIndentIDB.Text = date + "001";
                        }
                    }
                    else
                    {
                        MessageBox.Show("今日订单总量已达上限！" , "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 执行采购订单界面部分控件数据清空
        /// </summary>
        private void PartControlClear()
        {
            lbToenCodeB.Text = "";
            txtMaterialIDB.Text = "";
            txtMaterialNameB.Text = "";
            txtNumberB.Text = "";
            txtPriceB.Text = "";
            txtSumB.Text = "";
            txtRemarksB.Text = "";
            txtMaterialIDB.Focus();
        }

        /// <summary>
        /// 采购订单数据提交至采购数据表前的临时存放点
        /// </summary>
        private void TempDataInsert()   //数据提交至数据表前的临时存放点
        {
            if (dgvIndentListB.Rows.Count < 10)
            {
                DataGridViewRow Row = new DataGridViewRow();
                Row.CreateCells(dgvIndentListB);
                Row.Cells[0].Value = dgvIndentListB.Rows.Count + 1;
                Row.Cells[1].Value = lbToenCodeB.Text.Trim();
                Row.Cells[2].Value = txtMaterialIDB.Text.Trim();
                Row.Cells[3].Value = txtMaterialNameB.Text.Trim();
                Row.Cells[4].Value = txtUnitsB.Text.Trim();
                Row.Cells[5].Value = txtNumberB.Text.Trim();
                Row.Cells[6].Value = txtPriceB.Text.Trim();
                Row.Cells[7].Value = txtSumB.Text.Trim();
                Row.Cells[8].Value = txtRemarksB.Text.Trim();
                dgvIndentListB.Rows.Add(Row);
                decimal SumTotal = 0;
                for (int i = 0; i < dgvIndentListB.RowCount; i++)
                {
                    SumTotal += Convert.ToDecimal(dgvIndentListB.Rows[i].Cells[7].Value.ToString().Trim());
                }
                lbTotalSum.Text = Convert.ToString(SumTotal);
                PartControlClear();
            }
            else
            {
                if (MessageBox.Show("每份订单最多只能有10条记录！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    PartControlClear();
                    btnSaveB.Focus();
                }
            }
        }

        /// <summary>
        /// 材料单价比较
        /// </summary>
        /// <param name="p">单价</param>
        /// <param name="mid">材料内码</param>
        /// <returns>true 单价相同，false 单价不同</returns>
        private static bool MaterialPriceDiff(decimal p, string mid)
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            string sqlstr = "SELECT COUNT(*) AS total FROM material WHERE Matid = '" + mid + "' AND Material_price = '" + p + "'";
            MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dr.Read();
            if (dr.HasRows)
            {
                if (dr["total"].ToString().Trim() == "1")
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
        /// 原材料单价更新
        /// </summary>
        private void MaterialPriceUp()
        {
            if (!MaterialPriceDiff(Convert.ToDecimal(txtPriceB.Text.Trim()), lbToenCodeB.Text.Trim()))
            {
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string sqlstr = "UPDATE `material` SET Material_Price = @Material_Price WHERE Matid = @Matid";

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sqlstr;
                    cmd.Parameters.AddWithValue("@Matid", lbToenCodeB.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_Price", Convert.ToDecimal(txtPriceB.Text.Trim()));
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
                        TempDataInsert();
                    }
                }
            }
            else
            {
                TempDataInsert();
            }
        }

        /// <summary>
        /// 对采购日期和到货日期进行比较
        /// </summary>
        /// <param name="dta">起始时间</param>
        /// <param name="dtb">结束时间</param>
        /// <returns>起始时间小于等于结束时间 true,否则 false</returns>
        private static bool dtCompare(DateTime dta,DateTime dtb) //日期大小比较
        {
            if (DateTime.Compare(dta, dtb) > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 提交采购记录
        /// </summary>
        private void dataInsert()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                string sqlstr = "INSERT INTO `tb_orderformmain` VALUES(NULL,@OrderFormID,@OrderSupplierID,";
                sqlstr += "@OrderDate,@OrderSupplierName,@OrderSupplierPeople,@OrderSupplierFax,@RequireArriveDate,";
                sqlstr += "@SupplierPrompt,@Consignee,@AllSum,@OrderConvention,@OrderFormStatus)";
                cmd.CommandText = sqlstr;
                cmd.Parameters.AddWithValue("@OrderFormID", lbIndentIDB.Text.Trim());
                cmd.Parameters.AddWithValue("@OrderSupplierID", lbSupplierIDB.Text.Trim());
                cmd.Parameters.AddWithValue("@OrderDate", Convert.ToDateTime(dtpOrderDateB.Value.ToShortDateString()));
                cmd.Parameters.AddWithValue("@OrderSupplierName", txtSupplierNameB.Text.Trim());
                cmd.Parameters.AddWithValue("@OrderSupplierPeople", txtSupplierManB.Text.Trim());
                cmd.Parameters.AddWithValue("@OrderSupplierFax", txtSupplierFaxB.Text.Trim());
                cmd.Parameters.AddWithValue("@RequireArriveDate", Convert.ToDateTime(dtpRADateB.Value.ToShortDateString()));
                cmd.Parameters.AddWithValue("@SupplierPrompt", txtPromptB.Text.Trim());
                cmd.Parameters.AddWithValue("@Consignee", txtConsigneeB.Text.Trim());
                cmd.Parameters.AddWithValue("@AllSum", Convert.ToDecimal(lbTotalSum.Text.Trim()));
                cmd.Parameters.AddWithValue("@OrderConvention", txtConventionB.Text);
                cmd.Parameters.AddWithValue("@OrderFormStatus", "有效");
                cmd.ExecuteNonQuery();


                for (int i = 0; i < dgvIndentListB.RowCount; i++)
                {
                    MySqlCommand cmdA = new MySqlCommand();
                    cmdA.Connection = conn;
                    string sqlstrA = "";
                    sqlstrA = "INSERT INTO `tb_orderform` VALUES(NULL,@OrderFormID,@OrderDate,@InteriorID,";
                    sqlstrA += "@Material_ID,@Material_Name,@Material_Units,@Material_Number,@Material_Price,";
                    sqlstrA += "@Material_Sum,@Material_Remarks,@Goods_Status,@Dh_Status,@Fk_Status,@Dp_Status)";

                    cmdA.CommandText = sqlstrA;
                    cmdA.Parameters.AddWithValue("@OrderFormID", lbIndentIDB.Text.Trim());
                    cmdA.Parameters.AddWithValue("@OrderDate", dtpOrderDateB.Value.ToShortDateString());
                    cmdA.Parameters.AddWithValue("@InteriorID", dgvIndentListB.Rows[i].Cells[1].Value.ToString());
                    cmdA.Parameters.AddWithValue("@Material_ID", dgvIndentListB.Rows[i].Cells[2].Value.ToString());
                    cmdA.Parameters.AddWithValue("@Material_Name", dgvIndentListB.Rows[i].Cells[3].Value.ToString());
                    cmdA.Parameters.AddWithValue("@Material_Units", dgvIndentListB.Rows[i].Cells[4].Value.ToString());
                    cmdA.Parameters.AddWithValue("@Material_Number", Convert.ToDecimal(dgvIndentListB.Rows[i].Cells[5].Value.ToString()));
                    cmdA.Parameters.AddWithValue("@Material_Price", Convert.ToDecimal(dgvIndentListB.Rows[i].Cells[6].Value.ToString()));
                    cmdA.Parameters.AddWithValue("@Material_Sum", Convert.ToDecimal(dgvIndentListB.Rows[i].Cells[7].Value.ToString()));
                    cmdA.Parameters.AddWithValue("@Material_Remarks", dgvIndentListB.Rows[i].Cells[8].Value.ToString());
                    cmdA.Parameters.AddWithValue("@Goods_Status", "有效");
                    cmdA.Parameters.AddWithValue("@Dh_Status", "未到");
                    cmdA.Parameters.AddWithValue("@Fk_Status", "未到");
                    cmdA.Parameters.AddWithValue("@Dp_Status", "未到");
                    cmdA.ExecuteNonQuery();
                }

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
                    if (MessageBox.Show("数据已保存成功！是否打印？", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Frm_IndentFormPrint fifp = new Frm_IndentFormPrint();
                        fifp.OrderID = lbIndentIDB.Text.Trim();
                        fifp.ShowDialog();
                    }
                    AllControlClearB();
                }
            }

        }

        /// <summary>
        /// 执行采购订单界面所有控件数据清空
        /// </summary>
        private void AllControlClearB()
        {
            lbIndentIDB.Text = "订单号!";
            lbSupplierIDB.Text = "供应商编号！";
            txtSupplierNameB.Text = "";
            txtSupplierManB.Text = "";
            txtSupplierFaxB.Text = "";
            lbToenCodeB.Text = "";
            txtMaterialIDB.Text = "";
            txtMaterialNameB.Text = "";
            txtUnitsB.Text = "";
            txtNumberB.Text = "";
            txtPriceB.Text = "";
            txtSumB.Text = "";
            txtRemarksB.Text = "";
            dgvIndentListB.Rows.Clear();
            txtPromptB.Text = "";
            lbTotalSum.Text = "";
        }

        private void btnNewIndentID_Click(object sender, EventArgs e)
        {
            NewIndentID();
        }

        private void txtSupplierNameB_DoubleClick(object sender, EventArgs e)
        {
            Frm_SupplierForIndentPur frsfi = new Frm_SupplierForIndentPur();
            frsfi.ShowDialog();
            if (frsfi.SpID != null)
            {
                lbSupplierIDB.Text = frsfi.SpID.Trim();
                txtSupplierNameB.Text = frsfi.SpName.Trim();
                txtSupplierManB.Text = frsfi.SpMan.Trim();
                txtSupplierFaxB.Text = frsfi.SpFax.Trim();
                txtPromptB.Text = frsfi.SpPro.Trim();
                txtMaterialIDB.Focus();
            }
            else
            {
                txtSupplierNameB.Focus();
            }
        }

        private void tbIndentPur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbIndentPur.SelectedIndex == 0)
            {
                dtpOrderDateB.Value = DateTime.Now;
                dtpRADateB.Value = DateTime.Now;
                dgvIndentListB.Columns[0].ReadOnly = true;
                dgvIndentListB.Columns[1].ReadOnly = true;
                dgvIndentListB.Columns[2].ReadOnly = true;
                dgvIndentListB.Columns[3].ReadOnly = true;
                dgvIndentListB.Columns[4].ReadOnly = true;
                dgvIndentListB.Columns[5].ReadOnly = true;
                dgvIndentListB.Columns[6].ReadOnly = true;
            }
            else if (tbIndentPur.SelectedIndex == 1)
            {
                //dtpStartTimeD.Value = DateTime.Now;
                dtpEndtimeD.Value = DateTime.Now;
            }
        }

        private void txtMaterialIDB_DoubleClick(object sender, EventArgs e)
        {
            Frm_MaterialForIndentPur fmfip = new Frm_MaterialForIndentPur();
            fmfip.ShowDialog();
            if (fmfip.MaID != null)
            {
                lbToenCodeB.Text = fmfip.MaInID.Trim();
                txtMaterialIDB.Text = fmfip.MaID.Trim();
                txtMaterialNameB.Text = fmfip.MaName.Trim();
                txtPriceB.Text = fmfip.MaPrice.Trim();
                txtUnitsB.Text = fmfip.MaUnit.Trim();
                txtNumberB.Focus();
            }
            else
            {
                txtMaterialIDB.Focus();
            }
        }

        private void txtUnitsB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (txtUnitsB.Text.Trim().Length != 0)
                {
                    txtNumberB.Focus();
                }
                else
                {
                    txtUnitsB.Focus();
                }
            }
        }

        private void txtUnitsB_Leave(object sender, EventArgs e)
        {
            if (txtUnitsB.Text.Trim().Length != 0)
            {
                txtNumberB.Focus();
            }
            else
            {
                txtUnitsB.Focus();
            }
        }

        private void txtNumberB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (txtNumberB.Text.Trim().Length == 0 || (!JuNum.ISNumeric(txtNumberB.Text.Trim())))
                {
                    txtNumberB.Focus();
                    txtNumberB.SelectAll();
                }
                else if ((Convert.ToDouble(txtNumberB.Text.Trim())) > 99999.99)
                {
                    txtNumberB.Focus();
                    txtNumberB.SelectAll();
                }
                else
                {
                    string TempStr = txtNumberB.Text.Trim();
                    txtPriceB.Focus();
                }
            }
        }

        private void txtNumberB_Leave(object sender, EventArgs e)
        {
            if (txtNumberB.Text.Trim().Length == 0 || (!JuNum.ISNumeric(txtNumberB.Text.Trim())))
            {
                txtNumberB.Focus();
                txtNumberB.SelectAll();
            }
            else if (txtPriceB.Text.Trim().Length == 0 || (!JuNum.ISNumeric(txtPriceB.Text.Trim())))
            {
                txtPriceB.Focus();
                txtPriceB.SelectAll();
            }
            else if ((Convert.ToDouble(txtNumberB.Text.Trim())) > 99999.99)
            {
                txtNumberB.Focus();
                txtNumberB.SelectAll();
            }
            else
            {
                string TempStr = txtNumberB.Text.Trim();
                txtSumB.Text = Convert.ToString((Convert.ToDecimal(txtNumberB.Text.Trim())) * (Convert.ToDecimal(txtPriceB.Text.Trim())));
                txtSumB.Focus();
            }
        }

        private void txtPriceB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (txtPriceB.Text.Trim().Length == 0 || (!JuNum.ISNumeric(txtPriceB.Text.Trim())))
                {
                    txtPriceB.Focus();
                    txtPriceB.SelectAll();
                }
                else if (txtNumberB.Text.Trim().Length == 0 || (!JuNum.ISNumeric(txtNumberB.Text.Trim())))
                {
                    txtNumberB.Focus();
                    txtNumberB.SelectAll();
                }
                else if ((Convert.ToDouble(txtPriceB.Text.Trim()) > 9999.99))
                {
                    txtPriceB.Focus();
                    txtPriceB.SelectAll();
                }
                else
                {
                    txtSumB.Text = Convert.ToString((Convert.ToDecimal(txtNumberB.Text.Trim())) * (Convert.ToDecimal(txtPriceB.Text.Trim())));
                    txtSumB.Focus();
                }
            }
        }

        private void txtPriceB_Leave(object sender, EventArgs e)
        {
            if (txtPriceB.Text.Trim().Length == 0 || (!JuNum.ISNumeric(txtPriceB.Text.Trim())))
            {
                txtPriceB.Focus();
                txtPriceB.SelectAll();
            }
            else if (txtNumberB.Text.Trim().Length == 0 || (!JuNum.ISNumeric(txtNumberB.Text.Trim())))
            {
                txtNumberB.Focus();
            }
            else if ((Convert.ToDouble(txtPriceB.Text.Trim()) > 9999.99))
            {
                txtPriceB.Focus();
                txtPriceB.SelectAll();
            }
            else
            {
                txtSumB.Text = Convert.ToString((Convert.ToDecimal(txtNumberB.Text.Trim())) * (Convert.ToDecimal(txtPriceB.Text.Trim())));
                txtSumB.Focus();
            }
        }

        private void txtSumB_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtRemarksB.Focus();
        }

        private void txtRemarksB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                if (lbSupplierIDB.Text.Trim().Length == 0 || lbSupplierIDB.Text == "供应商编号！")
                {
                    txtSupplierNameB.Focus();
                }
                else if (lbToenCodeB.Text.Trim().Length == 0)
                {
                    txtMaterialIDB.Focus();
                }
                else if (txtUnitsB.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("计量单位不能为空！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dgvIndentListB.Rows.Count > 0)
                {
                    int ii = 0;
                    for (int i = 0; i < dgvIndentListB.Rows.Count; i++)
                    {
                        if (lbToenCodeB.Text.Trim() == dgvIndentListB.Rows[i].Cells[0].Value.ToString().Trim())
                        {
                            ii = 1;
                            break;
                        }
                        else
                        {
                            ii = 0;
                        }
                    }
                    if (ii != 0)
                    {
                        MessageBox.Show("订单中已有相同的材料存在！", "警告提示", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        PartControlClear();
                    }
                    else
                    {
                        MaterialPriceUp();
                    }
                }
                else
                {
                    MaterialPriceUp();
                }

            }
        }

        private void btnSaveB_Click(object sender, EventArgs e)
        {
            if (lbIndentIDB.Text.Trim().Length == 0 || lbIndentIDB.Text == "订单号！")
            {
                MessageBox.Show("没有订单号！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNewIndentID.Focus();
            }
            else if (!dtCompare(Convert.ToDateTime(dtpOrderDateB.Text), Convert.ToDateTime(dtpRADateB.Text)))
            {
                MessageBox.Show("到货时间不能小于开单时间！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpRADateB.Focus();
            }
            else if (txtConsigneeB.Text.Trim().Length == 0)
            {
                MessageBox.Show("没有收货人！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConsigneeB.Focus();
            }
            else if (dgvIndentListB.RowCount <= 0)
            {
                MessageBox.Show("没有可存储的数据！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataInsert();
            }
        }

        private void btnCancelB_Click(object sender, EventArgs e)
        {
            AllControlClearB();
        }

        #endregion

        #region 采购查询代码段

        /// <summary>
        /// 空条件检索采购订单记录，将返回所有订单记录，默认情况下返回前10000条记录
        /// </summary>
        private void IndentSelectedConditionNull()    //当查询条件为空时执行本代码段
        {
            ds_Queryresult.Clear();
            dgvIndentListD.DataSource = null;
            string Sql = "";
            Sql = "SELECT OrderFormID AS 订单号,OrderDate AS 下单时间,";
            Sql += "Material_ID AS 材料编号,Material_Name AS 材料名称,";
            Sql += "Material_Units AS 单位,Material_Number AS 数量,Material_Price AS 单价,";
            Sql += "Material_Sum AS 金额,Material_Remarks AS 备注,Goods_Status AS 记录状态,";
            Sql += "Dh_Status AS 到货状态,Fk_Status AS 付款状态,Dp_Status AS 到票状态";
            if (chbRecordsD.Checked == true)
            {
                Sql += " FROM tb_OrderForm WHERE OrderDate >= '" + dtpStartTimeD.Value.ToShortDateString() + "'";
                Sql += " AND OrderDate <= '" + dtpEndtimeD.Value.ToShortDateString() + "' LIMIT 10000";
            }
            else
            {

                Sql += " FROM tb_OrderForm WHERE OrderDate >= '" + dtpStartTimeD.Value.ToShortDateString() + "'";
                Sql += " AND OrderDate <= '" + dtpEndtimeD.Value.ToShortDateString() + "'";
            }
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlDataAdapter msda = new MySqlDataAdapter(Sql, conn);
            msda.Fill(ds_Queryresult, "tb_orderform");

            dv_Queryresult.Table = ds_Queryresult.Tables["tb_orderform"];
            dgvIndentListD.DataSource = dv_Queryresult.ToTable("tb_orderform");

            sumTotalcount();
        }
        /// <summary>
        /// 有条件检索采购订单记录，将返回与条件相符的订单记录，默认情况下返回前10000条记录
        /// </summary>
        private void IndentSelectConditionNoNull()  //当查询条件不为空时执行本代码段
        {
            ds_Queryresult.Clear();
            dgvIndentListD.DataSource = null;
            string Sql = "";
            Sql = "SELECT tb_OrderForm.OrderFormID AS 订单号,tb_OrderForm.OrderDate AS 下单时间,";
            Sql += "tb_OrderForm.Material_ID AS 材料编号,tb_OrderForm.Material_Name AS 材料名称,";
            Sql += "tb_OrderForm.Material_Units AS 单位,tb_OrderForm.Material_Number AS 数量,";
            Sql += "tb_OrderForm.Material_Price AS 单价,tb_OrderForm.Material_Sum AS 金额,";
            Sql += "tb_OrderForm.Material_Remarks AS 备注,tb_OrderForm.Goods_Status AS 记录状态,";
            Sql += "tb_OrderForm.Dh_Status AS 到货状态,tb_OrderForm.Fk_Status AS 付款状态,tb_OrderForm.Dp_Status AS 到票状态";

            if (rdbMaterialNameD.Checked == true)
            {
                if (chbRecordsD.Checked == true)
                {
                    Sql += " FROM tb_OrderForm WHERE tb_OrderForm.Material_Name LIKE '%" + txtSelectConditionD.Text.Trim() + "%'";
                    Sql += " AND tb_OrderForm.OrderDate >= '" + dtpStartTimeD.Value.ToShortDateString() + "'";
                    Sql += " AND tb_OrderForm.OrderDate <= '" + dtpEndtimeD.Value.ToShortDateString() + "' LIMIT 10000";
                }
                else
                {
                    Sql += " FROM tb_OrderForm WHERE tb_OrderForm.Material_Name LIKE '%" + txtSelectConditionD.Text.Trim() + "%'";
                    Sql += " AND tb_OrderForm.OrderDate >= '" + dtpStartTimeD.Value.ToShortDateString() + "'";
                    Sql += " AND tb_OrderForm.OrderDate <= '" + dtpEndtimeD.Value.ToShortDateString() + "'";
                }
            }
            else if (rdbSupplierNameD.Checked == true)
            {
                if (chbRecordsD.Checked == true)
                {
                    Sql += " FROM tb_OrderForm INNER JOIN tb_OrderFormMain ON";
                    Sql += " tb_OrderForm.OrderFormID = tb_OrderFormMain.OrderFormID";
                    Sql += " WHERE (tb_OrderFormMain.OrderSupplierName LIKE";
                    Sql += " '%" + txtSelectConditionD.Text.Trim() + "%') AND";
                    Sql += " tb_OrderForm.OrderDate >= '" + dtpStartTimeD.Value.ToShortDateString() + "' AND";
                    Sql += " tb_OrderForm.OrderDate <= '" + dtpEndtimeD.Value.ToShortDateString() + "' LIMIT 10000";
                }
                else
                {
                    Sql += " FROM tb_OrderForm INNER JOIN tb_OrderFormMain ON";
                    Sql += " tb_OrderForm.OrderFormID = tb_OrderFormMain.OrderFormID";
                    Sql += " WHERE (tb_OrderFormMain.OrderSupplierName LIKE";
                    Sql += " '%" + txtSelectConditionD.Text.Trim() + "%') AND";
                    Sql += " tb_OrderForm.OrderDate >= '" + dtpStartTimeD.Value.ToShortDateString() + "' AND";
                    Sql += " tb_OrderForm.OrderDate <= '" + dtpEndtimeD.Value.ToShortDateString() + "'";
                }
            }
            else if (rdbIndentIDD.Checked == true)
            {
                if (chbRecordsD.Checked == true)
                {
                    Sql += " FROM tb_OrderForm WHERE tb_OrderForm.OrderFormID LIKE '%" + txtSelectConditionD.Text.Trim() + "%'";
                    Sql += " AND tb_OrderForm.OrderDate >= '" + dtpStartTimeD.Value.ToShortDateString() + "'";
                    Sql += " AND tb_OrderForm.OrderDate <= '" + dtpEndtimeD.Value.ToShortDateString() + "'LIMIT 10000";
                }
                else
                {

                    Sql += " FROM tb_OrderForm WHERE tb_OrderForm.OrderFormID LIKE '%" + txtSelectConditionD.Text.Trim() + "%'";
                    Sql += " AND tb_OrderForm.OrderDate >= '" + dtpStartTimeD.Value.ToShortDateString() + "'";
                    Sql += " AND tb_OrderForm.OrderDate <= '" + dtpEndtimeD.Value.ToShortDateString() + "'";
                }
            }
            else if (rdbMaterialIDD.Checked == true)
            {
                if (chbRecordsD.Checked == true)
                {
                    Sql += " FROM tb_OrderForm WHERE tb_OrderForm.Material_ID LIKE '%" + txtSelectConditionD.Text.Trim() + "%'";
                    Sql += " AND tb_OrderForm.OrderDate >= '" + dtpStartTimeD.Value.ToShortDateString() + "'";
                    Sql += " AND tb_OrderForm.OrderDate <= '" + dtpEndtimeD.Value.ToShortDateString() + "'LIMIT 10000";
                }
                else
                {
                    Sql += " FROM tb_OrderForm WHERE tb_OrderForm.Material_ID LIKE '%" + txtSelectConditionD.Text.Trim() + "%'";
                    Sql += " AND tb_OrderForm.OrderDate >= '" + dtpStartTimeD.Value.ToShortDateString() + "'";
                    Sql += " AND tb_OrderForm.OrderDate <= '" + dtpEndtimeD.Value.ToShortDateString() + "'";
                }
            }
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlDataAdapter msda = new MySqlDataAdapter(Sql, conn);
            msda.Fill(ds_Queryresult, "tb_orderform");

            dv_Queryresult.Table = ds_Queryresult.Tables["tb_orderform"];
            dgvIndentListD.DataSource = dv_Queryresult.ToTable("tb_orderform");

            sumTotalcount();
        }

        /// <summary>
        /// 总数量和总重量统计
        /// </summary>
        private void sumTotalcount()
        {
            decimal sumTotalweight = 0;
            decimal sumTotalmoney = 0;
            for (int i = 0; i < dgvIndentListD.RowCount; i++)
            {
                sumTotalweight += Convert.ToDecimal(dgvIndentListD.Rows[i].Cells[5].Value.ToString().Trim());
                sumTotalmoney += Convert.ToDecimal(dgvIndentListD.Rows[i].Cells[7].Value.ToString().Trim());

            }
            label2.Text = dgvIndentListD.Rows.Count.ToString();
            label6.Text = sumTotalweight.ToString();
            label26.Text = sumTotalmoney.ToString();
        }

        private void btnSelectD_Click(object sender, EventArgs e)
        {
            SelectedCondition();
        }
        /// <summary>
        /// 根据选择项执行对应检索功能
        /// </summary>
        private void SelectedCondition()
        {
            if (rdbMaterialNameD.Checked == true)   //当选择按材料名称查询时执行
            {
                if (txtSelectConditionD.Text.Trim().Length == 0)    //查询条件不为空执行ELSE
                {
                    IndentSelectedConditionNull();
                }
                else
                {
                    IndentSelectConditionNoNull();
                }
            }
            else if (rdbSupplierNameD.Checked == true)  //当选择按供应商名称查询时执行
            {
                if (txtSelectConditionD.Text.Trim().Length == 0)    //查询条件不为空执行ELSE
                {
                    IndentSelectedConditionNull();
                }
                else
                {
                    IndentSelectConditionNoNull();
                }
            }
            else if (rdbIndentIDD.Checked == true)  //当选择订单编号查询时执行
            {
                if (txtSelectConditionD.Text.Trim().Length == 0)    //查询条件不为空执行ELSE
                {
                    IndentSelectedConditionNull();
                }
                else
                {
                    IndentSelectConditionNoNull();
                }
            }
            else if (rdbMaterialIDD.Checked == true)    //当选择材料编号查询时执行
            {
                if (txtSelectConditionD.Text.Trim().Length == 0)    //查询条件不为空执行ELSE
                {
                    IndentSelectedConditionNull();
                }
                else
                {
                    IndentSelectConditionNoNull();
                }
            }
            else
            {
                IndentSelectedConditionNull();
            }
        }

        private void txtSelectConditionD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnSelectD.Focus();
            }
        }

        private void dgvIndentListD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIndentListD.RowCount > 0)
            {
                Frm_IndentPurUp fipu = new Frm_IndentPurUp();
                fipu.IndentUpID = dgvIndentListD.SelectedCells[0].Value.ToString().Trim();
                fipu.FormStatus = dgvIndentListD.SelectedCells[10].Value.ToString().Trim();
                fipu.ShowDialog();
                SelectedCondition();
            }
        }
        #endregion
    }
}
