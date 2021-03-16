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
    public partial class Frm_mat_confirm : Form
    {
        public Frm_mat_confirm()
        {
            InitializeComponent();
        }

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        string disagreeReason = string.Empty;

        private void Frm_mat_confirm_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmmatconfirm == "CLOSE" || frmShowstatus._Frmmatconfirm == null)
            {
                frmShowstatus._Frmmatconfirm = "OPEN";
                txt_Savedate.Text = DateTime.Now.ToShortDateString().Trim();
                mat_gbQuery();
                rdb_agree.Enabled = false;
                rdb_disagree.Enabled = false;
            }
        }

        private void Frm_mat_confirm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmmatconfirm = "CLOSE";
        }

        private void mat_gbQuery()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();

            string sqlstr = "SELECT id,gbid,Inputid,Matid,Material_id,Material_inside_name,Material_gbnum,";
            sqlstr += "Material_unit,Material_gbTotal,Outdate,back_date,back_operator,gbReason,back_status FROM material_giveback";
            sqlstr += " WHERE back_status = '待确认'";

            MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
            msda.Fill(ds_Queryresult, "resultTable");

            dv_Queryresult.Table = ds_Queryresult.Tables["resultTable"];
            dgv_Query_result.DataSource = dv_Queryresult.ToTable("resultTable");
            dgv_Query_result.Columns[0].HeaderText = "序号";
            dgv_Query_result.Columns[0].Visible = false;
            dgv_Query_result.Columns[1].HeaderText = "退回记录号";
            dgv_Query_result.Columns[1].Visible = false;
            dgv_Query_result.Columns[2].HeaderText = "领用记录号";
            dgv_Query_result.Columns[2].Visible = false;
            dgv_Query_result.Columns[3].HeaderText = "系统编号";
            dgv_Query_result.Columns[3].Visible = false;
            dgv_Query_result.Columns[4].HeaderText = "材料编号";
            dgv_Query_result.Columns[5].HeaderText = "材料名称";
            dgv_Query_result.Columns[6].HeaderText = "材料数量";
            dgv_Query_result.Columns[7].HeaderText = "材料规格";
            dgv_Query_result.Columns[8].HeaderText = "材料总量";
            dgv_Query_result.Columns[9].HeaderText = "领用时间";
            dgv_Query_result.Columns[9].Visible = false;
            dgv_Query_result.Columns[10].HeaderText = "提交时间";
            dgv_Query_result.Columns[10].Visible = false;
            dgv_Query_result.Columns[11].HeaderText = "操作人";
            dgv_Query_result.Columns[11].Visible = false;
            dgv_Query_result.Columns[12].HeaderText = "退回原因";
            dgv_Query_result.Columns[13].HeaderText = "退回状态";
        }

        private void dgv_Query_result_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Query_result.Rows.Count > 0)
            {
                txt_gbid.Text = dgv_Query_result.SelectedCells[1].Value.ToString().Trim();
                txt_Outid.Text = dgv_Query_result.SelectedCells[2].Value.ToString().Trim();
                txt_matid.Text = dgv_Query_result.SelectedCells[3].Value.ToString().Trim();
                txt_Materia_id.Text = dgv_Query_result.SelectedCells[4].Value.ToString().Trim();
                txt_Materia_name.Text = dgv_Query_result.SelectedCells[5].Value.ToString().Trim();
                txt_Lysl.Text = dgv_Query_result.SelectedCells[6].Value.ToString().Trim();
                txt_Materia_unit.Text = dgv_Query_result.SelectedCells[7].Value.ToString().Trim();
                txt_Lyzl.Text = dgv_Query_result.SelectedCells[8].Value.ToString().Trim();
                txt_Outdate.Text = string.Format("{0:d}", Convert.ToDateTime(dgv_Query_result.SelectedCells[9].Value.ToString().Trim()));
                txt_gbdate.Text = string.Format("{0:d}", Convert.ToDateTime(dgv_Query_result.SelectedCells[10].Value.ToString().Trim()));
                txt_Operator.Text = dgv_Query_result.SelectedCells[11].Value.ToString().Trim();
                txt_backReason.Text = dgv_Query_result.SelectedCells[12].Value.ToString().Trim();
                rdb_agree.Enabled = true;
                rdb_disagree.Enabled = true;
            }
        }

        private void rdb_agree_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_disagree.Checked == true)
            {
                Frm_matgbdisagree frmgbdisagree = new Frm_matgbdisagree();
                frmgbdisagree.ShowDialog();
                if (frmgbdisagree.Reasons.Length == 0)
                {
                    rdb_agree.Checked = true;
                    disagreeReason = string.Empty;
                }
                else
                {
                    disagreeReason = frmgbdisagree.Reasons.ToString().Trim();
                }
            }
        }
        /// <summary>
        /// 清空所有内容
        /// </summary>
        private void clearAll()
        {
            disagreeReason = string.Empty;
            txt_gbid.Text = "";
            txt_Outid.Text = "";
            txt_matid.Text = "";
            txt_Materia_id.Text = "";
            txt_Materia_name.Text = "";
            txt_Lysl.Text = "";
            txt_Materia_unit.Text = "";
            txt_Lyzl.Text = "";
            txt_Outdate.Text = "";
            txt_gbdate.Text = "";
            txt_Operator.Text = "";
            txt_backReason.Text = "";
            rdb_agree.Checked = true;
            rdb_agree.Enabled = false;
            rdb_disagree.Enabled = false;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_gbid.Text.Trim().Length == 0)
            {
                MessageBox.Show("回退记录号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_matid.Text.Trim().Length == 0)
            {
                MessageBox.Show("材料系统编号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Materia_id.Text.Trim().Length == 0)
            {
                MessageBox.Show("材料编号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Materia_name.Text.Trim().Length == 0)
            {
                MessageBox.Show("材料名称不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Lysl.Text.Trim().Length == 0)
            {
                MessageBox.Show("回退数量不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Materia_unit.Text.Trim().Length == 0)
            {
                MessageBox.Show("材料规格不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Lyzl.Text.Trim().Length == 0)
            {
                MessageBox.Show("回退总量不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Outdate.Text.Trim().Length == 0)
            {
                MessageBox.Show("领用时间不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Operator.Text.Trim().Length == 0)
            {
                MessageBox.Show("操作人信息不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_gbdate.Text.Trim().Length == 0)
            {
                MessageBox.Show("回退时间不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Savedate.Text.Trim().Length == 0)
            {
                MessageBox.Show("提交时间不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_backReason.Text.Trim().Length == 0)
            {
                MessageBox.Show("回退原因不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rdb_agree.Checked==true)
                {
                    mat_giveBack_Save();
                }
                else
                {

                }
            }
        }

        /// <summary>
        /// 提交修改数据
        /// </summary>
        private void mat_giveBack_Save()
        {
            if (MessageBox.Show("是否保存领料数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR.Trim());
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    //备份需要修改的材料记录
                    string sqlstr = "INSERT INTO `material_giveback_bk` VALUES (NULL,@gbid,@Outid,@Matid,@Material_id,@Material_inside_name,";
                    sqlstr += "@Material_gbnum,@Material_unit,@Material_gbTotal,@Outdate,@back_operator,@back_date,@confirm_date,@back_Reason,@confrim_operator)";
                    cmd.CommandText = sqlstr;
                    cmd.Parameters.AddWithValue("@gbid", txt_gbid.Text.Trim());
                    cmd.Parameters.AddWithValue("@Outid", txt_Outid.Text.Trim());
                    cmd.Parameters.AddWithValue("@Matid", txt_matid.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_id", txt_Materia_id.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_inside_name", txt_Materia_name.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_gbnum", Convert.ToDecimal(txt_Lysl.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Material_unit", Convert.ToDecimal(txt_Materia_unit.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Material_gbTotal", Convert.ToDecimal(txt_Lyzl.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Outdate", Convert.ToDateTime(txt_Outdate.Text.Trim()));
                    cmd.Parameters.AddWithValue("@back_operator", txt_Operator.Text.Trim());
                    cmd.Parameters.AddWithValue("@back_date", Convert.ToDateTime(txt_gbdate.Text.Trim()));
                    cmd.Parameters.AddWithValue("@confirm_date", Convert.ToDateTime(txt_Savedate.Text.Trim()));
                    cmd.Parameters.AddWithValue("@back_Reason", txt_backReason.Text.Trim());
                    cmd.Parameters.AddWithValue("@confrim_operator", userInfocheck._Usname.Trim());
                    cmd.ExecuteNonQuery();

                    //材料领用表增加一条退货记录
                    MySqlCommand cmdA = new MySqlCommand();
                    cmdA.Connection = conn;
                    string sqlstrA = "INSERT INTO `Material_out` VALUES (NULL, @Outid, @Matid, @Material_id, @Material_inside_name,";
                    sqlstrA += " @Material_lysl, @Material_unit, @Lyzl, @Out_date, @Out_operator)";

                    cmdA.CommandText = sqlstrA;
                    cmdA.Parameters.AddWithValue("@Outid", txt_gbid.Text.Trim());
                    cmdA.Parameters.AddWithValue("@Matid", txt_matid.Text.Trim());
                    cmdA.Parameters.AddWithValue("@Material_id", txt_Materia_id.Text.Trim());
                    cmdA.Parameters.AddWithValue("@Material_inside_name", txt_Materia_name.Text.Trim());
                    cmdA.Parameters.AddWithValue("@Material_lysl", Convert.ToDecimal('-' + txt_Lysl.Text.Trim()));
                    cmdA.Parameters.AddWithValue("@Material_unit", Convert.ToDecimal(txt_Materia_unit.Text.Trim()));
                    cmdA.Parameters.AddWithValue("@Lyzl", Convert.ToDecimal('-' + txt_Lyzl.Text.Trim()));
                    cmdA.Parameters.AddWithValue("@Out_date", Convert.ToDateTime(txt_Savedate.Text.Trim()));
                    cmdA.Parameters.AddWithValue("@Out_operator", txt_Operator.Text.Trim());
                    cmdA.ExecuteNonQuery();

                    //材料进仓表增加一条进仓数量
                    //MySqlCommand cmdB = new MySqlCommand();
                    //cmdB.Connection = conn;
                    //string sqlstrB = "INSERT INTO `material_input` VALUES (NULL, @Inpuid, @Matid, @Material_id, @Material_inside_name,";
                    //sqlstrB += " @Material_jlsl, @Material_unit, @Jlzl, @Input_date, @Input_operator)";

                    //cmdB.CommandText = sqlstrB;
                    //cmdB.Parameters.AddWithValue("@Inpuid", txt_gbid.Text.Trim());
                    //cmdB.Parameters.AddWithValue("@Matid", txt_matid.Text.Trim());
                    //cmdB.Parameters.AddWithValue("@Material_id", txt_Materia_id.Text.Trim());
                    //cmdB.Parameters.AddWithValue("@Material_inside_name", txt_Materia_name.Text.Trim());
                    //cmdB.Parameters.AddWithValue("@Material_jlsl", Convert.ToDecimal(txt_Lysl.Text.Trim()));
                    //cmdB.Parameters.AddWithValue("@Material_unit", Convert.ToDecimal(txt_Materia_unit.Text.Trim()));
                    //cmdB.Parameters.AddWithValue("@Jlzl", Convert.ToDecimal(txt_Lyzl.Text.Trim()));
                    //cmdB.Parameters.AddWithValue("@Input_date", Convert.ToDateTime(txt_Savedate.Text.Trim()));
                    //cmdB.Parameters.AddWithValue("@Input_operator", userInfocheck._Usname.Trim());
                    //cmdB.ExecuteNonQuery();

                    //更新材料库存表
                    MySqlCommand cmdC = new MySqlCommand();
                    cmdC.Connection = conn;
                    string sqlstrC = "UPDATE `material_stock` SET Material_stock = Material_stock + @Matstock WHERE Matid=@Matida";

                    cmdC.CommandText = sqlstrC;
                    cmdC.Parameters.AddWithValue("@Matida", txt_matid.Text.Trim());
                    cmdC.Parameters.AddWithValue("@Matstock", Convert.ToDecimal(txt_Lyzl.Text.Trim()));
                    cmdC.ExecuteNonQuery();

                    //更新材料退回记录表记录状态
                    MySqlCommand cmdD = new MySqlCommand();
                    cmdD.Connection = conn;
                    string sqlstrD = "UPDATE `material_giveback` SET back_status='完成' WHERE gbid=@gbid";
                    cmdD.CommandText = sqlstrD;
                    cmdD.Parameters.AddWithValue("@gbid", txt_gbid.Text.Trim());
                    cmdD.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transaction.Rollback();
                    conn.Close();
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        transaction.Commit();
                        conn.Close();
                        MessageBox.Show("数据已保存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearAll();
                        ds_Queryresult.Clear();
                        mat_gbQuery();
                    }
                }
            }
        }
    }
}
