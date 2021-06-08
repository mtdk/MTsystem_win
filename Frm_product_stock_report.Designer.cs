namespace MTsystem_win
{
    partial class Frm_product_stock_report
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
            this.product_stock_reportview = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.product_stock_reportview);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 887);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "结果显示区";
            // 
            // product_stock_reportview
            // 
            this.product_stock_reportview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_stock_reportview.Location = new System.Drawing.Point(3, 22);
            this.product_stock_reportview.Name = "product_stock_reportview";
            this.product_stock_reportview.ShowBackButton = false;
            this.product_stock_reportview.ShowExportButton = false;
            this.product_stock_reportview.ShowFindControls = false;
            this.product_stock_reportview.ShowRefreshButton = false;
            this.product_stock_reportview.ShowStopButton = false;
            this.product_stock_reportview.Size = new System.Drawing.Size(1154, 862);
            this.product_stock_reportview.TabIndex = 0;
            // 
            // Frm_product_stock_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 911);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_product_stock_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品进仓报表";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_product_stock_report_FormClosed);
            this.Load += new System.EventHandler(this.Frm_product_stock_report_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer product_stock_reportview;
    }
}