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
    public partial class Frm_Material : Form
    {
        public Frm_Material()
        {
            InitializeComponent();
        }

        DataSet ds_Queryresult = new DataSet();

        DataView dv_Queryresult = new DataView();

        JudgeNumber jnum = new JudgeNumber();

        int Maxid;
        /// <summary>
        /// 材料编号是否存在
        /// </summary>
        static Boolean MIDStatus;

        private void Frm_Material_Load(object sender, EventArgs e)
        {
            if (frmShowstatus._Fmaterial == "CLOSE" || frmShowstatus._Fmaterial == null)
            {
                frmShowstatus._Fmaterial = "OPEN";
                MclassSelect();
                MapplicationSelect();
                MaterialList();
                dgvMaterialList.DataSource = dv_Queryresult.ToTable("material");
                dgvHeadTextSet();
            }
        }

        private void Frm_Material_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmShowstatus._Fmaterial = "CLOSE";
        }

        /// <summary>
        /// 检索绑定所有材料类型
        /// </summary>
        private void MclassSelect()
        {
            string sqlstr = "SELECT id,material_name FROM material_class";
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
            msda.Fill(ds_Queryresult, "material_class");
            cmbClass.DataSource = ds_Queryresult.Tables["material_class"];
            cmbClass.DisplayMember = "material_name";
            cmbClass.ValueMember = "material_name";
            msda.Dispose();
            conn.Close();
        }

        /// <summary>
        /// 检索绑定所有材料用途
        /// </summary>
        private void MapplicationSelect()
        {
            string sqlstr = "SELECT id,MaterialApplication FROM material_application";
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
            msda.Fill(ds_Queryresult, "material_application");
            cmbApp.DataSource = ds_Queryresult.Tables["material_application"];
            cmbApp.DisplayMember = "MaterialApplication";
            cmbApp.ValueMember = "MaterialApplication";
            msda.Dispose();
            conn.Close();

        }
        /// <summary>
        /// 检索绑定所有材料信息
        /// </summary>
        private void MaterialList()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            string sqlstr = "SELECT id,Matid,Material_id,Material_inside_name,Material_name,";
            sqlstr += "Material_class,Material_price,Material_category,Material_Unit,Material_cino,";
            sqlstr += "Material_application,Material_status,Material_remarks FROM material ORDER BY ID ASC";
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlstr, conn);
            msda.Fill(ds_Queryresult, "material");

            dv_Queryresult.Table = ds_Queryresult.Tables["material"];
            dgvMaterialList.DataSource = dv_Queryresult.ToTable("material");
            conn.Close();

        }
        /// <summary>
        /// 过滤已检索绑定的材料信息
        /// </summary>
        private void MaterialFilterList()
        {
            if (txtSelectCondition.Text.Trim().Length == 0)
            {
                dv_Queryresult.Table = ds_Queryresult.Tables["material"];
            }
            else
            {
                if (rdbMaterialName.Checked == true)
                {
                    dgvMaterialList.DataSource = null;
                    dv_Queryresult.Table = ds_Queryresult.Tables["material"];
                    dv_Queryresult.RowFilter = "Material_Name like'%" + txtSelectCondition.Text.Trim() + "%'";
                    dgvMaterialList.DataSource = dv_Queryresult.ToTable();
                    dgvHeadTextSet();
                }
                else if (rdbMaterialID.Checked == true)
                {
                    dgvMaterialList.DataSource = null;
                    dv_Queryresult.Table = ds_Queryresult.Tables["material"];
                    dv_Queryresult.RowFilter = "Material_id like'%" + txtSelectCondition.Text.Trim() + "%'";
                    dgvMaterialList.DataSource = dv_Queryresult.ToTable();
                    dgvHeadTextSet();
                }
            }
        }
        /// <summary>
        /// 设置材料显示列表
        /// </summary>
        private void dgvHeadTextSet()
        {
            this.dgvMaterialList.Columns[0].HeaderText = "序号";
            this.dgvMaterialList.Columns[1].HeaderText = "系统号";
            this.dgvMaterialList.Columns[2].HeaderText = "编号";
            this.dgvMaterialList.Columns[3].HeaderText = "名称(内)";
            this.dgvMaterialList.Columns[4].HeaderText = "名称(原)";
            this.dgvMaterialList.Columns[5].HeaderText = "类型";
            this.dgvMaterialList.Columns[6].HeaderText = "单价";
            this.dgvMaterialList.Columns[7].HeaderText = "规格";
            this.dgvMaterialList.Columns[8].HeaderText = "单位";
            this.dgvMaterialList.Columns[9].HeaderText = "索引号";
            this.dgvMaterialList.Columns[10].HeaderText = "用途";
            this.dgvMaterialList.Columns[11].HeaderText = "状态";
            this.dgvMaterialList.Columns[12].HeaderText = "备注";
            this.dgvMaterialList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvMaterialList.AutoResizeColumnHeadersHeight();
        }
        /// <summary>
        /// 产生新材料系统编码
        /// </summary>
        private void NewInteriorID()
        {
            string strsql = "SELECT Matid From material order by id DESC limit 1";
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(strsql, conn);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dr.Read();
            try
            {
                if (dr.HasRows)
                {
                    Maxid = Convert.ToInt32(dr["Matid"].ToString().Substring(1, 4).ToString());
                    Maxid++;
                    lbInteriorID.Text = string.Format("M{0}", Maxid.ToString().PadLeft(4, '0'));
                }
                else
                {
                    Maxid = 1;
                    lbInteriorID.Text = string.Format("M{0}", Maxid.ToString().PadLeft(4, '0'));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 判断是否有相同材料编号存在
        /// </summary>
        private void MaterialSameSelect()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            string strsql ="SELECT count(*) as total From material where material_id = '"+txtMaterialID.Text.Trim()+"'";
            MySqlCommand cmd = new MySqlCommand(strsql, conn);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dr.Read();
            try
            {
                if (dr.HasRows)
                {
                    if (dr["total"].ToString().Trim() == "0")
                    {
                        MIDStatus = true;
                    }
                    else
                    {
                        MIDStatus = false;
                    }
                }
                else
                {
                    MIDStatus = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 向材料数据表增加新纪录
        /// </summary>
        private void MaterialInsert()
        {
            MaterialSameSelect();
            if (MIDStatus == false)
            {
                MessageBox.Show("材料编号已经存在，请重新输入材料编号！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaterialID.Focus();
                txtMaterialID.SelectAll();
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string strsql = "INSERT INTO `material` VALUES(NULL,@Matid,@Material_id,@Material_inside_name,";
                    strsql += "@Material_name,@Material_class,@Material_price,@Material_category,@Material_Unit,";
                    strsql += "@Material_cino,@Material_application,@Material_status,@Material_remarks)";

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = strsql;
                    cmd.Parameters.AddWithValue("@Matid", lbInteriorID.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_id", txtMaterialID.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_inside_name", txtMaterialName_inside.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_name", txtMaterialName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_class", cmbClass.SelectedValue.ToString().Trim());
                    cmd.Parameters.AddWithValue("@Material_price", Convert.ToDecimal(txtMaterialPrice.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Material_category", txtcategory.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_Unit", txtUnit.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_cino", txtCino.Text.Trim());
                    cmd.Parameters.AddWithValue("@Material_application", cmbApp.SelectedValue.ToString().Trim());
                    if (rdbMaterialY.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Material_status", rdbMaterialY.Text.Trim());
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Material_status", rdbMaterialN.Text.Trim());
                    }
                    cmd.Parameters.AddWithValue("@Material_remarks", txtRemarks.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transaction.Rollback();
                    conn.Close();
                }
                finally
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        transaction.Commit();
                        conn.Close();
                        MessageBox.Show("数据已保存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        aControlClear();
                        ds_Queryresult.Clear();
                        MclassSelect();
                        MapplicationSelect();
                        MaterialList();
                    }
                }
            }
        }
        /// <summary>
        /// 更新材料数据表记录
        /// </summary>
        private void MaterialUp()
        {
            MySqlConnection conn = new MySqlConnection(connectstr.CONNECTSTR);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                string strsql = "UPDATE `material` SET Material_id = @Material_id,Material_inside_name = @Material_inside_name,";
                strsql += "Material_name = @Material_name,Material_class = @Material_class,Material_price = @Material_price,";
                strsql += "Material_category = @Material_category,Material_Unit = @Material_Unit,Material_cino = @Material_cino,";
                strsql += "Material_application = @Material_application,Material_status = @Material_status,";
                strsql += "Material_remarks = @Material_remarks WHERE Matid = @Matid";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = strsql;
                cmd.Parameters.AddWithValue("@Matid", lbInteriorID.Text.Trim());
                cmd.Parameters.AddWithValue("@Material_id", txtMaterialID.Text.Trim());
                cmd.Parameters.AddWithValue("@Material_inside_name", txtMaterialName_inside.Text.Trim());
                cmd.Parameters.AddWithValue("@Material_name", txtMaterialName.Text.Trim());
                cmd.Parameters.AddWithValue("@Material_class", cmbClass.SelectedValue.ToString().Trim());
                cmd.Parameters.AddWithValue("@Material_price", Convert.ToDecimal(txtMaterialPrice.Text.Trim()));
                cmd.Parameters.AddWithValue("@Material_category", txtcategory.Text.Trim());
                cmd.Parameters.AddWithValue("@Material_Unit", txtUnit.Text.Trim());
                cmd.Parameters.AddWithValue("@Material_cino", txtCino.Text.Trim());
                cmd.Parameters.AddWithValue("@Material_application", cmbApp.SelectedValue.ToString().Trim());
                if (rdbMaterialY.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Material_status", rdbMaterialY.Text.Trim());
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Material_status", rdbMaterialN.Text.Trim());
                }
                cmd.Parameters.AddWithValue("@Material_remarks", txtRemarks.Text.Trim());
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("错误代码：" + ex.Number + " 错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transaction.Rollback();
                conn.Close();
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    transaction.Commit();
                    conn.Close();
                    MessageBox.Show("数据已保存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    aControlClear();
                    ds_Queryresult.Clear();
                    MclassSelect();
                    MapplicationSelect();
                    MaterialList();
                }
            }
        }
        /// <summary>
        /// 清楚材料录入、修改界面控件的数据
        /// </summary>
        private void aControlClear()
        {
            lbInteriorID.Text = "系统编码！";
            txtMaterialID.Text = "";
            txtMaterialName.Text = "";
            txtMaterialName_inside.Text = "";
            txtMaterialPrice.Text = "0.00";
            txtcategory.Text = "0";
            cmbClass.SelectedIndex = 0;
            txtCino.Text = "无";
            cmbApp.SelectedIndex = 0;
            rdbMaterialY.Checked = true;
            txtUnit.Text = "kg";
        }

        private void txtSelectCondition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                MaterialFilterList();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            MaterialFilterList();
        }

        private void btnNewID_Click(object sender, EventArgs e)
        {
            if (rdbRegister.Checked == true)
            {
                NewInteriorID();
                txtMaterialID.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rdbSelect.Checked == false)
            {
                if (rdbRegister.Checked == true)
                {
                    if (lbInteriorID.Text == "系统编码！")
                    {
                        MessageBox.Show("还未进行系统编号，请先编号！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnNewID.Focus();
                    }
                    else if (txtMaterialID.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("材料编号未填写，请填写材料编号！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaterialID.Focus();
                    }
                    else if (txtMaterialName.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("材料原名称未填写，请填写材料原名称！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaterialName.Focus();
                    }
                    else if (txtMaterialName_inside.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("材料内部名称未填写，请填写材料内部名称！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaterialName_inside.Focus();
                    }
                    else if (txtMaterialPrice.Text == string.Empty)
                    {
                        MessageBox.Show("材料单价未填写，系统默认为 0.00 ！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaterialPrice.Text = "0.00";
                    }
                    else if (!jnum.ISNumeric(txtMaterialPrice.Text.Trim()))
                    {
                        MessageBox.Show("输入单价不合法，系统将恢复默认值！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaterialPrice.Text = "0.00";
                    }
                    else if ((Convert.ToDouble(txtMaterialPrice.Text.Trim())) > 9999.99)
                    {
                        MessageBox.Show("材料单价太大了！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaterialPrice.Focus();
                        txtMaterialPrice.SelectAll();
                    }
                    else if (txtcategory.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("计量单位不能为空，系统将恢复默认值！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtcategory.Text = "0";
                    }
                    else if (!jnum.ISNumeric(txtcategory.Text.Trim()))
                    {
                        MessageBox.Show("输入规格不合法，系统将恢复默认值！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtcategory.Text = "0";
                    }
                    else
                    {
                        MaterialInsert();
                    }
                }
                else
                {
                    if (lbInteriorID.Text == "系统编码！")
                    {
                        MessageBox.Show("还未获得系统编号！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtMaterialName.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("材料原名称未填写，请填写材料原名称！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaterialName.Focus();
                    }
                    else if (txtMaterialName_inside.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("材料内部名称未填写，请填写材料内部名称！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaterialName_inside.Focus();
                    }
                    else if (txtMaterialPrice.Text == string.Empty)
                    {
                        MessageBox.Show("材料单价未填写，系统默认为 0.00 ！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaterialPrice.Text = "0.00";
                    }
                    else if (!jnum.ISNumeric(txtMaterialPrice.Text.Trim()))
                    {
                        MessageBox.Show("输入单价不合法，系统将恢复默认值！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaterialPrice.Text = "0.00";
                    }
                    else if ((Convert.ToDouble(txtMaterialPrice.Text.Trim())) > 9999.99)
                    {
                        MessageBox.Show("材料单价太大了！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaterialPrice.Focus();
                        txtMaterialPrice.SelectAll();
                    }
                    else if (txtcategory.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("计量单位不能为空，系统将恢复默认值！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtcategory.Text = "0";
                    }
                    else if (!jnum.ISNumeric(txtcategory.Text.Trim()))
                    {
                        MessageBox.Show("输入规格不合法，系统将恢复默认值！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtcategory.Text = "0";
                    }
                    else
                    {
                        MaterialUp();
                    }
                }
            }
        }

        private void dgvMaterialList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                if (rdbUp.Checked == true)
                {
                    aControlClear();
                    lbInteriorID.Text = dgvMaterialList.SelectedCells[1].Value.ToString();
                    txtMaterialID.Text = dgvMaterialList.SelectedCells[2].Value.ToString();
                    txtMaterialName.Text = dgvMaterialList.SelectedCells[4].Value.ToString();
                    txtMaterialName_inside.Text = dgvMaterialList.SelectedCells[3].Value.ToString();
                    int tempClassA = cmbClass.FindString(dgvMaterialList.SelectedCells[5].Value.ToString());
                    cmbClass.SelectedIndex = tempClassA; 
                    txtMaterialPrice.Text = dgvMaterialList.SelectedCells[6].Value.ToString();
                    txtcategory.Text = dgvMaterialList.SelectedCells[7].Value.ToString();
                    txtUnit.Text = dgvMaterialList.SelectedCells[8].Value.ToString().Trim();
                    txtCino.Text = dgvMaterialList.SelectedCells[9].Value.ToString();
                    int tempAppA = cmbApp.FindString(dgvMaterialList.SelectedCells[10].Value.ToString());
                    cmbApp.SelectedIndex = tempAppA;
                    if (dgvMaterialList.SelectedCells[11].Value.ToString().Trim() == "有效")
                    {
                        rdbMaterialY.Checked = true;
                    }
                    else
                    {
                        rdbMaterialN.Checked = true;
                    }
                    txtRemarks.Text = dgvMaterialList.SelectedCells[12].Value.ToString();
                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            aControlClear();
        }

        private void txtMaterialPrice_Leave(object sender, EventArgs e)
        {
            if (txtMaterialPrice.Text == string.Empty)
            {
                txtMaterialPrice.Text = "0.00";
            }
            else if (!jnum.ISNumeric(txtMaterialPrice.Text.Trim()))
            {
                MessageBox.Show("输入单价不合法，系统将恢复默认值！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaterialPrice.Text = "0.00";
            }
            else if ((Convert.ToDouble(txtMaterialPrice.Text.Trim())) > 9999.99)
            {
                MessageBox.Show("材料单价太大了！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaterialPrice.Focus();
                txtMaterialPrice.SelectAll();
            }
        }

        private void txtcategory_Leave(object sender, EventArgs e)
        {
            if (txtcategory.Text.Trim() == string.Empty)
            {
                MessageBox.Show("计量单位不能为空，系统将恢复默认值！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcategory.Text = "0";
            }
            else if (!jnum.ISNumeric(txtcategory.Text.Trim()))
            {
                MessageBox.Show("输入规格不合法，系统将恢复默认值！", "警告提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcategory.Text = "0";
            }
        }

        private void btnCopymatid_Click(object sender, EventArgs e)
        {
            if (txtMaterialID.Text.Trim().Length != 0)
            {
                txtMaterialName_inside.Text = txtMaterialID.Text.Trim();
            }
        }
    }
}
