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
    public partial class Frm_pro_returnGoods : Form
    {
        public Frm_pro_returnGoods()
        {
            InitializeComponent();
        }

        JudgeNumber jnum = new JudgeNumber();

        //tmpdt 一个为了迎合用户特殊习惯的不应该出现的垃圾全局变量-1
        public DateTime tmpdt;

        private void Frm_pro_returnGoods_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmmatreturngoods == "CLOSE" || frmShowstatus._Frmmatreturngoods == null)
            {
                frmShowstatus._Frmmatreturngoods = "OPEN";
                newOutputid();
            }
        }

        private void Frm_pro_returnGoods_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmmatreturngoods = "CLOSE";
        }

        private void btn_Cancel_B_Click(object sender, EventArgs e)
        {
            ctrlClear();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        /// <summary>
        /// 产品退货单号
        /// </summary>
        private void newOutputid()
        {
            txt_outputid.Text = DateTime.Now.Year.ToString().Trim();
            txt_outputid.Text += DateTime.Now.Month.ToString().PadLeft(2, '0').Trim();
            txt_outputid.Text += DateTime.Now.Day.ToString().PadLeft(2, '0').Trim();
            txt_outputid.Text += DateTime.Now.Hour.ToString().PadLeft(2, '0').Trim();
            txt_outputid.Text += DateTime.Now.Minute.ToString().PadLeft(2, '0').Trim();
            txt_outputid.Text += DateTime.Now.Second.ToString().PadLeft(2, '0').Trim();
            txt_outputDate.Text = txt_outputid.Text.Substring(0, 8).Trim();
            //txt_batchNum.Text = txt_outputid.Text.Substring(8, 6).Trim();
            txt_batchNum.Text = txt_outputid.Text.Trim();
        }

        /// <summary>
        /// 清除录入控件数据
        /// </summary>
        private void ctrlClear()
        {
            txt_proId.Text = "";
            txt_productId.Text = "";
            txt_productName.Text = "";
            txt_OutputNum.Text = "0";
            txt_OutputUnit.Text = "0";
            txt_OutputWeight.Text = "0";
            txt_Price.Text = "0";
            txt_AmountMoney.Text = "0";
            txt_Remarks.Text = "";
            txt_productId.Focus();

        }

        /// <summary>
        /// 清空所有控件
        /// </summary>
        private void AllClear()
        {
            txt_Cusid.Text = "";
            txt_CusName.Text = "";
            txt_CusName.ReadOnly = false;
            txt_batchNum.Text = "";
            newOutputid();
            txt_outputDate.ReadOnly = false;
            txt_batchNum.ReadOnly = false;
            txt_proId.Text = "";
            txt_productId.Text = "";
            txt_productName.Text = "";
            txt_OutputNum.Text = "0";
            txt_OutputUnit.Text = "0";
            txt_OutputWeight.Text = "0";
            txt_Price.Text = "0";
            txt_AmountMoney.Text = "0";
            txt_Remarks.Text = "";
            dgv_OutputView.Rows.Clear();
        }

        /// <summary>
        /// 查询已有的datagridview表格中是否有相同的记录存在
        /// </summary>
        /// <param name="tmp_proid">产品内码</param>
        /// <returns>0 or 1(0 标识没有相同的记录，1或者各大的数表示有相同记录出现</returns>
        private int theSameRecord(string tmp_proid)
        {
            int t = 0;
            for (int i = 0; i < dgv_OutputView.RowCount; i++)
            {
                if (txt_proId.Text.Trim() == dgv_OutputView.Rows[i].Cells[0].Value.ToString().Trim())
                {
                    t = t + 1;
                }
            }
            return t;
        }

        /// <summary>
        /// 数据临时保存到datagridview前的数据完整性校验
        /// </summary>
        private void tempInsertJudge()
        {
            if (txt_Cusid.Text.Trim().Length != 0)
            {
                if (txt_proId.Text.Trim().Length != 0)
                {
                    if (dgv_OutputView.RowCount < 6)
                    {
                        if (dgv_OutputView.RowCount >= 1)
                        {
                            if ((theSameRecord(txt_proId.Text.Trim())) > 0)
                            {
                                MessageBox.Show("请不要输入相同的记录！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                tempDateInsert();
                            }
                        }
                        else
                        {
                            tempDateInsert();
                        }
                    }
                    else
                    {
                        MessageBox.Show("最多只能输入6条记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("请输入产品后再提交数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("客户不存在，不能保存记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 添加数据到datagridview
        /// </summary>
        private void tempDateInsert()
        {
            DataGridViewRow Row = new DataGridViewRow();
            SetBorderAndGridlineStyles();
            Row.CreateCells(dgv_OutputView);
            Row.Cells[0].Value = txt_proId.Text.Trim();
            Row.Cells[1].Value = txt_productId.Text.Trim();
            Row.Cells[2].Value = txt_productName.Text.Trim();
            Row.Cells[3].Value = txt_OutputNum.Text.Trim();
            Row.Cells[4].Value = txt_OutputUnit.Text.Trim();
            Row.Cells[5].Value = txt_OutputWeight.Text.Trim();
            Row.Cells[6].Value = txt_Price.Text.Trim();
            Row.Cells[7].Value = txt_AmountMoney.Text.Trim();
            Row.Cells[8].Value = txt_Remarks.Text.Trim();
            dgv_OutputView.Rows.Add(Row);

            sumTotalcount();
            ctrlClear();
        }

        private void SetBorderAndGridlineStyles()
        {
            this.dgv_OutputView.GridColor = Color.Black;    //datagridview网格线颜色
            this.dgv_OutputView.BorderStyle = BorderStyle.FixedSingle;  //datagridview边框样式
            this.dgv_OutputView.CellBorderStyle = DataGridViewCellBorderStyle.Single;   //单元格边框样式
            this.dgv_OutputView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;   //行标题单元格样式
            this.dgv_OutputView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;    //列标题边框样式
        }
        /// <summary>
        /// 总数量和总重量统计
        /// </summary>
        private void sumTotalcount()
        {
            decimal sumTotalweight = 0;
            int sumTotalnumber = 0;
            decimal sumTotalmoney = 0;
            for (int i = 0; i < dgv_OutputView.RowCount; i++)
            {
                sumTotalnumber += Convert.ToInt32(dgv_OutputView.Rows[i].Cells[3].Value.ToString().Trim());
                sumTotalweight += Convert.ToDecimal(dgv_OutputView.Rows[i].Cells[5].Value.ToString().Trim());
                sumTotalmoney += Convert.ToDecimal(dgv_OutputView.Rows[i].Cells[7].Value.ToString().Trim());

            }
            label11.Text = sumTotalnumber.ToString();
            label13.Text = sumTotalweight.ToString();
            label20.Text = sumTotalmoney.ToString();
        }

        /// <summary>
        /// 客户产品单价查询
        /// </summary>
        private void priceOfquery()
        {
            if (txt_proId.Text.Trim().Length != 0)
            {
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                conn.Open();
                string sqlstr = "SELECT product_price FROM product_offer WHERE Cus_id=@Cus_id AND proid=@proid";
                MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
                cmd.Parameters.AddWithValue("@proid", txt_proId.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_id", txt_Cusid.Text.Trim());
                cmd.CommandText = sqlstr;
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    txt_Price.Text = dr["product_price"].ToString().Trim();
                }
                else
                {
                    txt_Price.Text = "0";
                }
            }
        }


        /// <summary>
        /// 产品库存表中是否已经存在产品编号
        /// </summary>
        /// <param name="i">i为DataGridView当前行</param>
        /// <returns></returns>
        private bool QueryProid(int i)
        {
            bool b = false;
            string sqlstr = "SELECT Proid From product_stock WHERE Proid=@Proid";

            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
            cmd.Parameters.AddWithValue("@Proid", dgv_OutputView.Rows[i].Cells[0].Value.ToString().Trim());
            cmd.CommandText = sqlstr;
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            b = dr.Read();
            return b;
        }


        /// <summary>
        /// 添加退货数据
        /// </summary>
        private void dataInsert()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();

            try
            {
                int ii = 0;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                //产品退货主单信息添加
                string sqlstr = "INSERT INTO `product_out_main` VALUES(NULL,@Outid,@Cus_id,@Cus_name,@Out_date,@Output_id,@Out_status,@Out_operator)";

                cmd.CommandText = sqlstr;
                cmd.Parameters.AddWithValue("@Outid", txt_outputid.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_id", txt_Cusid.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_name", txt_CusName.Text.Trim());
                cmd.Parameters.AddWithValue("@Out_date",Convert.ToDateTime(tmpdt).ToShortDateString());
                cmd.Parameters.AddWithValue("@Output_id",txt_batchNum.Text.Trim());
                cmd.Parameters.AddWithValue("@Out_status","有效");
                cmd.Parameters.AddWithValue("@Out_operator",userInfocheck._Usname.Trim());
                cmd.ExecuteNonQuery();

                for (int i = 0; i < dgv_OutputView.RowCount; i++)
                {
                    MySqlCommand cmdA = new MySqlCommand();
                    cmdA.Connection = conn;
                    string sqlstrA = "";
                    //产品退货子单信息添加
                    sqlstrA = "INSERT INTO `product_out` VALUES(NULL,@OutidA,@ProidA,@Product_idA,@Product_nameA,";
                    sqlstrA += "@Product_ckslA,@Product_unitA,@CkzlA,@Product_priceA,";
                    sqlstrA += "@Product_total_amountA,@Out_remarksA,@Out_dateA,@Out_statusA)";

                    cmdA.CommandText = sqlstrA;
                    cmdA.Parameters.AddWithValue("@OutidA", txt_outputid.Text.Trim());
                    cmdA.Parameters.AddWithValue("@ProidA", dgv_OutputView.Rows[i].Cells[0].Value.ToString().Trim());
                    cmdA.Parameters.AddWithValue("@Product_idA", dgv_OutputView.Rows[i].Cells[1].Value.ToString().Trim());
                    cmdA.Parameters.AddWithValue("@Product_nameA", dgv_OutputView.Rows[i].Cells[2].Value.ToString().Trim());
                    cmdA.Parameters.AddWithValue("@Product_ckslA", Convert.ToInt32(dgv_OutputView.Rows[i].Cells[3].Value.ToString().Trim()) * -1);
                    cmdA.Parameters.AddWithValue("@Product_unitA", Convert.ToDecimal(dgv_OutputView.Rows[i].Cells[4].Value.ToString().Trim()));
                    cmdA.Parameters.AddWithValue("@CkzlA", Convert.ToDecimal(dgv_OutputView.Rows[i].Cells[5].Value.ToString().Trim()));
                    cmdA.Parameters.AddWithValue("@Product_priceA", Convert.ToDecimal(dgv_OutputView.Rows[i].Cells[6].Value.ToString().Trim()));
                    cmdA.Parameters.AddWithValue("@Product_total_amountA", Convert.ToDecimal(dgv_OutputView.Rows[i].Cells[7].Value.ToString().Trim()));
                    cmdA.Parameters.AddWithValue("@Out_remarksA", dgv_OutputView.Rows[i].Cells[8].Value.ToString().Trim());
                    cmdA.Parameters.AddWithValue("@Out_dateA", Convert.ToDateTime(tmpdt).ToShortDateString());
                    cmdA.Parameters.AddWithValue("@Out_statusA", "有效");
                    cmdA.ExecuteNonQuery();

                    //ii作为当前行号传递给QueryProid()方法，进行查询比较，确定数据表中是否已存在相关记录，有则进行数据更新，无则添加新记录
                    ii = i;
                    if (QueryProid(ii))
                    {
                        string sqlstrD = "";
                        sqlstrD = "UPDATE product_stock SET Product_num = Product_num + @Product_numD,";
                        sqlstrD += "Product_stock = Product_stock + @Product_stockD WHERE Proid = @ProidD";
                        MySqlCommand cmdD = new MySqlCommand();
                        cmdD.Connection = conn;
                        cmdD.CommandText = sqlstrD;
                        cmdD.Parameters.AddWithValue("@ProidD", dgv_OutputView.Rows[ii].Cells[0].Value.ToString().Trim());
                        cmdD.Parameters.AddWithValue("@Product_numD", Math.Abs(Convert.ToInt32(dgv_OutputView.Rows[ii].Cells[3].Value.ToString().Trim())));
                        cmdD.Parameters.AddWithValue("@Product_stockD", Math.Abs(Convert.ToDecimal(dgv_OutputView.Rows[ii].Cells[5].Value.ToString().Trim())));
                        cmdD.ExecuteNonQuery();
                    }
                    else
                    {
                        string sqlstrE = "";
                        sqlstrE = "INSERT INTO `product_stock` VALUES(NULL,@ProidE,@Product_idE,@Product_nameE,";
                        sqlstrE += "@Product_numE,@Product_stockE,@Input_dateE,@Input_operatorE)";
                        MySqlCommand cmdE = new MySqlCommand();
                        cmdE.Connection = conn;
                        cmdE.CommandText = sqlstrE;
                        cmdE.Parameters.AddWithValue("@ProidE", dgv_OutputView.Rows[ii].Cells[0].Value.ToString().Trim());
                        cmdE.Parameters.AddWithValue("@Product_idE", dgv_OutputView.Rows[ii].Cells[1].Value.ToString().Trim());
                        cmdE.Parameters.AddWithValue("@Product_nameE", dgv_OutputView.Rows[ii].Cells[2].Value.ToString().Trim());
                        cmdE.Parameters.AddWithValue("@Product_numE", Math.Abs(Convert.ToInt32(dgv_OutputView.Rows[ii].Cells[3].Value.ToString().Trim())));
                        cmdE.Parameters.AddWithValue("@Product_stockE", Math.Abs(Convert.ToDecimal(dgv_OutputView.Rows[ii].Cells[5].Value.ToString().Trim())));
                        cmdE.Parameters.AddWithValue("@Input_dateE", Convert.ToDateTime(tmpdt).ToShortDateString());
                        cmdE.Parameters.AddWithValue("@Input_operatorE", userInfocheck._Usname.Trim());
                        cmdE.ExecuteNonQuery();
                    }
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
                    MessageBox.Show("数据已保存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Frm_product_outPrint fpoutprint = new Frm_product_outPrint();
                    //fpoutprint.out_id = txt_outputid.Text.Trim();
                    //fpoutprint.ShowDialog();
                    AllClear();
                    newOutputid();
                }
            }
        }

        private void txt_CusName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (txt_CusName.Text.Trim().Length != 0)
                {
                    Frm_CusinfoShow frmcusinfoshow = new Frm_CusinfoShow();
                    frmcusinfoshow.selectCondition = txt_CusName.Text.Trim();
                    frmcusinfoshow.ShowDialog();
                    if (frmcusinfoshow.Cus_id != "")
                    {
                        txt_Cusid.Text = frmcusinfoshow.Cus_id.Trim();
                        txt_CusName.Text = frmcusinfoshow.Cus_name.Trim();
                        txt_outputDate.Focus();
                    }
                }
            }
        }

        private void txt_outputDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_batchNum.Focus();
            }
        }

        private void txt_outputDate_Leave(object sender, EventArgs e)
        {
            if (txt_outputDate.Text.Trim().Length == 0)
            {
                MessageBox.Show("格式错误，此处不能为空，应填入如：20210101", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_outputDate.Focus();
                txt_outputDate.SelectAll();
            }
            else if(!jnum.IntegralNumber(txt_outputDate.Text.Trim()))
            {
                MessageBox.Show("格式错误，这个位置只能输入数字，如：20210101", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_outputDate.Focus();
                txt_outputDate.SelectAll();
            }
            else if (txt_outputDate.Text.Trim().Length != 8)
            {
                MessageBox.Show("格式错误，这个位置只能输入8位数字，如：20210101", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_outputDate.Focus();
                txt_outputDate.SelectAll();
            }
            else
            {
                //tmp 一个为了迎合用户特殊习惯的不应该出现的垃圾全局变量-2
                string tmp;
                tmp = txt_outputDate.Text.Trim().Substring(0, 4) + "-" + txt_outputDate.Text.Trim().Substring(4, 2) + "-" + txt_outputDate.Text.Trim().Substring(6, 2).Trim();

                if (DateTime.TryParse(tmp, out tmpdt))
                {
                    txt_outputDate.ReadOnly = true;
                    txt_batchNum.Focus();
                }
                else
                {
                    MessageBox.Show("格式错误，此处不能为空，应填入如：20210101", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_outputDate.Focus();
                    txt_outputDate.SelectAll();
                }
            }
        }

        private void txt_batchNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_CusName.ReadOnly = true;
                txt_batchNum.ReadOnly = true;
                txt_productId.Focus();
            }
        }

        private void txt_productId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (txt_productId.Text.Trim().Length != 0)
                {
                    Frm_productOutSelect frmpOutselect = new Frm_productOutSelect();
                    frmpOutselect.selectCondition = txt_productId.Text.Trim();
                    frmpOutselect.ShowDialog();
                    if (frmpOutselect.pro_id !="" && frmpOutselect.pro_id!=null)
                    {
                        txt_proId.Text = frmpOutselect.pro_id.Trim();
                        txt_productId.Text = frmpOutselect.product_id.Trim();
                        txt_productName.Text = frmpOutselect.product_name.Trim();
                        txt_OutputUnit.Text = frmpOutselect.product_unit.Trim();
                        txt_OutputNum.Focus();
                        priceOfquery();
                    }

                }
            }
        }

        private void txt_OutputNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                e.Handled = true;
                txt_OutputUnit.Focus();
            }
        }

        private void txt_OutputNum_Leave(object sender, EventArgs e)
        {
            if (txt_OutputNum.Text.Trim().Length==0)
            {
                txt_OutputNum.Text = "0";
            }
            else if (!jnum.IntegralNumber(txt_OutputNum.Text.Trim()))
            {
                MessageBox.Show("格式错误，这个位置只能输入大于0的整数，如：20", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_OutputNum.Focus();
                txt_OutputNum.SelectAll();
            }
            else if ((Convert.ToInt32(txt_OutputNum.Text.Trim())) < 0)
            {
                MessageBox.Show("请输入大于0的整数，如：20", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_OutputNum.Focus();
                txt_OutputNum.SelectAll();
            }
            else
            {
                if (txt_OutputUnit.Text.Trim().Length != 0)
                {
                    txt_OutputWeight.Text = ((Convert.ToInt32(txt_OutputNum.Text.Trim()) * -1) * Convert.ToDecimal(txt_OutputUnit.Text.Trim())).ToString().Trim();
                    txt_AmountMoney.Text = (Convert.ToInt32(txt_OutputWeight.Text.Trim()) * Convert.ToDecimal(txt_Price.Text.Trim())).ToString().Trim();
                }
            }
        }

        private void txt_OutputUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_Price.Focus();
            }
        }

        private void txt_OutputUnit_Leave(object sender, EventArgs e)
        {
            if (txt_OutputUnit.Text.Trim().Length == 0)
            {
                txt_OutputUnit.Text = "20";
            }
            else if (!jnum.ISNumeric(txt_OutputUnit.Text.Trim()))
            {
                MessageBox.Show("格式错误，这个位置只能输入大于0的数，如：20", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_OutputUnit.Focus();
                txt_OutputUnit.SelectAll();
            }
            else
            {
                if (txt_OutputNum.Text.Trim().Length != 0)
                {
                    txt_OutputWeight.Text = ((Convert.ToInt32(txt_OutputNum.Text.Trim()) * -1) * Convert.ToDecimal(txt_OutputUnit.Text.Trim())).ToString().Trim();
                    txt_AmountMoney.Text = (Convert.ToInt32(txt_OutputWeight.Text.Trim()) * Convert.ToDecimal(txt_Price.Text.Trim())).ToString().Trim();
                }
            }
        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_Remarks.Focus();
            }
        }

        private void txt_Price_Leave(object sender, EventArgs e)
        {
            if (txt_Price.Text.Trim().Length == 0)
            {
                txt_Price.Text = "0";
            }
            else if (!jnum.ISNumeric(txt_Price.Text.Trim()))
            {
                MessageBox.Show("格式错误，这个位置只能输入大于0的数，如：20", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Price.Focus();
                txt_Price.SelectAll();
            }
            else
            {
                if (txt_OutputUnit.Text.Trim().Length != 0)
                {
                    txt_AmountMoney.Text = (Convert.ToInt32(txt_OutputWeight.Text.Trim()) * Convert.ToDecimal(txt_Price.Text.Trim())).ToString().Trim();
                }
            }
        }

        private void txt_Remarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                tempInsertJudge();
            }
        }


        private void dgv_OutputView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgv_OutputView.Rows.Count > 0)
            {
                sumTotalcount();
            }
            else
            {
                label11.Text = "0";
                label13.Text = "0";
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (dgv_OutputView.RowCount > 0)
            {
                dataInsert();
            }
            else
            {
                MessageBox.Show("没有数据记录可以保存的！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_tempInsert_Click(object sender, EventArgs e)
        {
            tempInsertJudge();
        }

    }
}
