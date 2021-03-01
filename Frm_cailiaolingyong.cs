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

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        /// <summary>
        /// 材料系统编码(内码)
        /// </summary>
        string mTid;

        private void Frm_cailiaolingyong_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmclly == "CLOSE" || frmShowstatus._Frmclly == null)
            {
                //将窗口状态设置为打开
                frmShowstatus._Frmclly = "OPEN";
                newOutid();
                //获取领料时间
                txt_Outdate.Text = DateTime.Now.ToShortDateString();
                //操作人信息
                txt_Operator.Text = userInfocheck._Usname.Trim();
                //列出材料库存
                Querymtastock();
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
                mTid = mtashow.mtaid.ToString().Trim();
                txt_Materia_id.Text = mtashow.mtaId.ToString().Trim();
                txt_Materia_name.Text = mtashow.mtaName.ToString().Trim();
                txt_Lysl.Focus();
                Querymtaid(mTid.Trim());
            }
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
                txt_Operator.Focus();
                //btn_Save.Focus();
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

        private void txt_Operator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btn_Save.Focus();
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
            else if ((Convert.ToDecimal(txt_Lyzl.Text.Trim())) < 1)
            {
                MessageBox.Show("领用总量不能为\"0\"！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                //领料总量大于库存材料库存总量
                if ((Convert.ToDecimal(txt_Lyzl.Text.Trim())) > (Convert.ToDecimal(txt_matStock.Text.Trim())))
                {
                    if (MessageBox.Show("领用总量超过当前材料库存总量！是否继续领用？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        mat_out();
                    }
                }
                else
                {
                    //领料总量不大于库存材料总量
                    mat_out();
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Materia_id.Text = "";
            txt_Materia_name.Text = "";
            txt_Lysl.Text = "";
            txt_Materia_unit.Text = "";
            txt_Lyzl.Text = "0";
            txt_matStock.Text = "0";
            txt_Materia_id.Focus();
        }

        /// <summary>
        /// 保存领料记录
        /// </summary>
        private void mat_out()
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
                    string strsql = "INSERT INTO `Material_out` VALUES (NULL, @Outid, @Matid, @Material_id, @Material_inside_name,";
                    strsql += " @Material_lysl, @Material_unit, @Lyzl, @Out_date, @Out_operator)";

                    cmd.CommandText = strsql;
                    cmd.Parameters.AddWithValue("@Outid", txt_Outid.Text.Trim());
                    cmd.Parameters.AddWithValue("@Matid", mTid.Trim());
                    cmd.Parameters.AddWithValue("@Material_id", txt_Materia_id.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_inside_name", txt_Materia_name.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_lysl", Convert.ToDecimal(txt_Lysl.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Material_unit", Convert.ToDecimal(txt_Materia_unit.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Lyzl", Convert.ToDecimal(txt_Lyzl.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Out_date", Convert.ToDateTime(txt_Outdate.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Out_operator", txt_Operator.Text.Trim());
                    cmd.ExecuteNonQuery();

                    string strsqlA = "UPDATE `material_stock` SET Material_stock = Material_stock - @Matstock WHERE Matid=@Matida";

                    cmd.CommandText = strsqlA;
                    cmd.Parameters.AddWithValue("@Matida", mTid.Trim());
                    cmd.Parameters.AddWithValue("@Matstock", Convert.ToDecimal(txt_Lyzl.Text.Trim()));
                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("错误代码：" + ex.ErrorCode + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transaction.Rollback();
                    conn.Close();
                }
                finally
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        transaction.Commit();
                        conn.Close();
                        MessageBox.Show("数据已保存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        newOutid();
                        txt_Materia_id.Text = "";
                        txt_Materia_name.Text = "";
                        txt_Lysl.Text = "";
                        txt_Materia_unit.Text = "";
                        txt_Lyzl.Text = "0";
                        txt_matStock.Text = "0";
                        txt_Materia_id.Focus();
                        ds_Queryresult.Clear();
                        Querymtastock();
                    }
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
            //txt_Outid.Text += DateTime.Now.Millisecond.ToString().Trim();
        }

        /// <summary>
        /// 材料库存数据检索
        /// </summary>
        private void Querymtastock()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR.Trim());
            conn.Open();
            string sqlstr = "SELECT Matid, Material_id, Material_inside_name, Material_stock FROM material_stock";
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
            msda.Fill(ds_Queryresult, "resultStock");

            dv_Queryresult.Table = ds_Queryresult.Tables["resultStock"];
            dgv_Query_result.DataSource = dv_Queryresult.ToTable("resultStock");
            dgv_Query_result.Columns[0].HeaderText = "系统码";
            dgv_Query_result.Columns[1].HeaderText = "材料编号";
            dgv_Query_result.Columns[2].HeaderText = "材料名称";
            dgv_Query_result.Columns[3].HeaderText = "材料库存数(KG)";
            conn.Close();
            msda.Dispose();
        }

        /// <summary>
        /// 查询材料期初值是否存在
        /// </summary>
        /// <param name="mtdi">材料系统编号</param>
        /// <returns>存在返回 true,不存在返回 false</returns>
        private void Querymtaid(string mt_di)
        {

            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR.Trim());
            conn.Open();
            string sqlstr = "SELECT Matid, Material_stock FROM material_stock WHERE Matid=@Matid";
            MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
            cmd.Parameters.AddWithValue("@Matid", mt_di.Trim());

            MySqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            rd.Read();
            if (rd.HasRows)
            {
                txt_matStock.Text = rd[1].ToString().Trim();
            }
            else
            {
                txt_matStock.Text = "0";
            }
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            doQuery();
        }
        /// <summary>
        /// 执行材料信息查询
        /// </summary>
        private void doQuery()
        {
            if (txt_Queryid.Text.Trim() != "")
            {
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                conn.Open();
                ds_Queryresult.Clear();
                string sqlstr = "SELECT Matid, Material_id, Material_inside_name, Material_stock FROM material_stock WHERE Material_id LIKE '%" + txt_Queryid.Text.Trim() + "%'";
                MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
                msda.Fill(ds_Queryresult, "resultStock");

                dv_Queryresult.Table = ds_Queryresult.Tables["resultStock"];
                dgv_Query_result.DataSource = dv_Queryresult.ToTable("resultStock");
                dgv_Query_result.Columns[0].HeaderText = "系统码";
                dgv_Query_result.Columns[1].HeaderText = "材料编号";
                dgv_Query_result.Columns[2].HeaderText = "材料名称";
                dgv_Query_result.Columns[3].HeaderText = "材料库存数(KG)";
                conn.Close();
                msda.Dispose();
            }
            else
            {
                ds_Queryresult.Clear();
                Querymtastock();
            }
        }

        /// <summary>
        /// 根据材料库存数量修改单元格字体颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Query_result_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < this.dgv_Query_result.Rows.Count; i++)
            {
                if (Convert.ToDecimal(dgv_Query_result.Rows[i].Cells[3].Value.ToString().Trim()) <= 0)
                {
                    this.dgv_Query_result.Rows[i].Cells[3].Style.ForeColor = Color.Red;
                }
                else
                {
                    this.dgv_Query_result.Rows[i].Cells[3].Style.ForeColor = Color.Black;
                }
            }
        }

        private void txt_Queryid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                e.Handled = true;
                doQuery();
            }
        }
    }
}