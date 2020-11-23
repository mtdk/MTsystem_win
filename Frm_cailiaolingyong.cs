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

        /// <summary>
        /// 数据库链接
        /// </summary>
        dbconnectstr dbc = new dbconnectstr();

        private void Frm_cailiaolingyong_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmclly == "CLOSE" || frmShowstatus._Frmclly == null)
            {
                //将窗口状态设置为打开
                frmShowstatus._Frmclly = "OPEN";
                newOutid();
                //获取领料时间
                txt_Outdate.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void Frm_cailiaolingyong_FormClosed(object sender, FormClosedEventArgs e)
        {
            //将窗口状态设置为关闭
            frmShowstatus._Frmclly = "CLOSE";
        }
        /// <summary>
        /// 双击材料编号文本框打开材料选择窗口
        /// </summary>
        /// <param name="sender">回传材料编号、名称</param>
        /// <param name="e"></param>
        private void txt_Materia_id_DoubleClick(object sender, EventArgs e)
        {
            Frm_mtashow mtashow = new Frm_mtashow();
            mtashow.ShowDialog();
            if (mtashow.mtaId != null)
            {
                txt_Lysl.Text = "";
                txt_Materia_unit.Text = "";
                txt_Lyzl.Text = "";
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
            if (txt_Outid.Text.Trim() == "")
            {
                MessageBox.Show("领料记录号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_Materia_id.Text.Trim() == "")
            {
                MessageBox.Show("材料编号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_Materia_name.Text.Trim() == "")
            {
                MessageBox.Show("材料名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_Lysl.Text.Trim() == "")
            {
                MessageBox.Show("领用数量不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_Lysl.Focus();
            }
            else if (txt_Materia_unit.Text.Trim() == "")
            {
                MessageBox.Show("材料规格不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_Materia_unit.Focus();
            }
            else if (txt_Lyzl.Text.Trim() == "")
            {
                MessageBox.Show("领用总量不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_Outdate.Text.Trim() == "")
            {
                MessageBox.Show("领用日期不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_Operator.Text.Trim() == "")
            {
                MessageBox.Show("领用人不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_Operator.Focus();
            }
            else
            {
                mat_out();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Materia_id.Text = "";
            txt_Materia_name.Text = "";
            txt_Lysl.Text = "";
            txt_Materia_unit.Text = "";
            txt_Lyzl.Text = "";
            txt_Operator.Text = "";
            txt_Materia_id.Focus();
        }

        /// <summary>
        /// 保存领料记录
        /// </summary>
        private void mat_out()
        {
            if(MessageBox.Show("是否保存领料数据？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = dbc.getCon();
                    string strsql = "INSERT INTO `Material_out` VALUES (NULL, @Outid, @Material_id, @Material_inside_name,";
                    strsql += " @Material_lysl, @Material_unit, @Lyzl, @Out_date, @Out_operator)";

                    cmd.CommandText = strsql;
                    cmd.Parameters.AddWithValue("@Outid", txt_Outid.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_id", txt_Materia_id.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_inside_name", txt_Materia_name.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_lysl", Convert.ToDecimal(txt_Lysl.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Material_unit", Convert.ToDecimal(txt_Materia_unit.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Lyzl", Convert.ToDecimal(txt_Lyzl.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Out_date", Convert.ToDateTime(txt_Outdate.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Out_operator", txt_Operator.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("数据已保存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbc._getClose();
                    cmd.Dispose();
                    newOutid();
                    txt_Materia_id.Text = "";
                    txt_Materia_name.Text = "";
                    txt_Lysl.Text = "";
                    txt_Materia_unit.Text = "";
                    txt_Lyzl.Text = "";
                    txt_Operator.Text = "";
                    txt_Materia_id.Focus();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        /// <summary>
        /// 产生新领料记录号
        /// </summary>
        private void newOutid()
        {
            txt_Outid.Text = DateTime.Now.Year.ToString().Trim();
            txt_Outid.Text += DateTime.Now.Month.ToString().Trim();
            txt_Outid.Text += DateTime.Now.Day.ToString().Trim();
            txt_Outid.Text += DateTime.Now.Hour.ToString().Trim();
            txt_Outid.Text += DateTime.Now.Minute.ToString().Trim();
            txt_Outid.Text += DateTime.Now.Second.ToString().Trim();
            txt_Outid.Text += DateTime.Now.Millisecond.ToString().Trim();
        }
    }
}
