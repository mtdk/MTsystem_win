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
    public partial class Frm_product_taginput : Form
    {
        public Frm_product_taginput()
        {
            InitializeComponent();
        }

        private void txt_Productid_DoubleClick(object sender, EventArgs e)
        {
            Frm_productSelect frmps = new Frm_productSelect();
            frmps.ShowDialog();
        }

        private void dgv_tagprint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_tagprint.RowCount > 0)
            {
                Frm_tag_print frmtp = new Frm_tag_print();
                frmtp.ShowDialog();
                frmtp.productid = dgv_tagprint.SelectedCells[1].Value.ToString().Trim();
            }
        }

        private void btn_Saveprint_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Productid.Text = "";
            txt_ProductName.Text = "";
            dtp_Productdate.Value = DateTime.Now;
            txt_Unit.Text = "";
            txt_batchNum.Text = "";
            txt_Shelflife.Text = "6个月";
        }
    }
}
