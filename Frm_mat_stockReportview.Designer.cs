namespace MTsystem_win
{
    partial class Frm_mat_stockReportview
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
            this.mat_stockReportview = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mat_stockReportview
            // 
            reportDataSource1.Name = "ds_mat_stockReport";
            reportDataSource1.Value = null;
            this.mat_stockReportview.LocalReport.DataSources.Add(reportDataSource1);
            this.mat_stockReportview.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.mat_stockReportview.rdlc";
            this.mat_stockReportview.Location = new System.Drawing.Point(2, 68);
            this.mat_stockReportview.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mat_stockReportview.Name = "mat_stockReportview";
            this.mat_stockReportview.ShowBackButton = false;
            this.mat_stockReportview.ShowFindControls = false;
            this.mat_stockReportview.ShowRefreshButton = false;
            this.mat_stockReportview.ShowStopButton = false;
            this.mat_stockReportview.Size = new System.Drawing.Size(830, 610);
            this.mat_stockReportview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Frm_mat_stockReportview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mat_stockReportview);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Frm_mat_stockReportview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_mat_stockReportview";
            this.Load += new System.EventHandler(this.Frm_mat_stockReportview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer mat_stockReportview;
        private System.Windows.Forms.Label label1;
    }
}