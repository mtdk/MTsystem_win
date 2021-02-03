namespace MTsystem_win
{
    partial class Frm_Supplier_info
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
            this.tbc_supplier_info = new System.Windows.Forms.TabControl();
            this.tp_sup_base_info = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_supid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_supplier_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sup_abbreviation = new System.Windows.Forms.TextBox();
            this.btn_save_A = new System.Windows.Forms.Button();
            this.btn_cancel_A = new System.Windows.Forms.Button();
            this.tbc_supplier_info.SuspendLayout();
            this.tp_sup_base_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_supplier_info
            // 
            this.tbc_supplier_info.Controls.Add(this.tp_sup_base_info);
            this.tbc_supplier_info.Controls.Add(this.tabPage2);
            this.tbc_supplier_info.Location = new System.Drawing.Point(12, 12);
            this.tbc_supplier_info.Name = "tbc_supplier_info";
            this.tbc_supplier_info.SelectedIndex = 0;
            this.tbc_supplier_info.Size = new System.Drawing.Size(1050, 571);
            this.tbc_supplier_info.TabIndex = 0;
            // 
            // tp_sup_base_info
            // 
            this.tp_sup_base_info.Controls.Add(this.btn_cancel_A);
            this.tp_sup_base_info.Controls.Add(this.btn_save_A);
            this.tp_sup_base_info.Controls.Add(this.txt_sup_abbreviation);
            this.tp_sup_base_info.Controls.Add(this.label3);
            this.tp_sup_base_info.Controls.Add(this.txt_supplier_name);
            this.tp_sup_base_info.Controls.Add(this.label2);
            this.tp_sup_base_info.Controls.Add(this.txt_supid);
            this.tp_sup_base_info.Controls.Add(this.label1);
            this.tp_sup_base_info.Location = new System.Drawing.Point(4, 28);
            this.tp_sup_base_info.Name = "tp_sup_base_info";
            this.tp_sup_base_info.Padding = new System.Windows.Forms.Padding(3);
            this.tp_sup_base_info.Size = new System.Drawing.Size(1042, 539);
            this.tp_sup_base_info.TabIndex = 0;
            this.tp_sup_base_info.Text = "供应商基础信息";
            this.tp_sup_base_info.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1042, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "系统编号:";
            // 
            // txt_supid
            // 
            this.txt_supid.Location = new System.Drawing.Point(102, 15);
            this.txt_supid.Name = "txt_supid";
            this.txt_supid.ReadOnly = true;
            this.txt_supid.Size = new System.Drawing.Size(158, 26);
            this.txt_supid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "供应商名称:";
            // 
            // txt_supplier_name
            // 
            this.txt_supplier_name.Location = new System.Drawing.Point(120, 55);
            this.txt_supplier_name.MaxLength = 100;
            this.txt_supplier_name.Name = "txt_supplier_name";
            this.txt_supplier_name.Size = new System.Drawing.Size(282, 26);
            this.txt_supplier_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "供应商简称:";
            // 
            // txt_sup_abbreviation
            // 
            this.txt_sup_abbreviation.Location = new System.Drawing.Point(120, 104);
            this.txt_sup_abbreviation.MaxLength = 20;
            this.txt_sup_abbreviation.Name = "txt_sup_abbreviation";
            this.txt_sup_abbreviation.Size = new System.Drawing.Size(282, 26);
            this.txt_sup_abbreviation.TabIndex = 5;
            // 
            // btn_save_A
            // 
            this.btn_save_A.Location = new System.Drawing.Point(423, 453);
            this.btn_save_A.Name = "btn_save_A";
            this.btn_save_A.Size = new System.Drawing.Size(98, 30);
            this.btn_save_A.TabIndex = 6;
            this.btn_save_A.Text = "保  存";
            this.btn_save_A.UseVisualStyleBackColor = true;
            // 
            // btn_cancel_A
            // 
            this.btn_cancel_A.Location = new System.Drawing.Point(544, 453);
            this.btn_cancel_A.Name = "btn_cancel_A";
            this.btn_cancel_A.Size = new System.Drawing.Size(98, 30);
            this.btn_cancel_A.TabIndex = 7;
            this.btn_cancel_A.Text = "取  消";
            this.btn_cancel_A.UseVisualStyleBackColor = true;
            // 
            // Frm_Supplier_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 595);
            this.Controls.Add(this.tbc_supplier_info);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Supplier_info";
            this.Text = "供应商信息窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Supplier_info_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Supplier_info_Load);
            this.tbc_supplier_info.ResumeLayout(false);
            this.tp_sup_base_info.ResumeLayout(false);
            this.tp_sup_base_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_supplier_info;
        private System.Windows.Forms.TabPage tp_sup_base_info;
        private System.Windows.Forms.TextBox txt_sup_abbreviation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_supplier_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_supid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_cancel_A;
        private System.Windows.Forms.Button btn_save_A;
    }
}