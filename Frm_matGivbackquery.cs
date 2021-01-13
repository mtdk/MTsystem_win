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
    public partial class Frm_matGivbackquery : Form
    {
        public Frm_matGivbackquery()
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
                    strsql = "SELECT material_giveback.gbid,material_giveback.Inputid,material_giveback.Matid,";
                    strsql += "material_giveback.Material_id,material_giveback.Material_inside_name,material_giveback.Material_gbnum,";
                    strsql += "material_giveback.Material_unit,material_giveback.Material_gbTotal,material_giveback.Outdate,";
                    strsql += "material_giveback.back_date,material_giveback.back_operator,material_giveback.gbReason,material_giveback.back_status";
                    strsql += " FROM material_giveback WHERE material_giveback.back_date >= '" + dtp_start.Value.ToShortDateString().Trim() + "'";
                    strsql += " AND material_giveback.back_date <= '" + dtp_end.Value.ToShortDateString().Trim() + "'";
                    strsql += " ORDER BY material_giveback.back_date ASC";
                }
                else
                {//查询编号为空且没有选择查询日期范围
                    strsql = "SELECT material_giveback.gbid,material_giveback.Inputid,material_giveback.Matid,";
                    strsql += "material_giveback.Material_id,material_giveback.Material_inside_name,material_giveback.Material_gbnum,";
                    strsql += "material_giveback.Material_unit,material_giveback.Material_gbTotal,material_giveback.Outdate,";
                    strsql += "material_giveback.back_date,material_giveback.back_operator,material_giveback.gbReason,material_giveback.back_status";
                    strsql += " FROM material_giveback ORDER BY material_giveback.back_date ASC";
                }
            }
            else
            {//查询编号不为空且选择查询日期范围
                if (cb_Querydate.Checked == true)
                {
                    strsql = "SELECT material_giveback.gbid,material_giveback.Inputid,material_giveback.Matid,";
                    strsql += "material_giveback.Material_id,material_giveback.Material_inside_name,material_giveback.Material_gbnum,";
                    strsql += "material_giveback.Material_unit,material_giveback.Material_gbTotal,material_giveback.Outdate,";
                    strsql += "material_giveback.back_date,material_giveback.back_operator,material_giveback.gbReason,material_giveback.back_status";
                    strsql += " FROM material_giveback WHERE material_giveback.back_date >= '" + dtp_start.Value.ToShortDateString().Trim() + "'";
                    strsql += " AND material_giveback.back_date <= '" + dtp_end.Value.ToShortDateString().Trim() + "'";
                    strsql += " AND material_giveback.Material_id = '" + txt_Queryid.Text.Trim() + "'";
                    strsql += " ORDER BY material_giveback.back_date ASC";
                }
                else
                {//查询编号不为空且没有选择查询日期范围
                    strsql = "SELECT material_giveback.gbid,material_giveback.Inputid,material_giveback.Matid,";
                    strsql += "material_giveback.Material_id,material_giveback.Material_inside_name,material_giveback.Material_gbnum,";
                    strsql += "material_giveback.Material_unit,material_giveback.Material_gbTotal,material_giveback.Outdate,";
                    strsql += "material_giveback.back_date,material_giveback.back_operator,material_giveback.gbReason,material_giveback.back_status";
                    strsql += " FROM material_giveback WHERE material_giveback.Material_id = '" + txt_Queryid.Text.Trim() + "'";
                    strsql+=" ORDER BY material_giveback.back_date ASC";
                }
            }

            MySqlDataAdapter msda = new MySqlDataAdapter(strsql, conn);
            msda.Fill(ds_Queryresult, "resultTable");

            dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];
            dgv_Queryresult.DataSource = dv_Queryresult.ToTable("resultTable");

            dgv_Queryresult.Columns[0].HeaderText = "退回记录号";
            dgv_Queryresult.Columns[1].HeaderText = "进仓记录号";
            dgv_Queryresult.Columns[2].HeaderText = "材料内码";
            dgv_Queryresult.Columns[3].HeaderText = "材料编码";
            dgv_Queryresult.Columns[4].HeaderText = "材料名称";
            dgv_Queryresult.Columns[5].HeaderText = "数量";
            dgv_Queryresult.Columns[6].HeaderText = "规格";
            dgv_Queryresult.Columns[7].HeaderText = "总量";
            dgv_Queryresult.Columns[8].HeaderText = "出仓时间";
            dgv_Queryresult.Columns[9].HeaderText = "回退时间";
            dgv_Queryresult.Columns[10].HeaderText = "操作人";
            dgv_Queryresult.Columns[11].HeaderText = "回退原因";
            dgv_Queryresult.Columns[12].HeaderText = "状态";

            conn.Close();
        }

        private void Frm_matGivbackquery_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._FrmmatgiveBackQuery == "CLOSE" || frmShowstatus._FrmmatgiveBackQuery == null)
            {
                frmShowstatus._FrmmatgiveBackQuery = "OPEN";
            }
        }

        private void Frm_matGivbackquery_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._FrmmatgiveBackQuery = "CLOSE";
        }

        private void txt_Queryid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                ds_Queryresult.Clear();
                doQuery();
            }
        }
    }
}
