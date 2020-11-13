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
    public partial class Frm_cailiaolingyong : Form
    {
        public Frm_cailiaolingyong()
        {
            InitializeComponent();
        }

        private void Frm_cailiaolingyong_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmclly=="CLOSE"||frmShowstatus._Frmclly==null)
            {
                frmShowstatus._Frmclly = "OPEN";
            }
        }

        private void Frm_cailiaolingyong_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmclly = "CLOSE";
        }

        private void txt_Materia_id_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txt_Lysl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar)&&!Char.IsPunctuation(e.KeyChar)&&!Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if(Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar!='.'||this.txt_Lysl.Text.Length==0)
                {
                    e.Handled = true;
                }
                if (txt_Lysl.Text.LastIndexOf('.')!=-1)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
