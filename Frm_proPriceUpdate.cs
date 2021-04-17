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
    public partial class Frm_proPriceUpdate : Form
    {
        public Frm_proPriceUpdate()
        {
            InitializeComponent();
        }

        private void Frm_proPriceUpdate_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmpropriceupdate == "CLOSE" || frmShowstatus._Frmpropriceupdate == null)
            {
                frmShowstatus._Frmpropriceupdate = "OPEN";
            }
        }

        private void Frm_proPriceUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmpropriceupdate = "CLOSE";
        }
    }
}
