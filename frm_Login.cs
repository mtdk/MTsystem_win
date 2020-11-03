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

            MySqlConnection conn;
            string connstr = "server=127.0.0.1;uid=root;pwd=1;database=qhdatabase;";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connstr;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        userInfocheck usCheck = new userInfocheck();

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(txt_Username.Text.Trim().Length==0)
            {
                MessageBox.Show("用户名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Username.Focus();

            }else if(txt_Userpwd.Text.Trim().Length==0)
            {
                MessageBox.Show("用户密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Userpwd.Focus();
            }
            else
            {
                //执行用户名、密码验证方法
                //if(uCheck.usCheck(txt_Username.Text.Trim(),txt_Userpwd.Text.Trim()))
                //{
                //    MessageBox.Show("登录验证成功！");
                //}
                //else
                //{
                //    MessageBox.Show("登录验证失败了！");
                //}
                usCheck._usname = txt_Username.Text.Trim();
                usCheck._uspwd = txt_Userpwd.Text.Trim();
                
                if(usCheck.usCheck(usCheck._usname,usCheck._uspwd))
                {
                    MessageBox.Show("登录验证成功！");
                }
                else
                {
                    MessageBox.Show("登录验证失败了！");
                }
            }
        }

        

    }
}
