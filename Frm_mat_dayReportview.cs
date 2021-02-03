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
                mat_dayReportview.Reset();
                matInputReport();
            }
            else
            {
                mat_dayReportview.Reset();
                matOutputReport();
            }
        }

        /// <summary>
        /// 材料进仓日报表
        /// </summary>
        private void matInputReport()
        {
            string strsql;
            if (txt_Queryid.Text.Trim().Length != 0)
            {
                strsql = "SELECT material_input.Material_id,";
                strsql += "material_input.Material_inside_name,material_input.Material_jlsl,";
                strsql += "material_input.Material_unit,material_input.Jlzl,material_input.Input_date,";
                strsql += "material.Material_class FROM material_input,material";
                strsql += " WHERE material_input.Material_id = '" + txt_Queryid.Text.Trim() + "'";
                strsql += " AND material_input.Input_date >= '" + dtp_Querydate.Value.ToShortDateString().Trim() + "'";
                strsql += " AND material_input.Input_date <= '" + dtp_QuerydateEnd.Value.ToShortDateString().Trim() + "'";
                strsql += " AND material_input.Matid = material.Matid";
                strsql += " ORDER BY material_input.Input_date ASC";
                #region
                ds_mat_stockReport ds = new ds_mat_stockReport();
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(strsql, conn);
                    MySqlDataReader dr = null;
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    ds.Tables["tb_mat_inputReport"].Load(dr);

                    ReportDataSource rds = new ReportDataSource();
                    mat_dayReportview.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.mat_dayinReportview.rdlc";
                    rds.Name = "ds_mat_stockReport";
                    rds.Value = ds.Tables["tb_mat_inputReport"];

                    mat_dayReportview.LocalReport.DataSources.Add(rds);

                    this.mat_dayReportview.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                    this.mat_dayReportview.ZoomMode = ZoomMode.PageWidth;
                    this.mat_dayReportview.ZoomPercent = 100;
                    this.mat_dayReportview.RefreshReport();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                #endregion
            }
            else
            {
                strsql = "SELECT material_input.Material_id,";
                strsql += "material_input.Material_inside_name,material_input.Material_jlsl,";
                strsql += "material_input.Material_unit,material_input.Jlzl,material_input.Input_date,";
                strsql += "material.Material_class FROM material_input,material";
                strsql += " WHERE material_input.Input_date >= '" + dtp_Querydate.Value.ToShortDateString().Trim() + "'";
                strsql += " AND material_input.Input_date <= '" + dtp_QuerydateEnd.Value.ToShortDateString().Trim() + "'";
                strsql += " AND material_input.Matid = material.Matid";
                strsql += " ORDER BY material.Material_class ASC, material_input.Input_date ASC";
                #region
                ds_mat_stockReport ds = new ds_mat_stockReport();
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(strsql, conn);
                    MySqlDataReader dr = null;
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    ds.Tables["tb_mat_inputReport"].Load(dr);

                    ReportDataSource rds = new ReportDataSource();
                    mat_dayReportview.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.mat_dayinReportview.rdlc";
                    rds.Name = "ds_mat_stockReport";
                    rds.Value = ds.Tables["tb_mat_inputReport"];

                    mat_dayReportview.LocalReport.DataSources.Add(rds);

                    this.mat_dayReportview.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                    this.mat_dayReportview.ZoomMode = ZoomMode.PageWidth;
                    this.mat_dayReportview.ZoomPercent = 100;
                    this.mat_dayReportview.RefreshReport();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
        }
        
              

        /// <summary>
        /// 材料出仓日报表
        /// </summary>
        private void matOutputReport()
        {
            string strsql;
            if (txt_Queryid.Text.Trim().Length != 0)
            {
                strsql = "SELECT material_out.Material_id,material_out.Material_inside_name,";
                strsql += "material_out.Material_lysl,material_out.Material_unit,material_out.Lyzl,";
                strsql += "material_out.Out_date,material.Material_class FROM material_out,material";
                strsql += " WHERE material_out.Material_id = '" + txt_Queryid.Text.Trim() + "'";
                strsql += " AND material_out.Out_date >= '" + dtp_Querydate.Value.ToShortDateString().Trim() + "'";
                strsql += " AND material_out.Out_date <= '" + dtp_QuerydateEnd.Value.ToShortDateString().Trim() + "'";
                strsql += " AND material_out.Matid = material.Matid";
                strsql += " ORDER BY material_out.Out_date ASC";
                #region
                ds_mat_stockReport ds = new ds_mat_stockReport();
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(strsql, conn);
                    MySqlDataReader dr = null;
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    ds.Tables["tb_mat_outputReport"].Load(dr);

                    ReportDataSource rds = new ReportDataSource();
                    mat_dayReportview.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.mat_dayoutReportview.rdlc";
                    rds.Name = "ds_mat_stockReport";
                    rds.Value = ds.Tables["tb_mat_outputReport"];

                    mat_dayReportview.LocalReport.DataSources.Add(rds);

                    this.mat_dayReportview.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                    this.mat_dayReportview.ZoomMode = ZoomMode.PageWidth;
                    this.mat_dayReportview.ZoomPercent = 100;
                    this.mat_dayReportview.RefreshReport();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
            else
            {
                strsql = "SELECT material_out.Material_id,material_out.Material_inside_name,";
                strsql += "material_out.Material_lysl,material_out.Material_unit,material_out.Lyzl,";
                strsql += "material_out.Out_date,material.Material_class FROM material_out,material";
                strsql += " WHERE material_out.Out_date >= '" + dtp_Querydate.Value.ToShortDateString().Trim() + "'";
                strsql += " AND material_out.Out_date <= '" + dtp_QuerydateEnd.Value.ToShortDateString().Trim() + "'";
                strsql += " AND material_out.Matid = material.Matid";
                strsql += " ORDER BY material.Material_class ASC, material_out.Out_date ASC";
                #region
                ds_mat_stockReport ds = new ds_mat_stockReport();
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(strsql, conn);
                    MySqlDataReader dr = null;
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    ds.Tables["tb_mat_outputReport"].Load(dr);

                    ReportDataSource rds = new ReportDataSource();
                    mat_dayReportview.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.mat_dayoutReportview.rdlc";
                    rds.Name = "ds_mat_stockReport";
                    rds.Value = ds.Tables["tb_mat_outputReport"];

                    mat_dayReportview.LocalReport.DataSources.Add(rds);

                    this.mat_dayReportview.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                    this.mat_dayReportview.ZoomMode = ZoomMode.PageWidth;
                    this.mat_dayReportview.ZoomPercent = 100;
                    this.mat_dayReportview.RefreshReport();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
        }
    }
}
