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
    public partial class Frm_chejian : Form
    {
        public Frm_chejian()
        {
            InitializeComponent();
        }

        userInfocheck usinfo = new userInfocheck();

        private void Frm_chejian_Load(object sender, EventArgs e)
        {
        }
    }
}
