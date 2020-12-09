using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MTsystem_win
{
    public partial class Frm_tag_print : Form
    {
        public Frm_tag_print()
        {
            InitializeComponent();
        }

        public string productid;

        private void Frm_tag_print_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Print(object sender, Microsoft.Reporting.WinForms.ReportPrintEventArgs e)
        {
            MessageBox.Show("报表已打印", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
