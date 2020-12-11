namespace MTsystem_win
{
    partial class Frm_tag_print
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
            this.tagPrint_reportview = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // tagPrint_reportview
            // 
            this.tagPrint_reportview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagPrint_reportview.Location = new System.Drawing.Point(0, 0);
            this.tagPrint_reportview.Name = "tagPrint_reportview";
            this.tagPrint_reportview.ShowBackButton = false;
            this.tagPrint_reportview.ShowExportButton = false;
            this.tagPrint_reportview.ShowFindControls = false;
            this.tagPrint_reportview.ShowPageNavigationControls = false;
            this.tagPrint_reportview.ShowRefreshButton = false;
            this.tagPrint_reportview.ShowStopButton = false;
            this.tagPrint_reportview.ShowZoomControl = false;
            this.tagPrint_reportview.Size = new System.Drawing.Size(819, 711);
            this.tagPrint_reportview.TabIndex = 0;
            this.tagPrint_reportview.PrintingBegin += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.tagPrint_reportview_PrintingBegin);
            // 
            // Frm_tag_print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 711);
            this.Controls.Add(this.tagPrint_reportview);
            this.Name = "Frm_tag_print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品标签打印窗口";
            this.Load += new System.EventHandler(this.Frm_tag_print_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer tagPrint_reportview;
    }
}