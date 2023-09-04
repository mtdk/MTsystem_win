using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting;
using Microsoft.Reporting.WinForms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MTsystem_win.allClass;
using MTsystem_win.dsControl;

namespace MTsystem_win
{
    public partial class Frm_IndentFormPrint : Form
    {
        public Frm_IndentFormPrint()
        {
            InitializeComponent();
        }


        //MemoryClearClass Mcc = new MemoryClearClass();

        public string OrderID;

        private void IndentFormPrint_Load(object sender, EventArgs e)
        {
            PrintBind();
        }

        private void Frm_IndentFormPrint_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Mcc.FlushMemory();
            this.Close();
            this.Dispose();
            GC.Collect();
        }

        private void rdbReadPrint_CheckedChanged(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            PrintBind();
        }

        private void PrintBind()
        {
            //string Sql = "SELECT tb_OrderFormMain.OrderFormID,tb_OrderFormMain.OrderSupplierID,tb_OrderFormMain.OrderDate,tb_OrderFormMain.OrderSupplierName,";
            //Sql += " tb_OrderFormMain.OrderSupplierPeople,tb_OrderFormMain.OrderSupplierFax,tb_OrderFormMain.RequireArriveDate, ";
            //Sql += " tb_OrderFormMain.SupplierPrompt,tb_OrderFormMain.Consignee,tb_OrderFormMain.OrderConvention,tb_OrderForm.Material_ID,tb_OrderForm.Material_Name, ";
            //Sql += " tb_OrderForm.Material_Units,tb_OrderForm.Material_Number,tb_OrderForm.Material_Price,tb_OrderForm.Material_Sum,";
            //Sql += " tb_OrderForm.Material_Remarks FROM tb_OrderFormMain INNER JOIN tb_OrderForm ON tb_OrderFormMain.OrderFormID =tb_OrderForm.OrderFormID";
            //Sql += " WHERE (tb_OrderFormMain.OrderFormID = '" + OrderID.Trim() + "') AND [Goods_Status]='有效'";
            //SqlCommand Cmd = new SqlCommand(Sql, Sqlstr.GetCon());

            //SqlDataReader read = null;

            //DataSet ds = new DsIndentFormPrint();

            //read = Cmd.ExecuteReader(CommandBehavior.CloseConnection);

            //ds.Tables[0].Load(read);

            //ReportDataSource rds = new ReportDataSource();

            //if (rdbCgPrint.Checked == true)
            //{
            //    reportViewer1.LocalReport.ReportEmbeddedResource = "PurchaseManageSystem.PrintForms.Rp_IndentPurPrint.rdlc";

            //    rds.Name = "IndentPurPrint";

            //    rds.Value = ds.Tables[0];
            //}
            //else
            //{
            //    reportViewer1.LocalReport.ReportEmbeddedResource = "PurchaseManageSystem.PrintForms.Rp_ReadPrint.rdlc";

            //    rds.Name = "dsReadPrint";

            //    rds.Value = ds.Tables[0];
            //}
            ////reportViewer1.LocalReport.DataSources.Clear();

            //reportViewer1.LocalReport.DataSources.Add(rds);

            //this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            //this.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            //this.reportViewer1.ZoomPercent = 100;
            //this.reportViewer1.RefreshReport();
        }
    }
}
