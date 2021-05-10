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
    public partial class Frm_product_outputReport : Form
    {
        public Frm_product_outputReport()
        {
            InitializeComponent();
        }

        private void Frm_product_outputReport_Load(object sender, EventArgs e)
        {

            this.product_outputallReportview.RefreshReport();
        }
    }
}
