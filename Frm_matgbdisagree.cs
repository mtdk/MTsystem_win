using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MTsystem_win
{
    public partial class Frm_matgbdisagree : Form
    {
        public Frm_matgbdisagree()
        {
            InitializeComponent();
        }

        public string Reasons = string.Empty;

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_gbdisagreeReason.Text.Trim().Length==0)
            {
                MessageBox.Show("原因不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_gbdisagreeReason.Focus();
            }
            else
            {
                Reasons = txt_gbdisagreeReason.Text.Trim();
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Reasons = string.Empty;
            this.Close();
        }

        private void txt_gbdisagreeReason_TextChanged(object sender, EventArgs e)
        {
            if (txt_gbdisagreeReason.Text.Length==30)
            {
                MessageBox.Show("输入字符长度不能超过30个字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
