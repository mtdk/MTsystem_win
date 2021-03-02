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
    public partial class Frm_productSelect_A : Form
    {
        public Frm_productSelect_A()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 传递查询值（产品编号）
        /// </summary>
        public string Querycondition = "";
        /// <summary>
        /// 回传的产品系统编码
        /// </summary>
        public string pro_id = "";
        /// <summary>
        /// 回传的产品编号
        /// </summary>
        public string product_id = "";
        /// <summary>
        /// 回传的产品名称
        /// </summary>
        public string product_name = "";
        /// <summary>
        /// 回传的产品规格
        /// </summary>
        public string product_unit = "";

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        /// <summary>
        /// 所有产品信息检索
        /// </summary>
        private void Productresult()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            string strsql = "SELECT proid,product_id,product_name,product_unit FROM product WHERE product_id LIKE '%" + Querycondition.ToString().Trim() + "%'";
            MySqlDataAdapter msda = new MySqlDataAdapter(strsql, conn);
            msda.Fill(ds_Queryresult, "resultTable");

            dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];
            dgv_Queryresult.DataSource = dv_Queryresult.ToTable("resultTable");
            dgv_Queryresult.Columns[0].HeaderText = "系统编号";
            dgv_Queryresult.Columns[1].HeaderText = "产品编号";
            dgv_Queryresult.Columns[2].HeaderText = "产品名称";
            dgv_Queryresult.Columns[3].HeaderText = "产品规格";
            conn.Close();
        }

        private void Frm_productSelect_A_Load(object sender, EventArgs e)
        {
            //this.KeyPreview = true;
            Productresult();
        }

        private void dgv_Queryresult_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (dgv_Queryresult.RowCount > 0)
                {
                    pro_id = dgv_Queryresult.CurrentRow.Cells[0].Value.ToString().Trim();
                    product_id = dgv_Queryresult.CurrentRow.Cells[1].Value.ToString().Trim();
                    product_name = dgv_Queryresult.CurrentRow.Cells[2].Value.ToString().Trim();
                    product_unit = dgv_Queryresult.CurrentRow.Cells[3].Value.ToString().Trim();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
