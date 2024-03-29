﻿using System;
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
    public partial class Frm_mat_stockReportview : Form
    {
        public Frm_mat_stockReportview()
        {
            InitializeComponent();
        }

        private void Frm_mat_stockReportview_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmsrv == "CLOSE" || frmShowstatus._Frmsrv == null)
            {
                frmShowstatus._Frmsrv = "OPEN";
                PrintBing();
            }
        }

        private void PrintBing()
        {
            string strsql = "SELECT material_stock.Material_id,";
            strsql += "material_stock.Material_inside_name,";
            strsql += "material_stock.Material_stock,";
            strsql += "material.Material_class";
            strsql += " FROM material_stock, material";
            strsql += " WHERE material_stock.Material_stock <> 0 AND material_stock.Matid = material.Matid";
            strsql+=" ORDER BY material.Material_class ASC,material_stock.Material_inside_name ASC ";
            
            ds_mat_stockReport ds = new ds_mat_stockReport();
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(strsql, conn);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                ds.Tables["tb_mat_stockReport"].Load(dr);

                ReportDataSource rds = new ReportDataSource();
                mat_stockReportview.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.mat_stockReportview.rdlc";
                rds.Name = "ds_mat_stockReport";
                rds.Value = ds.Tables["tb_mat_stockReport"];

                mat_stockReportview.LocalReport.DataSources.Add(rds);

                this.mat_stockReportview.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.mat_stockReportview.ZoomMode = ZoomMode.PageWidth;
                this.mat_stockReportview.ZoomPercent = 100;
                this.mat_stockReportview.RefreshReport();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_mat_stockReportview_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmsrv = "CLOSE";
        }
    }
}
