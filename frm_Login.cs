﻿using System;
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
            try
            {
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR.Trim());
                conn.Open();
                string sqlStr = "SELECT * FROM user WHERE userid='" + txt_Userid.Text.Trim() + "' AND userPwd='" + txt_Userpwd.Text.Trim() + "'";

                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dr.Read();
                if (dr.HasRows)
                {
                    userInfocheck._Usid = txt_Userid.Text.Trim();
                    userInfocheck._Usname = dr[2].ToString().Trim();
                    userInfocheck._Uspwd = txt_Userpwd.Text.Trim();
                    userInfocheck._Usdepartmentid = Convert.ToInt16(dr[4].ToString().Trim());
                    userInfocheck._Uspowerid = Convert.ToInt16(dr[5].ToString().Trim());
                    Frm_main frm_main = new Frm_main();
                    frm_main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
