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

        #region 车间
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

        private void tsmi_mat_ReceiveQuery_Click(object sender, EventArgs e)
        {
            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 206)
            {
                if (userInfocheck._Uspowerid == 100 || userInfocheck._Uspowerid == 101 || userInfocheck._Uspowerid == 102)
                {
                    if (frmShowstatus._Frmatouttquery == "CLOSE" || frmShowstatus._Frmatouttquery == null)
                    {
                        Frm_mat_out_query frm_miq = new Frm_mat_out_query();
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

        private void tsmi_mat_Givbackquery_Click(object sender, EventArgs e)
        {
            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 206)
            {
                if (userInfocheck._Uspowerid == 100 || userInfocheck._Uspowerid == 101 || userInfocheck._Uspowerid == 102)
                {
                    if (frmShowstatus._FrmmatgiveBackQuery == "CLOSE" || frmShowstatus._FrmmatgiveBackQuery == null)
                    {
                        Frm_matGivbackquery frm_mgvq = new Frm_matGivbackquery();
                        frm_mgvq.MdiParent = this;
                        frm_mgvq.Show();
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
        #endregion

        #region 仓库
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
            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 209)
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

        private void mat_giveback_Click(object sender, EventArgs e)
        {
            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 209)
            {
                if (userInfocheck._Uspowerid == 100 || userInfocheck._Uspowerid == 101 || userInfocheck._Uspowerid == 102)
                {
                    if (frmShowstatus._Frmmatconfirm == "CLOSE" || frmShowstatus._Frmmatconfirm == null)
                    {
                        Frm_mat_confirm frmmatconfirm = new Frm_mat_confirm();
                        frmmatconfirm.MdiParent = this;
                        frmmatconfirm.Show();
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

        private void mat_returnPurchase_Click(object sender, EventArgs e)
        {
            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 209)
            {
                if (userInfocheck._Uspowerid == 100 || userInfocheck._Uspowerid == 101 || userInfocheck._Uspowerid == 102)
                {
                    if (frmShowstatus._Frmmatreturngoods == "CLOSE" || frmShowstatus._Frmmatreturngoods == null)
                    {
                        Frm_mat_returnGoods frmmatreturngoods = new Frm_mat_returnGoods();
                        frmmatreturngoods.MdiParent = this;
                        frmmatreturngoods.Show();
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

        private void cus_info_input_Click(object sender, EventArgs e)
        {
            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 209)
            {
                if (userInfocheck._Uspowerid == 100 || userInfocheck._Uspowerid == 101 || userInfocheck._Uspowerid == 102)
                {
                    if (frmShowstatus._Frmcustorminfo == "CLOSE" || frmShowstatus._Frmcustorminfo == null)
                    {
                        Frm_customerinfo frmcustomerinfo = new Frm_customerinfo();
                        frmcustomerinfo.MdiParent = this;
                        frmcustomerinfo.Show();
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
        #endregion

        #region 采购菜单
        private void purchaseInfor_Click(object sender, EventArgs e)
        {
            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 203)
            {
                if (userInfocheck._Uspowerid == 100 || userInfocheck._Uspowerid == 101 || userInfocheck._Uspowerid == 102)
                {

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

        private void supplierInfor_Click(object sender, EventArgs e)
        {
            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 203)
            {
                if (userInfocheck._Uspowerid == 100 || userInfocheck._Uspowerid == 101 || userInfocheck._Uspowerid == 102)
                {
                    if (frmShowstatus._Fsupinfo == "CLOSE" || frmShowstatus._Fsupinfo == null)
                    {
                        Frm_Supplier_info frmsupinfo = new Frm_Supplier_info();
                        frmsupinfo.MdiParent = this;
                        frmsupinfo.Show();
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

        private void purchaseOrder_Click(object sender, EventArgs e)
        {
            if (userInfocheck._Usdepartmentid == 200 || userInfocheck._Usdepartmentid == 201 || userInfocheck._Usdepartmentid == 203)
            {
                if (userInfocheck._Uspowerid == 100 || userInfocheck._Uspowerid == 101 || userInfocheck._Uspowerid == 102)
                {

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
        #endregion

        #region 标签打印
        private void tag_Item_Click(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmptag == "CLOSE" || frmShowstatus._Frmptag == null)
            {
                Frm_product_taginput frm_ptag = new Frm_product_taginput();
                frm_ptag.MdiParent = this;
                frm_ptag.Show();
            }
        }
        #endregion

        #region 退出系统
        private void sys_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}