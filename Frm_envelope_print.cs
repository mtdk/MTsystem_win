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
    public partial class Frm_envelope_print : Form
    {
        public Frm_envelope_print()
        {
            InitializeComponent();
        }

        private void Frm_envelope_print_Load(object sender, EventArgs e)
        {

        }

        private void txt_Cusname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (txt_Cusname.Text.Trim().Length != 0)
                {
                    Frm_CusinfoShow frmcfs = new Frm_CusinfoShow();
                    frmcfs.selectCondition = txt_Cusname.Text.Trim();
                    frmcfs.ShowDialog();
                    if (frmcfs.Cus_id != "")
                    {
                        txt_Cusid.Text = frmcfs.Cus_id.Trim();
                        txt_Cusname.Text = frmcfs.Cus_name.Trim();
                        btn_confirm.Focus();
                    }
                }
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (txt_Cusid.Text.Trim().Length != 0)
            {
                envelope_reportViewer.Reset();
                cusinfoQuery();

            }
        }

        /// <summary>
        /// 客户信息查找
        /// </summary>
        private void cusinfoQuery()
        {
            string sqlstr = "SELECT Cus_id,Cus_name,Cus_add,Cus_contact,Cus_mobile,Cus_telephone,Cus_fax FROM customers WHERE Cus_id = '" + txt_Cusid.Text.Trim() + "'";

            ds_cus_info ds = new ds_cus_info();
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
                MySqlDataReader dr = null;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                ds.Tables["tb_cusinfo"].Load(dr);

                ReportDataSource rds = new ReportDataSource();
                envelope_reportViewer.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.envelope_Reportview.rdlc";
                rds.Name = "ds_cus_info";
                rds.Value = ds.Tables["tb_cusinfo"];

                envelope_reportViewer.LocalReport.DataSources.Add(rds);

                this.envelope_reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.envelope_reportViewer.ZoomMode = ZoomMode.PageWidth;
                this.envelope_reportViewer.ZoomPercent = 100;
                this.envelope_reportViewer.RefreshReport();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txt_Cusid.Text = "";
                txt_Cusname.Text = "";
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_Cusid.Text = "";
            txt_Cusname.Text = "";
            envelope_reportViewer.Reset();
        }
    }
}
