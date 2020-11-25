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
    public partial class Frm_matbaseinput : Form
    {
        public Frm_matbaseinput()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 数据链接
        /// </summary>
        dbconnectstr dbc = new dbconnectstr();

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        private void Frm_matbaseinput_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmbsin == "CLOSE" || frmShowstatus._Frmbsin == null)
            {
                //将窗口状态设置为打开
                frmShowstatus._Frmbsin = "OPEN";
                //获取领料时间
                txt_Inputdate.Text = DateTime.Now.ToShortDateString();
                txt_Operator.Text = userInfocheck._Usname.Trim();
                Querymtastock();
            }
        }

        private void Frm_matbaseinput_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmbsin = "CLOSE";
        }

        private void txt_Materia_id_DoubleClick(object sender, EventArgs e)
        {
            Frm_mtashow mtashow = new Frm_mtashow();
            mtashow.ShowDialog();
            if (mtashow.mtaId != null)
            {
                txt_mat_id.Text = mtashow.mtaid.ToString().Trim();
                txt_Materia_id.Text = mtashow.mtaId.ToString().Trim();
                txt_Materia_name.Text = mtashow.mtaName.ToString().Trim();
                txt_Qczl.Text = "";
                txt_Qczl.Focus();
            }
        }

        private void txt_Qczl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.' || this.txt_Qczl.Text.Length == 0)
                {
                    e.Handled = true;
                }
                if (txt_Qczl.Text.LastIndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar == 13 || e.KeyChar == 9)
            {
                e.Handled = true;
                btn_Save.Focus();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(txt_mat_id.Text.Trim()=="")
            {
                MessageBox.Show("系统码不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if(txt_Materia_id.Text.Trim()=="")
            {
                MessageBox.Show("材料编号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_Materia_id.Focus();
            }
            else if(txt_Materia_name.Text.Trim()=="")
            {
                MessageBox.Show("材料名称不能为空！","警告",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                txt_Materia_id.Focus();
            }
            else if(txt_Qczl.Text.Trim()=="")
            {
                MessageBox.Show("材料期初数不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_Qczl.Focus();
            }
            else if(txt_Operator.Text.Trim()=="")
            {
                MessageBox.Show("操作人不能为空！请与系统管理员联系！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Querymtaid(txt_mat_id.Text.Trim()) == true)
                {
                    MessageBox.Show("警告：" + txt_Materia_id.Text.Trim() + " 材料已存在期初数，不能再次添加该材料期初值！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    mta_input();
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_mat_id.Text = "";
            txt_Materia_id.Text = "";
            txt_Materia_name.Text = "";
            txt_Qczl.Text = "";
        }

        /// <summary>
        /// 保存期初数据记录
        /// </summary>
        private void mta_input()
        {
            if(MessageBox.Show("是否保存领料数据？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk)==DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = dbc.getCon();
                    string strsql = "INSERT INTO `material_stock` VALUES(NULL,@Matid,@Material_id,@Material_inside_name,";
                    strsql += "@Material_stock,@Input_date,@Input_operator)";
                    cmd.CommandText = strsql;
                    cmd.Parameters.AddWithValue("@Matid", txt_mat_id.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_id", txt_Materia_id.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_inside_name", txt_Materia_name.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_stock", Convert.ToDecimal(txt_Qczl.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Input_date", Convert.ToDateTime(txt_Inputdate.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Input_operator", txt_Operator.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("数据已保存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dbc._getClose();
                    cmd.Dispose();
                    txt_mat_id.Text = "";
                    txt_Materia_id.Text = "";
                    txt_Materia_name.Text = "";
                    txt_Qczl.Text = "";
                    ds_Queryresult.Clear();
                    Querymtastock();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// 查询材料期初值是否存在
        /// </summary>
        /// <param name="mtdi">材料系统编号</param>
        /// <returns>存在返回 true,不存在返回 false</returns>
        private bool Querymtaid(string mtdi)
        {
            bool b = false;
            string sqlstr = "SELECT * FROM material_stock WHERE Matid=@Matid";
            MySqlCommand cmd = new MySqlCommand(sqlstr, dbc.getCon());
            cmd.Parameters.AddWithValue("@Matid", mtdi.Trim());

            MySqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            b = rd.Read();
            return b;
        }

        /// <summary>
        /// 材料库存数据检索
        /// </summary>
        private void Querymtastock()
        {
            string sqlstr = "SELECT Matid, Material_id, Material_inside_name, Material_stock FROM material_stock";
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, dbc.getCon());
            msda.Fill(ds_Queryresult, "resultStock");
            dbc._getClose();
            msda.Dispose();
            dv_Queryresult.Table = ds_Queryresult.Tables["resultStock"];
            dgv_Query_result.DataSource = dv_Queryresult.ToTable("resultStock");
            dgv_Query_result.Columns[0].HeaderText = "系统码";
            dgv_Query_result.Columns[1].HeaderText = "材料编号";
            dgv_Query_result.Columns[2].HeaderText = "材料名称";
            dgv_Query_result.Columns[3].HeaderText = "材料库存数";
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            if (txt_Queryid.Text.Trim()!="")
            {
                dgv_Query_result.DataSource = null;
                dv_Queryresult.RowFilter = "Material_id like '%" + txt_Queryid.Text.Trim() + "%'";
                dgv_Query_result.DataSource = dv_Queryresult.ToTable("resultStock");
                dgv_Query_result.Columns[0].HeaderText = "系统码";
                dgv_Query_result.Columns[1].HeaderText = "材料编号";
                dgv_Query_result.Columns[2].HeaderText = "材料名称";
                dgv_Query_result.Columns[3].HeaderText = "材料库存数";
            }
            else
            {
                dgv_Query_result.DataSource = null;
                dv_Queryresult.RowFilter = null;
                Querymtastock();
                dgv_Query_result.DataSource = dv_Queryresult.ToTable("resultStock");
                dgv_Query_result.Columns[0].HeaderText = "系统码";
                dgv_Query_result.Columns[1].HeaderText = "材料编号";
                dgv_Query_result.Columns[2].HeaderText = "材料名称";
                dgv_Query_result.Columns[3].HeaderText = "材料库存数";
            }
        }
    }
}
