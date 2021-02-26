using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MTsystem_win.allClass;

namespace MTsystem_win
{
    public partial class Frm_product_output : Form
    {
        public Frm_product_output()
        {
            InitializeComponent();
        }

        private void Frm_product_output_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmproductoutput == "CLOSE" || frmShowstatus._Frmproductoutput == null)
            {
                frmShowstatus._Frmproductoutput = "OPEN";
            }
        }

        private void Frm_product_output_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmproductoutput = "CLOSE";
        }
    }
}
