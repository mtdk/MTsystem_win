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
    public partial class Frm_mat_giveback : Form
    {
        public Frm_mat_giveback()
        {
            InitializeComponent();
        }

        private void Frm_mat_giveback_Load(object sender, EventArgs e)
        {
            newGbid();
            txt_Outid.Text = sendParameters._Outid.ToString().Trim();
            txt_Materia_id.Text = sendParameters._Matid.ToString().Trim();
            txt_Materia_name.Text = sendParameters._MatinsideName.ToString().Trim();
            txt_Lysl.Text = sendParameters._Matnum.ToString().Trim();
            txt_Materia_unit.Text = sendParameters._Matunit.ToString().Trim();
            txt_Lyzl.Text = sendParameters._MatTotal.ToString().Trim();
            txt_Outdate.Text = sendParameters._Outdate.ToString().Trim();
            txt_Operator.Text = sendParameters._OutOperator.ToString().Trim();
            txt_gbdate.Text = DateTime.Now.ToShortDateString();
        }

        /// <summary>
        /// 产生回退单号
        /// </summary>
        private void newGbid()
        {
            txt_gbid.Text = DateTime.Now.Year.ToString().Trim();
            txt_gbid.Text += DateTime.Now.Month.ToString().Trim();
            txt_gbid.Text += DateTime.Now.Day.ToString().Trim();
            txt_gbid.Text += DateTime.Now.Hour.ToString().Trim();
            txt_gbid.Text += DateTime.Now.Minute.ToString().Trim();
            txt_gbid.Text += DateTime.Now.Second.ToString().Trim();
            //txt_Outid.Text += DateTime.Now.Millisecond.ToString().Trim();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Lysl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.' || this.txt_Lysl.Text.Length == 0)
                {
                    e.Handled = true;
                }
                if (txt_Lysl.Text.LastIndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar == 13 || e.KeyChar == 9)
            {
                e.Handled = true;
                if (txt_Lysl.Text.Trim() != "" && txt_Materia_unit.Text.Trim() != "")
                {
                    txt_Lyzl.Text = Convert.ToString(Convert.ToDecimal(txt_Lysl.Text) * Convert.ToDecimal(txt_Materia_unit.Text.Trim())).Trim();
                }
                else
                {
                    txt_Lyzl.Text = "0";
                }
                txt_Materia_unit.Focus();
            }
        }

        private void txt_Lysl_Leave(object sender, EventArgs e)
        {
            if (txt_Lysl.Text.Trim() != "" && txt_Materia_unit.Text.Trim() != "")
            {
                txt_Lyzl.Text = Convert.ToString(Convert.ToDecimal(txt_Lysl.Text) * Convert.ToDecimal(txt_Materia_unit.Text.Trim())).Trim();
            }
            else
            {
                txt_Lyzl.Text = "0";
            }
        }

        private void txt_Materia_unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.' || this.txt_Materia_unit.Text.Length == 0)
                {
                    e.Handled = true;
                }
                if (txt_Materia_unit.Text.LastIndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar == 13 || e.KeyChar == 9)
            {
                e.Handled = true;
                if (txt_Lysl.Text.Trim() != "" && txt_Materia_unit.Text.Trim() != "")
                {
                    txt_Lyzl.Text = Convert.ToString(Convert.ToDecimal(txt_Lysl.Text) * Convert.ToDecimal(txt_Materia_unit.Text.Trim())).Trim();
                }
                else
                {
                    txt_Lyzl.Text = "0";
                }
            }
        }

        private void txt_Materia_unit_Leave(object sender, EventArgs e)
        {
            if (txt_Lysl.Text.Trim() != "" && txt_Materia_unit.Text.Trim() != "")
            {
                txt_Lyzl.Text = Convert.ToString(Convert.ToDecimal(txt_Lysl.Text) * Convert.ToDecimal(txt_Materia_unit.Text.Trim())).Trim();
            }
            else
            {
                txt_Lyzl.Text = "0";
            }
        }
    }
}
