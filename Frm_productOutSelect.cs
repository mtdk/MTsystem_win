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
    public partial class Frm_productOutSelect : Form
    {
        public Frm_productOutSelect()
        {
            InitializeComponent();
        }

        public string selectCondition;

        public string pro_id;

        public string product_id;

        public string product_name;

        public string product_unit;

        public string product_price;


        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        private void Frm_productOutSelect_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();

            string sqlstr = "SELECT proid,product_id,product_name,product_unit FROM product WHERE product_id LIKE '%" + selectCondition.Trim() + "%'";

            MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
            msda.Fill(ds_Queryresult, "resultTable");

            dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];
            dgv_productOutSelect.DataSource = dv_Queryresult.ToTable("resultTable");
            dgv_productOutSelect.Columns[0].HeaderText = "系统编号";
            dgv_productOutSelect.Columns[1].HeaderText = "产品编号";
            dgv_productOutSelect.Columns[2].HeaderText = "产品名称";
            dgv_productOutSelect.Columns[3].HeaderText = "产品规格";
            conn.Close();
        }

        private void dgv_productOutSelect_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (dgv_productOutSelect.RowCount > 0)
                {
                    pro_id = dgv_productOutSelect.CurrentRow.Cells[0].Value.ToString().Trim();
                    product_id = dgv_productOutSelect.CurrentRow.Cells[1].Value.ToString().Trim();
                    product_name = dgv_productOutSelect.CurrentRow.Cells[2].Value.ToString().Trim();
                    product_unit = dgv_productOutSelect.CurrentRow.Cells[3].Value.ToString().Trim();
                    this.Close();
                }
            }
        }
    }
}
