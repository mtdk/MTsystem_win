namespace MTsystem_win
{
    partial class Frm_IndentFormPrint
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbReadPrint = new System.Windows.Forms.RadioButton();
            this.rdbCgPrint = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "IndentPurPrint";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EnterpriseMS.PrintForms.Rp_IndentPurPrint.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 22);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(834, 590);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbReadPrint);
            this.groupBox1.Controls.Add(this.rdbCgPrint);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能选择区";
            // 
            // rdbReadPrint
            // 
            this.rdbReadPrint.AutoSize = true;
            this.rdbReadPrint.Location = new System.Drawing.Point(101, 22);
            this.rdbReadPrint.Name = "rdbReadPrint";
            this.rdbReadPrint.Size = new System.Drawing.Size(83, 24);
            this.rdbReadPrint.TabIndex = 1;
            this.rdbReadPrint.Text = "传阅打印";
            this.rdbReadPrint.UseVisualStyleBackColor = true;
            this.rdbReadPrint.CheckedChanged += new System.EventHandler(this.rdbReadPrint_CheckedChanged);
            // 
            // rdbCgPrint
            // 
            this.rdbCgPrint.AutoSize = true;
            this.rdbCgPrint.Checked = true;
            this.rdbCgPrint.Location = new System.Drawing.Point(12, 22);
            this.rdbCgPrint.Name = "rdbCgPrint";
            this.rdbCgPrint.Size = new System.Drawing.Size(83, 24);
            this.rdbCgPrint.TabIndex = 0;
            this.rdbCgPrint.TabStop = true;
            this.rdbCgPrint.Text = "采购打印";
            this.rdbCgPrint.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reportViewer1);
            this.groupBox2.Location = new System.Drawing.Point(0, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 615);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "打印显示区";
            // 
            // Frm_IndentFormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 687);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_IndentFormPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "采购订单打印";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_IndentFormPrint_FormClosed);
            this.Load += new System.EventHandler(this.IndentFormPrint_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbReadPrint;
        private System.Windows.Forms.RadioButton rdbCgPrint;
        private System.Windows.Forms.GroupBox groupBox2;




    }
}