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
    public partial class Frm_proPriceUpdate : Form
    {
        public Frm_proPriceUpdate()
        {
            InitializeComponent();
        }

        JudgeNumber jnum = new JudgeNumber();

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        private void Frm_proPriceUpdate_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmpropriceupdate == "CLOSE" || frmShowstatus._Frmpropriceupdate == null)
            {
                frmShowstatus._Frmpropriceupdate = "OPEN";
            }
        }

        private void Frm_proPriceUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmpropriceupdate = "CLOSE";
        }

        private void Query_product_offer()
        {
            string sqlstr = "SELECT Cus_id, proid, product_id, product_name, product_price FROM product_offer WHERE Cus_id = '" + txt_CusId.Text.Trim() + "'";
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
            msda.Fill(ds_Queryresult, "resultTable");

            dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];
            dgv_productPrice.DataSource = dv_Queryresult.ToTable("resultTable");
            dgv_productPrice.Columns[0].Visible = true;
            dgv_productPrice.Columns[0].HeaderText = "客户编号";
            dgv_productPrice.Columns[1].Visible = false;
            dgv_productPrice.Columns[2].HeaderText = "产品编号";
            dgv_productPrice.Columns[3].HeaderText = "产品名称";
            dgv_productPrice.Columns[4].HeaderText = "产品价格";
            conn.Close();
            conn.Dispose();
            msda.Dispose();
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
                        txt_CusId.Text = frmcusinfoshow.Cus_id.Trim();
                        txt_CusName.Text = frmcusinfoshow.Cus_name.Trim();
                        Query_product_offer();
                        txt_CusName.ReadOnly = true;
                        dgv_productPrice.Focus();
                    }
                }
            }
        }

        private void dgv_productPrice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_productPrice.Rows.Count > 0)
            {
                txt_proid.Text = dgv_productPrice.SelectedCells[1].Value.ToString().Trim();
                txt_ProductId.Text = dgv_productPrice.SelectedCells[2].Value.ToString().Trim();
                txt_ProductName.Text = dgv_productPrice.SelectedCells[3].Value.ToString().Trim();
                txt_ProductPrice.Text = dgv_productPrice.SelectedCells[4].Value.ToString().Trim();
                txt_ProductPrice.Focus();
                txt_ProductPrice.SelectAll();
            }
        }

        private void dgv_productPrice_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (dgv_productPrice.Rows.Count > 0)
                {
                    txt_proid.Text = dgv_productPrice.CurrentRow.Cells[1].Value.ToString().Trim();
                    txt_ProductId.Text = dgv_productPrice.CurrentRow.Cells[2].Value.ToString().Trim();
                    txt_ProductName.Text = dgv_productPrice.CurrentRow.Cells[3].Value.ToString().Trim();
                    txt_ProductPrice.Text = dgv_productPrice.CurrentRow.Cells[4].Value.ToString().Trim();
                    txt_ProductPrice.Focus();
                    txt_ProductPrice.SelectAll();
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_CusId.Text.Trim().Length == 0)
            {
                MessageBox.Show("客户编号不能为空！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            dgv_productPrice.DataSource = null;
            dgv_productPrice.Refresh();
            txt_CusName.Text = "";
            txt_CusName.ReadOnly = false;
            txt_proid.Text = "";
            txt_ProductId.Text = "";
            txt_ProductName.Text = "";
            txt_ProductPrice.Text = "";
        }

        private void txt_ProductPrice_Leave(object sender, EventArgs e)
        {
            if (txt_ProductPrice.Text.Trim().Length == 0)
            {
                txt_ProductPrice.Text = "0";
            }
            else if (!jnum.ISNumeric(txt_ProductPrice.Text.Trim()))
            {
                MessageBox.Show("格式错误，这个位置只能输入数字！！！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ProductPrice.Focus();
                txt_ProductPrice.SelectAll();
            }
        }
    }
}
