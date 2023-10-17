using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using MTsystem_win.allClass;
using MTsystem_win.dsControl;

namespace MTsystem_win
{
    public partial class Frm_IndentPurUp : Form
    {
        public Frm_IndentPurUp()
        {
            InitializeComponent();
        }

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        public string IndentUpID;

        public string FormStatus;

        private void Frm_IndentPurUp_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        /// <summary>
        /// 刷新数据
        /// </summary>
        private void RefreshData()
        {
            ///已到货的订单只能查看和打印，不能进行修改的限制代码
            if (FormStatus.Trim() == "已到")
            {
                btnSave.Enabled = false;
                btnStateUp.Enabled = false;
            }
            FormMainSelecte();
            lbFormStatus.Text = FormStatus.Trim();
            FormOrderSelect();
        }
        /// <summary>
        /// 获取订单主单信息
        /// </summary>
        private void FormMainSelecte()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            string Sql = "SELECT OrderFormID,OrderSupplierID,OrderDate,";
            Sql += "OrderSupplierName,OrderSupplierPeople,OrderSupplierFax,";
            Sql += "RequireArriveDate,SupplierPrompt,Consignee,AllSum,OrderConvention,OrderFormStatus";
            Sql += " FROM tb_OrderFormMain WHERE OrderFormID='" + IndentUpID.Trim() + "'";
            MySqlCommand cmd = new MySqlCommand(Sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            dr.Read();
            try
            {
                if (dr.HasRows)
                {
                    lbIndentID.Text = dr["OrderFormID"].ToString().Trim();
                    lbSupplierID.Text = dr["OrderSupplierID"].ToString().Trim();
                    txtSupplierName.Text = dr["OrderSupplierName"].ToString().Trim();
                    lbKdDate.Text = dr["OrderDate"].ToString().Trim();
                    txtSupplierMan.Text = dr["OrderSupplierPeople"].ToString().Trim();
                    txtSupplierFax.Text = dr["OrderSupplierFax"].ToString().Trim();
                    dtpRADate.Value = Convert.ToDateTime(dr["RequireArriveDate"].ToString().Trim());
                    txtPrompt.Text = dr["SupplierPrompt"].ToString();
                    txtConsignee.Text = dr["Consignee"].ToString();
                    lbTotalSum.Text = dr["AllSum"].ToString();
                    txtConvention.Text = dr["OrderConvention"].ToString();
                    lbIndentStatus.Text = dr["OrderFormStatus"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 获取订单子单信息
        /// </summary>
        private void FormOrderSelect()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            string Sql = "SELECT InteriorID,Material_ID AS 材料编号,Material_Name AS 材料名称,";
            Sql += "Material_Units AS 单位,Material_Number AS 数量,Material_Price AS 单价,";
            Sql += "Material_Sum AS 金额,Material_Remarks AS 备注,Goods_Status AS 记录状态";
            Sql += " FROM tb_OrderForm WHERE OrderFormID='" + IndentUpID.Trim() + "' ORDER BY ID ASC";
            MySqlDataAdapter msda = new MySqlDataAdapter(Sql, conn);
            try
            {
                msda.Fill(ds_Queryresult, "tb_orderform");
                dv_Queryresult.Table = ds_Queryresult.Tables["tb_orderform"];
                dgvIndentList.DataSource = dv_Queryresult.ToTable("tb_orderform");
                dgvIndentList.Columns[0].Visible = false;
                dgvIndentList.Columns[1].ReadOnly = true;
                dgvIndentList.Columns[4].DefaultCellStyle.Format = "N3";
                dgvIndentList.Columns[5].DefaultCellStyle.Format = "N3";
                dgvIndentList.Columns[6].ReadOnly = true;
                dgvIndentList.Columns[8].ReadOnly = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvIndentList_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                try
                {
                    if (e.FormattedValue.ToString().Trim().Length == 0)
                    {
                        MessageBox.Show("这个单元格不应该为空值！", "警告提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    else if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        decimal Val = decimal.Parse(e.FormattedValue.ToString());
                        TotalSumJe();
                    }
                }
                catch
                {
                    MessageBox.Show("这个单元格只能接受数值型数据！", "警告提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else if (e.ColumnIndex == 5)
            {
                try
                {
                    if (e.FormattedValue.ToString().Trim().Length == 0)
                    {
                        MessageBox.Show("这个单元格不应该为空值！", "警告提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    else if (!String.IsNullOrEmpty(e.FormattedValue.ToString()))
                    {
                        decimal Val = decimal.Parse(e.FormattedValue.ToString());
                    }
                }
                catch
                {
                    MessageBox.Show("这个单元格只能接受数值型数据！", "警告提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void dgvIndentList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                dgvIndentList.Rows[e.RowIndex].Cells[6].Value = ((Convert.ToDecimal(dgvIndentList.Rows[e.RowIndex].
                    Cells[4].Value.ToString().Trim())) * (Convert.ToDecimal(dgvIndentList.Rows[e.RowIndex].Cells[5].
                    Value.ToString().Trim())));
                TotalSumJe();
            }
        }

        private void dgvIndentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIndentList.RowCount > 0)
            {
                if (e.ColumnIndex == 8)
                {
                    if (dgvIndentList.Rows[e.RowIndex].Cells[8].Value.ToString().Trim() == "有效")
                    {
                        dgvIndentList.Rows[e.RowIndex].Cells[8].Value = "无效";
                        TotalSumJe();
                    }
                    else
                    {
                        dgvIndentList.Rows[e.RowIndex].Cells[8].Value = "有效";
                        TotalSumJe();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dtCompare(Convert.ToDateTime(lbKdDate.Text.Trim()),Convert.ToDateTime(dtpRADate.Text.Trim())))
            {
                MessageBox.Show("到货时间小于开单时间！", "警告提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (txtPrompt.Text.Trim().Length == 0)
            {
                MessageBox.Show("结款方式为空！", "警告提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPrompt.Focus();
            }
            else if (txtConsignee.Text.Trim().Length == 0)
            {
                MessageBox.Show("收货人为空！", "警告提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtConsignee.Focus();
            }
            else
            {
                OrderMainRecordUp();
                RefreshData();
            }
        }
        /// <summary>
        /// 对采购日期和到货日期进行比较
        /// </summary>
        /// <param name="dta">起始时间</param>
        /// <param name="dtb">结束时间</param>
        /// <returns>起始时间小于等于结束时间 true,否则 false</returns>
        private static bool dtCompare(DateTime dta, DateTime dtb) //日期大小比较
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
        /// 订单子单记录修改
        /// </summary>
        private void RecordsUp()
        {
            if (dgvIndentList.Rows.Count > 0)
            {
                //SqlCommand cmd = new SqlCommand("", Sqlstr.GetCon());
                //try
                //{
                //    for (int i = 0; i < dgvIndentList.Rows.Count; i++)
                //    {
                //        string Sql = "UPDATE [tb_OrderForm] SET [Material_Units] = '" + dgvIndentList.Rows[i].Cells[3].Value.ToString().Trim() + "'";
                //        Sql += ",[Material_Number] = '" + Convert.ToDecimal(dgvIndentList.Rows[i].Cells[4].Value.ToString().Trim()) + "'";
                //        Sql += ",[Material_Price] = '" + Convert.ToDecimal(dgvIndentList.Rows[i].Cells[5].Value.ToString().Trim()) + "'";
                //        Sql += ",[Material_Sum] = '" + Convert.ToDecimal(dgvIndentList.Rows[i].Cells[6].Value.ToString().Trim()) + "'";
                //        Sql += ",[Material_Remarks] = '" + dgvIndentList.Rows[i].Cells[7].Value.ToString() + "'";
                //        Sql += ",[Goods_Status] = '" + dgvIndentList.Rows[i].Cells[8].Value.ToString().Trim() + "'";
                //        Sql += " WHERE [OrderFormID] = '" + lbIndentID.Text.Trim() + "'";
                //        Sql += " AND [InteriorID]='" + dgvIndentList.Rows[i].Cells[0].Value.ToString().Trim() + "'";
                //        cmd.CommandText = Sql;
                //        cmd.ExecuteNonQuery();
                //    }
                //}
                //catch (SqlException Ex)
                //{
                //    MessageBox.Show("修改出错！" + Ex.Message, "警告提示", MessageBoxButtons.OK,
                //        MessageBoxIcon.Error);
                //    return;
                //}
                //finally
                //{
                //    cmd.Dispose();
                //    Sqlstr.GetClose();
                //}
            }
        }
        /// <summary>
        /// 订单主单信息修改
        /// </summary>
        private void OrderMainRecordUp()
        {
            //SqlCommand cmd = new SqlCommand("Pr_OrderFormMainUp", Sqlstr.GetCon());
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@OrderFormID", SqlDbType.NVarChar, 255).Value = lbIndentID.Text.Trim();
            //cmd.Parameters.Add("@RequireArriveDate", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpRADate.Value.ToShortDateString());
            //cmd.Parameters.Add("@SupplierPrompt", SqlDbType.NVarChar, 255).Value = txtPrompt.Text.Trim();
            //cmd.Parameters.Add("@Consignee", SqlDbType.NVarChar, 50).Value = txtConsignee.Text.Trim();
            //cmd.Parameters.Add("@AllSum", SqlDbType.Decimal).Value = Convert.ToDecimal(lbTotalSum.Text.Trim());
            //cmd.Parameters.Add("@OrderConvention", SqlDbType.Text).Value = txtConvention.Text;
            //cmd.Parameters.Add("@returnInsert", SqlDbType.Int);
            //cmd.Parameters["@returnInsert"].Direction = ParameterDirection.ReturnValue;
            //try
            //{
            //    cmd.ExecuteNonQuery();
            //}
            //catch (SqlException Ex)
            //{
            //    MessageBox.Show("数据更新失败" + Ex.Message, "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //finally
            //{
            //    Sqlstr.GetClose();
            //}
            //string TempRv = cmd.Parameters["@returnInsert"].Value.ToString();
            //switch (TempRv)
            //{
            //    case"0":
            //        RecordsUp();
            //        break;
            //    case"1":
            //        MessageBox.Show("没有找到相应的数据记录！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        break;
            //    case"2":
            //        MessageBox.Show("数据更新失败！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        break;
            //}
            //cmd.Dispose();
        }
        /// <summary>
        /// 整单状态修改
        /// </summary>
        private void FormStatusUp()
        {
            //SqlCommand cmd = new SqlCommand("Pr_OrderFormStatusUp", Sqlstr.GetCon());
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@OrderFormID", SqlDbType.NVarChar, 255).Value = IndentUpID.Trim();
            //if (lbIndentStatus.Text.Trim() == "有效")
            //{
            //    cmd.Parameters.Add("@OrderFormStatus", SqlDbType.NVarChar, 2).Value = "无效";
            //    cmd.Parameters.Add("@Goods_Status", SqlDbType.NVarChar, 2).Value = "无效";
            //}
            //else
            //{
            //    cmd.Parameters.Add("@OrderFormStatus", SqlDbType.NVarChar, 2).Value = "有效";
            //    cmd.Parameters.Add("@Goods_Status", SqlDbType.NVarChar, 2).Value = "有效";
            //}
            //cmd.Parameters.Add("@returnID", SqlDbType.Int);
            //cmd.Parameters["@returnID"].Direction = ParameterDirection.ReturnValue;
            //try
            //{
            //    cmd.ExecuteNonQuery();
            //}
            //catch
            //{
            //    return;
            //}
            //finally
            //{
            //    Sqlstr.GetClose();
            //}
            //string RtID = cmd.Parameters["@returnID"].Value.ToString();
            //switch (RtID)
            //{
            //    case "0":
            //        MessageBox.Show("数据更新完成，请校对！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        FormMainSelecte();
            //        FormOrderSelect();
            //        break;
            //    case "1":
            //        MessageBox.Show("数据主表更新失败！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        break;
            //    case "2":
            //        MessageBox.Show("数据子表更新失败！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        break;
            //}
            //cmd.Dispose();
        }

        private void btnStateUp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("请注意：本操作将更新该订单中所有记录的状态！\r\r选择“是”将更新，选择“否”不更新！",
                "警告提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FormStatusUp();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否打印订单？", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lbIndentStatus.Text.Trim() == "有效")
                {
                    Frm_IndentFormPrint fifp = new Frm_IndentFormPrint();
                    fifp.OrderID = lbIndentID.Text.Trim();
                    fifp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("无效订单不可打印！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Close();
                this.Dispose();
                //GC.Collect();
                //Mcc.FlushMemory();
            }
        }
        /// <summary>
        /// 合计金额统计法方
        /// </summary>
        private void TotalSumJe()
        {
            decimal TotalSum = 0;
            for (int i = 0; i < dgvIndentList.Rows.Count; i++)
            {
                if (dgvIndentList.Rows[i].Cells[8].Value.ToString().Trim() == "有效")
                {
                    TotalSum = TotalSum + (Convert.ToDecimal(dgvIndentList.Rows[i].Cells[6].Value.ToString().Trim()));
                }
            }
            lbTotalSum.Text = Convert.ToString(TotalSum);
        }

        private void Frm_IndentPurUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            GC.Collect();
            //Mcc.FlushMemory();
        }
    }
}
