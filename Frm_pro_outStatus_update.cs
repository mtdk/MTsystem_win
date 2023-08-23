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
    public partial class Frm_pro_outStatus_update : Form
    {
        public Frm_pro_outStatus_update()
        {
            InitializeComponent();
        }

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        private void Frm_pro_outStatus_update_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmpro_outstatusup == "CLOSE" || frmShowstatus._Frmpro_outstatusup == null)
            {
                frmShowstatus._Frmpro_outstatusup = "OPEN";
                queryAlloutmain();
            }
        }

        private void Frm_pro_outStatus_update_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmpro_outstatusup = "CLOSE";
        }

        private void queryAlloutmain()
        {
            string strsql = null;
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            if (txt_Outputid.Text.Trim().Length == 0)
            {
                strsql = "SELECT Outid AS 记录号, Cus_name AS 客户名称, Output_id AS 货号,Out_status AS 单据状态 FROM product_out_main";
                strsql +=" WHERE YEAR(product_out_main.Out_date) >= "+dtp_start_year.Value.Year.ToString().Trim()+"";
                MySqlDataAdapter msda = new MySqlDataAdapter(strsql, conn);
                msda.Fill(ds_Queryresult, "resultTable");

                dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];

                dgv_Pro_outmain_view.DataSource = dv_Queryresult.ToTable("resultTable");
                msda.Dispose();

            }
            else
            {
                strsql = "SELECT Outid AS 记录号, Cus_name AS 客户名称, Output_id AS 货号,Out_status AS 单据状态 FROM product_out_main";
                strsql += " WHERE Output_id ='" + txt_Outputid.Text.Trim() + "' AND";
                strsql += " YEAR(product_out_main.Out_date) >= " + dtp_start_year.Value.Year.ToString().Trim() + "";
                MySqlDataAdapter msda = new MySqlDataAdapter(strsql, conn);
                msda.Fill(ds_Queryresult, "resultTable");

                dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];

                dgv_Pro_outmain_view.DataSource = dv_Queryresult.ToTable("resultTable");
                msda.Dispose();
            }
            conn.Dispose();
        }

        private void dgv_Pro_outmain_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgv_pro_outview.DataSource = null;
            dv_Queryresult.Table.Clear();
            if (dgv_Pro_outmain_view.RowCount > 0)
            {
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                conn.Open();
                string strsql = "SELECT Proid AS 系统码, Product_id AS 编号,Product_name AS 名称,Product_cksl AS 数量,Product_unit AS 规格,";
                strsql += "Ckzl AS 重量,Product_price AS 单价,Product_total_amount AS 金额,Out_remarks AS 备注 FROM product_out";
                strsql += " WHERE Outid = '" + dgv_Pro_outmain_view.SelectedCells[0].Value.ToString().Trim() + "'";
                MySqlDataAdapter msda = new MySqlDataAdapter(strsql, conn);
                msda.Fill(ds_Queryresult, "pro_outResult");

                dv_Queryresult.Table = ds_Queryresult.Tables["pro_outResult"];

                dgv_pro_outview.DataSource = dv_Queryresult.ToTable("pro_outResult");
                conn.Dispose();
                msda.Dispose();
                label4.Text = dgv_Pro_outmain_view.SelectedCells[2].Value.ToString().Trim();
                label5.Text = dgv_Pro_outmain_view.SelectedCells[3].Value.ToString().Trim();
                label7.Text = dgv_Pro_outmain_view.SelectedCells[0].Value.ToString().Trim();
            }
        }

        private void txt_Outputid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                dv_Queryresult.Table.Clear();
                label4.Text = "NULL";
                label5.Text = "NULL";
                label7.Text = "NULL";
                queryAlloutmain();
            }
        }

        private void btn_Upstatus_Click(object sender, EventArgs e)
        {
            if (label4.Text.Trim().Length!=0)
            {
                if (label4.Text.Trim() != "NULL")
                {
                    if (label7.Text.Trim() != "NULL")
                    {
                        if (label5.Text.Trim() != "无效")
                        {
                            //更新状态
                            statusUpdate();
                        }
                        else
                        {
                            MessageBox.Show("这个出货单状态已是无效！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("货号不能为NULL！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("货单流水号不能为NULL！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("货号不能为空！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cmd.Parameters.AddWithValue("@Proid", dgv_pro_outview.Rows[i].Cells[0].Value.ToString().Trim());
            cmd.CommandText = sqlstr;
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            b = dr.Read();
            return b;
        }

        //单据状态更新
        private void statusUpdate()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                string sqlstr = "update product_out_main set Out_status = @Out_status where Outid = @Outid";
                cmd.CommandText = sqlstr;
                cmd.Parameters.Add("@Out_status", MySqlDbType.VarChar).Value = "无效";
                cmd.Parameters.Add("@Outid", MySqlDbType.VarChar).Value = label7.Text.Trim();
                cmd.ExecuteNonQuery();

                string sqlstrB = "update product_out set Out_status = @Out_statusB where Outid = @OutidB";
                cmd.CommandText = sqlstrB;
                cmd.Parameters.Add("@Out_statusB", MySqlDbType.VarChar).Value = "无效";
                cmd.Parameters.Add("@OutidB", MySqlDbType.VarChar).Value = label7.Text.Trim();
                cmd.ExecuteNonQuery();

                for (int i = 0; i < dgv_pro_outview.RowCount; i++)
                {
                    //ii作为当前行号传递给QueryProid()方法，进行查询比较，确定数据表中是否已存在相关记录，有则进行数据更新，无则添加新记录
                    if (QueryProid(i))
                    {
                        string sqlstrD = "";
                        sqlstrD = "UPDATE product_stock SET Product_num = Product_num + @Product_numD, Product_stock = Product_stock + @Product_stockD WHERE Proid = @ProidD";
                        MySqlCommand cmdD = new MySqlCommand();
                        cmdD.Connection = conn;
                        cmdD.CommandText = sqlstrD;
                        cmdD.Parameters.AddWithValue("@ProidD", dgv_pro_outview.Rows[i].Cells[0].Value.ToString().Trim());
                        cmdD.Parameters.AddWithValue("@Product_numD", Convert.ToDecimal(dgv_pro_outview.Rows[i].Cells[3].Value.ToString().Trim()));
                        cmdD.Parameters.AddWithValue("@Product_stockD", Convert.ToDecimal(dgv_pro_outview.Rows[i].Cells[5].Value.ToString().Trim()));
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
                        cmdE.Parameters.AddWithValue("@ProidE", dgv_pro_outview.Rows[i].Cells[0].Value.ToString().Trim());
                        cmdE.Parameters.AddWithValue("@Product_idE", dgv_pro_outview.Rows[i].Cells[1].Value.ToString().Trim());
                        cmdE.Parameters.AddWithValue("@Product_nameE", dgv_pro_outview.Rows[i].Cells[2].Value.ToString().Trim());
                        cmdE.Parameters.AddWithValue("@Product_numE", Convert.ToDecimal(dgv_pro_outview.Rows[i].Cells[3].Value.ToString().Trim()));
                        cmdE.Parameters.AddWithValue("@Product_stockE", Convert.ToDecimal(dgv_pro_outview.Rows[i].Cells[5].Value.ToString().Trim()));
                        cmdE.Parameters.AddWithValue("@Input_dateE", DateTime.Now.ToShortDateString().Trim());
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
                    dv_Queryresult.Table.Clear();
                    label4.Text = "NULL";
                    label5.Text = "NULL";
                    label7.Text = "NULL";
                    queryAlloutmain();
                }
            }
        }

        private void dgv_Pro_outmain_view_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                dv_Queryresult.Table.Clear();
                if (dgv_Pro_outmain_view.RowCount > 0)
                {
                    MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                    conn.Open();
                    string strsql = "SELECT Product_id AS 编号,Product_name AS 名称,Product_cksl AS 数量,Product_unit AS 规格,";
                    strsql += "Ckzl AS 重量,Product_price AS 单价,Product_total_amount AS 金额,Out_remarks AS 备注 FROM product_out";
                    strsql += " WHERE Outid = '" + dgv_Pro_outmain_view.SelectedCells[0].Value.ToString().Trim() + "'";
                    MySqlDataAdapter msda = new MySqlDataAdapter(strsql, conn);
                    msda.Fill(ds_Queryresult, "pro_outResult");

                    dv_Queryresult.Table = ds_Queryresult.Tables["pro_outResult"];

                    dgv_pro_outview.DataSource = dv_Queryresult.ToTable("pro_outResult");
                    conn.Dispose();
                    msda.Dispose();
                    label4.Text = dgv_Pro_outmain_view.SelectedCells[2].Value.ToString().Trim();
                    label5.Text = dgv_Pro_outmain_view.SelectedCells[3].Value.ToString().Trim();
                    label7.Text = dgv_Pro_outmain_view.SelectedCells[0].Value.ToString().Trim();
                }
            }
        }
    }
}
