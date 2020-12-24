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
            if (frmShowstatus._Frmmatconfirm=="CLOSE"||frmShowstatus._Frmmatconfirm==null)
            {
                frmShowstatus._Frmmatconfirm = "OPEN";
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
            if (dgv_Query_result.Rows.Count>0)
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
            else if (txt_backReason.Text.Trim().Length == 0)
            {
                MessageBox.Show("回退原因不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            }
        }
    }
}
