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
    public partial class Frm_product_input : Form
    {
        public Frm_product_input()
        {
            InitializeComponent();
        }

        JudgeNumber jnum = new JudgeNumber();

        private void Frm_product_input_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Frmproductinput == "CLOSE" || frmShowstatus._Frmproductinput == null)
            {
                frmShowstatus._Frmproductinput = "OPEN";
                newInputid();
                txt_inputDate.Text = txt_Inputid.Text.Substring(0, 8).Trim();
            }
        }

        private void Frm_product_input_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Frmproductinput = "CLOSE";
        }

        /// <summary>
        /// 产生进仓单号
        /// </summary>
        private void newInputid()
        {
            txt_Inputid.Text = DateTime.Now.Year.ToString().Trim();
            txt_Inputid.Text += DateTime.Now.Month.ToString().PadLeft(2,'0').Trim();
            txt_Inputid.Text += DateTime.Now.Day.ToString().PadLeft(2,'0').Trim();
            txt_Inputid.Text += DateTime.Now.Hour.ToString().PadLeft(2,'0').Trim();
            txt_Inputid.Text += DateTime.Now.Minute.ToString().PadLeft(2,'0').Trim();
            txt_Inputid.Text += DateTime.Now.Second.ToString().PadLeft(2,'0').Trim();
        }

        /// <summary>
        /// 添加数据到datagridview
        /// </summary>
        private void tempDateInsert()
        {
            DataGridViewRow Row = new DataGridViewRow();
            Row.CreateCells(dgv_inputView);
            Row.Cells[0].Value = txt_proId.Text.Trim();
            Row.Cells[1].Value = txt_productId.Text.Trim();
            Row.Cells[2].Value = txt_productName.Text.Trim();
            Row.Cells[3].Value = txt_inputNum.Text.Trim();
            Row.Cells[4].Value = txt_inputUnit.Text.Trim();
            Row.Cells[5].Value = txt_inputWeight.Text.Trim();
            dgv_inputView.Rows.Add(Row);

            sumTotalcount();
            ctrlClear();
        }

        /// <summary>
        /// 总数量和总重量统计
        /// </summary>
        private void sumTotalcount()
        {
            decimal sumTotalweight = 0;
            int sumTotalnumber = 0;
            for (int i = 0; i < dgv_inputView.RowCount; i++)
            {
                sumTotalnumber += Convert.ToInt32(dgv_inputView.Rows[i].Cells[3].Value.ToString().Trim());
                sumTotalweight += Convert.ToDecimal(dgv_inputView.Rows[i].Cells[5].Value.ToString().Trim());
            }
            label11.Text = sumTotalnumber.ToString();
            label13.Text = sumTotalweight.ToString();
        }

        /// <summary>
        /// 清空控件数据
        /// </summary>
        private void ctrlClear()
        {
            txt_proId.Text = "";
            txt_productId.Text = "";
            txt_productName.Text = "";
            txt_inputNum.Text = "";
            txt_inputUnit.Text = "";
            txt_inputWeight.Text = "";
            txt_productId.Focus();
        }

        private void txt_inputDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (!jnum.IntegralNumber(txt_inputDate.Text.Trim()))
                {
                    MessageBox.Show("格式错误，这个位置只能输入数字，如：20210101", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_inputDate.Focus();
                    txt_inputDate.SelectAll();
                }
                else
                {
                    txt_batchNum.Focus();
                }
            }
        }

        private void txt_inputDate_Leave(object sender, EventArgs e)
        {
            if (!jnum.IntegralNumber(txt_inputDate.Text.Trim()))
            {
                MessageBox.Show("格式错误，这个位置只能输入数字，如：20210101", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_inputDate.Focus();
                txt_inputDate.SelectAll();
            }
        }

        private void txt_batchNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
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
                    Frm_productSelect_A frmproductselecta = new Frm_productSelect_A();
                    frmproductselecta.Querycondition = txt_productId.Text.Trim();
                    frmproductselecta.ShowDialog();
                    if (frmproductselecta.pro_id!=null)
                    {
                        txt_proId.Text=frmproductselecta.pro_id.Trim();
                        txt_productId.Text = frmproductselecta.product_id.Trim();
                        txt_productName.Text = frmproductselecta.product_name.Trim();
                        txt_inputUnit.Text = frmproductselecta.product_unit.Trim();
                        txt_inputNum.Focus();
                    }
                }
            }
        }

        private void txt_inputNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (txt_inputNum.Text.Trim().Length != 0)
                {
                    if (!jnum.IntegralNumber(txt_inputNum.Text.Trim()))
                    {
                        MessageBox.Show("格式错误，这个位置只能输入大于0的整数，如：20", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_inputNum.Focus();
                        txt_inputNum.SelectAll();
                    }
                    else if ((Convert.ToInt32(txt_inputNum.Text.Trim())) <= 0)
                    {
                        MessageBox.Show("请输入大于0的整数，如：20", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txt_inputNum.Focus();
                        txt_inputNum.SelectAll();
                    }
                    else
                    {
                        txt_inputWeight.Text = (Convert.ToInt32(txt_inputNum.Text.Trim()) * Convert.ToDecimal(txt_inputUnit.Text.Trim())).ToString().Trim();
                        txt_inputUnit.Focus();
                    }
                }
            }
        }

        private void txt_inputNum_Leave(object sender, EventArgs e)
        {
            if (txt_inputNum.Text.Trim().Length != 0)
            {
                if (!jnum.IntegralNumber(txt_inputNum.Text.Trim()))
                {
                    MessageBox.Show("格式错误，这个位置只能输入大于0的整数，如：20", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_inputNum.Focus();
                    txt_inputNum.SelectAll();
                }
                else if ((Convert.ToInt32(txt_inputNum.Text.Trim())) <= 0)
                {
                    MessageBox.Show("请输入大于0的整数，如：20", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_inputNum.Focus();
                    txt_inputNum.SelectAll();
                }
                else
                {
                    txt_inputWeight.Text = (Convert.ToInt32(txt_inputNum.Text.Trim()) * Convert.ToDecimal(txt_inputUnit.Text.Trim())).ToString().Trim();
                }
            }
        }

        private void txt_inputUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (txt_inputUnit.Text.Trim().Length != 0)
                {
                    if (!jnum.ISNumeric(txt_inputUnit.Text.Trim()))
                    {
                        MessageBox.Show("格式错误，这个位置只能输入大于0的数字，如：20,20.1", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_inputUnit.Focus();
                        txt_inputUnit.SelectAll();
                    }
                    else if ((Convert.ToDecimal(txt_inputUnit.Text.Trim())) <= 0)
                    {
                        MessageBox.Show("请输入大于0的数字，如：20,20.1", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txt_inputUnit.Focus();
                        txt_inputUnit.SelectAll();
                    }
                    else
                    {
                        txt_inputWeight.Text = (Convert.ToInt32(txt_inputNum.Text.Trim()) * Convert.ToDecimal(txt_inputUnit.Text.Trim())).ToString().Trim();
                        txt_inputWeight.Focus();
                    }
                }
            }
        }

        private void txt_inputUnit_Leave(object sender, EventArgs e)
        {
            if (txt_inputUnit.Text.Trim().Length != 0)
            {
                if (!jnum.ISNumeric(txt_inputUnit.Text.Trim()))
                {
                    MessageBox.Show("格式错误，这个位置只能输入大于0的数字，如：20,20.1", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_inputUnit.Focus();
                    txt_inputUnit.SelectAll();
                }
                else if ((Convert.ToDecimal(txt_inputUnit.Text.Trim())) <= 0)
                {
                    MessageBox.Show("请输入大于0的数字，如：20,20.1", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_inputUnit.Focus();
                    txt_inputUnit.SelectAll();
                }
                else
                {
                    txt_inputWeight.Text = (Convert.ToInt32(txt_inputNum.Text.Trim()) * Convert.ToDecimal(txt_inputUnit.Text.Trim())).ToString().Trim();
                }
            }
        }

        private void txt_inputWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (txt_Inputid.Text.Trim().Length==0)
                {
                    MessageBox.Show("进仓记录号不能为空！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txt_inputDate.Text.Trim().Length==0)
                {
                    MessageBox.Show("进仓日期不能为空！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_inputDate.Focus();
                }
                else if (txt_proId.Text.Trim().Length == 0)
                {
                    MessageBox.Show("产品系统编码不能为空！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txt_productId.Text.Trim().Length == 0)
                {
                    MessageBox.Show("产品编号不能为空！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_productId.Focus();
                }
                else if (txt_productName.Text.Trim().Length==0)
                {
                    MessageBox.Show("产品名称不能为空！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_productId.Focus();
                }
                else if (txt_inputNum.Text.Trim().Length == 0)
                {
                    MessageBox.Show("产品数量不能为空！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_inputNum.Focus();
                }
                else if (txt_inputUnit.Text.Trim().Length == 0)
                {
                    MessageBox.Show("产品规格不能为空！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_inputUnit.Focus();
                }
                else
                {
                    tempDateInsert();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_Inputid.Text.Trim().Length == 0)
            {
                MessageBox.Show("进仓记录号不能为空！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_inputDate.Text.Trim().Length == 0)
            {
                MessageBox.Show("进仓日期不能为空！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_inputDate.Focus();
            }
            else if (txt_proId.Text.Trim().Length == 0)
            {
                MessageBox.Show("产品系统编码不能为空！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_productId.Text.Trim().Length == 0)
            {
                MessageBox.Show("产品编号不能为空！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_productId.Focus();
            }
            else if (txt_productName.Text.Trim().Length == 0)
            {
                MessageBox.Show("产品名称不能为空！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_productId.Focus();
            }
            else if (txt_inputNum.Text.Trim().Length == 0)
            {
                MessageBox.Show("产品数量不能为空！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_inputNum.Focus();
            }
            else if (txt_inputUnit.Text.Trim().Length == 0)
            {
                MessageBox.Show("产品规格不能为空！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_inputUnit.Focus();
            }
            else
            {
                tempDateInsert();
            }
        }

        private void dgv_inputView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgv_inputView.Rows.Count > 0)
            {
                sumTotalcount();
            }
            else
            {
                label11.Text = "0";
                label13.Text = "0";
            }
        }


    }
}
