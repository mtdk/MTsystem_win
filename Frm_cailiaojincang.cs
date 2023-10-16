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
    public partial class Frm_cailiaojincang : Form
    {
        public Frm_cailiaojincang()
        {
            InitializeComponent();
        }

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        private void Frm_cailiaojincang_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmcljc == "CLOSE" || frmShowstatus._Frmcljc == null)
            {
                frmShowstatus._Frmcljc = "OPEN";

                newInputid();

                txt_Inputdate.Text = DateTime.Now.ToShortDateString();

                txt_Operator.Text = userInfocheck._Usname.Trim();

                wdhListBind();
                //Querymtastock();
            }
        }

        private void txt_Materia_id_DoubleClick(object sender, EventArgs e)
        {
            Frm_mtashow mtashow = new Frm_mtashow();
            mtashow.ShowDialog();
            if (mtashow.mtaId != null)
            {
                txt_Inputsl.Text = "";
                txt_Materia_unit.Text = "";
                txt_Inputzl.Text = "0";
                txt_mat_id.Text = mtashow.mtaid.ToString().Trim();
                txt_Materia_id.Text = mtashow.mtaId.ToString().Trim();
                txt_Materia_name.Text = mtashow.mtaName.ToString().Trim();
                //暂不使用
                //txt_orderID.Text = mtashow.non_procurement_id.ToString().Trim();
                txt_orderID.Text = "";
                lb_inventory.Text = Materia_stock(txt_mat_id.Text.Trim());
                txt_Inputsl.Focus();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Inputid.Text.Trim() == "")
            {
                MessageBox.Show("进仓记录号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_mat_id.Text.Trim() == "")
            {
                MessageBox.Show("材料系统码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_Materia_id.Text.Trim() == "")
            {
                MessageBox.Show("材料编号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_Materia_name.Text.Trim() == "")
            {
                MessageBox.Show("材料名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_Materia_name.Text.Trim() == "未找到")
            {
                MessageBox.Show("未找到材料名称，不能保存数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_Inputsl.Text.Trim() == "")
            {
                MessageBox.Show("进仓数量不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_Inputsl.Focus();
            }
            else if (txt_Materia_unit.Text.Trim() == "")
            {
                MessageBox.Show("材料规格不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_Materia_unit.Focus();
            }
            else if (txt_Inputzl.Text.Trim() == "")
            {
                MessageBox.Show("进仓总量不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if ((Convert.ToDecimal(txt_Inputzl.Text.Trim())) < 1)
            {
                MessageBox.Show("进仓总量不能为\"0\"！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_Inputdate.Text.Trim() == "")
            {
                MessageBox.Show("进仓日期不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (txt_Operator.Text.Trim() == "")
            {
                MessageBox.Show("进仓人不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_Operator.Focus();
            }
            else
            {
                matInput();
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
            newInputid();
            txt_mat_id.Text = "";
            txt_Materia_id.Text = "";
            txt_Materia_name.Text = "";
            txt_Inputsl.Text = "";
            txt_Materia_unit.Text = "";
            txt_Inputzl.Text = "0";
            txt_Materia_id.Focus();
        }

        /// <summary>
        /// 产生进仓单号
        /// </summary>
        private void newInputid()
        {
            txt_Inputid.Text = DateTime.Now.Year.ToString().Trim();
            txt_Inputid.Text += DateTime.Now.Month.ToString().Trim();
            txt_Inputid.Text += DateTime.Now.Day.ToString().Trim();
            txt_Inputid.Text += DateTime.Now.Hour.ToString().Trim();
            txt_Inputid.Text += DateTime.Now.Minute.ToString().Trim();
            txt_Inputid.Text += DateTime.Now.Second.ToString().Trim();
        }

        /// <summary>
        /// 所有未到货订单检索
        /// </summary>
        private void wdhListBind()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR.Trim());
            conn.Open();
            string sqlstr = "SELECT OrderFormID AS 订单号,OrderDate AS 下单时间,";
            sqlstr += "InteriorID AS 系统码,Material_ID AS 材料编号,";
            sqlstr += "Material_Units AS 单位,Material_Number AS 数量,Material_Remarks AS 备注";
            sqlstr += " FROM tb_OrderForm WHERE Goods_Status='有效' AND Dh_Status='未到'";
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
            msda.Fill(ds_Queryresult, "resultOrder");

            dv_Queryresult.Table = ds_Queryresult.Tables["resultOrder"];
            dgv_Orderform.DataSource = dv_Queryresult.ToTable("resultOrder");
            dgv_Orderform.Columns[0].Frozen = true;
            dgv_Orderform.Columns[1].Frozen = true;
            dgv_Orderform.Columns[2].Frozen = true;
            dgv_Orderform.Columns[3].Frozen = true;
            conn.Close();
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

        /// <summary>
        /// 材料进仓
        /// </summary>
        private void matInput()
        {
            if (MessageBox.Show("是否保存进仓数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
                    cmd.Parameters.AddWithValue("@Material_jlsl", Convert.ToDecimal(txt_Inputsl.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Material_unit", Convert.ToDecimal(txt_Materia_unit.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Jlzl", Convert.ToDecimal(txt_Inputzl.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Input_date", Convert.ToDateTime(txt_Inputdate.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Input_operator", txt_Operator.Text.Trim());
                    cmd.ExecuteNonQuery();
                    //如果期初库中有数据执行UPDATE语句，如果期初库中没有数据执行INSERT语句
                    string strsqlA = "";
                    if (Querymtaid(txt_mat_id.Text.Trim()) == true)
                    {
                        strsqlA = "UPDATE `material_stock` SET Material_stock = Material_stock + @Matstock WHERE Matid=@Matida";
                        cmd.CommandText = strsqlA;
                        cmd.Parameters.AddWithValue("@Matida", txt_mat_id.Text.Trim());
                        cmd.Parameters.AddWithValue("@Matstock", Convert.ToDecimal(txt_Inputzl.Text.Trim()));

                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        strsqlA = "";

                        strsqlA = "INSERT INTO `material_stock` VALUES(NULL,@Matidb,@Materialid,@Materialinside_name,";
                        strsqlA += "@Materialstock,@Inputdate,@Inputoperator)";
                        cmd.CommandText = strsqlA;
                        cmd.Parameters.AddWithValue("@Matidb", txt_mat_id.Text.Trim());
                        cmd.Parameters.AddWithValue("@Materialid", txt_Materia_id.Text.Trim());
                        cmd.Parameters.AddWithValue("@Materialinside_name", txt_Materia_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@Materialstock", Convert.ToDecimal(txt_Inputzl.Text.Trim()));
                        cmd.Parameters.AddWithValue("@Inputdate", Convert.ToDateTime(txt_Inputdate.Text.Trim()));
                        cmd.Parameters.AddWithValue("@Inputoperator", txt_Operator.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }

                    if (txt_orderID.Text.Trim().Length != 0)
                    {
                        if (MessageBox.Show("是否关闭采购订单？", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            //关闭采购订单操作
                            string sqlstr = "UPDATE `tb_orderform` SET Dh_Status = '已到' WHERE OrderFormID=@OrderFormID";
                            cmd.CommandText = sqlstr;
                            cmd.Parameters.AddWithValue("@OrderFormID", txt_orderID.Text.Trim());

                            cmd.ExecuteNonQuery();
                        }
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
                        newInputid();
                        txt_mat_id.Text = "";
                        txt_Materia_id.Text = "";
                        txt_Materia_name.Text = "";
                        txt_Inputsl.Text = "";
                        txt_Materia_unit.Text = "";
                        txt_Inputzl.Text = "0";
                        txt_orderID.Text = "";
                        lb_inventory.Text = "0";
                        txt_Materia_id.Focus();
                        ds_Queryresult.Clear();
                        wdhListBind();
                    }
                }
            }
        }

        private void Frm_cailiaojincang_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmcljc = "CLOSE";
        }


        /// <summary>
        /// 获得当前原材料库存量
        /// </summary>
        /// <param name="mid">原材料系统编号</param>
        /// <returns>返回库存数或者0</returns>
        private string Materia_stock(string mid)
        {
            string tmp;
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            string sqlstr = "SELECT Material_stock FROM material_stock WHERE Matid = '" + mid.Trim() + "'";
            MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dr.Read();
            if (dr.HasRows)
            {
                tmp = dr["Material_stock"].ToString();
            }
            else
            {
                tmp = "0";
            }
            return tmp;
        }

        /// <summary>
        /// 从原材料数据表中找对应的原材料名称
        /// </summary>
        /// <param name="name">原材料系统编号</param>
        /// <returns>返回原材料名称或者未找到</returns>
        private string Materia_name(string name)
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            string sqlstr = "SELECT Material_inside_name FROM material WHERE Matid = '" + name.Trim() + "'";
            MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dr.Read();
            if (dr.HasRows)
            {
                name = dr["Material_inside_name"].ToString().Trim();
            }
            else
            {
                name = "未找到";
            }

            return name;
        }

        private void dgv_Orderform_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Orderform.Rows.Count > 0)
            {
                txt_orderID.Text = dgv_Orderform.SelectedCells[0].Value.ToString().Trim();
                txt_mat_id.Text = dgv_Orderform.SelectedCells[2].Value.ToString().Trim();
                txt_Materia_id.Text = dgv_Orderform.SelectedCells[3].Value.ToString().Trim();
                //order_total = Convert.ToDecimal(dgv_Orderform.SelectedCells[5].Value.ToString().Trim());
                txt_Materia_name.Text = Materia_name(txt_mat_id.Text.Trim());
                lb_inventory.Text = Materia_stock(txt_mat_id.Text.Trim());
                txt_Inputsl.Text = "";
                txt_Materia_unit.Text = "";
                txt_Inputzl.Text = "0";
                txt_Inputsl.Focus();
            }
        }
    }
}
