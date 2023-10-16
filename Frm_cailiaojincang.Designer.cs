namespace MTsystem_win
{
    partial class Frm_cailiaojincang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Orderform = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_inventory = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mat_id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Operator = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Inputdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Inputid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Inputzl = new System.Windows.Forms.TextBox();
            this.txt_Materia_unit = new System.Windows.Forms.TextBox();
            this.txt_Inputsl = new System.Windows.Forms.TextBox();
            this.txt_Materia_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Materia_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_orderID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orderform)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(577, 130);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_Cancel.TabIndex = 33;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Save.Location = new System.Drawing.Point(463, 130);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 30);
            this.btn_Save.TabIndex = 32;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Orderform);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1125, 295);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "到货选择";
            // 
            // dgv_Orderform
            // 
            this.dgv_Orderform.AllowUserToAddRows = false;
            this.dgv_Orderform.AllowUserToDeleteRows = false;
            this.dgv_Orderform.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_Orderform.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Orderform.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_Orderform.ColumnHeadersHeight = 25;
            this.dgv_Orderform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Orderform.Location = new System.Drawing.Point(3, 22);
            this.dgv_Orderform.Name = "dgv_Orderform";
            this.dgv_Orderform.ReadOnly = true;
            this.dgv_Orderform.RowHeadersVisible = false;
            this.dgv_Orderform.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_Orderform.RowTemplate.Height = 23;
            this.dgv_Orderform.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Orderform.Size = new System.Drawing.Size(1119, 270);
            this.dgv_Orderform.TabIndex = 1;
            this.dgv_Orderform.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Orderform_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_orderID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lb_inventory);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_mat_id);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_Cancel);
            this.groupBox2.Controls.Add(this.txt_Operator);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_Inputdate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_Inputid);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_Inputzl);
            this.groupBox2.Controls.Add(this.txt_Materia_unit);
            this.groupBox2.Controls.Add(this.txt_Inputsl);
            this.groupBox2.Controls.Add(this.txt_Materia_name);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_Materia_id);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1126, 166);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "进仓信息";
            // 
            // lb_inventory
            // 
            this.lb_inventory.AutoSize = true;
            this.lb_inventory.Location = new System.Drawing.Point(989, 136);
            this.lb_inventory.Name = "lb_inventory";
            this.lb_inventory.Size = new System.Drawing.Size(18, 19);
            this.lb_inventory.TabIndex = 67;
            this.lb_inventory.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(893, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 66;
            this.label6.Text = "当前库存:";
            // 
            // txt_mat_id
            // 
            this.txt_mat_id.BackColor = System.Drawing.Color.LightCyan;
            this.txt_mat_id.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mat_id.Location = new System.Drawing.Point(392, 35);
            this.txt_mat_id.Name = "txt_mat_id";
            this.txt_mat_id.ReadOnly = true;
            this.txt_mat_id.Size = new System.Drawing.Size(91, 31);
            this.txt_mat_id.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 64;
            this.label10.Text = "系统码:";
            // 
            // txt_Operator
            // 
            this.txt_Operator.BackColor = System.Drawing.Color.Pink;
            this.txt_Operator.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Operator.Location = new System.Drawing.Point(971, 78);
            this.txt_Operator.Name = "txt_Operator";
            this.txt_Operator.ReadOnly = true;
            this.txt_Operator.Size = new System.Drawing.Size(143, 31);
            this.txt_Operator.TabIndex = 63;
            this.txt_Operator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Operator_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(893, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 62;
            this.label9.Text = "进仓人:";
            // 
            // txt_Inputdate
            // 
            this.txt_Inputdate.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Inputdate.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Inputdate.Location = new System.Drawing.Point(739, 78);
            this.txt_Inputdate.Name = "txt_Inputdate";
            this.txt_Inputdate.ReadOnly = true;
            this.txt_Inputdate.Size = new System.Drawing.Size(148, 31);
            this.txt_Inputdate.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(643, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 60;
            this.label8.Text = "进仓日期:";
            // 
            // txt_Inputid
            // 
            this.txt_Inputid.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Inputid.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Inputid.Location = new System.Drawing.Point(102, 35);
            this.txt_Inputid.Name = "txt_Inputid";
            this.txt_Inputid.ReadOnly = true;
            this.txt_Inputid.Size = new System.Drawing.Size(206, 31);
            this.txt_Inputid.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 58;
            this.label7.Text = "进仓单号:";
            // 
            // txt_Inputzl
            // 
            this.txt_Inputzl.BackColor = System.Drawing.Color.Bisque;
            this.txt_Inputzl.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Inputzl.Location = new System.Drawing.Point(489, 78);
            this.txt_Inputzl.Name = "txt_Inputzl";
            this.txt_Inputzl.ReadOnly = true;
            this.txt_Inputzl.Size = new System.Drawing.Size(148, 31);
            this.txt_Inputzl.TabIndex = 57;
            // 
            // txt_Materia_unit
            // 
            this.txt_Materia_unit.BackColor = System.Drawing.Color.Bisque;
            this.txt_Materia_unit.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Materia_unit.Location = new System.Drawing.Point(310, 78);
            this.txt_Materia_unit.MaxLength = 10;
            this.txt_Materia_unit.Name = "txt_Materia_unit";
            this.txt_Materia_unit.Size = new System.Drawing.Size(76, 31);
            this.txt_Materia_unit.TabIndex = 56;
            this.txt_Materia_unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Materia_unit_KeyPress);
            this.txt_Materia_unit.Leave += new System.EventHandler(this.txt_Materia_unit_Leave);
            // 
            // txt_Inputsl
            // 
            this.txt_Inputsl.BackColor = System.Drawing.Color.Bisque;
            this.txt_Inputsl.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Inputsl.Location = new System.Drawing.Point(102, 78);
            this.txt_Inputsl.MaxLength = 10;
            this.txt_Inputsl.Name = "txt_Inputsl";
            this.txt_Inputsl.Size = new System.Drawing.Size(106, 31);
            this.txt_Inputsl.TabIndex = 55;
            this.txt_Inputsl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Inputsl_KeyPress);
            this.txt_Inputsl.Leave += new System.EventHandler(this.txt_Inputsl_Leave);
            // 
            // txt_Materia_name
            // 
            this.txt_Materia_name.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Materia_name.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Materia_name.Location = new System.Drawing.Point(893, 35);
            this.txt_Materia_name.Name = "txt_Materia_name";
            this.txt_Materia_name.ReadOnly = true;
            this.txt_Materia_name.Size = new System.Drawing.Size(221, 31);
            this.txt_Materia_name.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "进仓总量:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 52;
            this.label4.Text = "材料规格:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "进仓数量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "材料名称:";
            // 
            // txt_Materia_id
            // 
            this.txt_Materia_id.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Materia_id.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Materia_id.Location = new System.Drawing.Point(585, 35);
            this.txt_Materia_id.Name = "txt_Materia_id";
            this.txt_Materia_id.ReadOnly = true;
            this.txt_Materia_id.Size = new System.Drawing.Size(206, 31);
            this.txt_Materia_id.TabIndex = 49;
            this.txt_Materia_id.DoubleClick += new System.EventHandler(this.txt_Materia_id_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "材料编号:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 19);
            this.label11.TabIndex = 68;
            this.label11.Text = "订单编号:";
            // 
            // txt_orderID
            // 
            this.txt_orderID.BackColor = System.Drawing.Color.LightCyan;
            this.txt_orderID.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderID.Location = new System.Drawing.Point(102, 124);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.ReadOnly = true;
            this.txt_orderID.Size = new System.Drawing.Size(206, 31);
            this.txt_orderID.TabIndex = 69;
            // 
            // Frm_cailiaojincang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_cailiaojincang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "材料进仓窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_cailiaojincang_FormClosed);
            this.Load += new System.EventHandler(this.Frm_cailiaojincang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orderform)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_mat_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Operator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Inputdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Inputid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Inputzl;
        private System.Windows.Forms.TextBox txt_Materia_unit;
        private System.Windows.Forms.TextBox txt_Inputsl;
        private System.Windows.Forms.TextBox txt_Materia_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Materia_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_inventory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_Orderform;
        private System.Windows.Forms.TextBox txt_orderID;
        private System.Windows.Forms.Label label11;
    }
}