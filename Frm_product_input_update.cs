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
    public partial class Frm_product_input_update : Form
    {
        public Frm_product_input_update()
        {
            InitializeComponent();
        }

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        private void Frm_product_input_update_Load(object sender, EventArgs e)
        {
            allDataLoad();
        }

        //检索所有产品进仓记录
        private void allDataLoad()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            string sqlstr="SELECT id,Inputid,Proid,Product_id,Product_name,Product_jcsl,Product_unit,";
            sqlstr += "Jczl,Pro_batchNum,Input_date,Input_operator,Record_status FROM product_input";
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
            msda.Fill(ds_Queryresult, "resultData");

            dv_Queryresult.Table = ds_Queryresult.Tables["resultData"];
            dgv_SelectResult.DataSource = dv_Queryresult.ToTable("resultData");
            dgv_SelectResult.Columns[0].HeaderText = "序号";
            dgv_SelectResult.Columns[1].HeaderText = "进仓记录号";
            dgv_SelectResult.Columns[2].HeaderText = "产品系统编号";
            dgv_SelectResult.Columns[2].Visible = false;
            dgv_SelectResult.Columns[3].HeaderText = "产品编号";
            dgv_SelectResult.Columns[4].HeaderText = "产品名称";
            dgv_SelectResult.Columns[4].Frozen = true;
            dgv_SelectResult.Columns[5].HeaderText = "进仓数量";
            dgv_SelectResult.Columns[6].HeaderText = "规格";
            dgv_SelectResult.Columns[7].HeaderText = "进仓总量";
            dgv_SelectResult.Columns[8].HeaderText = "生产批号";
            dgv_SelectResult.Columns[9].HeaderText = "进仓时间";
            dgv_SelectResult.Columns[10].HeaderText = "操作人";
            dgv_SelectResult.Columns[11].HeaderText = "记录状态";
            conn.Close();
            msda.Dispose();
            txt_Inputid.Text = dgv_SelectResult.Rows[0].Cells[1].Value.ToString().Trim();
            txt_inputDate.Text = Convert.ToDateTime(dgv_SelectResult.Rows[0].Cells[9].Value.ToString().Trim()).ToShortDateString();
            txt_batchNum.Text = dgv_SelectResult.Rows[0].Cells[8].Value.ToString().Trim();
            lb_status.Text = dgv_SelectResult.Rows[0].Cells[11].Value.ToString().Trim();
        }

        private void btn_MovePrevious_Click(object sender, EventArgs e)
        {
            if (dgv_SelectResult.CurrentCell.RowIndex > 0)
            {
                this.dgv_SelectResult.CurrentCell = this.dgv_SelectResult[this.dgv_SelectResult.CurrentCell.ColumnIndex, this.dgv_SelectResult.CurrentCell.RowIndex - 1];

                txt_Inputid.Text = dgv_SelectResult.CurrentRow.Cells[1].Value.ToString().Trim();
                txt_inputDate.Text = Convert.ToDateTime(dgv_SelectResult.CurrentRow.Cells[9].Value.ToString().Trim()).ToShortDateString();
                txt_batchNum.Text = dgv_SelectResult.CurrentRow.Cells[8].Value.ToString().Trim();
                lb_status.Text = dgv_SelectResult.CurrentRow.Cells[11].Value.ToString().Trim();
            }
        }

        private void btn_MoveNext_Click(object sender, EventArgs e)
        {
            if (dgv_SelectResult.CurrentCell.RowIndex < dgv_SelectResult.RowCount - 1)
            {
                this.dgv_SelectResult.CurrentCell = this.dgv_SelectResult[this.dgv_SelectResult.CurrentCell.ColumnIndex, this.dgv_SelectResult.CurrentCell.RowIndex + 1];

                txt_Inputid.Text = dgv_SelectResult.CurrentRow.Cells[1].Value.ToString().Trim();
                txt_inputDate.Text = Convert.ToDateTime(dgv_SelectResult.CurrentRow.Cells[9].Value.ToString().Trim()).ToShortDateString();
                txt_batchNum.Text = dgv_SelectResult.CurrentRow.Cells[8].Value.ToString().Trim();
                lb_status.Text = dgv_SelectResult.CurrentRow.Cells[11].Value.ToString().Trim();
            }
        }

        private void btn_MoveFirst_Click(object sender, EventArgs e)
        {
            this.dgv_SelectResult.CurrentCell = this.dgv_SelectResult[this.dgv_SelectResult.CurrentCell.ColumnIndex, 0];

            txt_Inputid.Text = dgv_SelectResult.CurrentRow.Cells[1].Value.ToString().Trim();
            txt_inputDate.Text = Convert.ToDateTime(dgv_SelectResult.CurrentRow.Cells[9].Value.ToString().Trim()).ToShortDateString();
            txt_batchNum.Text = dgv_SelectResult.CurrentRow.Cells[8].Value.ToString().Trim();
            lb_status.Text = dgv_SelectResult.CurrentRow.Cells[11].Value.ToString().Trim();
        }

        private void btn_MoveLast_Click(object sender, EventArgs e)
        {
            this.dgv_SelectResult.CurrentCell = this.dgv_SelectResult[this.dgv_SelectResult.CurrentCell.ColumnIndex, this.dgv_SelectResult.RowCount - 1];

            txt_Inputid.Text = dgv_SelectResult.CurrentRow.Cells[1].Value.ToString().Trim();
            txt_inputDate.Text = Convert.ToDateTime(dgv_SelectResult.CurrentRow.Cells[9].Value.ToString().Trim()).ToShortDateString();
            txt_batchNum.Text = dgv_SelectResult.CurrentRow.Cells[8].Value.ToString().Trim();
            lb_status.Text = dgv_SelectResult.CurrentRow.Cells[11].Value.ToString().Trim();
        }

        private void dgv_SelectResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_SelectResult.RowCount > 0)
            {
                if (e.ColumnIndex == 11)
                {
                    if (dgv_SelectResult.Rows[e.RowIndex].Cells[11].Value.ToString().Trim() == "有效")
                    {
                        dgv_SelectResult.Rows[e.RowIndex].Cells[11].Value = "无效";
                        ProductStock_RecordUpdate();
                    }
                    else
                    {
                        dgv_SelectResult.Rows[e.RowIndex].Cells[11].Value = "有效";
                        ProductStock_RecordUpdate();
                    }
                }
            }
        }

        //单条产品记录状态修改及库存数量更新
        private void ProductStock_RecordUpdate()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();

            try
            {
                string sqlstr = "UPDATE `product_input` SET Record_status = @Record_status WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlstr;

                cmd.Parameters.AddWithValue("@id", dgv_SelectResult.CurrentRow.Cells[0].Value.ToString().Trim());
                cmd.Parameters.AddWithValue("@Record_status", dgv_SelectResult.CurrentRow.Cells[11].Value.ToString().Trim());
                cmd.ExecuteNonQuery();

                string sqlstrA = "";
                if (dgv_SelectResult.CurrentRow.Cells[11].Value.ToString().Trim() == "有效")
                {
                    sqlstrA = "UPDATE `product_stock` SET Product_stock = Product_stock + @Product_stock WHERE Proid = @Proid";
                }
                else
                {
                    sqlstrA = "UPDATE `product_stock` SET Product_stock = Product_stock - @Product_stock WHERE Proid = @Proid";
                }
                cmd.CommandText = sqlstrA;
                cmd.Parameters.AddWithValue("@Proid", dgv_SelectResult.CurrentRow.Cells[2].Value.ToString().Trim());
                cmd.Parameters.AddWithValue("@Product_stock", Convert.ToDecimal(dgv_SelectResult.CurrentRow.Cells[7].Value.ToString().Trim()));
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
                if (conn.State != ConnectionState.Closed)
                {
                    transaction.Commit();
                    conn.Close();
                    MessageBox.Show("数据已保存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
