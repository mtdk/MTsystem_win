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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.mat_stockReportview = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // mat_stockReportview
            // 
            this.mat_stockReportview.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ds_mat_stockReport";
            this.mat_stockReportview.LocalReport.DataSources.Add(reportDataSource1);
            this.mat_stockReportview.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.mat_stockReportview.rdlc";
            this.mat_stockReportview.Location = new System.Drawing.Point(0, 0);
            this.mat_stockReportview.Name = "mat_stockReportview";
            this.mat_stockReportview.Size = new System.Drawing.Size(909, 638);
            this.mat_stockReportview.TabIndex = 0;
            // 
            // Frm_mat_stockReportview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 638);
            this.Controls.Add(this.mat_stockReportview);
            this.Name = "Frm_mat_stockReportview";
            this.Text = "Frm_mat_stockReportview";
            this.Load += new System.EventHandler(this.Frm_mat_stockReportview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer mat_stockReportview;
    }
}