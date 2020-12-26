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
            txt_matid.Text = sendParameters._Matid.ToString().Trim();
            txt_Materia_id.Text = sendParameters._Mat_id.ToString().Trim();
            txt_Materia_name.Text = sendParameters._MatinsideName.ToString().Trim();
            txt_Lysl.Text = sendParameters._Matnum.ToString().Trim();
            txt_Materia_unit.Text = sendParameters._Matunit.ToString().Trim();
            txt_Lyzl.Text = sendParameters._MatTotal.ToString().Trim();
            txt_Outdate.Text = string.Format("{0:d}", Convert.ToDateTime(sendParameters._Outdate.ToString().Trim()));
            txt_Operator.Text = sendParameters._OutOperator.ToString().Trim();
            txt_gbdate.Text = DateTime.Now.ToShortDateString();
            //txt_backReason.Focus();
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_gbid.Text.Trim().Length==0)
            {
                MessageBox.Show("回退记录号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_matid.Text.Trim().Length==0)
            {
                MessageBox.Show("材料系统编号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Materia_id.Text.Trim().Length==0)
            {
                MessageBox.Show("材料编号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Materia_id.Focus();
            }
            else if (txt_Materia_name.Text.Trim().Length==0)
            {
                MessageBox.Show("材料名称不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Materia_id.Focus();
            }
            else if (txt_Lysl.Text.Trim().Length==0)
            {
                MessageBox.Show("回退数量不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Lysl.Focus();
            }
            else if (txt_Materia_unit.Text.Trim().Length == 0)
            {
                MessageBox.Show("材料规格不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Materia_unit.Focus();
            }
            else if (txt_Lyzl.Text.Trim().Length==0)
            {
                MessageBox.Show("回退总量不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Outdate.Text.Trim().Length==0)
            {
                MessageBox.Show("领用时间不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Operator.Text.Trim().Length==0)
            {
                MessageBox.Show("操作人信息不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_gbdate.Text.Trim().Length==0)
            {
                MessageBox.Show("回退时间不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_backReason.Text.Trim().Length==0)
            {
                MessageBox.Show("回退原因不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_backReason.Focus();
            }
            else
            {
                if (Sameid(txt_Outid.Text.Trim())==false)
                {
                    mat_gbinsert();
                }
                else
                {
                    MessageBox.Show("记录已提交回退，不能再次提交！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool Sameid(string findid)
        {
            bool b = false;
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR.Trim());
            conn.Open();
            string sqlstr = "SELECT * FROM material_giveback WHERE Inputid = @Inputid";
            MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
            cmd.Parameters.AddWithValue("@Inputid", findid.Trim());

            MySqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            b = rd.Read();

            return b;
        }
        /// <summary>
        /// 提交退回数据和备份数据
        /// </summary>
        private void mat_gbinsert()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR.Trim());
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                string strsqlA = "INSERT INTO `material_giveback` VALUES (NULL,@gbid,@Inputid,@Matid,@Material_id,";
                strsqlA += "@Material_inside_name,@Material_gbnum,@Material_unit,@Material_gbTotal,@Outdate,";
                strsqlA += "@back_date,@back_operator,@gbReason,@back_status)";

                cmd.CommandText = strsqlA;
                cmd.Parameters.AddWithValue("@gbid", txt_gbid.Text.Trim());
                cmd.Parameters.AddWithValue("@Inputid", txt_Outid.Text.Trim());
                cmd.Parameters.AddWithValue("@Matid", txt_matid.Text.Trim());
                cmd.Parameters.AddWithValue("@Material_id", txt_Materia_id.Text.Trim());
                cmd.Parameters.AddWithValue("@Material_inside_name", txt_Materia_name.Text.Trim());
                cmd.Parameters.AddWithValue("@Material_gbnum", txt_Lysl.Text.Trim());
                cmd.Parameters.AddWithValue("@Material_unit", txt_Materia_unit.Text.Trim());
                cmd.Parameters.AddWithValue("@Material_gbTotal", txt_Lyzl.Text.Trim());
                cmd.Parameters.AddWithValue("@Outdate", txt_Outdate.Text.Trim());
                cmd.Parameters.AddWithValue("@back_date", txt_gbdate.Text.Trim());
                cmd.Parameters.AddWithValue("@gbReason", txt_backReason.Text.Trim());
                cmd.Parameters.AddWithValue("@back_operator", txt_Operator.Text.Trim());
                cmd.Parameters.AddWithValue("@back_status", "待确认");

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transaction.Rollback();
                conn.Close();
            }
            finally
            {
                if (conn.State==ConnectionState.Open)
                {
                    transaction.Commit();
                    conn.Close();
                    MessageBox.Show("数据已提交！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void rdb_ReasoneA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_ReasoneA.Checked == true)
            {
                txt_backReason.Text = rdb_ReasoneA.Text.Trim();
                txt_backReason.ReadOnly = true;
            }
            else if (rdb_ReasoneB.Checked == true)
            {
                txt_backReason.Text = rdb_ReasoneB.Text.Trim();
                txt_backReason.ReadOnly = true;
            }
            else if (rdb_ReasoneC.Checked == true)
            {
                txt_backReason.Text = rdb_ReasoneC.Text.Trim();
                txt_backReason.ReadOnly = true;
            }
            else
            {
                txt_backReason.Text = string.Empty;
                txt_backReason.ReadOnly = false;
                txt_backReason.Focus();
            }
        }

        private void rdb_ReasoneB_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_ReasoneA.Checked == true)
            {
                txt_backReason.Text = rdb_ReasoneA.Text.Trim();
                txt_backReason.ReadOnly = true;
            }
            else if (rdb_ReasoneB.Checked == true)
            {
                txt_backReason.Text = rdb_ReasoneB.Text.Trim();
                txt_backReason.ReadOnly = true;
            }
            else if (rdb_ReasoneC.Checked == true)
            {
                txt_backReason.Text = rdb_ReasoneC.Text.Trim();
                txt_backReason.ReadOnly = true;
            }
            else
            {
                txt_backReason.Text = string.Empty;
                txt_backReason.ReadOnly = false;
                txt_backReason.Focus();
            }
        }

        private void rdb_ReasoneC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_ReasoneA.Checked == true)
            {
                txt_backReason.Text = rdb_ReasoneA.Text.Trim();
                txt_backReason.ReadOnly = true;
            }
            else if (rdb_ReasoneB.Checked == true)
            {
                txt_backReason.Text = rdb_ReasoneB.Text.Trim();
                txt_backReason.ReadOnly = true;
            }
            else if (rdb_ReasoneC.Checked == true)
            {
                txt_backReason.Text = rdb_ReasoneC.Text.Trim();
                txt_backReason.ReadOnly = true;
            }
            else
            {
                txt_backReason.Text = string.Empty;
                txt_backReason.ReadOnly = false;
                txt_backReason.Focus();
            }
        }

        private void rdb_ReasoneD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_ReasoneA.Checked == true)
            {
                txt_backReason.Text = rdb_ReasoneA.Text.Trim();
                txt_backReason.ReadOnly = true;
            }
            else if (rdb_ReasoneB.Checked == true)
            {
                txt_backReason.Text = rdb_ReasoneB.Text.Trim();
                txt_backReason.ReadOnly = true;
            }
            else if (rdb_ReasoneC.Checked == true)
            {
                txt_backReason.Text = rdb_ReasoneC.Text.Trim();
                txt_backReason.ReadOnly = true;
            }
            else
            {
                txt_backReason.Text = string.Empty;
                txt_backReason.ReadOnly = false;
                txt_backReason.Focus();
            }
        }

        private void txt_backReason_TextChanged(object sender, EventArgs e)
        {
            if (txt_backReason.Text.Trim().Length==10)
            {
                MessageBox.Show("退回原因最多只能输入10个字！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
   
    }
}
