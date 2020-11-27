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

        /// <summary>
        /// 数据库链接
        /// </summary>
        dbconnectstr dbc = new dbconnectstr();

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        /// <summary>
        /// 材料系统编码(内码)
        /// </summary>
        string mTid;

        private void Frm_cailiaojincang_Load(object sender, EventArgs e)
        {
            if(frmShowstatus._Frmcljc=="CLOSE"||frmShowstatus._Frmcljc==null)
            {
                frmShowstatus._Frmcljc = "OPEN";

                newInputid();

                txt_Inputdate.Text = DateTime.Now.ToShortDateString();

                Querymtastock();
            }
        }

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
            //if (rd.HasRows)
            //{
            //    txt_matStock.Text = rd[1].ToString().Trim();
            //}
            //else
            //{
            //    txt_matStock.Text = "0";
            //}
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

        }
    }
}
