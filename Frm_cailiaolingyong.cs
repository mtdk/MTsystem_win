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
            Frm_mtashow mtashow = new Frm_mtashow();
            mtashow.ShowDialog();
            if (mtashow.mtaId != null)
            {
                txt_Materia_id.Text = mtashow.mtaId.ToString().Trim();
                txt_Materia_name.Text = mtashow.mtaName.ToString().Trim();
                txt_Lysl.Focus();
            }
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
                btn_Save.Focus();
            }
        }

        private void txt_Materia_unit_Leave(object sender, EventArgs e)
        {
            if (txt_Lysl.Text.Trim()!="" && txt_Materia_unit.Text.Trim() != "")
            {
                txt_Lyzl.Text = Convert.ToString(Convert.ToDecimal(txt_Lysl.Text) * Convert.ToDecimal(txt_Materia_unit.Text.Trim())).Trim();
            }
            else
            {
                txt_Lyzl.Text = "0";
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否保存领料数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MessageBox.Show("数据已保存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Materia_id.Text = "";
                txt_Materia_name.Text = "";
                txt_Lysl.Text = "";
                txt_Materia_unit.Text = "";
                txt_Lyzl.Text = "";
                txt_Materia_id.Focus();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Materia_id.Text = "";
            txt_Materia_name.Text = "";
            txt_Lysl.Text = "";
            txt_Materia_unit.Text = "";
            txt_Lyzl.Text = "";
            txt_Materia_id.Focus();
        }
    }
}
