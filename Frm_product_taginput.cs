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
    public partial class Frm_product_taginput : Form
    {
        public Frm_product_taginput()
        {
            InitializeComponent();
        }

        private void txt_Productid_DoubleClick(object sender, EventArgs e)
        {
            Frm_productSelect frmps = new Frm_productSelect();
            frmps.ShowDialog();
        }

        private void dgv_tagprint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_tagprint.RowCount > 0)
            {
                Frm_tag_print frmtp = new Frm_tag_print();
                frmtp.ShowDialog();
                frmtp.productid = dgv_tagprint.SelectedCells[1].Value.ToString().Trim();
            }
        }

        private void btn_Saveprint_Click(object sender, EventArgs e)
        {
            Frm_tag_print frmtp = new Frm_tag_print();
            frmtp.ShowDialog();

            //if (txt_Productid.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("产品编号不能为空！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txt_Productid.Focus();
            //}
            //else if (txt_ProductName.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("产品名称不能为空！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txt_Productid.Focus();
            //}
            //else if (txt_Unit.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("产品规格不能为空！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txt_Unit.Focus();
            //}
            //else if (txt_batchNum.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("生产批号不能为空！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txt_batchNum.Focus();
            //}
            //else if (txt_Shelflife.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("产品保质期不能为空！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txt_Shelflife.Focus();
            //}
            //else
            //{
            //    //tagSaveAndprint();
            //}
        }

        private void tagSaveAndprint()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                string strsql = "INSERT INTO `tag_print` VALUES(NULL,@product_id,@product_name,@product_unit,@product_date,";
                strsql += "@batch_number,@product_shelflife,@print_status)";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = strsql;
                cmd.Parameters.AddWithValue("@product_id", txt_Productid.Text.Trim());
                cmd.Parameters.AddWithValue("@product_name", txt_ProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@product_unit", txt_Unit.Text.Trim());
                cmd.Parameters.AddWithValue("@product_date", Convert.ToDateTime(dtp_Productdate.Value.ToShortDateString().Trim()));
                cmd.Parameters.AddWithValue("@batch_number", txt_batchNum.Text.Trim());
                cmd.Parameters.AddWithValue("@product_shelflife", txt_Shelflife.Text.Trim());
                cmd.Parameters.AddWithValue("@print_status", "未打印");
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
                if (conn.State!=ConnectionState.Closed)
                {
                    transaction.Commit();
                    conn.Close();
                    MessageBox.Show("数据已保存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Productid.Text = "";
            txt_ProductName.Text = "";
            dtp_Productdate.Value = DateTime.Now;
            txt_Unit.Text = "";
            txt_batchNum.Text = "";
            txt_Shelflife.Text = "6个月";
        }

        private void txt_batchNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13 || e.KeyChar == 9)
            {
                txt_Unit.Focus();
            }
        }

        private void txt_Unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.' || this.txt_Unit.Text.Length == 0)
                {
                    e.Handled = true;
                }
                if (txt_Unit.Text.LastIndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
