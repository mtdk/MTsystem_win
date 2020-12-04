using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting;
using Microsoft.Reporting.WinForms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MTsystem_win.allClass;
using MTsystem_win.dsControl;

namespace MTsystem_win
{
    public partial class Frm_mat_dayReportview : Form
    {
        public Frm_mat_dayReportview()
        {
            InitializeComponent();
        }

        private void Frm_mat_dayReportview_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frdmsrv == "CLOSE" || frmShowstatus._Frdmsrv == null)
            {
                frmShowstatus._Frdmsrv = "OPEN";
                dtp_Querydate.Value = DateTime.Now;
            }
        }

        private void Frm_mat_dayReportview_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frdmsrv = "CLOSE";
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            if (rdb_matInput_report.Checked == true)
            {
                matInputReport();
            }
            else
            {
                matOutputReport();
            }
        }

        /// <summary>
        /// 材料进仓日报表
        /// </summary>
        private void matInputReport()
        {
            string strsql="SELECT material_input.Material_id,";
            strsql+="material_input.Material_inside_name,material_input.Material_jlsl,";
            strsql+="material_input.Material_unit,material_input.Jlzl,material_input.Input_date,";
            strsql+="material.Material_class FROM material_input,material";
            strsql+=" WHERE material_input.Matid = material.Matid";
            strsql += " AND material_input.Input_date = '" + dtp_Querydate.Value.ToShortDateString().Trim() + "'";
            strsql += " ORDER BY material.Material_class ASC";

            ds_mat_dinputReport ds = new ds_mat_dinputReport();
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(strsql, conn);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                ds.Tables["tb_mat_inputReport"].Load(dr);

                ReportDataSource rds = new ReportDataSource();
                mat_stockDayreportview.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.mat_DayReportview.rdlc";
                rds.Name = "ds_mat_dinputReport";
                rds.Value = "tb_mat_inputReport";

                mat_stockDayreportview.LocalReport.DataSources.Add(rds);
                mat_stockDayreportview.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                mat_stockDayreportview.ZoomMode = ZoomMode.PageWidth;
                mat_stockDayreportview.RefreshReport();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// 材料出仓日报表
        /// </summary>
        private void matOutputReport()
        {
        }
    }
}
