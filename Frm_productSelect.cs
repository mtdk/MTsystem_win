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

        public string selectCondition;
        public string prsystemid;
        public string prid;
        public string prname;
        public string prunit;

        private void Frm_productSelect_Load(object sender, EventArgs e)
        {
            ProductQuery();
        }

        /// <summary>
        /// 产品信息查找
        /// </summary>
        private void ProductQuery()
        {

            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            string strsql = "SELECT id,proid,product_id,product_name,product_unit FROM product WHERE product_id LIKE '%" + selectCondition.Trim() + "%'";

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
            conn.Dispose();
            msda.Dispose();

        }

        private void dgv_Queryresult_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (dgv_Queryresult.RowCount > 0)
                {
                    prsystemid = dgv_Queryresult.CurrentRow.Cells[1].Value.ToString().Trim();
                    prid = dgv_Queryresult.CurrentRow.Cells[2].Value.ToString().Trim();
                    prname = dgv_Queryresult.CurrentRow.Cells[3].Value.ToString().Trim();
                    prunit = dgv_Queryresult.CurrentRow.Cells[4].Value.ToString().Trim();
                    this.Close();
                }
            }
        }
    }
}
