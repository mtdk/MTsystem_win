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
    public partial class Frm_Supplier_info : Form
    {
        public Frm_Supplier_info()
        {
            InitializeComponent();
        }

        private void Frm_Supplier_info_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Fsupinfo == "CLOSE" || frmShowstatus._Fsupinfo == null)
            {
                frmShowstatus._Fsupinfo = "OPEN";
            }
        }

        private void Frm_Supplier_info_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Fsupinfo = "CLOSE";
        }
    }
}
