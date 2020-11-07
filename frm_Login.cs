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

        //数据库链接
        dbconnectstr dbc=new dbconnectstr();
        //用户信息存储

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Userid.Text.Trim().Length == 0)
            {
                MessageBox.Show("用户名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Userid.Focus();

            }
            else if (txt_Userpwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("用户密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Userpwd.Focus();
            }
            else
            {
                go();
            }
        }

        #region
        /// <summary>
        /// 用户登录验证
        /// </summary>
        private void go()
        {
                string sqlStr = "select * from user where userid='" + txt_Userid.Text.Trim() + "' and userPwd='" + txt_Userpwd.Text.Trim() + "'";

                MySqlCommand cmd = new MySqlCommand(sqlStr, dbc.getCon());
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    userInfocheck._Usid = txt_Userid.Text.Trim();
                    userInfocheck._Uspwd = txt_Userpwd.Text.Trim();
                    userInfocheck._Usdepartmentid = Convert.ToInt16(dr[4].ToString().Trim());
                    userInfocheck._Uspowerid = Convert.ToInt16(dr[5].ToString().Trim());
                    Frm_main frm_main = new Frm_main();
                    frm_main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新输入！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                dbc._getClose();
        }
        #endregion

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_Userpwd.Focus();
            }
        }

        private void txt_Userpwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btn_Login.Focus();
            }
        }

    }
}
