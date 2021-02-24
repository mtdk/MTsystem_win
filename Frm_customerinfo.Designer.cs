﻿namespace MTsystem_win
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
            this.tbc_customerinfo = new System.Windows.Forms.TabControl();
            this.tbp_cus_info_input = new System.Windows.Forms.TabPage();
            this.txt_cusAdd_A = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_cusinfo_preview = new System.Windows.Forms.DataGridView();
            this.btn_cancel_A = new System.Windows.Forms.Button();
            this.btn_save_A = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Fax_A = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Telephone_A = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MobilePhone_A = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Contact_A = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cusName_A = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cusId_A = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbp_cus_info_update = new System.Windows.Forms.TabPage();
            this.tbc_customerinfo.SuspendLayout();
            this.tbp_cus_info_input.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cusinfo_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_customerinfo
            // 
            this.tbc_customerinfo.Controls.Add(this.tbp_cus_info_input);
            this.tbc_customerinfo.Controls.Add(this.tbp_cus_info_update);
            this.tbc_customerinfo.Location = new System.Drawing.Point(12, 12);
            this.tbc_customerinfo.Name = "tbc_customerinfo";
            this.tbc_customerinfo.SelectedIndex = 0;
            this.tbc_customerinfo.Size = new System.Drawing.Size(1222, 561);
            this.tbc_customerinfo.TabIndex = 0;
            // 
            // tbp_cus_info_input
            // 
            this.tbp_cus_info_input.Controls.Add(this.txt_cusAdd_A);
            this.tbp_cus_info_input.Controls.Add(this.groupBox1);
            this.tbp_cus_info_input.Controls.Add(this.btn_cancel_A);
            this.tbp_cus_info_input.Controls.Add(this.btn_save_A);
            this.tbp_cus_info_input.Controls.Add(this.label7);
            this.tbp_cus_info_input.Controls.Add(this.txt_Fax_A);
            this.tbp_cus_info_input.Controls.Add(this.label6);
            this.tbp_cus_info_input.Controls.Add(this.txt_Telephone_A);
            this.tbp_cus_info_input.Controls.Add(this.label5);
            this.tbp_cus_info_input.Controls.Add(this.txt_MobilePhone_A);
            this.tbp_cus_info_input.Controls.Add(this.label4);
            this.tbp_cus_info_input.Controls.Add(this.txt_Contact_A);
            this.tbp_cus_info_input.Controls.Add(this.label3);
            this.tbp_cus_info_input.Controls.Add(this.txt_cusName_A);
            this.tbp_cus_info_input.Controls.Add(this.label2);
            this.tbp_cus_info_input.Controls.Add(this.txt_cusId_A);
            this.tbp_cus_info_input.Controls.Add(this.label1);
            this.tbp_cus_info_input.Location = new System.Drawing.Point(4, 28);
            this.tbp_cus_info_input.Name = "tbp_cus_info_input";
            this.tbp_cus_info_input.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_cus_info_input.Size = new System.Drawing.Size(1214, 529);
            this.tbp_cus_info_input.TabIndex = 0;
            this.tbp_cus_info_input.Text = "客户信息录入";
            this.tbp_cus_info_input.UseVisualStyleBackColor = true;
            // 
            // txt_cusAdd_A
            // 
            this.txt_cusAdd_A.Location = new System.Drawing.Point(578, 58);
            this.txt_cusAdd_A.Name = "txt_cusAdd_A";
            this.txt_cusAdd_A.Size = new System.Drawing.Size(477, 26);
            this.txt_cusAdd_A.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_cusinfo_preview);
            this.groupBox1.Location = new System.Drawing.Point(10, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1198, 416);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息预览";
            // 
            // dgv_cusinfo_preview
            // 
            this.dgv_cusinfo_preview.AllowUserToAddRows = false;
            this.dgv_cusinfo_preview.AllowUserToDeleteRows = false;
            this.dgv_cusinfo_preview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cusinfo_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cusinfo_preview.Location = new System.Drawing.Point(3, 22);
            this.dgv_cusinfo_preview.Name = "dgv_cusinfo_preview";
            this.dgv_cusinfo_preview.ReadOnly = true;
            this.dgv_cusinfo_preview.RowTemplate.Height = 23;
            this.dgv_cusinfo_preview.Size = new System.Drawing.Size(1192, 391);
            this.dgv_cusinfo_preview.TabIndex = 0;
            // 
            // btn_cancel_A
            // 
            this.btn_cancel_A.Location = new System.Drawing.Point(1101, 55);
            this.btn_cancel_A.Name = "btn_cancel_A";
            this.btn_cancel_A.Size = new System.Drawing.Size(75, 30);
            this.btn_cancel_A.TabIndex = 15;
            this.btn_cancel_A.Text = "取  消";
            this.btn_cancel_A.UseVisualStyleBackColor = true;
            // 
            // btn_save_A
            // 
            this.btn_save_A.Location = new System.Drawing.Point(1101, 16);
            this.btn_save_A.Name = "btn_save_A";
            this.btn_save_A.Size = new System.Drawing.Size(75, 30);
            this.btn_save_A.TabIndex = 14;
            this.btn_save_A.Text = "保  存";
            this.btn_save_A.UseVisualStyleBackColor = true;
            this.btn_save_A.Click += new System.EventHandler(this.btn_save_A_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "地址:";
            // 
            // txt_Fax_A
            // 
            this.txt_Fax_A.Location = new System.Drawing.Point(358, 59);
            this.txt_Fax_A.Name = "txt_Fax_A";
            this.txt_Fax_A.Size = new System.Drawing.Size(154, 26);
            this.txt_Fax_A.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "传真号码:";
            // 
            // txt_Telephone_A
            // 
            this.txt_Telephone_A.Location = new System.Drawing.Point(102, 59);
            this.txt_Telephone_A.Name = "txt_Telephone_A";
            this.txt_Telephone_A.Size = new System.Drawing.Size(154, 26);
            this.txt_Telephone_A.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "联系电话:";
            // 
            // txt_MobilePhone_A
            // 
            this.txt_MobilePhone_A.Location = new System.Drawing.Point(901, 16);
            this.txt_MobilePhone_A.Name = "txt_MobilePhone_A";
            this.txt_MobilePhone_A.Size = new System.Drawing.Size(154, 26);
            this.txt_MobilePhone_A.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(805, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "手机号码:";
            // 
            // txt_Contact_A
            // 
            this.txt_Contact_A.Location = new System.Drawing.Point(684, 16);
            this.txt_Contact_A.Name = "txt_Contact_A";
            this.txt_Contact_A.Size = new System.Drawing.Size(115, 26);
            this.txt_Contact_A.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "联系人:";
            // 
            // txt_cusName_A
            // 
            this.txt_cusName_A.Location = new System.Drawing.Point(287, 16);
            this.txt_cusName_A.Name = "txt_cusName_A";
            this.txt_cusName_A.Size = new System.Drawing.Size(313, 26);
            this.txt_cusName_A.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "客户名称:";
            // 
            // txt_cusId_A
            // 
            this.txt_cusId_A.Location = new System.Drawing.Point(102, 16);
            this.txt_cusId_A.Name = "txt_cusId_A";
            this.txt_cusId_A.ReadOnly = true;
            this.txt_cusId_A.Size = new System.Drawing.Size(83, 26);
            this.txt_cusId_A.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "客户编号:";
            // 
            // tbp_cus_info_update
            // 
            this.tbp_cus_info_update.Location = new System.Drawing.Point(4, 28);
            this.tbp_cus_info_update.Name = "tbp_cus_info_update";
            this.tbp_cus_info_update.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_cus_info_update.Size = new System.Drawing.Size(1214, 529);
            this.tbp_cus_info_update.TabIndex = 1;
            this.tbp_cus_info_update.Text = "客户信息查询&修改";
            this.tbp_cus_info_update.UseVisualStyleBackColor = true;
            // 
            // Frm_customerinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 585);
            this.Controls.Add(this.tbc_customerinfo);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_customerinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户信息窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_customerinfo_FormClosed);
            this.Load += new System.EventHandler(this.Frm_customerinfo_Load);
            this.tbc_customerinfo.ResumeLayout(false);
            this.tbp_cus_info_input.ResumeLayout(false);
            this.tbp_cus_info_input.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cusinfo_preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_customerinfo;
        private System.Windows.Forms.TabPage tbp_cus_info_input;
        private System.Windows.Forms.TextBox txt_cusName_A;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cusId_A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbp_cus_info_update;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Fax_A;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Telephone_A;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MobilePhone_A;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Contact_A;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancel_A;
        private System.Windows.Forms.Button btn_save_A;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_cusinfo_preview;
        private System.Windows.Forms.TextBox txt_cusAdd_A;
    }
}