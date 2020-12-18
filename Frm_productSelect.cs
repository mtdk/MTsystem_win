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
    public partial class Frm_productSelect : Form
    {
        public Frm_productSelect()
        {
            InitializeComponent();
        }

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        public string prsystemid;
        public string prid;
        public string prname;
        public string prunit;

        private void Frm_productSelect_Load(object sender, EventArgs e)
        {
            Productresult();
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
            //txt_Querycondition.Focus();
        }

        /// <summary>
        /// 产品信息查找
        /// </summary>
        private void ProductQuery()
        {
            if (txt_Querycondition.Text.Trim().Length != 0)
            {
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                conn.Open();
                string strsql = null;
                if (rdb_Queryid.Checked==true)
                {
                    strsql = "SELECT id,proid,product_id,product_name,product_unit FROM product WHERE product_id LIKE '%" + txt_Querycondition.Text.Trim() + "%'";
                }
                else
                {
                    strsql = "SELECT id,proid,product_id,product_name,product_unit FROM product WHERE product_name LIKE '%" + txt_Querycondition.Text.Trim() + "%'";
                }
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
            else
            {
                ds_Queryresult.Clear();
                Productresult();
            }
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            ds_Queryresult.Clear();
            ProductQuery();
        }

        private void txt_Querycondition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                e.Handled = true;
                ds_Queryresult.Clear();
                ProductQuery();
            }
        }

        private void dgv_Queryresult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_Queryresult.RowCount > 0)
                {
                    prsystemid = dgv_Queryresult.SelectedCells[1].Value.ToString().Trim();
                    prid = dgv_Queryresult.SelectedCells[2].Value.ToString().Trim();
                    prname = dgv_Queryresult.SelectedCells[3].Value.ToString().Trim();
                    prunit = dgv_Queryresult.SelectedCells[4].Value.ToString().Trim();
                }
            }
            finally
            {
                this.Close();
                this.Dispose();
            }
        }
    }
}
