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

        private void Frm_customerinfo_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmcustorminfo == "CLOSE" || frmShowstatus._Frmcustorminfo == null)
            {
                frmShowstatus._Frmcustorminfo = "OPEN";
                NewCusid();
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
                txt_cusName_A.Focus();
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
                    txt_cusId_A.Text = string.Format("C{0}", MaxID.ToString().PadLeft(4, '0'));
                }
                else
                {
                    MaxID = 1;
                    txt_cusId_A.Text = string.Format("C{0}", MaxID.ToString().PadLeft(4, '0'));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_A_Click(object sender, EventArgs e)
        {
            if (txt_cusId_A.Text.Trim().Length == 0)
            {
                MessageBox.Show("客户代码不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_cusName_A.Text.Trim().Length == 0)
            {
                MessageBox.Show("客户名称不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_cusName_A.Focus();
            }
            else if (txt_cusAdd_A.Text.Trim().Length == 0)
            {
                MessageBox.Show("客户地址不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_cusAdd_A.Focus();
            }
            else
            {

            }
        }

    }
}
