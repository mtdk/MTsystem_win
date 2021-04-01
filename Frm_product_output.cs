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
    public partial class Frm_product_output : Form
    {
        public Frm_product_output()
        {
            InitializeComponent();
        }

        JudgeNumber jnum = new JudgeNumber();

        //tmpdt 一个为了迎合用户特殊习惯的不应该出现的垃圾全局变量-1
        public DateTime tmpdt;


        private void Frm_product_output_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmproductoutput == "CLOSE" || frmShowstatus._Frmproductoutput == null)
            {
                frmShowstatus._Frmproductoutput = "OPEN";
                newOutputid();
            }
        }

        private void Frm_product_output_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmproductoutput = "CLOSE";
        }

        /// <summary>
        /// 产品出库单号
        /// </summary>
        private void newOutputid()
        {
            txt_outputDate.Text = DateTime.Now.Year.ToString().Trim();
            txt_outputDate.Text += DateTime.Now.Month.ToString().PadLeft(2, '0').Trim();
            txt_outputDate.Text += DateTime.Now.Day.ToString().PadLeft(2, '0').Trim();
            txt_outputDate.Text += DateTime.Now.Hour.ToString().PadLeft(2, '0').Trim();
            txt_outputDate.Text += DateTime.Now.Minute.ToString().PadLeft(2, '0').Trim();
            txt_outputDate.Text += DateTime.Now.Second.ToString().PadLeft(2, '0').Trim();
            txt_outputDate.Text = txt_outputDate.Text.Substring(0, 8).Trim();

        }

        private void ctrlClear()
        {
            txt_proId.Text = "";
            txt_productId.Text = "";
            txt_productName.Text = "";
            txt_OutputNum.Text = "0";
            txt_OutputUnit.Text = "0";
            txt_OutputWeight.Text = "0";
            txt_Price.Text = "0";
            txt_AmountMoney.Text = "0";
            txt_Remarks.Text = "";
            txt_productId.Focus();

        }

        /// <summary>
        /// 清空所有控件
        /// </summary>
        private void AllClear()
        {
            txt_Cusid.Text = "";
            txt_CusName.Text = "";
            txt_CusName.ReadOnly = false;
            newOutputid();
            txt_outputDate.ReadOnly = false;
            txt_batchNum.Text = "";
            txt_batchNum.ReadOnly = false;
            txt_proId.Text = "";
            txt_productId.Text = "";
            txt_productName.Text = "";
            txt_OutputNum.Text = "";
            txt_OutputUnit.Text = "";
            txt_OutputWeight.Text = "";
            txt_Price.Text = "";
            txt_AmountMoney.Text = "";
            txt_Remarks.Text = "";
            dgv_OutputView.Rows.Clear();
        }

        private void txt_CusName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (txt_CusName.Text.Trim().Length != 0)
                {
                    Frm_CusinfoShow frmcusinfoshow = new Frm_CusinfoShow();
                    frmcusinfoshow.selectCondition = txt_CusName.Text.Trim();
                    frmcusinfoshow.ShowDialog();
                    if (frmcusinfoshow.Cus_id != "")
                    {
                        txt_Cusid.Text = frmcusinfoshow.Cus_id.Trim();
                        txt_CusName.Text = frmcusinfoshow.Cus_name.Trim();
                        txt_outputDate.Focus();
                    }
                }
            }
        }

        private void txt_outputDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_batchNum.Focus();
            }
        }

        private void txt_outputDate_Leave(object sender, EventArgs e)
        {
            if (txt_outputDate.Text.Trim().Length == 0)
            {
                MessageBox.Show("格式错误，此处不能为空，应填入如：20210101", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_outputDate.Focus();
                txt_outputDate.SelectAll();
            }
            else if(!jnum.IntegralNumber(txt_outputDate.Text.Trim()))
            {
                MessageBox.Show("格式错误，这个位置只能输入数字，如：20210101", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_outputDate.Focus();
                txt_outputDate.SelectAll();
            }
            else if (txt_outputDate.Text.Trim().Length != 8)
            {
                MessageBox.Show("格式错误，这个位置只能输入8位数字，如：20210101", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_outputDate.Focus();
                txt_outputDate.SelectAll();
            }
            else
            {
                //tmp 一个为了迎合用户特殊习惯的不应该出现的垃圾全局变量-2
                string tmp;
                tmp = txt_outputDate.Text.Trim().Substring(0, 4) + "-" + txt_outputDate.Text.Trim().Substring(4, 2) + "-" + txt_outputDate.Text.Trim().Substring(6, 2).Trim();

                if (DateTime.TryParse(tmp, out tmpdt))
                {
                    txt_outputDate.ReadOnly = true;
                    txt_batchNum.Focus();
                }
                else
                {
                    MessageBox.Show("格式错误，此处不能为空，应填入如：20210101", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_outputDate.Focus();
                    txt_outputDate.SelectAll();
                }
            }
        }

        private void txt_batchNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_CusName.ReadOnly = true;
                txt_batchNum.ReadOnly = true;
                txt_productId.Focus();
            }
        }

        private void txt_productId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (txt_productId.Text.Trim().Length != 0)
                {
                    Frm_productOutSelect frmpOutselect = new Frm_productOutSelect();
                    frmpOutselect.selectCondition = txt_productId.Text.Trim();
                    frmpOutselect.ShowDialog();
                    if (frmpOutselect.pro_id != "")
                    {
                        txt_proId.Text = frmpOutselect.pro_id.Trim();
                        txt_productId.Text = frmpOutselect.product_id.Trim();
                        txt_productName.Text = frmpOutselect.product_name.Trim();
                        txt_OutputUnit.Text = frmpOutselect.product_unit.Trim();
                        txt_OutputNum.Focus();
                    }

                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        private void txt_OutputNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                e.Handled = true;
                txt_OutputUnit.Focus();
            }
        }

        private void txt_OutputNum_Leave(object sender, EventArgs e)
        {
            if (txt_OutputNum.Text.Trim().Length==0)
            {
                MessageBox.Show("格式错误，这个位置不能为空，请输入如：20的数字", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_OutputNum.Focus();
                txt_OutputNum.SelectAll();
            }
            else if (!jnum.IntegralNumber(txt_OutputNum.Text.Trim()))
            {
                MessageBox.Show("格式错误，这个位置只能输入大于0的整数，如：20", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_OutputNum.Focus();
                txt_OutputNum.SelectAll();
            }
            else if ((Convert.ToInt32(txt_OutputNum.Text.Trim())) <= 0)
            {
                MessageBox.Show("请输入大于0的整数，如：20", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_OutputNum.Focus();
                txt_OutputNum.SelectAll();
            }
            else
            {
                if (txt_OutputUnit.Text.Trim().Length != 0)
                {
                    txt_OutputWeight.Text = (Convert.ToInt32(txt_OutputNum.Text.Trim()) * Convert.ToDecimal(txt_OutputUnit.Text.Trim())).ToString().Trim();
                }
            }
        }

        private void btn_Cancel_B_Click(object sender, EventArgs e)
        {
            ctrlClear();
        }

    }
}
