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

        private void sys_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmi_mat_Receive_Click(object sender, EventArgs e)
        {
            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 206)
            {
                if (userInfocheck._Uspowerid == 100 || userInfocheck._Uspowerid == 101 || userInfocheck._Uspowerid == 102)
                {
                    if (frmShowstatus._Frmclly == "CLOSE" || frmShowstatus._Frmclly == null)
                    {
                        Frm_cailiaolingyong frm_clly = new Frm_cailiaolingyong();
                        frm_clly.MdiParent = this;
                        //frm_clly.WindowState = FormWindowState.Maximized;
                        frm_clly.Show();
                    }
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

        private void tsmi_mat_In_Click(object sender, EventArgs e)
        {
            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 209)
            {
                if (userInfocheck._Uspowerid == 100 || userInfocheck._Uspowerid == 101 || userInfocheck._Uspowerid == 102)
                {
                    if (frmShowstatus._Frmcljc == "CLOSE" || frmShowstatus._Frmcljc == null)
                    {
                        Frm_cailiaojincang frm_cljc = new Frm_cailiaojincang();
                        frm_cljc.MdiParent = this;
                        //frm_cljc.WindowState = FormWindowState.Maximized;
                        frm_cljc.Show();
                    }
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

        private void pro_info_input_Click(object sender, EventArgs e)
        {
            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 206)
            {
                if (userInfocheck._Uspowerid == 100 || userInfocheck._Uspowerid == 101 || userInfocheck._Uspowerid == 102)
                {
                    if (frmShowstatus._Frmproductinfo == "CLOSE" || frmShowstatus._Frmproductinfo == null)
                    {
                        Frm_product_info frmpinfo = new Frm_product_info();
                        frmpinfo.MdiParent = this;
                        frmpinfo.Show();
                    }
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

        private void mat_Basestock_Click(object sender, EventArgs e)
        {
            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 209)
            {
                if (userInfocheck._Uspowerid == 100 || userInfocheck._Uspowerid == 101 || userInfocheck._Uspowerid == 102)
                {
                    if (frmShowstatus._Frmbsin == "CLOSE" || frmShowstatus._Frmbsin == null)
                    {
                        Frm_matbaseinput frm_bsin = new Frm_matbaseinput();
                        frm_bsin.MdiParent = this;
                        //frm_bsin.WindowState = FormWindowState.Maximized;
                        frm_bsin.Show();
                    }
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

        private void mat_stock_Report_Click(object sender, EventArgs e)
        {
            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 209)
            {
                if (userInfocheck._Uspowerid == 100 || userInfocheck._Uspowerid == 101 || userInfocheck._Uspowerid == 102)
                {
                    if (frmShowstatus._Frmsrv == "CLOSE" || frmShowstatus._Frmsrv == null)
                    {
                        Frm_mat_stockReportview frm_msrv = new Frm_mat_stockReportview();
                        frm_msrv.MdiParent = this;
                        frm_msrv.Show();
                    }
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

        private void mat_Dayreport_Click(object sender, EventArgs e)
        {
            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 209)
            {
                if (userInfocheck._Uspowerid == 100 || userInfocheck._Uspowerid == 101 || userInfocheck._Uspowerid == 102)
                {
                    if (frmShowstatus._Frdmsrv == "CLOSE" || frmShowstatus._Frdmsrv == null)
                    {
                        Frm_mat_dayReportview frm_dmsr = new Frm_mat_dayReportview();
                        frm_dmsr.MdiParent = this;
                        frm_dmsr.Show();
                    }
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

        private void tsmi_mat_ReceiveQuery_Click(object sender, EventArgs e)
        {
            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 206)
            {
                if (userInfocheck._Uspowerid == 100 || userInfocheck._Uspowerid == 101 || userInfocheck._Uspowerid == 102)
                {
                    if (frmShowstatus._Frmatinputquery == "CLOSE" || frmShowstatus._Frmatinputquery == null)
                    {
                        Frm_mat_input_query frm_miq = new Frm_mat_input_query();
                        frm_miq.MdiParent = this;
                        frm_miq.Show();
                    }
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

        private void tag_Item_Click(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmptag=="CLOSE"||frmShowstatus._Frmptag==null)
            {
                Frm_product_taginput frm_ptag = new Frm_product_taginput();
                frm_ptag.MdiParent = this;
                frm_ptag.Show();
            }
        }
    }
}