namespace MTsystem_win
{
    partial class Frm_customerinfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.txt_CusNameQuery = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdb_CusUpdate = new System.Windows.Forms.RadioButton();
            this.rdb_CusInsert = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_cusAdd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_cusinfo_preview = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Fax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Telephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MobilePhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cusId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cusinfo_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Select);
            this.groupBox1.Controls.Add(this.txt_CusNameQuery);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rdb_CusUpdate);
            this.groupBox1.Controls.Add(this.rdb_CusInsert);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1222, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(703, 21);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 30);
            this.btn_Select.TabIndex = 32;
            this.btn_Select.Text = "查  询";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Visible = false;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // txt_CusNameQuery
            // 
            this.txt_CusNameQuery.Location = new System.Drawing.Point(384, 24);
            this.txt_CusNameQuery.Name = "txt_CusNameQuery";
            this.txt_CusNameQuery.Size = new System.Drawing.Size(313, 26);
            this.txt_CusNameQuery.TabIndex = 3;
            this.txt_CusNameQuery.Visible = false;
            this.txt_CusNameQuery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CusNameQuery_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "信息查询:";
            this.label8.Visible = false;
            // 
            // rdb_CusUpdate
            // 
            this.rdb_CusUpdate.AutoSize = true;
            this.rdb_CusUpdate.Location = new System.Drawing.Point(147, 25);
            this.rdb_CusUpdate.Name = "rdb_CusUpdate";
            this.rdb_CusUpdate.Size = new System.Drawing.Size(135, 23);
            this.rdb_CusUpdate.TabIndex = 1;
            this.rdb_CusUpdate.Text = "客户信息修改";
            this.rdb_CusUpdate.UseVisualStyleBackColor = true;
            this.rdb_CusUpdate.CheckedChanged += new System.EventHandler(this.rdb_CusUpdate_CheckedChanged);
            // 
            // rdb_CusInsert
            // 
            this.rdb_CusInsert.AutoSize = true;
            this.rdb_CusInsert.Checked = true;
            this.rdb_CusInsert.Location = new System.Drawing.Point(6, 25);
            this.rdb_CusInsert.Name = "rdb_CusInsert";
            this.rdb_CusInsert.Size = new System.Drawing.Size(135, 23);
            this.rdb_CusInsert.TabIndex = 0;
            this.rdb_CusInsert.TabStop = true;
            this.rdb_CusInsert.Text = "客户信息录入";
            this.rdb_CusInsert.UseVisualStyleBackColor = true;
            this.rdb_CusInsert.CheckedChanged += new System.EventHandler(this.rdb_CusInsert_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_cusAdd);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_Fax);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_Telephone);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_MobilePhone);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Contact);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_cusName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_cusId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1222, 535);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txt_cusAdd
            // 
            this.txt_cusAdd.Location = new System.Drawing.Point(583, 67);
            this.txt_cusAdd.Name = "txt_cusAdd";
            this.txt_cusAdd.Size = new System.Drawing.Size(477, 26);
            this.txt_cusAdd.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_cusinfo_preview);
            this.groupBox3.Location = new System.Drawing.Point(15, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1198, 413);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "信息预览";
            // 
            // dgv_cusinfo_preview
            // 
            this.dgv_cusinfo_preview.AllowUserToAddRows = false;
            this.dgv_cusinfo_preview.AllowUserToDeleteRows = false;
            this.dgv_cusinfo_preview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_cusinfo_preview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cusinfo_preview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_cusinfo_preview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cusinfo_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cusinfo_preview.Location = new System.Drawing.Point(3, 22);
            this.dgv_cusinfo_preview.Name = "dgv_cusinfo_preview";
            this.dgv_cusinfo_preview.ReadOnly = true;
            this.dgv_cusinfo_preview.RowTemplate.Height = 30;
            this.dgv_cusinfo_preview.RowTemplate.ReadOnly = true;
            this.dgv_cusinfo_preview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cusinfo_preview.Size = new System.Drawing.Size(1192, 388);
            this.dgv_cusinfo_preview.TabIndex = 0;
            this.dgv_cusinfo_preview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cusinfo_preview_CellDoubleClick);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(1106, 64);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_cancel.TabIndex = 32;
            this.btn_cancel.Text = "取  消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1106, 25);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 30);
            this.btn_save.TabIndex = 31;
            this.btn_save.Text = "保  存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "地址:";
            // 
            // txt_Fax
            // 
            this.txt_Fax.Location = new System.Drawing.Point(363, 68);
            this.txt_Fax.Name = "txt_Fax";
            this.txt_Fax.Size = new System.Drawing.Size(154, 26);
            this.txt_Fax.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "传真号码:";
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(107, 68);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(154, 26);
            this.txt_Telephone.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "联系电话:";
            // 
            // txt_MobilePhone
            // 
            this.txt_MobilePhone.Location = new System.Drawing.Point(906, 25);
            this.txt_MobilePhone.Name = "txt_MobilePhone";
            this.txt_MobilePhone.Size = new System.Drawing.Size(154, 26);
            this.txt_MobilePhone.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(810, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "手机号码:";
            // 
            // txt_Contact
            // 
            this.txt_Contact.Location = new System.Drawing.Point(689, 25);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(115, 26);
            this.txt_Contact.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "联系人:";
            // 
            // txt_cusName
            // 
            this.txt_cusName.Location = new System.Drawing.Point(292, 25);
            this.txt_cusName.Name = "txt_cusName";
            this.txt_cusName.Size = new System.Drawing.Size(313, 26);
            this.txt_cusName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "客户名称:";
            // 
            // txt_cusId
            // 
            this.txt_cusId.Location = new System.Drawing.Point(107, 25);
            this.txt_cusId.Name = "txt_cusId";
            this.txt_cusId.ReadOnly = true;
            this.txt_cusId.Size = new System.Drawing.Size(83, 26);
            this.txt_cusId.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "客户编号:";
            // 
            // Frm_customerinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 640);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_customerinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户信息窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_customerinfo_FormClosed);
            this.Load += new System.EventHandler(this.Frm_customerinfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cusinfo_preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_cusAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_cusinfo_preview;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Fax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Telephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MobilePhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cusId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.TextBox txt_CusNameQuery;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdb_CusUpdate;
        private System.Windows.Forms.RadioButton rdb_CusInsert;

    }
}