namespace MTsystem_win
{
    partial class Frm_envelope_print
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Cusid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cusname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.envelope_reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_confirm);
            this.groupBox1.Controls.Add(this.txt_Cusname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Cusid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "打印内容选择区";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "客户编号:";
            // 
            // txt_Cusid
            // 
            this.txt_Cusid.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cusid.Location = new System.Drawing.Point(102, 29);
            this.txt_Cusid.Name = "txt_Cusid";
            this.txt_Cusid.ReadOnly = true;
            this.txt_Cusid.Size = new System.Drawing.Size(100, 30);
            this.txt_Cusid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "客户名称:";
            // 
            // txt_Cusname
            // 
            this.txt_Cusname.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cusname.Location = new System.Drawing.Point(304, 29);
            this.txt_Cusname.Name = "txt_Cusname";
            this.txt_Cusname.Size = new System.Drawing.Size(460, 30);
            this.txt_Cusname.TabIndex = 0;
            this.txt_Cusname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cusname_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.envelope_reportViewer);
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(995, 489);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(770, 28);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(82, 33);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "确定";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // envelope_reportViewer
            // 
            this.envelope_reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.envelope_reportViewer.Location = new System.Drawing.Point(3, 22);
            this.envelope_reportViewer.Name = "envelope_reportViewer";
            this.envelope_reportViewer.ShowBackButton = false;
            this.envelope_reportViewer.ShowExportButton = false;
            this.envelope_reportViewer.ShowFindControls = false;
            this.envelope_reportViewer.ShowPageNavigationControls = false;
            this.envelope_reportViewer.ShowRefreshButton = false;
            this.envelope_reportViewer.ShowStopButton = false;
            this.envelope_reportViewer.ShowZoomControl = false;
            this.envelope_reportViewer.Size = new System.Drawing.Size(989, 464);
            this.envelope_reportViewer.TabIndex = 0;
            // 
            // Frm_envelope_print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_envelope_print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信封打印窗口";
            this.Load += new System.EventHandler(this.Frm_envelope_print_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TextBox txt_Cusname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Cusid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer envelope_reportViewer;
    }
}