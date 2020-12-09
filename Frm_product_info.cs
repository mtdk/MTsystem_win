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
    public partial class Frm_product_info : Form
    {
        public Frm_product_info()
        {
            InitializeComponent();
        }

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        int Maxid;

        private void Frm_product_info_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmproductinfo == "CLOSE" || frmShowstatus._Frmproductinfo == null)
            {
                frmShowstatus._Frmproductinfo = "OPEN";
                newSystemid();
                Productresult();
            }
        }

        private void Frm_product_info_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmproductinfo = "CLOSE";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (rdb_input.Checked == true)
            {
                if (txt_Systemid.Text.Trim().Length == 0)
                {
                    MessageBox.Show("产品系统编号不能为空！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txt_Productid.Text.Trim().Length == 0)
                {
                    MessageBox.Show("产品编号不能为空！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Productid.Focus();
                }
                else if (txt_Productname.Text.Trim().Length == 0)
                {
                    MessageBox.Show("产品名称不能为空！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Productname.Focus();
                }
                else if (txt_Productunit.Text.Trim().Length == 0)
                {
                    MessageBox.Show("产品规格不能为空！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Productunit.Focus();
                }
                else
                {
                    Productinput();
                }
            }
            else
            {
                if (txt_Systemid.Text.Trim().Length == 0)
                {
                    MessageBox.Show("产品系统编号不能为空！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txt_Productid.Text.Trim().Length == 0)
                {
                    MessageBox.Show("产品编号不能为空！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Productid.Focus();
                }
                else if (txt_Productname.Text.Trim().Length == 0)
                {
                    MessageBox.Show("产品名称不能为空！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Productname.Focus();
                }
                else if (txt_Productunit.Text.Trim().Length == 0)
                {
                    MessageBox.Show("产品规格不能为空！", "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Productunit.Focus();
                }
                else
                {

                }
            }
        }

        /// <summary>
        /// 产生产品新系统编号
        /// </summary>
        private void newSystemid()
        {
            string strsql="SELECT id,proid,product_id,product_name,";
            strsql += "product_unit FROM product ORDER BY id DESC LIMIT 1";
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(strsql, conn);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dr.Read();
            if (dr.HasRows)
            {
                Maxid = Convert.ToInt32(dr["proid"].ToString().Substring(1, 4).ToString());
                Maxid++;
                txt_Systemid.Text = string.Format("P{0}", Maxid.ToString().PadLeft(4, '0'));
            }
            else
            {
                Maxid = 1;
                txt_Systemid.Text = string.Format("P{0}", Maxid.ToString().PadLeft(4, '0'));
            }
        }

        /// <summary>
        /// 添加新产品信息
        /// </summary>
        private void Productinput()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                string strsql = "INSERT INTO `product` VALUES(NULL,@proid,@product_id,@product_name,@product_unit)";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = strsql;
                cmd.Parameters.AddWithValue("@proid", txt_Systemid.Text.Trim());
                cmd.Parameters.AddWithValue("@product_id", txt_Productid.Text.Trim());
                cmd.Parameters.AddWithValue("@product_name", txt_Productname.Text.Trim());
                cmd.Parameters.AddWithValue("@product_unit", txt_Productunit.Text.Trim());
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
                    newSystemid();
                    ds_Queryresult.Clear();
                    Productresult();
                }
            }
        }

        /// <summary>
        /// 清除控件数据返回初始化
        /// </summary>
        private void allClear()
        {
            txt_Productid.Text = "";
            txt_Productid.Focus();
            txt_Productname.Text = "";
            txt_Productunit.Text = "20";
        }

        /// <summary>
        /// 所有产品信息检索
        /// </summary>
        private void Productresult()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            string strsql = "SELECT id,proid,product_id,product_name,product_unit FROM product";
            MySqlDataAdapter msda = new MySqlDataAdapter(strsql, conn);
            msda.Fill(ds_Queryresult, "resultTable");

            dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];
            dgv_Queryresult.DataSource = dv_Queryresult.ToTable("resultTable");
            dgv_Queryresult.Columns[0].HeaderText = "序号";
            dgv_Queryresult.Columns[1].HeaderText = "系统编号";
            dgv_Queryresult.Columns[2].HeaderText = "产品编号";
            dgv_Queryresult.Columns[3].HeaderText = "产品名称";
            dgv_Queryresult.Columns[4].HeaderText = "产品规格";
            conn.Close();
        }

        /// <summary>
        /// 产品信息查找
        /// </summary>
        private void ProductQuery()
        {
            if (txt_Queryid.Text.Trim().Length != 0)
            {
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                conn.Open();
                string strsql = "SELECT id,proid,product_id,product_name,product_unit FROM product WHERE product_id LIKE '%" + txt_Queryid.Text.Trim() + "%'";
                MySqlDataAdapter msda = new MySqlDataAdapter(strsql, conn);
                msda.Fill(ds_Queryresult, "resultTable");

                dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];
                dgv_Queryresult.DataSource = dv_Queryresult.ToTable("resultTable");
                dgv_Queryresult.Columns[0].HeaderText = "序号";
                dgv_Queryresult.Columns[1].HeaderText = "系统编号";
                dgv_Queryresult.Columns[2].HeaderText = "产品编号";
                dgv_Queryresult.Columns[3].HeaderText = "产品名称";
                dgv_Queryresult.Columns[4].HeaderText = "产品规格";
                conn.Close();
            }
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            ds_Queryresult.Clear();
            ProductQuery();
        }

        private void txt_Queryid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                e.Handled = true;
                ds_Queryresult.Clear();
                ProductQuery();
            }
        }

        private void txt_Productid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9)
            {
                e.Handled = true;
                txt_Productname.Focus();
            }
        }

        private void txt_Productname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                e.Handled = true;
                txt_Productunit.Focus();
            }
        }

        private void txt_Productunit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                e.Handled = true;
                btn_Save.Focus();
            }
        }
    }
}
