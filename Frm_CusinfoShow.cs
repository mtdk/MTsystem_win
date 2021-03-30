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
    public partial class Frm_CusinfoShow : Form
    {
        public Frm_CusinfoShow()
        {
            InitializeComponent();
        }

        public string selectCondition = "";

        public string Cus_id = "";

        public string Cus_name = "";

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        /// <summary>
        /// 按条件检索客户信息
        /// </summary>
        private void CusinfoResult()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();

            string sqlstr = "SELECT Cus_id,Cus_name FROM customers WHERE Cus_name LIKE '%" + selectCondition.Trim() + "%'";

            MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
            msda.Fill(ds_Queryresult, "resultTable");

            dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];
            dgv_cusinfoview.DataSource = dv_Queryresult.ToTable("resultTable");
            dgv_cusinfoview.Columns[0].HeaderText = "客户编号";
            dgv_cusinfoview.Columns[1].HeaderText = "客户名称";
            conn.Close();
        }

        private void dgv_cusinfoview_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (dgv_cusinfoview.RowCount > 0)
                {
                    Cus_id = dgv_cusinfoview.CurrentRow.Cells[0].Value.ToString().Trim();
                    Cus_name = dgv_cusinfoview.CurrentRow.Cells[1].Value.ToString().Trim();
                    this.Close();
                }
            }
        }

        private void Frm_CusinfoShow_Load(object sender, EventArgs e)
        {
            CusinfoResult();
        }

    }
}
