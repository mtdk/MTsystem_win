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
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }


        private void Frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsmi_mat_Receive_Click(object sender, EventArgs e)
        {

            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 206)
            {
                if (userInfocheck._Uspowerid == 100 || userInfocheck._Uspowerid == 101 || userInfocheck._Uspowerid == 102)
                {
                    Frm_chejian frm_cj = new Frm_chejian();
                    frm_cj.MdiParent = this;
                    frm_cj.Show();
                }
                else
                {
                    MessageBox.Show("你不能操作这个功能！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("你不是这个部门的操作人员！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
