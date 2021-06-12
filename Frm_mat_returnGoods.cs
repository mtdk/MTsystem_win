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
    public partial class Frm_mat_returnGoods : Form
    {
        public Frm_mat_returnGoods()
        {
            InitializeComponent();
        }

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        private void Frm_mat_returnGoods_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmmatreturngoods=="CLOSE"||frmShowstatus._Frmmatreturngoods==null)
            {
                frmShowstatus._Frmmatreturngoods = "OPEN";

                newReturnid();

                txt_Inputdate.Text = DateTime.Now.ToShortDateString();

                txt_Operator.Text = userInfocheck._Usname.Trim();

                Querymtastock();

            }
        }

        private void Frm_mat_returnGoods_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmmatreturngoods = "CLOSE";
        }

        /// <summary>
        /// 材料退货单号
        /// </summary>
        private void newReturnid()
        {
            txt_Inputid.Text = DateTime.Now.Year.ToString().Trim();
            txt_Inputid.Text += DateTime.Now.Month.ToString().Trim();
            txt_Inputid.Text += DateTime.Now.Day.ToString().Trim();
            txt_Inputid.Text += DateTime.Now.Hour.ToString().Trim();
            txt_Inputid.Text += DateTime.Now.Minute.ToString().Trim();
            txt_Inputid.Text += DateTime.Now.Second.ToString().Trim();
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
            conn.Dispose();
            msda.Dispose();
        }

        /// <summary>
        /// 查询材料期初值是否存在
        /// </summary>
        /// <param name="mtdi">材料系统编号</param>
        /// <returns>存在返回 true,不存在返回 false</returns>
        private bool Querymtaid(string mt_di)
        {
            bool b = false;
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR.Trim());
            conn.Open();
            string sqlstr = "SELECT Matid, Material_stock FROM material_stock WHERE Matid=@Matid";
            MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
            cmd.Parameters.AddWithValue("@Matid", mt_di.Trim());

            MySqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            b = rd.Read();

            return b;
        }

        private void txt_Materia_id_DoubleClick(object sender, EventArgs e)
        {
            Frm_mtashow mtashow = new Frm_mtashow();
            mtashow.ShowDialog();
            if (mtashow.mtaId != null)
            {
                txt_Inputsl.Text = "";
                txt_Materia_unit.Text = "";
                txt_Inputzl.Text = "";
                txt_mat_id.Text = mtashow.mtaid.ToString().Trim();
                txt_Materia_id.Text = mtashow.mtaId.ToString().Trim();
                txt_Materia_name.Text = mtashow.mtaName.ToString().Trim();
                txt_Inputsl.Focus();
            }
        }

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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Inputid.Text.Trim() == "")
            {
                MessageBox.Show("领料记录号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_mat_id.Text.Trim() == "")
            {
                MessageBox.Show("领料系统码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_Materia_id.Text.Trim() == "")
            {
                MessageBox.Show("材料编号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_Materia_name.Text.Trim() == "")
            {
                MessageBox.Show("材料名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_Inputsl.Text.Trim() == "")
            {
                MessageBox.Show("领用数量不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_Inputsl.Focus();
            }
            else if (txt_Materia_unit.Text.Trim() == "")
            {
                MessageBox.Show("材料规格不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_Materia_unit.Focus();
            }
            else if (txt_Inputzl.Text.Trim() == "")
            {
                MessageBox.Show("领用总量不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if ((Convert.ToDecimal(txt_Inputzl.Text.Trim())) < 1)
            {
                MessageBox.Show("领用总量不能为\"0\"！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_Inputdate.Text.Trim() == "")
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
                matReturn();
            }
        }

        private void txt_Inputsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.' || this.txt_Inputsl.Text.Length == 0)
                {
                    e.Handled = true;
                }
                if (txt_Inputsl.Text.LastIndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar == 13 || e.KeyChar == 9)
            {
                e.Handled = true;
                if (txt_Inputsl.Text.Trim() != "" && txt_Materia_unit.Text.Trim() != "")
                {
                    txt_Inputzl.Text = Convert.ToString(Convert.ToDecimal(txt_Inputsl.Text) * Convert.ToDecimal(txt_Materia_unit.Text.Trim())).Trim();
                }
                else
                {
                    txt_Inputzl.Text = "0";
                }
                txt_Materia_unit.Focus();
            }
        }

        private void txt_Inputsl_Leave(object sender, EventArgs e)
        {
            if (txt_Inputsl.Text.Trim() != "" && txt_Materia_unit.Text.Trim() != "")
            {
                txt_Inputzl.Text = Convert.ToString(Convert.ToDecimal(txt_Inputsl.Text) * Convert.ToDecimal(txt_Materia_unit.Text.Trim())).Trim();
            }
            else
            {
                txt_Inputzl.Text = "0";
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
                if (txt_Inputsl.Text.Trim() != "" && txt_Materia_unit.Text.Trim() != "")
                {
                    txt_Inputzl.Text = Convert.ToString(Convert.ToDecimal(txt_Inputsl.Text) * Convert.ToDecimal(txt_Materia_unit.Text.Trim())).Trim();
                }
                else
                {
                    txt_Inputzl.Text = "0";
                }
                txt_Operator.Focus();
            }
        }

        private void txt_Materia_unit_Leave(object sender, EventArgs e)
        {
            if (txt_Inputsl.Text.Trim() != "" && txt_Materia_unit.Text.Trim() != "")
            {
                txt_Inputzl.Text = Convert.ToString(Convert.ToDecimal(txt_Inputsl.Text) * Convert.ToDecimal(txt_Materia_unit.Text.Trim())).Trim();
            }
            else
            {
                txt_Inputzl.Text = "0";
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_mat_id.Text = "";
            txt_Materia_id.Text = "";
            txt_Materia_name.Text = "";
            txt_Inputsl.Text = "";
            txt_Materia_unit.Text = "";
            txt_Inputzl.Text = "0";
            txt_Materia_id.Focus();
        }

        /// <summary>
        /// 材料退货
        /// </summary>
        private void matReturn()
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
                    string strsql = "INSERT INTO `material_input` VALUES (NULL, @Inpuid, @Matid, @Material_id, @Material_inside_name,";
                    strsql += " @Material_jlsl, @Material_unit, @Jlzl, @Input_date, @Input_operator)";

                    cmd.CommandText = strsql;
                    cmd.Parameters.AddWithValue("@Inpuid", txt_Inputid.Text.Trim());
                    cmd.Parameters.AddWithValue("@Matid", txt_mat_id.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_id", txt_Materia_id.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_inside_name", txt_Materia_name.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_jlsl", Convert.ToDecimal('-' + txt_Inputsl.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Material_unit", Convert.ToDecimal(txt_Materia_unit.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Jlzl", Convert.ToDecimal('-' + txt_Inputzl.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Input_date", Convert.ToDateTime(txt_Inputdate.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Input_operator", txt_Operator.Text.Trim());
                    cmd.ExecuteNonQuery();
                    //如果期初库中有数据执行UPDATE语句，如果期初库中没有数据执行INSERT语句
                    string strsqlA = "";
                    if (Querymtaid(txt_mat_id.Text.Trim()) == true)
                    {
                        strsqlA = "UPDATE `material_stock` SET Material_stock = Material_stock - @Matstock WHERE Matid=@Matida";
                        cmd.CommandText = strsqlA;
                        cmd.Parameters.AddWithValue("@Matida", txt_mat_id.Text.Trim());
                        cmd.Parameters.AddWithValue("@Matstock", Convert.ToDecimal(txt_Inputzl.Text.Trim()));

                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("材料库存没有该原材料的记录，不能进行退货操作！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        transaction.Rollback();
                        conn.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        newReturnid();
                        txt_mat_id.Text = "";
                        txt_Materia_id.Text = "";
                        txt_Materia_name.Text = "";
                        txt_Inputsl.Text = "";
                        txt_Materia_unit.Text = "";
                        txt_Inputzl.Text = "0";
                        txt_Materia_id.Focus();
                        ds_Queryresult.Clear();
                        Querymtastock();
                    }
                }
            }
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

        private void btn_Query_Click(object sender, EventArgs e)
        {
            doQuery();
        }
    }
}
