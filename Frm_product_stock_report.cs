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
    public partial class Frm_product_stock_report : Form
    {
        public Frm_product_stock_report()
        {
            InitializeComponent();
        }

        private void Frm_product_stock_report_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmproductstockreport == "CLOSE" || frmShowstatus._Frmproductstockreport == null)
            {
                frmShowstatus._Frmproductstockreport = "OPEN";
                Querybind();
            }
        }

        private void Frm_product_stock_report_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmproductstockreport = "CLOSE";
        }

        private void Querybind()
        {
            string sqlstr = "SELECT Product_id, Product_name, Product_num, Product_stock FROM product_stock WHERE Product_num <> 0 OR Product_stock <> 0 ORDER BY Product_id ASC";

            ds_productoutReportview ds = new ds_productoutReportview();
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
                MySqlDataReader dr = null;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                ds.Tables["tb_product_stock"].Load(dr);

                ReportDataSource rds = new ReportDataSource();

                product_stock_reportview.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.product_storck_report.rdlc";

                rds.Name = "ds_productoutReportview";
                rds.Value = ds.Tables["tb_product_stock"];
                product_stock_reportview.LocalReport.DataSources.Add(rds);

                this.product_stock_reportview.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.product_stock_reportview.ZoomMode = ZoomMode.PageWidth;

                product_stock_reportview.ShowParameterPrompts = true;

                this.product_stock_reportview.RefreshReport();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
