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
    public partial class Frm_product_outputReport : Form
    {
        public Frm_product_outputReport()
        {
            InitializeComponent();
        }

        //public string out_id;

        private void outPrint()
        {
            string sqlstr = "";
            if (txt_cusName.Text.Trim().Length != 0)
            {
                sqlstr = "SELECT * FROM mtsystemdb.product_outReport_view WHERE Cus_name = '" + txt_cusName.Text.Trim() + "'";
                sqlstr += " AND Out_date >= '" + dtp_start.Value.ToShortDateString().Trim() + "'";
                sqlstr += " AND Out_date <= '" + dtp_end.Value.ToShortDateString().Trim() + "'";
            }
            else
            {
                sqlstr = "SELECT * FROM mtsystemdb.product_outReport_view WHERE Out_date >= '" + dtp_start.Value.ToShortDateString().Trim() + "'";
                sqlstr += " AND Out_date <= '" + dtp_end.Value.ToShortDateString().Trim() + "'";
            }
            ds_productoutReportview ds = new ds_productoutReportview();
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
                MySqlDataReader dr = null;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                ds.Tables["tb_productAllReport"].Load(dr);

                ReportDataSource rds = new ReportDataSource();

                if (rdb_all.Checked == true)
                {
                    product_outputallReportview.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.product_out_OutReport.rdlc";
                }
                else
                {
                    product_outputallReportview.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.product_out_OutReport_a.rdlc";
                }

                rds.Name = "ds_productoutReportview";
                rds.Value = ds.Tables["tb_productAllReport"];
                product_outputallReportview.LocalReport.DataSources.Add(rds);

                this.product_outputallReportview.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.product_outputallReportview.ZoomMode = ZoomMode.PageWidth;

                product_outputallReportview.ShowParameterPrompts = true;
                ReportParameter stp = new ReportParameter("StartTime", dtp_start.Value.ToShortDateString());
                ReportParameter ndt = new ReportParameter("EndTime", dtp_end.Value.ToShortDateString());
                this.product_outputallReportview.LocalReport.SetParameters(new ReportParameter[] { stp });
                this.product_outputallReportview.LocalReport.SetParameters(new ReportParameter[] { ndt });

                this.product_outputallReportview.RefreshReport();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Frm_product_outputReport_Load(object sender, EventArgs e)
        {

            //this.product_outputallReportview.Reset();
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            if (rdb_Account_Statement.Checked == true)
            {
                if (txt_cusName.Text.Trim().Length != 0)
                {
                    this.product_outputallReportview.Reset();
                    outPrint();
                }
                else
                {
                    MessageBox.Show("请输入客户名称后在查询！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_cusName.Focus();
                }
            }
            else
            {
                this.product_outputallReportview.Reset();
                outPrint();
            }
        }

        private void txt_cusName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (txt_cusName.Text.Trim().Length != 0)
                {
                    Frm_CusinfoShow frmcusinfoshow = new Frm_CusinfoShow();
                    frmcusinfoshow.selectCondition = txt_cusName.Text.Trim();
                    frmcusinfoshow.ShowDialog();
                    if (frmcusinfoshow.Cus_id != "")
                    {
                        txt_cusName.Text = frmcusinfoshow.Cus_id.Trim();
                        txt_cusName.Text = frmcusinfoshow.Cus_name.Trim();
                        txt_cusName.Focus();
                    }
                }
            }
        }
    }
}
