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
    public partial class Frm_customerinfo : Form
    {
        public Frm_customerinfo()
        {
            InitializeComponent();
        }

        private void Frm_customerinfo_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmcustorminfo == "CLOSE" || frmShowstatus._Frmcustorminfo == null)
            {
                frmShowstatus._Frmcustorminfo = "OPEN";
            }
        }

        private void Frm_customerinfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmcustorminfo = "CLOSE";
        }
    }
}
