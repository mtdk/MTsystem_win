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
                newInputid();
                txt_inputDate.Text = txt_Inputid.Text.Substring(0, 8).Trim();
            }
        }

        private void Frm_product_input_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmproductinput = "CLOSE";
        }

        /// <summary>
        /// 产生进仓单号
        /// </summary>
        private void newInputid()
        {
            txt_Inputid.Text = DateTime.Now.Year.ToString().Trim();
            txt_Inputid.Text += DateTime.Now.Month.ToString().PadLeft(2,'0').Trim();
            txt_Inputid.Text += DateTime.Now.Day.ToString().PadLeft(2,'0').Trim();
            txt_Inputid.Text += DateTime.Now.Hour.ToString().PadLeft(2,'0').Trim();
            txt_Inputid.Text += DateTime.Now.Minute.ToString().PadLeft(2,'0').Trim();
            txt_Inputid.Text += DateTime.Now.Second.ToString().PadLeft(2,'0').Trim();
        }
    }
}
