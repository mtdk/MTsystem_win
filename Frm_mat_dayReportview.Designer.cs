namespace MTsystem_win
{
    partial class Frm_mat_dayReportview
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_matInput_report = new System.Windows.Forms.RadioButton();
            this.rdb_matOut_report = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Querydate = new System.Windows.Forms.DateTimePicker();
            this.btn_Query = new System.Windows.Forms.Button();
            this.mat_stockDayreportview = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "报表选项:";
            // 
            // rdb_matInput_report
            // 
            this.rdb_matInput_report.AutoSize = true;
            this.rdb_matInput_report.Location = new System.Drawing.Point(183, 18);
            this.rdb_matInput_report.Name = "rdb_matInput_report";
            this.rdb_matInput_report.Size = new System.Drawing.Size(99, 23);
            this.rdb_matInput_report.TabIndex = 1;
            this.rdb_matInput_report.TabStop = true;
            this.rdb_matInput_report.Text = "进仓报表";
            this.rdb_matInput_report.UseVisualStyleBackColor = true;
            // 
            // rdb_matOut_report
            // 
            this.rdb_matOut_report.AutoSize = true;
            this.rdb_matOut_report.Location = new System.Drawing.Point(288, 18);
            this.rdb_matOut_report.Name = "rdb_matOut_report";
            this.rdb_matOut_report.Size = new System.Drawing.Size(99, 23);
            this.rdb_matOut_report.TabIndex = 2;
            this.rdb_matOut_report.TabStop = true;
            this.rdb_matOut_report.Text = "出仓报表";
            this.rdb_matOut_report.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "查询日期:";
            // 
            // dtp_Querydate
            // 
            this.dtp_Querydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Querydate.Location = new System.Drawing.Point(489, 16);
            this.dtp_Querydate.Name = "dtp_Querydate";
            this.dtp_Querydate.Size = new System.Drawing.Size(144, 26);
            this.dtp_Querydate.TabIndex = 4;
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(639, 12);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(108, 34);
            this.btn_Query.TabIndex = 5;
            this.btn_Query.Text = "生成报表";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // mat_stockDayreportview
            // 
            reportDataSource2.Name = "ds_mat_stockReport";
            reportDataSource2.Value = null;
            this.mat_stockDayreportview.LocalReport.DataSources.Add(reportDataSource2);
            this.mat_stockDayreportview.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.mat_stockReportview.rdlc";
            this.mat_stockDayreportview.Location = new System.Drawing.Point(5, 55);
            this.mat_stockDayreportview.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mat_stockDayreportview.Name = "mat_stockDayreportview";
            this.mat_stockDayreportview.ShowBackButton = false;
            this.mat_stockDayreportview.ShowFindControls = false;
            this.mat_stockDayreportview.ShowRefreshButton = false;
            this.mat_stockDayreportview.ShowStopButton = false;
            this.mat_stockDayreportview.Size = new System.Drawing.Size(825, 800);
            this.mat_stockDayreportview.TabIndex = 6;
            // 
            // Frm_mat_daystockReportview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 861);
            this.Controls.Add(this.mat_stockDayreportview);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.dtp_Querydate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdb_matOut_report);
            this.Controls.Add(this.rdb_matInput_report);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_mat_daystockReportview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "材料日报表窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_matInput_report;
        private System.Windows.Forms.RadioButton rdb_matOut_report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Querydate;
        private System.Windows.Forms.Button btn_Query;
        private Microsoft.Reporting.WinForms.ReportViewer mat_stockDayreportview;
    }
}