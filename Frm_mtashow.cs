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
    public partial class Frm_mtashow : Form
    {
        public Frm_mtashow()
        {
            InitializeComponent();
        }

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        /// <summary>
        /// 材料内码
        /// </summary>
        public string mtaid;
        /// <summary>
        /// 材料编号
        /// </summary>
        public string mtaId;
        /// <summary>
        /// 材料名称
        /// </summary>
        public string mtaName;


        private void Frm_mtashow_Load(object sender, EventArgs e)
        {
            dgv_Queryresult.DataSource = null;
            Queryresult();
            dgv_Queryresult.DataSource = dv_Queryresult.ToTable("resultTable");
            dgv_Queryresult.Columns[0].HeaderText = "序号";
            dgv_Queryresult.Columns[1].HeaderText = "材料编号";
            dgv_Queryresult.Columns[2].HeaderText = "材料名称";
        }

        /// <summary>
        /// 材料信息检索
        /// </summary>
        private void Queryresult()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            string sqlsrt = "SELECT Matid, Material_id, Material_inside_name FROM material";
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlsrt, conn);
            msda.Fill(ds_Queryresult, "resultTable");

            dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];
            dgv_Queryresult.DataSource = dv_Queryresult.ToTable("resultTable");
            dgv_Queryresult.Columns[0].HeaderText = "序号";
            dgv_Queryresult.Columns[1].HeaderText = "材料编号";
            dgv_Queryresult.Columns[2].HeaderText = "材料名称";
            conn.Close();
            conn.Dispose();
            msda.Dispose();
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            doQuery();
        }
        /// <summary>
        /// 执行材料信息查询
        /// </summary>
        private void doQuery()
        {
            if (txt_Querycondition.Text.Trim() != "")
            {
                if (rdb_Queryid.Checked == true)
                {
                    MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                    conn.Open();
                    ds_Queryresult.Clear();
                    string sqlsrt = "SELECT Matid, Material_id, Material_inside_name FROM material";
                    sqlsrt += " WHERE Material_id LIKE '%" + txt_Querycondition.Text.Trim() + "%'";
                    MySqlDataAdapter msda = new MySqlDataAdapter(sqlsrt, conn);
                    msda.Fill(ds_Queryresult, "resultTable");

                    dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];
                    dgv_Queryresult.DataSource = dv_Queryresult.ToTable("resultTable");
                    dgv_Queryresult.Columns[0].HeaderText = "序号";
                    dgv_Queryresult.Columns[1].HeaderText = "材料编号";
                    dgv_Queryresult.Columns[2].HeaderText = "材料名称";
                    conn.Close();
                    conn.Dispose();
                    msda.Dispose();
                }
                else
                {
                    MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                    conn.Open();
                    ds_Queryresult.Clear();
                    string sqlsrt = "SELECT Matid, Material_id, Material_inside_name FROM material";
                    sqlsrt += " WHERE Material_inside_name LIKE '%" + txt_Querycondition.Text.Trim() + "%'";
                    MySqlDataAdapter msda = new MySqlDataAdapter(sqlsrt, conn);
                    msda.Fill(ds_Queryresult, "resultTable");

                    dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];
                    dgv_Queryresult.DataSource = dv_Queryresult.ToTable("resultTable");
                    dgv_Queryresult.Columns[0].HeaderText = "序号";
                    dgv_Queryresult.Columns[1].HeaderText = "材料编号";
                    dgv_Queryresult.Columns[2].HeaderText = "材料名称";
                    conn.Close();
                    conn.Dispose();
                    msda.Dispose();
                }
            }
            else
            {
                ds_Queryresult.Clear();
                Queryresult();
            }
        }

        private void dgv_Queryresult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_Queryresult.RowCount > 0)
                {
                    mtaid = dgv_Queryresult.SelectedCells[0].Value.ToString().Trim();
                    mtaId = dgv_Queryresult.SelectedCells[1].Value.ToString().Trim();
                    mtaName = dgv_Queryresult.SelectedCells[2].Value.ToString().Trim();
                }
            }
            finally
            {
                this.Close();
                this.Dispose();
            }
        }

        private void txt_Querycondition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                doQuery();
            }
        }
    }
}
