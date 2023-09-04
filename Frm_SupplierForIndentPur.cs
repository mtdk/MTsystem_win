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
    public partial class Frm_SupplierForIndentPur : Form
    {
        public Frm_SupplierForIndentPur()
        {
            InitializeComponent();
        }

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();


        #region 定义传输变量
        /// <summary>
        /// 供应商编号
        /// </summary>
        public string SpID;
        /// <summary>
        /// 供应商名称
        /// </summary>
        public string SpName;
        ///<summary>
        ///法人代表
        /// </summary>
        public string Spfrdb;
        /// <summary>
        /// 联系人
        /// </summary>
        public string SpMan;
        /// <summary>
        /// 移动电话
        /// </summary>
        public string SpMobilePhone;
        /// <summary>
        /// 联系电话
        /// </summary>
        public string SpPhone;
        /// <summary>
        /// 传真
        /// </summary>
        public string SpFax;
        /// <summary>
        /// 通信地址
        /// </summary>
        public string SpAddress;
        /// <summary>
        /// 注册地址
        /// </summary>
        public string SpZcAddress;
        /// <summary>
        /// 成立时间
        /// </summary>
        public string SpClTime;
        /// <summary>
        /// 注册资金
        /// </summary>
        public string SpZczj;
        /// <summary>
        /// 员工数
        /// </summary>
        public string SpYgs;
        /// <summary>
        /// 企业性质
        /// </summary>
        public string SpQyxz;
        /// <summary>
        /// 提供产品类型
        /// </summary>
        public string SpTgcplx;
        /// <summary>
        /// 收款账户
        /// </summary>
        public string SpSkzh;
        /// <summary>
        /// 开户行
        /// </summary>
        public string SpKhh;
        /// <summary>
        /// 银行帐号
        /// </summary>
        public string SpYhzh;
        /// <summary>
        /// 付款方式
        /// </summary>
        public string SpPro;

        #endregion

        private void Frm_SupplierForIndentPur_Load(object sender, EventArgs e)
        {
            SupplierSelest();
            dv_Queryresult.Table = ds_Queryresult.Tables["tb_supplierinfor"];
            dgvHeadTextSet();
        }

        private void SupplierSelest()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();

            string sqlstr = "SELECT ID,SupplierID,SupplierName,SupplierFrdb,SupplierLinkMan,";
            sqlstr += "SupplierMobile,SupplierPhone,SupplierFax,SupplierAddress,SupplierZcAddress,";
            sqlstr += "SupplierClTime,SupplierZczj,SupplierYgs,SupplierQyxz,SupplierTgcplx,";
            sqlstr += "SupplierShouKuanZhangHu,SupplierBank,SupplierBankAccountNumber,";
            sqlstr += "SupplierPrompt FROM tb_supplierinfor ORDER BY ID ASC";
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
            msda.Fill(ds_Queryresult, "tb_supplierinfor");

            dv_Queryresult.Table = ds_Queryresult.Tables["tb_supplierinfor"];
            dgvSupplierList.DataSource = dv_Queryresult.ToTable("tb_supplierinfor");
            conn.Close();
            
        }

        private void txtSupplierName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (txtSupplierName.Text.Trim().Length == 0)
                {
                    dgvSupplierList.DataSource = null;
                    dv_Queryresult.Table = ds_Queryresult.Tables["tb_supplierinfor"];
                    dv_Queryresult.RowFilter = null;
                    dgvSupplierList.DataSource = dv_Queryresult.ToTable();
                    dgvHeadTextSet();
                }
                else
                {
                    dgvSupplierList.DataSource = null;
                    dv_Queryresult.Table = ds_Queryresult.Tables["tb_supplierinfor"];
                    dv_Queryresult.RowFilter = "SupplierName like'%" + txtSupplierName.Text.Trim() + "%'";
                    dgvSupplierList.DataSource = dv_Queryresult.ToTable();
                    dgvHeadTextSet();
                }
            }
        }

        private void dgvHeadTextSet()
        {
            this.dgvSupplierList.Columns[0].HeaderText = "序号";
            this.dgvSupplierList.Columns[1].HeaderText = "编号";
            this.dgvSupplierList.Columns[2].HeaderText = "名称";
            this.dgvSupplierList.Columns[2].Frozen = true;
            this.dgvSupplierList.Columns[3].HeaderText = "法人代表";
            this.dgvSupplierList.Columns[4].HeaderText = "联系人";
            this.dgvSupplierList.Columns[5].HeaderText = "手机";
            this.dgvSupplierList.Columns[6].HeaderText = "电话";
            this.dgvSupplierList.Columns[7].HeaderText = "传真";
            this.dgvSupplierList.Columns[8].HeaderText = "联系地址";
            this.dgvSupplierList.Columns[9].HeaderText = "注册地址";
            this.dgvSupplierList.Columns[10].HeaderText = "成立时间";
            this.dgvSupplierList.Columns[11].HeaderText = "注册资金";
            this.dgvSupplierList.Columns[12].HeaderText = "员工数";
            this.dgvSupplierList.Columns[13].HeaderText = "企业类型";
            this.dgvSupplierList.Columns[14].HeaderText = "提供产品类型";
            this.dgvSupplierList.Columns[15].HeaderText = "收款账户";
            this.dgvSupplierList.Columns[16].HeaderText = "开户银行";
            this.dgvSupplierList.Columns[17].HeaderText = "银行账号";
            this.dgvSupplierList.Columns[18].HeaderText = "付款期限";
            this.dgvSupplierList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            this.dgvSupplierList.AutoResizeColumnHeadersHeight();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ds_Queryresult.Clear();
            SupplierSelest();
            dv_Queryresult.Table = ds_Queryresult.Tables["tb_supplierinfor"];
            dgvHeadTextSet();
        }

        private void dgvSupplierList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSupplierList.Rows.Count > 0)
                {
                    SpID = dgvSupplierList.SelectedCells[1].Value.ToString().Trim();
                    SpName = dgvSupplierList.SelectedCells[2].Value.ToString().Trim();
                    Spfrdb = dgvSupplierList.SelectedCells[3].Value.ToString().Trim();
                    SpMan = dgvSupplierList.SelectedCells[4].Value.ToString().Trim();
                    SpMobilePhone = dgvSupplierList.SelectedCells[5].Value.ToString().Trim();
                    SpPhone = dgvSupplierList.SelectedCells[6].Value.ToString().Trim();
                    SpFax = dgvSupplierList.SelectedCells[7].Value.ToString().Trim();
                    SpAddress = dgvSupplierList.SelectedCells[8].Value.ToString().Trim();
                    SpZcAddress = dgvSupplierList.SelectedCells[9].Value.ToString().Trim();
                    SpClTime = dgvSupplierList.SelectedCells[10].Value.ToString().Trim();
                    SpZczj = dgvSupplierList.SelectedCells[11].Value.ToString().Trim();
                    SpYgs = dgvSupplierList.SelectedCells[12].Value.ToString().Trim();
                    SpQyxz = dgvSupplierList.SelectedCells[13].Value.ToString().Trim();
                    SpTgcplx = dgvSupplierList.SelectedCells[14].Value.ToString().Trim();
                    SpSkzh = dgvSupplierList.SelectedCells[15].Value.ToString().Trim();
                    SpKhh = dgvSupplierList.SelectedCells[16].Value.ToString().Trim();
                    SpYhzh = dgvSupplierList.SelectedCells[17].Value.ToString().Trim();
                    SpPro = dgvSupplierList.SelectedCells[18].Value.ToString().Trim();
                }
            }
            finally
            {
                this.Close();
                GC.Collect();
            }
        }
    }
}
