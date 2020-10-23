using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
            if(txt_Username.Text.Trim().Length==0)
            {
                MessageBox.Show("用户名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Username.Focus();

            }else if(txt_Userpwd.Text.Trim().Length==0)
            {
                MessageBox.Show("用户密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Userpwd.Focus();
            }else
            {
                //执行用户名、密码验证方法
            }
        }

    }
}
