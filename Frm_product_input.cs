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
    public partial class Frm_product_input : Form
    {
        public Frm_product_input()
        {
            InitializeComponent();
        }

        private void Frm_product_input_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmproductinput == "CLOSE" || frmShowstatus._Frmproductinput == null)
            {
                frmShowstatus._Frmproductinput = "OPEN";
            }

            if (dataGridView1.RowCount <= 0)
            {
                for (int i = 0; i <= 9; i++)
                {
                    dataGridView1.Rows.Add();
                }
            }
        }

        private void Frm_product_input_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmproductinput = "CLOSE";
        }
    }
}
