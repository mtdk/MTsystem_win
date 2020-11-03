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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();


        }
        userInfocheck uCheck = new userInfocheck();

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text.Trim().Length == 0)
            {
                MessageBox.Show("用户名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Username.Focus();

            }
            else if (txt_Userpwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("用户密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Userpwd.Focus();
            }
            else
            {
                //执行用户名、密码验证方法
                uCheck._usname = txt_Username.Text.Trim();
                uCheck._uspwd = txt_Userpwd.Text.Trim();
                if (uCheck.usCheck(uCheck._usname, uCheck._uspwd) == 0)
                {
                    go();
                }
                else if (uCheck.usCheck(uCheck._usname, uCheck._uspwd) == 1)
                {
                    MessageBox.Show("用户名只能输入字母和数字！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("密码不能用中文！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void go()
        {
            MySqlConnection conn;
            string connstr = "server=127.0.0.1;uid=root;pwd=1;database=test;";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connstr;
                conn.Open();
                string sqlStr = "select * from user where userid='" + txt_Username.Text.Trim() + "' and userPwd='" + txt_Userpwd.Text.Trim() + "'";

                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("Not");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
