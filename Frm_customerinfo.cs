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
    public partial class Frm_customerinfo : Form
    {
        public Frm_customerinfo()
        {
            InitializeComponent();
        }

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();


        private void Frm_customerinfo_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmcustorminfo == "CLOSE" || frmShowstatus._Frmcustorminfo == null)
            {
                frmShowstatus._Frmcustorminfo = "OPEN";
                NewCusid();
                txt_cusName.Focus();
            }
        }

        private void Frm_customerinfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmcustorminfo = "CLOSE";
        }

        /// <summary>
        /// 生成新客户编号
        /// </summary>
        private void NewCusid()
        {
            try
            {
                int MaxID = 0;
                txt_cusName.Focus();
                string strsql = "SELECT id,Cus_id FROM customers ORDER BY id DESC LIMIT 1";
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(strsql, conn);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dr.Read();
                if (dr.HasRows)
                {
                    MaxID = Convert.ToInt32(dr["Cus_id"].ToString().Substring(1, 4).ToString());
                    MaxID++;
                    txt_cusId.Text = string.Format("C{0}", MaxID.ToString().PadLeft(4, '0'));
                }
                else
                {
                    MaxID = 1;
                    txt_cusId.Text = string.Format("C{0}", MaxID.ToString().PadLeft(4, '0'));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdb_CusInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_CusUpdate.Checked == true)
            {
                label8.Visible = true;
                txt_CusNameQuery.Visible = true;
                btn_Select.Visible = true;
                txt_cusId.Text = "";
                txt_CusNameQuery.Focus();
            }
            else
            {
                label8.Visible = false;
                txt_CusNameQuery.Visible = false;
                btn_Select.Visible = false;
                NewCusid();
            }
        }

        private void rdb_CusUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_CusUpdate.Checked == true)
            {
                label8.Visible = true;
                txt_CusNameQuery.Visible = true;
                btn_Select.Visible = true;
                txt_cusId.Text = "";
                txt_CusNameQuery.Focus();
            }
            else
            {
                label8.Visible = false;
                txt_CusNameQuery.Visible = false;
                btn_Select.Visible = false;
                NewCusid();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_cusId.Text.Trim().Length == 0)
            {
                MessageBox.Show("客户代码不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_cusName.Text.Trim().Length == 0)
            {
                MessageBox.Show("客户名称不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_cusName.Focus();
            }
            else
            {
                if (rdb_CusInsert.Checked == true)
                {
                    //状态为添加客户信息时执行
                }
                else
                {
                    //状态为更新客户信息时执行
                }
            }
        }

        //客户信息添加
        private void CusInfor_insert()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                string strsql = "INSERT INTO `customers` VALUES(NULL,@Cus_id,@Cus_name,@Cus_add,@Cus_contact,@Cus_mobile,@Cus_telephone,@Cus_fax,NULL)";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = strsql;
                cmd.Parameters.AddWithValue("@Cus_id", txt_cusId.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_name", txt_cusName.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_add", txt_cusAdd.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_contact", txt_Contact.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_mobile", txt_MobilePhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_telephone", txt_Telephone.Text.Trim());
                cmd.Parameters.AddWithValue("@Cus_fax", txt_Fax.Text.Trim());
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
