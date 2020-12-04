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
            this.SuspendLayout();
            // 
            // mat_stockReportview
            // 
            this.mat_stockReportview.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ds_mat_stockReport";
            reportDataSource1.Value = null;
            this.mat_stockReportview.LocalReport.DataSources.Add(reportDataSource1);
            this.mat_stockReportview.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.mat_stockReportview.rdlc";
            this.mat_stockReportview.Location = new System.Drawing.Point(0, 0);
            this.mat_stockReportview.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mat_stockReportview.Name = "mat_stockReportview";
            this.mat_stockReportview.ShowBackButton = false;
            this.mat_stockReportview.ShowFindControls = false;
            this.mat_stockReportview.ShowRefreshButton = false;
            this.mat_stockReportview.ShowStopButton = false;
            this.mat_stockReportview.Size = new System.Drawing.Size(834, 861);
            this.mat_stockReportview.TabIndex = 0;
            // 
            // Frm_mat_stockReportview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 861);
            this.Controls.Add(this.mat_stockReportview);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_mat_stockReportview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存报表窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_mat_stockReportview_FormClosed);
            this.Load += new System.EventHandler(this.Frm_mat_stockReportview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer mat_stockReportview;
    }
}