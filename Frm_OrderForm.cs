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
        /// <returns>trun or false</returns>
        private Boolean dtCompare() //日期大小比较
        {
            if (DateTime.Compare(dtpOrderDateB.Value, dtpRADateB.Value) > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 新增采购订单父单记录
        /// </summary>
        private void OrderFormMainInsert()
        {
            //SqlCommand cmdmain = new SqlCommand("Pr_OrderFormMainInsert", Sqlstr.GetCon());
            //cmdmain.CommandType = CommandType.StoredProcedure;
            //cmdmain.Parameters.Add("@OrderFormID", SqlDbType.NVarChar, 255).Value = lbIndentIDB.Text.Trim();
            //cmdmain.Parameters.Add("@OrderSupplierID", SqlDbType.NVarChar, 255).Value = lbSupplierIDB.Text.Trim();
            //cmdmain.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpOrderDateB.Value.ToShortDateString());
            //cmdmain.Parameters.Add("@OrderSupplierName", SqlDbType.NVarChar, 255).Value = txtSupplierNameB.Text.Trim();
            //cmdmain.Parameters.Add("@OrderSupplierPeople", SqlDbType.NVarChar, 255).Value = txtSupplierManB.Text.Trim();
            //cmdmain.Parameters.Add("@OrderSupplierFax", SqlDbType.NVarChar, 255).Value = txtSupplierFaxB.Text.Trim();
            //cmdmain.Parameters.Add("@RequireArriveDate", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpRADateB.Value.ToShortDateString());
            //cmdmain.Parameters.Add("@SupplierPrompt", SqlDbType.NVarChar, 255).Value = txtPromptB.Text.Trim();
            //cmdmain.Parameters.Add("@Consignee", SqlDbType.NVarChar, 50).Value = txtConsigneeB.Text.Trim();
            //cmdmain.Parameters.Add("@AllSum", SqlDbType.Decimal).Value = Convert.ToDecimal(lbTotalSum.Text.Trim());
            //cmdmain.Parameters.Add("@OrderConvention", SqlDbType.Text).Value = txtConventionB.Text;
            //cmdmain.Parameters.Add("@OrderFormStatus", SqlDbType.NVarChar, 2).Value = "有效";
            //cmdmain.Parameters.Add("@returnInsert", SqlDbType.Int);
            //cmdmain.Parameters["@returnInsert"].Direction = ParameterDirection.ReturnValue;
            //try
            //{
            //    cmdmain.ExecuteNonQuery();
            //}
            //catch (SqlException Ex)
            //{
            //    MessageBox.Show("数据添加失败！" + Ex.Message, "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //finally
            //{
            //    Sqlstr.GetClose();
            //}
            //string TempMainFormInsert = cmdmain.Parameters["@returnInsert"].Value.ToString();
            //cmdmain.Dispose();
            //switch (TempMainFormInsert)
            //{
            //    case "0":
            //        OrderFormInsert();
            //        break;
            //    case "1":
            //        MessageBox.Show("订单已存在！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        break;
            //    case "2":
            //        MessageBox.Show("订单保存失败！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        break;
            //}
        }   //新增采购订单父单记录

        /// <summary>
        /// 新增采购订单子单记录
        /// </summary>
        private void OrderFormInsert()
        {
            //if (dgvIndentListB.RowCount > 0)
            //{
            //    SqlCommand cmd = new SqlCommand("", Sqlstr.GetCon());
            //    try
            //    {
            //        for (int i = 0; i < dgvIndentListB.RowCount; i++)
            //        {
            //            string Sql = "INSERT INTO tb_OrderForm(OrderFormID,OrderDate,InteriorID,Material_ID,Material_ID_B,";
            //            Sql += "Material_Name,Material_Units,Material_Number,Material_Price,Material_Sum,Material_Remarks,Goods_Status)";
            //            Sql += " VALUES('" + lbIndentIDB.Text.Trim() + "','" + dtpOrderDateB.Value.ToShortDateString() + "','" + dgvIndentListB.Rows[i].Cells[0].Value.ToString() + "','" + dgvIndentListB.Rows[i].Cells[1].Value.ToString() + "','" + dgvIndentListB.Rows[i].Cells[2].Value.ToString() + "',";
            //            Sql += "'" + dgvIndentListB.Rows[i].Cells[3].Value.ToString() + "','"+dgvIndentListB.Rows[i].Cells[4].Value.ToString()+"',";
            //            Sql += "'" + Convert.ToDecimal(dgvIndentListB.Rows[i].Cells[5].Value.ToString()) + "','" + Convert.ToDecimal(dgvIndentListB.Rows[i].Cells[6].Value.ToString()) + "',";
            //            Sql += "'" + Convert.ToDecimal(dgvIndentListB.Rows[i].Cells[7].Value.ToString()) + "','" + dgvIndentListB.Rows[i].Cells[8].Value.ToString() + "','有效')";
            //            cmd.CommandText = Sql;
            //            cmd.ExecuteNonQuery();
            //        }
            //    }
            //    catch (SqlException Ex)
            //    {
            //        MessageBox.Show("数据添加失败！" + Ex.Message, "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    finally
            //    {
            //        cmd.Dispose();
            //        Sqlstr.GetClose();
            //    }
            //}
        }   //新增采购订单子单记录

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
            else if (tbIndentPur.SelectedIndex == 2)
            {
                wdhListBind();
                dtpSdDateE.Value = DateTime.Now;
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
                //txtMaterialIDB_B.Text = fmfip.MaID_B.Trim();
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
            else if (!dtCompare())
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
                OrderFormMainInsert();
                if (MessageBox.Show("订单已添加成功！是否打印？", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Frm_IndentFormPrint fifp = new Frm_IndentFormPrint();
                    //fifp.OrderID = lbIndentIDB.Text.Trim();
                    //fifp.ShowDialog();
                }
                AllControlClearB();
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
            //string Sql = "";
            //if (chbRecordsD.Checked == true)
            //{
            //    Sql = "SELECT TOP 10000 [OrderFormID] AS 订单号,[OrderDate] AS 下单时间,";
            //    Sql += "[Material_ID] AS 材料A编号,[Material_ID_B] AS 材料B编号,[Material_Name] AS 材料名称,";
            //    Sql += "[Material_Units] AS 单位,[Material_Number] AS 数量,[Material_Price] AS 单价,";
            //    Sql += "[Material_Sum] AS 金额,[Material_Remarks] AS 备注,[Goods_Status] AS 记录状态,";
            //    Sql += "[Dh_Status] AS 到货状态,[Fk_Status] AS 付款状态,[Dp_Status] AS 到票状态";
            //    Sql += " FROM [tb_OrderForm] WHERE [OrderDate] >= '" + dtpStartTimeD.Value.ToShortDateString() + "'";
            //    Sql += " AND [OrderDate] <= '" + dtpEndtimeD.Value.ToShortDateString() + "'";
            //}
            //else
            //{
            //    Sql = "SELECT [OrderFormID] AS 订单号,[OrderDate] AS 下单时间,";
            //    Sql += "[Material_ID] AS 材料A编号,[Material_ID_B] AS 材料B编号,[Material_Name] AS 材料名称,";
            //    Sql += "[Material_Units] AS 单位,[Material_Number] AS 数量,[Material_Price] AS 单价,";
            //    Sql += "[Material_Sum] AS 金额,[Material_Remarks] AS 备注,[Goods_Status] AS 记录状态,";
            //    Sql += "[Dh_Status] AS 到货状态,[Fk_Status] AS 付款状态,[Dp_Status] AS 到票状态";
            //    Sql += " FROM [tb_OrderForm] WHERE [OrderDate] >= '" + dtpStartTimeD.Value.ToShortDateString() + "'";
            //    Sql += " AND [OrderDate] <= '" + dtpEndtimeD.Value.ToShortDateString() + "'";
            //}
            //dgvIndentListD.DataSource = Sqlstr.GetDs(Sql).Tables[0];
        }
        /// <summary>
        /// 有条件检索采购订单记录，将返回与条件相符的订单记录，默认情况下返回前10000条记录
        /// </summary>
        private void IndentSelectConditionNoNull()  //当查询条件不为空时执行本代码段
        {
            //string Sql = "";

            //if (rdbMaterialNameD.Checked == true)
            //{
            //    if (chbRecordsD.Checked == true)
            //    {
            //        Sql = "SELECT TOP 10000 [OrderFormID] AS 订单号,[OrderDate] AS 下单时间,";
            //        Sql += "[Material_ID] AS 材料A编号,[Material_ID_B] AS 材料B编号,[Material_Name] AS 材料名称,";
            //        Sql += "[Material_Units] AS 单位,[Material_Number] AS 数量,[Material_Price] AS 单价,";
            //        Sql += "[Material_Sum] AS 金额,[Material_Remarks] AS 备注,[Goods_Status] AS 记录状态,";
            //        Sql += "[Dh_Status] AS 到货状态,[Fk_Status] AS 付款状态,[Dp_Status] AS 到票状态";
            //        Sql += " FROM [tb_OrderForm] WHERE [Material_Name] LIKE '%" + txtSelectConditionD.Text.Trim() + "%'";
            //        Sql += " AND [OrderDate] >= '" + dtpStartTimeD.Value.ToShortDateString() + "'";
            //        Sql += " AND [OrderDate] <= '" + dtpEndtimeD.Value.ToShortDateString() + "'";
            //    }
            //    else
            //    {
            //        Sql = "SELECT [OrderFormID] AS 订单号,[OrderDate] AS 下单时间,";
            //        Sql += "[Material_ID] AS 材料A编号,[Material_ID_B] AS 材料B编号,[Material_Name] AS 材料名称,";
            //        Sql += "[Material_Units] AS 单位,[Material_Number] AS 数量,[Material_Price] AS 单价,";
            //        Sql += "[Material_Sum] AS 金额,[Material_Remarks] AS 备注,[Goods_Status] AS 记录状态,";
            //        Sql += "[Dh_Status] AS 到货状态,[Fk_Status] AS 付款状态,[Dp_Status] AS 到票状态";
            //        Sql += " FROM [tb_OrderForm] WHERE [Material_Name] LIKE '%" + txtSelectConditionD.Text.Trim() + "%'";
            //        Sql += " AND [OrderDate] >= '" + dtpStartTimeD.Value.ToShortDateString() + "'";
            //        Sql += " AND [OrderDate] <= '" + dtpEndtimeD.Value.ToShortDateString() + "'";
            //    }
            //}
            //else if (rdbSupplierNameD.Checked == true)
            //{
            //    if (chbRecordsD.Checked == true)
            //    {
            //        Sql = " SELECT TOP 10000 tb_OrderForm.OrderFormID AS 订单号,tb_OrderForm.OrderDate AS 下单时间,";
            //        Sql += "tb_OrderForm.Material_ID AS 材料A编号,tb_OrderForm.Material_ID_B AS 材料B编号,tb_OrderForm.Material_Name AS 材料名称,";
            //        Sql += "tb_OrderForm.Material_Units AS 单位,tb_OrderForm.Material_Number AS 数量,";
            //        Sql += "tb_OrderForm.Material_Price AS 单价,tb_OrderForm.Material_Sum AS 金额,";
            //        Sql += "tb_OrderForm.Material_Remarks AS 备注,tb_OrderForm.Goods_Status AS 记录状态,";
            //        Sql += "tb_OrderForm.Dh_Status AS 到货状态,tb_OrderForm.Fk_Status AS 付款状态,";
            //        Sql += "tb_OrderForm.Dp_Status AS 到票状态";
            //        Sql += " FROM tb_OrderForm INNER JOIN tb_OrderFormMain ON";
            //        Sql += " tb_OrderForm.OrderFormID = tb_OrderFormMain.OrderFormID";
            //        Sql += " WHERE (tb_OrderFormMain.OrderSupplierName LIKE";
            //        Sql += " '%" + txtSelectConditionD.Text.Trim() + "%') AND";
            //        Sql += " tb_OrderForm.OrderDate >= '" + dtpStartTimeD.Value.ToShortDateString() + "' AND";
            //        Sql += " tb_OrderForm.OrderDate <= '" + dtpEndtimeD.Value.ToShortDateString() + "'";
            //    }
            //    else
            //    {
            //        Sql = " SELECT tb_OrderForm.OrderFormID AS 订单号,tb_OrderForm.OrderDate AS 下单时间,";
            //        Sql += "tb_OrderForm.Material_ID AS 材料A编号,tb_OrderForm.Material_ID_B AS 材料B编号,tb_OrderForm.Material_Name AS 材料名称,";
            //        Sql += "tb_OrderForm.Material_Units AS 单位,tb_OrderForm.Material_Number AS 数量,";
            //        Sql += "tb_OrderForm.Material_Price AS 单价,tb_OrderForm.Material_Sum AS 金额,";
            //        Sql += "tb_OrderForm.Material_Remarks AS 备注,tb_OrderForm.Goods_Status AS 记录状态,";
            //        Sql += "tb_OrderForm.Dh_Status AS 到货状态,tb_OrderForm.Fk_Status AS 付款状态,";
            //        Sql += "tb_OrderForm.Dp_Status AS 到票状态";
            //        Sql += " FROM tb_OrderForm INNER JOIN tb_OrderFormMain ON";
            //        Sql += " tb_OrderForm.OrderFormID = tb_OrderFormMain.OrderFormID";
            //        Sql += " WHERE (tb_OrderFormMain.OrderSupplierName LIKE";
            //        Sql += " '%" + txtSelectConditionD.Text.Trim() + "%') AND";
            //        Sql += " tb_OrderForm.OrderDate >= '" + dtpStartTimeD.Value.ToShortDateString() + "' AND";
            //        Sql += " tb_OrderForm.OrderDate <= '" + dtpEndtimeD.Value.ToShortDateString() + "'";
            //    }
            //}
            //else if (rdbIndentIDD.Checked == true)
            //{
            //    if (chbRecordsD.Checked == true)
            //    {
            //        Sql = "SELECT TOP 10000 [OrderFormID] AS 订单号,[OrderDate] AS 下单时间,";
            //        Sql += "[Material_ID] AS 材料A编号,[Material_ID_B] AS 材料B编号,[Material_Name] AS 材料名称,";
            //        Sql += "[Material_Units] AS 单位,[Material_Number] AS 数量,[Material_Price] AS 单价,";
            //        Sql += "[Material_Sum] AS 金额,[Material_Remarks] AS 备注,[Goods_Status] AS 记录状态,";
            //        Sql += "[Dh_Status] AS 到货状态,[Fk_Status] AS 付款状态,[Dp_Status] AS 到票状态";
            //        Sql += " FROM [tb_OrderForm] WHERE [OrderFormID] LIKE '%" + txtSelectConditionD.Text.Trim() + "%'";
            //        //Sql += " AND [OrderDate] >= '" + dtpStartTimeD.Value.ToShortDateString() + "'";
            //        //Sql += " AND [OrderDate] <= '" + dtpEndtimeD.Value.ToShortDateString() + "'";
            //    }
            //    else
            //    {
            //        Sql = "SELECT [OrderFormID] AS 订单号,[OrderDate] AS 下单时间,";
            //        Sql += "[Material_ID] AS 材料A编号,[Material_ID_B] AS 材料B编号,[Material_Name] AS 材料名称,";
            //        Sql += "[Material_Units] AS 单位,[Material_Number] AS 数量,[Material_Price] AS 单价,";
            //        Sql += "[Material_Sum] AS 金额,[Material_Remarks] AS 备注,[Goods_Status] AS 记录状态,";
            //        Sql += "[Dh_Status] AS 到货状态,[Fk_Status] AS 付款状态,[Dp_Status] AS 到票状态";
            //        Sql += " FROM [tb_OrderForm] WHERE [OrderFormID] LIKE '%" + txtSelectConditionD.Text.Trim() + "%'";
            //        //Sql += " AND [OrderDate] >= '" + dtpStartTimeD.Value.ToShortDateString() + "'";
            //        //Sql += " AND [OrderDate] <= '" + dtpEndtimeD.Value.ToShortDateString() + "'";
            //    }
            //}
            //else if (rdbMaterialIDD.Checked == true)
            //{
            //    if (chbRecordsD.Checked == true)
            //    {
            //        Sql = "SELECT TOP 10000 [OrderFormID] AS 订单号,[OrderDate] AS 下单时间,";
            //        Sql += "[Material_ID] AS 材料A编号,[Material_ID_B] AS 材料B编号,[Material_Name] AS 材料名称,";
            //        Sql += "[Material_Units] AS 单位,[Material_Number] AS 数量,[Material_Price] AS 单价,";
            //        Sql += "[Material_Sum] AS 金额,[Material_Remarks] AS 备注,[Goods_Status] AS 记录状态,";
            //        Sql += "[Dh_Status] AS 到货状态,[Fk_Status] AS 付款状态,[Dp_Status] AS 到票状态";
            //        Sql += " FROM [tb_OrderForm] WHERE [Material_ID] LIKE '%" + txtSelectConditionD.Text.Trim() + "%'";
            //        Sql += " AND [OrderDate] >= '" + dtpStartTimeD.Value.ToShortDateString() + "'";
            //        Sql += " AND [OrderDate] <= '" + dtpEndtimeD.Value.ToShortDateString() + "'";
            //    }
            //    else
            //    {
            //        Sql = "SELECT [OrderFormID] AS 订单号,[OrderDate] AS 下单时间,";
            //        Sql += "[Material_ID] AS 材料A编号,[Material_ID_B] AS 材料B编号,[Material_Name] AS 材料名称,";
            //        Sql += "[Material_Units] AS 单位,[Material_Number] AS 数量,[Material_Price] AS 单价,";
            //        Sql += "[Material_Sum] AS 金额,[Material_Remarks] AS 备注,[Goods_Status] AS 记录状态,";
            //        Sql += "[Dh_Status] AS 到货状态,[Fk_Status] AS 付款状态,[Dp_Status] AS 到票状态";
            //        Sql += " FROM [tb_OrderForm] WHERE [Material_ID] LIKE '%" + txtSelectConditionD.Text.Trim() + "%'";
            //        Sql += " AND [OrderDate] >= '" + dtpStartTimeD.Value.ToShortDateString() + "'";
            //        Sql += " AND [OrderDate] <= '" + dtpEndtimeD.Value.ToShortDateString() + "'";
            //    }
            //}
            //dgvIndentListD.DataSource = Sqlstr.GetDs(Sql).Tables[0];
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
            //if (dgvIndentListD.RowCount > 0)
            //{
            //    Frm_IndentPurUp fipu = new Frm_IndentPurUp();
            //    fipu.IndentUpID = dgvIndentListD.SelectedCells[0].Value.ToString().Trim();
            //    fipu.FormStatus = dgvIndentListD.SelectedCells[10].Value.ToString().Trim();
            //    fipu.ShowDialog();
            //    SelectedCondition();
            //}
        }
        #endregion

        #region 到货确认代码段

        private void wdhListBind()  //所有未到货订单检索
        {
            //string Sql = "SELECT [OrderFormID] AS 订单号,[OrderDate] AS 采购时间,[Material_ID] AS 材料A编号";
            //Sql += ",[Material_ID_B] AS 材料B编号,[Material_Name] AS 材料名称,[Material_Units] AS 单位,[Material_Number] AS [数量 | 重量]";
            //Sql += ",[Material_Price] AS 单价,[Material_Sum] AS 金额,[Material_Remarks] AS 备注";
            //Sql += ",[Goods_Status] AS 记录状态,[Dh_Status] AS 到货状态";
            //Sql += " FROM [tb_OrderForm] WHERE [Goods_Status]='有效' AND [Dh_Status]='未到'";
            //dgvWdhListE.DataSource = Sqlstr.GetDs(Sql).Tables[0];
            //dgvWdhListE.Columns[0].Frozen = true;
            //dgvWdhListE.Columns[1].Frozen = true;
            //dgvWdhListE.Columns[2].Frozen = true;
            //dgvWdhListE.Columns[3].Frozen = true;
            //Sqlstr.GetDs(Sql).Clear();
        }

        /// <summary>
        /// 根据采购订单号检索与之相关的采购父表记录
        /// </summary>
        private void IndentOrderFormMainBind()
        {
            //string Sql = "SELECT [OrderSupplierID],[OrderSupplierName],CONVERT(NVARCHAR(10),[OrderDate],120) AS OrderDate,[AllSum],";
            //Sql += "CONVERT(NVARCHAR(10),[RequireArriveDate],120) AS RequireArriveDate";
            //Sql += " FROM [tb_OrderFormMain] WHERE [OrderFormID]='" + txtDhIndentIDE.Text.Trim() + "'";
            //SqlCommand cmd = new SqlCommand(Sql, Sqlstr.GetCon());
            //SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            //dr.Read();
            //try
            //{
            //    if (dr.HasRows)
            //    {
            //        lbSupplierIDD.Text = dr["OrderSupplierID"].ToString();
            //        lbDhSupplierName.Text = dr["OrderSupplierName"].ToString();
            //        lbDgDateE.Text = dr["OrderDate"].ToString();
            //        lbRequireArriveDate.Text = dr["RequireArriveDate"].ToString();
            //        lbTotalSumE.Text = dr["AllSum"].ToString();
            //    }
            //}
            //catch
            //{
            //    return;
            //}
            //finally
            //{
            //    cmd.Dispose();
            //    dr.Close();
            //    dr.Dispose();
            //    Sqlstr.GetClose();
            //}
        }   //查询采购订单主单记录

        /// <summary>
        /// 检索指定未到货且状态为有效的采购订单记录
        /// </summary>
        private void IndentOrderFormBind()
        {
            //string Sql = "SELECT [InteriorID] AS 系统编号,[Material_ID] AS 材料编号,[Material_Name] AS 材料名称,";
            //Sql += "[Material_Units] AS 单位,[Material_Number] AS [数量 | 重量],";
            //Sql += "[Material_Price] AS 单价,[Material_Sum] AS 金额,[Dh_Status] AS 到货状态";
            //Sql += " FROM [tb_OrderForm] WHERE [OrderFormID] ='" + txtDhIndentIDE.Text.Trim() + "' AND [Goods_Status]='有效' AND [Dh_Status]='未到'";
            //dgvDhSelectList.DataSource = Sqlstr.GetDs(Sql).Tables[0];
            //dgvDhSelectList.Columns[0].Visible = false;
            //dgvDhSelectList.Columns[0].Frozen = true;
            //dgvDhSelectList.Columns[1].Visible = false;
            //dgvDhSelectList.Columns[1].Frozen = true;
            //dgvDhSelectList.Columns[2].Frozen = true;
            //Sqlstr.GetDs(Sql).Clear();
        }   //查询并绑定采购子单记录

        /// 依据采购订单单号检索到货数据表记录
        /// 通过该方法可得知该单号是否已有到货记录
        /// </summary>
        private void dhsDataBind()
        {
            //string Sql = "SELECT [OrderFormID] AS 订单号,[OrderDate] AS 订购时间,[InteriorID] AS 系统编码";
            //Sql += ",[Material_ID] AS 材料编号,[Material_Name] AS 材料名称,[Material_Units] AS 单位";
            //Sql += ",[Material_Number] AS [数量 | 重量],[Material_Price] AS 单价,[Material_Sum] AS 金额";
            //Sql += ",[Material_Remarks] AS 备注 FROM [tb_DhQueren] WHERE [OrderFormID]='" + txtDhIndentIDE.Text.Trim() + "'";
            //dgvSjdhListE.DataSource = Sqlstr.GetDs(Sql).Tables[0];
            //dgvSjdhListE.Columns[0].Visible = false;
            //dgvSjdhListE.Columns[1].Visible = false;
            //dgvSjdhListE.Columns[2].Visible = false;
            //dgvSjdhListE.Columns[3].Visible = false;
            //Sqlstr.GetDs(Sql).Clear();
        }   //查询并绑定到货数据表记录

        /// <summary>
        /// 向材料到货表及材料库存表中增加记录
        /// </summary>
        private void QueRenInsert() //向材料到货表及材料库存表中增加记录
        {
            //SqlCommand cmd = new SqlCommand("Pr_DhQuerenInsert", Sqlstr.GetCon());
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@OrderFormID", SqlDbType.NVarChar, 255).Value = txtDhIndentIDE.Text.Trim();
            //cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = Convert.ToDateTime(lbDgDateE.Text.Trim());
            //cmd.Parameters.Add("@DhDate", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpSdDateE.Value.ToShortDateString());
            //cmd.Parameters.Add("@InteriorID", SqlDbType.NVarChar, 255).Value = dgvDhSelectList.SelectedCells[0].Value.ToString().Trim();
            //cmd.Parameters.Add("@Material_ID", SqlDbType.NVarChar, 255).Value = lbSdMaterialIDE.Text.Trim();
            //cmd.Parameters.Add("@Material_Name", SqlDbType.NVarChar, 255).Value = lbSdNameE.Text.Trim();
            //cmd.Parameters.Add("@Material_Units", SqlDbType.NVarChar, 255).Value = lbUnitDhE.Text.Trim();
            //cmd.Parameters.Add("@Material_Number", SqlDbType.Decimal).Value = Convert.ToDecimal(txtDhslE.Text.Trim());
            //cmd.Parameters.Add("@Material_Price", SqlDbType.Decimal).Value = Convert.ToDecimal(lbSdPriceE.Text.Trim());
            //cmd.Parameters.Add("@Material_Sum", SqlDbType.Decimal).Value = Convert.ToDecimal(lbSdSumE.Text.Trim());
            //cmd.Parameters.Add("@Material_Remarks", SqlDbType.NVarChar, 255).Value = txtSdRemarkE.Text;
            //DateTime yqDate = Convert.ToDateTime(lbRequireArriveDate.Text.Trim());
            //DateTime sdDate = Convert.ToDateTime(dtpSdDateE.Value.ToShortDateString());
            //Result = DateTime.Compare(yqDate, sdDate);
            //cmd.Parameters.Add("@PointValue", SqlDbType.Decimal).Value = Result;
            //cmd.Parameters.Add("@Return", SqlDbType.Int);
            //cmd.Parameters["@Return"].Direction = ParameterDirection.ReturnValue;
            //try
            //{
            //    cmd.ExecuteNonQuery();
            //}
            //catch (SqlException Ex)
            //{
            //    MessageBox.Show("数据保存失败！" + Ex.Message, "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //finally
            //{
            //    Sqlstr.GetClose();
            //}
            //string TemReturn = cmd.Parameters["@Return"].Value.ToString();
            //cmd.Dispose();
            //switch (TemReturn)
            //{
            //    case "0":
            //        ///写入分值更新代码
            //        TransportScoresUp();
            //        dhsDataBind();
            //        sDsAndyds();
            //        if (sds >= yds)
            //        {
            //            //更新状态
            //            odfStatusUp();
            //            txtDhIndentIDE.Enabled = true;
            //            dgvDhSelectList.Enabled = true;
            //            ControlClearE();
            //            wdhListBind();
            //            IndentOrderFormBind();
            //        }
            //        else
            //        {
            //            if (MessageBox.Show("实际到货数：" + sds + "" + lbUnitDhE.Text + "  少于应到数：" + yds + " " + lbUnitDhE.Text + "，是否将到货状态更改为已到货？\r\r要更改请选“是”，不更改请选“否”！",
            //                "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            //            {
            //                odfStatusUp();
            //                txtDhIndentIDE.Enabled = true;
            //                dgvDhSelectList.Enabled = true;
            //                ControlClearE();
            //                wdhListBind();
            //                IndentOrderFormBind();
            //            }
            //            else
            //            {
            //                txtDhIndentIDE.Enabled = true;
            //                dgvDhSelectList.Enabled = true;
            //                ControlClearE();
            //                wdhListBind();
            //                IndentOrderFormBind();

            //            }
            //        }
            //        break;
            //    case "1":
            //        break;
            //}
        }

        /// <summary>
        /// 更新供应商信息表中的运输分值字段
        /// </summary>
        private void TransportScoresUp()    //更新供应商信息表中的运输分值字段
        {
            //SqlCommand cmd = new SqlCommand("Pr_SupplierTransportScoresUp", Sqlstr.GetCon());
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@SupplierID", SqlDbType.NVarChar, 255).Value = lbSupplierIDD.Text.Trim();
            //cmd.Parameters.Add("@TransportScores", SqlDbType.Decimal).Value = Result;
            //cmd.Parameters.Add("@ReturnValue", SqlDbType.Int);
            //cmd.Parameters["@ReturnValue"].Direction = ParameterDirection.ReturnValue;
            //try
            //{
            //    cmd.ExecuteNonQuery();
            //}
            //catch (SqlException Ex)
            //{
            //    MessageBox.Show("分值数据更新失败！" + Ex.Message, "警告提示", MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //    return;
            //}
        }

        /// <summary>
        /// 对采购数量及实际到货数量进行比较，
        /// 确认是否需要手动修改采购订单的到货状态
        /// </summary>
        private void sDsAndyds()    //实际到货数与应到货数的比较
        {
            //string Sql = "SELECT SUM([Material_Number]) AS Number";
            //Sql += " FROM [tb_OrderForm] WHERE [OrderFormID] ='" + txtDhIndentIDE.Text.Trim() + "' AND";
            //Sql += " [Material_ID]='" + dgvDhSelectList.SelectedCells[1].Value.ToString().Trim() + "'";
            //SqlCommand cmd = new SqlCommand(Sql, Sqlstr.GetCon());
            //SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            //sdr.Read();
            //try
            //{
            //    if (sdr.HasRows)
            //    {
            //        if (!JuNum.ISNumeric(sdr["Number"].ToString().Trim()))
            //        {
            //            yds = 0;
            //        }
            //        else
            //        {
            //            yds = Convert.ToDecimal(sdr["Number"].ToString().Trim());
            //        }
            //    }
            //    else
            //    {
            //        yds = 0;
            //    }
            //}
            //finally
            //{
            //    sdr.Dispose();
            //    sdr.Close();
            //    cmd.Dispose();
            //    Sqlstr.GetClose();
            //    Sql = "";
            //}

            //Sql = "SELECT SUM([Material_Number]) AS Number";
            //Sql += " FROM [tb_DhQueren] WHERE [OrderFormID] ='" + txtDhIndentIDE.Text.Trim() + "' AND";
            //Sql += " [Material_ID]='" + dgvDhSelectList.SelectedCells[1].Value.ToString().Trim() + "'";
            //cmd = new SqlCommand(Sql, Sqlstr.GetCon());
            //sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            //sdr.Read();
            //try
            //{
            //    if (sdr.HasRows)
            //    {
            //        if (!JuNum.ISNumeric(sdr["Number"].ToString().Trim()))
            //        {
            //            sds = 0;
            //        }
            //        else
            //        {
            //            sds = Convert.ToDecimal(sdr["Number"].ToString().Trim());
            //        }
            //    }
            //    else
            //    {
            //        sds = 0;
            //    }
            //}
            //finally
            //{
            //    sdr.Dispose();
            //    sdr.Close();
            //    cmd.Dispose();
            //    Sqlstr.GetClose();
            //}

        }

        /// <summary>
        /// 采购订单状态改变的具体执行方法
        /// </summary>
        private void odfStatusUp()  //采购订单到货状态修改
        {
            //SqlCommand cmd = new SqlCommand("Pr_OrderFormDhStatusUp", Sqlstr.GetCon());
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@OrderFormID", SqlDbType.NVarChar, 255).Value = txtDhIndentIDE.Text.Trim();
            //cmd.Parameters.Add("@InteriorID", SqlDbType.NVarChar, 255).Value = dgvDhSelectList.SelectedCells[0].Value.ToString().Trim();
            //cmd.Parameters.Add("@Dh_Status", SqlDbType.NChar, 2).Value = "已到";
            //try
            //{
            //    cmd.ExecuteNonQuery();
            //}
            //catch (SqlException Ex)
            //{
            //    MessageBox.Show("记录状态无法被更新！" + Ex.Message, "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //finally
            //{
            //    cmd.Dispose();
            //    Sqlstr.GetClose();
            //}
        }
        /// <summary>
        /// 清除到货界面中部分控件的数据
        /// </summary>
        private void ControlClearE()
        {
            lbSdMaterialIDE.Text = "";
            lbSdNameE.Text = "";
            lbUnitDhE.Text = "";
            txtDhslE.Text = "";
            lbSdPriceE.Text = "";
            lbSdSumE.Text = "";
            txtSdRemarkE.Text = "";
        }        
        
        private void txtDhIndentIDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 13)
            //{
            //    e.Handled = true;
            //    IndentOrderFormMainBind();
            //    try
            //    {
            //        IndentOrderFormBind();
            //        dhsDataBind();
            //    }
            //    catch (SqlException Ex)
            //    {
            //        MessageBox.Show(Ex.Message, "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //}
        }

        private void dgvDhSelectList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDhSelectList.RowCount > 0)
            {
                if (dgvDhSelectList.SelectedCells[7].Value.ToString().Trim() == "未到")
                {
                    if (txtDhIndentIDE.Text.Trim().Length != 0)
                    {
                        lbSdMaterialIDE.Text = dgvDhSelectList.SelectedCells[1].Value.ToString().Trim();
                        lbSdNameE.Text = dgvDhSelectList.SelectedCells[2].Value.ToString().Trim();
                        lbUnitDhE.Text = dgvDhSelectList.SelectedCells[3].Value.ToString().Trim();
                        lbSdPriceE.Text = dgvDhSelectList.SelectedCells[5].Value.ToString().Trim();
                        lbSdSumE.Text = dgvDhSelectList.SelectedCells[6].Value.ToString().Trim();
                        txtDhIndentIDE.Enabled = false;
                        dgvDhSelectList.Enabled = false;
                    }
                }
            }
        }

        private void dgvWdhListE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvWdhListE.RowCount > 0)
            {
                txtDhIndentIDE.Text = dgvWdhListE.SelectedCells[0].Value.ToString();
                txtDhIndentIDE.Focus();
            }
        }

        private void txtDhslE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                dtpSdDateE.Focus();
            }
        }

        private void dtpSdDateE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtSdRemarkE.Focus();
            }
        }

        private void txtSdRemarkE_Enter(object sender, EventArgs e)
        {
            txtSdRemarkE.ForeColor = Color.Blue;
            txtSdRemarkE.BackColor = Color.BurlyWood;
            txtSdRemarkE.Select(txtSdRemarkE.Text.Length, 0);
            ToolTip tTp = new ToolTip();
            tTp.IsBalloon = true;
            tTp.SetToolTip(txtSdRemarkE, "按回车键提交数据，按ESC键取消提交！");
            tTp.Show("按回车键提交数据，按ESC键取消提交！", txtSdRemarkE, 18000);
        }

        private void txtSdRemarkE_Leave(object sender, EventArgs e)
        {
            txtSdRemarkE.ForeColor = Color.Black;
            txtSdRemarkE.BackColor = Color.White;
            txtSdRemarkE.Select(0, 0);
        }

        private void txtSdRemarkE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (lbSdMaterialIDE.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("没有材料信息，不能提交数据", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtDhslE.Text.Trim().Length == 0)
                {
                    txtDhslE.Focus();
                }
                else if (!JuNum.ISNumeric(txtDhslE.Text.Trim()))
                {
                    txtDhslE.Focus();
                    txtDhslE.Select();
                }
                else if (DateTime.Compare((Convert.ToDateTime(lbDgDateE.Text.Trim())), dtpSdDateE.Value) > 0)
                {
                    MessageBox.Show("到货日期不能大于开单日期！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpSdDateE.Focus();
                }
                else
                {
                    QueRenInsert();
                }
            }
            else if (e.KeyChar == 27)
            {
                e.Handled = true;
                ControlClearE();
                txtDhIndentIDE.Text = "";
                txtDhIndentIDE.Focus();
                txtDhIndentIDE.Enabled = true;
                lbSupplierIDD.Text = "订单号！";
                lbDhSupplierName.Text = "供应商名称！";
                lbDgDateE.Text = "订购时间！";
                lbRequireArriveDate.Text = "要求到货时间！";
                lbTotalSumE.Text = "";
                dgvDhSelectList.DataSource = null;
                dgvDhSelectList.Enabled = true;
                dgvSjdhListE.DataSource = null;
                dgvDhSelectList.Rows.Clear();
                dgvSjdhListE.Rows.Clear();
            }
        }

        private void btnClearDateE_Click(object sender, EventArgs e)
        {
            ControlClearE();
            txtDhIndentIDE.Text = "";
            txtDhIndentIDE.Enabled = true;
            lbSupplierIDD.Text = "订单号！";
            lbDhSupplierName.Text = "供应商名称！";
            lbDgDateE.Text = "订购时间！";
            lbRequireArriveDate.Text = "要求到货时间！";
            lbTotalSumE.Text = "";
            dgvDhSelectList.DataSource = null;
            dgvDhSelectList.Enabled = true;
            dgvSjdhListE.DataSource = null;
            dgvDhSelectList.Rows.Clear();
            dgvSjdhListE.Rows.Clear();
        }

        #endregion


        /// <summary>
        /// 到货查询及结果绑定
        /// </summary>
        private void DhSelectBind()
        {
            //string Sql = "";
            //if (rdbDhSupplierG.Checked == true)
            //{
            //    Sql = "SELECT tb_OrderFormMain.OrderFormID,tb_OrderFormMain.OrderSupplierName,tb_DhQueren.OrderDate,";
            //    Sql += "tb_DhQueren.DhDate,tb_DhQueren.Material_ID,tb_DhQueren.Material_Name,tb_DhQueren.Material_Number,";
            //    Sql += "tb_DhQueren.Material_Price,tb_DhQueren.Material_Sum,tb_DhQueren.Material_Remarks,tb_DhQueren.PointValue";
            //    Sql += " FROM tb_OrderFormMain INNER JOIN tb_DhQueren ON";
            //    Sql += " tb_OrderFormMain.OrderFormID = tb_DhQueren.OrderFormID";
            //    Sql += " WHERE tb_OrderFormMain.OrderSupplierName ='" + lbSupNameDhG.Text.Trim() + "'";
            //    Sql += " ORDER BY tb_DhQueren.DhDate ASC";
            //}
            //else
            //{
            //    Sql = "SELECT tb_OrderFormMain.OrderFormID,tb_OrderFormMain.OrderSupplierName,tb_DhQueren.OrderDate,";
            //    Sql += "tb_DhQueren.DhDate,tb_DhQueren.Material_ID,tb_DhQueren.Material_Name,tb_DhQueren.Material_Number,";
            //    Sql += "tb_DhQueren.Material_Price,tb_DhQueren.Material_Sum,tb_DhQueren.Material_Remarks,tb_DhQueren.PointValue";
            //    Sql += " FROM tb_OrderFormMain INNER JOIN tb_DhQueren ON";
            //    Sql += " tb_OrderFormMain.OrderFormID = tb_DhQueren.OrderFormID";
            //    Sql += " WHERE tb_OrderFormMain.OrderSupplierName ='" + lbSupNameDhG.Text.Trim() + "'";
            //    Sql += " AND tb_DhQueren.DhDate >='" + dtpDhStartG.Value.ToShortDateString() + "'";
            //    Sql += " AND tb_DhQueren.DhDate <='" + dtpDhEndG.Value.ToShortDateString() + "'";
            //    Sql += " ORDER BY tb_DhQueren.DhDate ASC";
            //}
            //SqlCommand cmd = new SqlCommand(Sql, Sqlstr.GetCon());
            //SqlDataReader dr = null;
            //DataSet ds = new DsDhSelect();
            //dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            //ds.Tables[0].Load(dr);
            //rvDhSelect.LocalReport.ReportEmbeddedResource = "PurchaseManageSystem.PrintForms.Rp_DhSelect.rdlc";
            //ReportDataSource rdsDh = new ReportDataSource();
            //rdsDh.Name = "DsDhSelect";
            //rdsDh.Value = ds.Tables[0];
            //rvDhSelect.LocalReport.DataSources.Add(rdsDh);
            //this.rvDhSelect.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            //this.rvDhSelect.ZoomMode = ZoomMode.Percent;
            //this.rvDhSelect.ZoomPercent = 75;
            //this.rvDhSelect.RefreshReport();
            //Sqlstr.GetClose();
        }

        /// <summary>
        /// 到货开始时间与结束时间比较
        /// </summary>
        /// <returns>true,false</returns>
        private Boolean dhdtCompare()
        {
            if (DateTime.Compare(dtpDhStartG.Value, dtpDhEndG.Value) > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void lbSupNameDhG_DoubleClick(object sender, EventArgs e)
        {
            Frm_SupplierForIndentPur frsfi = new Frm_SupplierForIndentPur();
            frsfi.ShowDialog();
            if (frsfi.SpID != null)
            {
                lbSupNameDhG.Text = frsfi.SpName.Trim();
            }
        }

        private void btnDhSelectG_Click(object sender, EventArgs e)
        {
            rvDhSelect.Reset();
            if (rdbDhSupplierG.Checked == true)
            {
                if (lbSupNameDhG.Text.Trim() == String.Empty || lbSupNameDhG.Text.Trim() == "鼠标双击选择供应商！")
                {
                    MessageBox.Show("请选择供应商，再进行查询！", "警告提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    DhSelectBind();
                }
            }
            else
            {
                if (lbSupNameDhG.Text.Trim() == String.Empty || lbSupNameDhG.Text.Trim() == "鼠标双击选择供应商！")
                {
                    MessageBox.Show("请选择供应商，再进行查询！", "警告提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (!dhdtCompare())
                {
                    MessageBox.Show("开始时间不能小于结束时间！", "警告提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    dtpDhStartG.Focus();
                }
                else
                {
                    DhSelectBind();
                }
            }
        }

        private void btnDhClearG_Click(object sender, EventArgs e)
        {
            lbSupNameDhG.Text = "鼠标双击选择供应商！";
            rvDhSelect.Reset();
        }
    }
}
