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
    public partial class Frm_mat_input_query : Form
    {
        public Frm_mat_input_query()
        {
            InitializeComponent();
        }

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        private void btn_Query_Click(object sender, EventArgs e)
        {
            ds_Queryresult.Clear();
            doQuery();
        }


        /// <summary>
        /// 材料出库查询
        /// </summary>
        private void doQuery()
        {
            string strsql = null;
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            if (txt_Queryid.Text.Trim().Length == 0)
            {//查询编号为空并且选择查询日期范围
                if (cb_Querydate.Checked == true)
                {
                    strsql = "SELECT material_out.Outid,material_out.Material_id,material_out.Material_inside_name,";
                    strsql += "material_out.Material_lysl,material_out.Material_unit,material_out.Lyzl,material_out.Out_date,material_out.Out_operator";
                    strsql += " FROM material_out WHERE material_out.Out_date >= '" + dtp_start.Value.ToShortDateString().Trim() + "'";
                    strsql += " AND material_out.Out_date <= '" + dtp_end.Value.ToShortDateString().Trim() + "'";
                    strsql += " ORDER BY material_out.Out_date ASC";
                }
                else
                {//查询编号为空且没有选择查询日期范围
                    strsql = "SELECT material_out.Outid,material_out.Material_id,material_out.Material_inside_name,";
                    strsql += "material_out.Material_lysl,material_out.Material_unit,material_out.Lyzl,material_out.Out_date,";
                    strsql += "material_out.Out_operator FROM material_out ORDER BY material_out.Out_date ASC";
                }
            }
            else
            {//查询编号不为空且选择查询日期范围
                if (cb_Querydate.Checked == true)
                {
                    strsql = "SELECT material_out.Outid,material_out.Material_id,material_out.Material_inside_name,";
                    strsql += "material_out.Material_lysl,material_out.Material_unit,material_out.Lyzl,material_out.Out_date,material_out.Out_operator";
                    strsql += " FROM material_out WHERE material_out.Out_date >= '" + dtp_start.Value.ToShortDateString().Trim() + "'";
                    strsql += " AND material_out.Out_date <= '" + dtp_end.Value.ToShortDateString().Trim() + "'";
                    strsql += " AND material_out.Material_id = '" + txt_Queryid.Text.Trim() + "' ORDER BY material_out.Out_date ASC";
                }
                else
                {//查询编号不为空且没有选择查询日期范围
                    strsql = "SELECT material_out.Outid,material_out.Material_id,material_out.Material_inside_name,";
                    strsql += "material_out.Material_lysl,material_out.Material_unit,material_out.Lyzl,material_out.Out_date,material_out.Out_operator";
                    strsql += " FROM material_out WHERE material_out.Material_id = '" + txt_Queryid.Text.Trim() + "'";
                    strsql += " ORDER BY material_out.Out_date ASC";
                }
            }

            MySqlDataAdapter msda = new MySqlDataAdapter(strsql, conn);
            msda.Fill(ds_Queryresult, "resultTable");

            dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];
            dgv_Queryresult.DataSource = dv_Queryresult.ToTable("resultTable");

            dgv_Queryresult.Columns[0].HeaderText = "出仓单号";
            dgv_Queryresult.Columns[1].HeaderText = "材料编号";
            dgv_Queryresult.Columns[2].HeaderText = "材料名称";
            dgv_Queryresult.Columns[3].HeaderText = "领用数量";
            dgv_Queryresult.Columns[4].HeaderText = "领用规格";
            dgv_Queryresult.Columns[5].HeaderText = "领用总量";
            dgv_Queryresult.Columns[6].HeaderText = "出库时间";
            dgv_Queryresult.Columns[7].HeaderText = "操作员";

            conn.Close();
        }
    }
}
