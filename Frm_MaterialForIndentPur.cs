using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using MTsystem_win.allClass;

namespace MTsystem_win
{
    public partial class Frm_MaterialForIndentPur : Form
    {
        public Frm_MaterialForIndentPur()
        {
            InitializeComponent();
        }

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        public string MaInID;
        public string MaID;
        //public string MaID_B;
        public string MaName;
        public string MaPrice;
        public string MaUnit;

        private void Frm_MaterialForIndentPur_Load(object sender, EventArgs e)
        {
            MaterialList();
            dgvMaterialList.DataSource = ds_Queryresult.Tables["material"];
            dgvHeadTextSet();
        }

        private void MaterialList()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            string sqlstr = "SELECT id,Matid,Material_id,Material_name,Material_price,Material_Unit,";
            sqlstr += "Material_status FROM material ORDER BY ID ASC";
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
            msda.Fill(ds_Queryresult, "material");

            dv_Queryresult.Table = ds_Queryresult.Tables["material"];
            dgvMaterialList.DataSource = dv_Queryresult.ToTable("material");
            conn.Close();
        }

        private void txtMaterialName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (txtMaterialName.Text.Trim().Length == 0)
                {
                    dgvMaterialList.DataSource = null;
                    dv_Queryresult.Table = ds_Queryresult.Tables["material"];
                    dv_Queryresult.RowFilter = null;
                    dgvMaterialList.DataSource = dv_Queryresult.ToTable();
                    dgvHeadTextSet();
                }
                else
                {
                    dgvMaterialList.DataSource = null;
                    dv_Queryresult.Table = ds_Queryresult.Tables["material"];
                    dv_Queryresult.RowFilter = "Material_Name like'%" + txtMaterialName.Text.Trim() + "%'";
                    dgvMaterialList.DataSource = dv_Queryresult.ToTable();
                    dgvHeadTextSet();
                }
            }
        }

        private void dgvHeadTextSet()
        {
            this.dgvMaterialList.Columns[0].HeaderText = "序号";
            this.dgvMaterialList.Columns[1].HeaderText = "系统号";
            this.dgvMaterialList.Columns[2].HeaderText = "编号";
            this.dgvMaterialList.Columns[3].HeaderText = "名称(原)";
            this.dgvMaterialList.Columns[4].HeaderText = "单价";
            this.dgvMaterialList.Columns[5].HeaderText = "单位";
            this.dgvMaterialList.Columns[6].HeaderText = "状态";
            this.dgvMaterialList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvMaterialList.AutoResizeColumnHeadersHeight();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ds_Queryresult.Clear();
            MaterialList();
            dgvMaterialList.DataSource = ds_Queryresult.Tables["material"];
            dgvHeadTextSet();
        }

        private void dgvMaterialList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMaterialList.Rows.Count > 0)
                {
                    if (dgvMaterialList.SelectedCells[6].Value.ToString().Trim() == "有效")
                    {
                        MaInID = dgvMaterialList.SelectedCells[1].Value.ToString().Trim();
                        MaID = dgvMaterialList.SelectedCells[2].Value.ToString().Trim();
                        MaName = dgvMaterialList.SelectedCells[3].Value.ToString().Trim();
                        MaPrice = dgvMaterialList.SelectedCells[4].Value.ToString().Trim();
                        MaUnit = dgvMaterialList.SelectedCells[5].Value.ToString().Trim();
                    }
                    else
                    {
                        MessageBox.Show("原材料状态为'无效'，不能进行采购！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            finally
            {
                this.Close();
                //Mcc.FlushMemory();
                this.Dispose();
                //GC.Collect();
            }
            
        }

    }
}
