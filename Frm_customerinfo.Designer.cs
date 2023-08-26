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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.txt_CusNameQuery = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdb_CusUpdate = new System.Windows.Forms.RadioButton();
            this.rdb_CusInsert = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_Cus_classification = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_cusAdd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_CusClassinfo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
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
            this.groupBox1.Size = new System.Drawing.Size(1279, 62);
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
            this.groupBox2.Controls.Add(this.cmb_Cus_classification);
            this.groupBox2.Controls.Add(this.label16);
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
            this.groupBox2.Size = new System.Drawing.Size(1279, 535);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // cmb_Cus_classification
            // 
            this.cmb_Cus_classification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cus_classification.FormattingEnabled = true;
            this.cmb_Cus_classification.Location = new System.Drawing.Point(1152, 25);
            this.cmb_Cus_classification.Name = "cmb_Cus_classification";
            this.cmb_Cus_classification.Size = new System.Drawing.Size(121, 27);
            this.cmb_Cus_classification.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1066, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 19);
            this.label16.TabIndex = 34;
            this.label16.Text = "负责人：";
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
            this.groupBox3.Controls.Add(this.txt_CusClassinfo);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.dgv_cusinfo_preview);
            this.groupBox3.Location = new System.Drawing.Point(15, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1247, 413);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "信息预览";
            // 
            // txt_CusClassinfo
            // 
            this.txt_CusClassinfo.Location = new System.Drawing.Point(1126, 121);
            this.txt_CusClassinfo.Name = "txt_CusClassinfo";
            this.txt_CusClassinfo.ReadOnly = true;
            this.txt_CusClassinfo.Size = new System.Drawing.Size(115, 26);
            this.txt_CusClassinfo.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1051, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 19);
            this.label17.TabIndex = 45;
            this.label17.Text = "负责人：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(928, 313);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(313, 55);
            this.textBox1.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(858, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 43;
            this.label9.Text = "地址:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(928, 265);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(154, 26);
            this.textBox2.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(832, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 41;
            this.label10.Text = "传真号码:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(928, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(154, 26);
            this.textBox3.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(832, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 19);
            this.label11.TabIndex = 39;
            this.label11.Text = "联系电话:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(928, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(154, 26);
            this.textBox4.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(832, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 19);
            this.label12.TabIndex = 37;
            this.label12.Text = "手机号码:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(928, 121);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(115, 26);
            this.textBox5.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(850, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 19);
            this.label13.TabIndex = 35;
            this.label13.Text = "联系人:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(928, 73);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(313, 26);
            this.textBox6.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(832, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 19);
            this.label14.TabIndex = 34;
            this.label14.Text = "客户名称:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(928, 25);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(83, 26);
            this.textBox7.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(832, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 19);
            this.label15.TabIndex = 32;
            this.label15.Text = "客户编号:";
            // 
            // dgv_cusinfo_preview
            // 
            this.dgv_cusinfo_preview.AllowUserToAddRows = false;
            this.dgv_cusinfo_preview.AllowUserToDeleteRows = false;
            this.dgv_cusinfo_preview.AllowUserToResizeRows = false;
            this.dgv_cusinfo_preview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_cusinfo_preview.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_cusinfo_preview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cusinfo_preview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_cusinfo_preview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cusinfo_preview.Location = new System.Drawing.Point(3, 22);
            this.dgv_cusinfo_preview.Name = "dgv_cusinfo_preview";
            this.dgv_cusinfo_preview.ReadOnly = true;
            this.dgv_cusinfo_preview.RowHeadersVisible = false;
            this.dgv_cusinfo_preview.RowTemplate.Height = 30;
            this.dgv_cusinfo_preview.RowTemplate.ReadOnly = true;
            this.dgv_cusinfo_preview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cusinfo_preview.Size = new System.Drawing.Size(823, 388);
            this.dgv_cusinfo_preview.TabIndex = 0;
            this.dgv_cusinfo_preview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cusinfo_preview_CellClick);
            this.dgv_cusinfo_preview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cusinfo_preview_CellDoubleClick);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(1187, 64);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_cancel.TabIndex = 32;
            this.btn_cancel.Text = "取  消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1091, 64);
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
            this.ClientSize = new System.Drawing.Size(1303, 640);
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
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_Cus_classification;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_CusClassinfo;
        private System.Windows.Forms.Label label17;

    }
}