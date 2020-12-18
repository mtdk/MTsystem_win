using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Reporting;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MTsystem_win.allClass;
using MTsystem_win.dsControl;

namespace MTsystem_win
{
    public partial class Frm_tag_print : Form
    {
        public Frm_tag_print()
        {
            InitializeComponent();
        }

        public string printid;

        public string productid;

        public short copies;

        private void Frm_tag_print_Load(object sender, EventArgs e)
        {
            printResult();
        }

        private void printResult()
        {
            string strsql = "SELECT tag_print.proid,tag_print.product_id,tag_print.product_name,tag_print.product_unit,";
            strsql += "tag_print.product_date,tag_print.batch_number,tag_print.product_shelflife,tag_print.print_status";
            strsql += " FROM tag_print WHERE tag_print.id = '" + Convert.ToInt16(printid.Trim()) + "'";

            ds_product ds = new ds_product();
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(strsql, conn);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                ds.Tables["tag_print"].Load(dr);

                ReportDataSource rds = new ReportDataSource();
                if (rdb_printSelectA.Checked==true)
                {
                    tagPrint_reportview.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.product_tagReportview.rdlc";
                }
                else
                {
                    tagPrint_reportview.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.product_tagReportview_a.rdlc";
                }
                rds.Name = "ds_product";
                rds.Value = ds.Tables["tag_print"];

                tagPrint_reportview.LocalReport.DataSources.Add(rds);

                this.tagPrint_reportview.PrinterSettings.Copies = copies;

                this.tagPrint_reportview.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.tagPrint_reportview.ZoomMode = ZoomMode.PageWidth;
                this.tagPrint_reportview.ZoomPercent = 100;
                this.tagPrint_reportview.RefreshReport();                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tagPrint_reportview_PrintingBegin(object sender, ReportPrintEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                string strsql = "UPDATE tag_print SET print_status = @print_status WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = strsql;
                cmd.Parameters.AddWithValue("@print_status", "已打印");
                cmd.Parameters.AddWithValue("@id", Convert.ToInt16(printid.Trim()));
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + "这条信息仍然能被打印，但数据状态无法被更新，请尽快与管理员联系！\n错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transaction.Rollback();
                conn.Close();
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    transaction.Commit();
                    conn.Close();
                }
            }
        }

        private void rdb_printSelectB_CheckedChanged(object sender, EventArgs e)
        {
            printResult();
        }

        private void rdb_printSelectA_CheckedChanged(object sender, EventArgs e)
        {
            printResult();
        }
    }
}
