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

        DataSet ds_tagprint = new DataSet();

        DataView dv_tagprint = new DataView();



        private void txt_Productid_DoubleClick(object sender, EventArgs e)
        {
            Frm_productSelect frmps = new Frm_productSelect();
            frmps.ShowDialog();
            if (frmps.prid != null)
            {
                txt_Systemid.Text = frmps.prsystemid.ToString().Trim();
                txt_Productid.Text = frmps.prid.ToString().Trim();
                txt_ProductName.Text = frmps.prname.ToString().Trim();
                txt_Unit.Text = frmps.prunit.ToString().Trim();
                txt_Unit.Focus();
            }
        }

        private void dgv_tagprint_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_tagprint.RowCount > 0)
            {
                Frm_tag_print frmtp = new Frm_tag_print();
                frmtp.printid = dgv_tagprint.SelectedCells[0].Value.ToString().Trim();
                frmtp.copies = Convert.ToInt16(dgv_tagprint.SelectedCells[7].Value.ToString().Trim());
                frmtp.ShowDialog();
            }
            ds_tagprint.Clear();
            tagQuery();
        }

        private void btn_Saveprint_Click(object sender, EventArgs e)
        {
            if (txt_Productid.Text.Trim().Length == 0)
            {
                MessageBox.Show("产品编号不能为空！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Productid.Focus();
            }
            else if (txt_ProductName.Text.Trim().Length == 0)
            {
                MessageBox.Show("产品名称不能为空！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Productid.Focus();
            }
            else if (txt_Unit.Text.Trim().Length == 0)
            {
                MessageBox.Show("产品规格不能为空！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Unit.Focus();
            }
            else if (txt_batchNum.Text.Trim().Length == 0)
            {
                MessageBox.Show("生产批号不能为空！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_batchNum.Focus();
            }
            else if (txt_Shelflife.Text.Trim().Length == 0)
            {
                MessageBox.Show("产品保质期不能为空！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Shelflife.Focus();
            }
            else if (txt_num.Text.Trim().Length==0)
            {
                MessageBox.Show("数量不能为空！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_num.Focus();
            }
            else
            {
                tagSaveAndprint();
            }
        }

        private void tagSaveAndprint()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                string strsql = "INSERT INTO `tag_print` VALUES(NULL,@proid,@product_id,@product_name,@product_unit,@product_date,";
                strsql += "@batch_number,@product_shelflife,@product_num,@print_status)";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = strsql;
                cmd.Parameters.AddWithValue("@proid", txt_Systemid.Text.Trim());
                cmd.Parameters.AddWithValue("@product_id", txt_Productid.Text.Trim());
                cmd.Parameters.AddWithValue("@product_name", txt_ProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@product_unit", txt_Unit.Text.Trim());
                cmd.Parameters.AddWithValue("@product_date", Convert.ToDateTime(dtp_Productdate.Value.ToShortDateString().Trim()));
                cmd.Parameters.AddWithValue("@batch_number", txt_batchNum.Text.Trim());
                cmd.Parameters.AddWithValue("@product_shelflife", txt_Shelflife.Text.Trim());
                cmd.Parameters.AddWithValue("@product_num", txt_num.Text.Trim());
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
                if (conn.State != ConnectionState.Closed)
                {
                    transaction.Commit();
                    conn.Close();
                    MessageBox.Show("数据已保存请在下方列表中选择打印！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    allClear();
                    ds_tagprint.Clear();
                    tagQuery();
                }
            }
        }

        /// <summary>
        /// 标签检索
        /// </summary>
        private void tagQuery()
        {
            string strsql = "SELECT id,tag_print.proid,tag_print.product_id,tag_print.product_name,tag_print.product_unit,";
            strsql += "tag_print.product_date,tag_print.batch_number,tag_print.product_num,tag_print.product_shelflife,tag_print.print_status";
            strsql += " FROM tag_print WHERE tag_print.print_status = '未打印' ORDER BY tag_print.id ASC";

            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter(strsql,conn);
            msda.Fill(ds_tagprint, "resultTable");

            dv_tagprint.Table = ds_tagprint.Tables["resultTable"];
            dgv_tagprint.DataSource = dv_tagprint.ToTable("resultTable");
            dgv_tagprint.Columns[0].HeaderText = "系统编号";
            dgv_tagprint.Columns[0].Visible = false;
            dgv_tagprint.Columns[1].HeaderText = "系统编号";
            dgv_tagprint.Columns[1].Visible = false;
            dgv_tagprint.Columns[2].HeaderText = "产品编号";
            dgv_tagprint.Columns[3].HeaderText = "产品名称";
            dgv_tagprint.Columns[4].HeaderText = "规格";
            dgv_tagprint.Columns[5].HeaderText = "生产日期";
            dgv_tagprint.Columns[6].HeaderText = "批号";
            dgv_tagprint.Columns[7].HeaderText = "数量";
            dgv_tagprint.Columns[8].HeaderText = "保质期";
            dgv_tagprint.Columns[9].HeaderText = "状态";

            conn.Close();
            msda.Dispose();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            allClear();
        }

        private void allClear()
        {
            txt_Systemid.Text = "";
            txt_Productid.Text = "";
            txt_ProductName.Text = "";
            dtp_Productdate.Value = DateTime.Now;
            txt_Unit.Text = "";
            txt_Shelflife.Text = "6个月";
            txt_num.Text = "";
        }

        private void txt_batchNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13 || e.KeyChar == 9)
            {
                txt_Shelflife.Focus();
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
            else if(e.KeyChar==13||e.KeyChar==9)
            {
                e.Handled = true;
                txt_batchNum.Focus();
            }
        }

        private void txt_Shelflife_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13||e.KeyChar==9)
            {
                e.Handled = true;
                txt_num.Focus();
            }
        }

        private void Frm_product_taginput_Load(object sender, EventArgs e)
        {
            txt_batchNum.Text = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            tagQuery();
        }

        private void txt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.' || this.txt_num.Text.Length == 0)
                {
                    e.Handled = true;
                }
                if (txt_num.Text.LastIndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar == 13 || e.KeyChar == 9)
            {
                e.Handled = true;
                btn_Saveprint.Focus();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ds_tagprint.Clear();
            tagQuery();
        }
    }
}
