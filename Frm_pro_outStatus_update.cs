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
                MySqlDataAdapter msda = new MySqlDataAdapter(strsql, conn);
                msda.Fill(ds_Queryresult, "resultTable");

                dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];

                dgv_Pro_outmain_view.DataSource = dv_Queryresult.ToTable("resultTable");
            }
            else
            {
                strsql = "SELECT Outid AS 记录号, Cus_name AS 客户名称, Output_id AS 货号,Out_status AS 单据状态 FROM product_out_main";
                strsql += " WHERE Output_id ='" + txt_Outputid.Text.Trim() + "'";
                MySqlDataAdapter msda = new MySqlDataAdapter(strsql, conn);
                msda.Fill(ds_Queryresult, "resultTable");

                dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];

                dgv_Pro_outmain_view.DataSource = dv_Queryresult.ToTable("resultTable");
            }
        }

        private void dgv_Pro_outmain_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgv_pro_outview.DataSource = null;
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
                queryAlloutmain();
            }
        }

        private void btn_Upstatus_Click(object sender, EventArgs e)
        {
            if (label4.Text.Trim().Length!=0)
            {
                if (label4.Text.Trim() != "NULL")
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
                MessageBox.Show("货号不能为空！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //单据状态更新
        private void statusUpdate()
        {

        }
    }
}
