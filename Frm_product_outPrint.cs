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
    public partial class Frm_product_outPrint : Form
    {
        public Frm_product_outPrint()
        {
            InitializeComponent();
        }

        public string out_id;

        private void outPrint()
        {
            string sqlstr = "SELECT * FROM mtsystemdb.product_out_view WHERE Outid = '" + out_id.ToString().Trim() + "'";
            ds_productoutReportview ds = new ds_productoutReportview();
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
                MySqlDataReader dr = null;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                ds.Tables["tb_productPrint"].Load(dr);

                if (ds.Tables["tb_productPrint"].Rows.Count < 7)
                {
                    for (int i = 7 - (ds.Tables["tb_productPrint"].Rows.Count); i > 0; i--)
                    {
                        DataRow dtr = ds.Tables["tb_productPrint"].NewRow();
                        ds.Tables["tb_productPrint"].Rows.Add(dtr);
                    }
                }

                ReportDataSource rds = new ReportDataSource();
                product_out_reportViewer.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.product_out_Report.rdlc";
                rds.Name = "ds_productoutReportview";
                rds.Value = ds.Tables["tb_productPrint"];
                product_out_reportViewer.LocalReport.DataSources.Add(rds);

                this.product_out_reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.product_out_reportViewer.ZoomMode = ZoomMode.PageWidth;
                this.product_out_reportViewer.RefreshReport();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_product_outPrint_Load(object sender, EventArgs e)
        {
            product_out_reportViewer.Reset();
            outPrint();
        }
    }
}
