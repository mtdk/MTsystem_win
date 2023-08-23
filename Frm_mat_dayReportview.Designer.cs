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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_matInput_report = new System.Windows.Forms.RadioButton();
            this.rdb_matOut_report = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Querydate = new System.Windows.Forms.DateTimePicker();
            this.btn_Query = new System.Windows.Forms.Button();
            this.mat_dayReportview = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_Queryid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_QuerydateEnd = new System.Windows.Forms.DateTimePicker();
            this.cb_date = new System.Windows.Forms.CheckBox();
            this.rdb_matReturn_report = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "报表选项:";
            // 
            // rdb_matInput_report
            // 
            this.rdb_matInput_report.AutoSize = true;
            this.rdb_matInput_report.Checked = true;
            this.rdb_matInput_report.Location = new System.Drawing.Point(108, 10);
            this.rdb_matInput_report.Name = "rdb_matInput_report";
            this.rdb_matInput_report.Size = new System.Drawing.Size(99, 23);
            this.rdb_matInput_report.TabIndex = 1;
            this.rdb_matInput_report.TabStop = true;
            this.rdb_matInput_report.Text = "进仓报表";
            this.rdb_matInput_report.UseVisualStyleBackColor = true;
            this.rdb_matInput_report.CheckedChanged += new System.EventHandler(this.rdb_matInput_report_CheckedChanged);
            // 
            // rdb_matOut_report
            // 
            this.rdb_matOut_report.AutoSize = true;
            this.rdb_matOut_report.Location = new System.Drawing.Point(213, 10);
            this.rdb_matOut_report.Name = "rdb_matOut_report";
            this.rdb_matOut_report.Size = new System.Drawing.Size(99, 23);
            this.rdb_matOut_report.TabIndex = 2;
            this.rdb_matOut_report.Text = "出仓报表";
            this.rdb_matOut_report.UseVisualStyleBackColor = true;
            this.rdb_matOut_report.CheckedChanged += new System.EventHandler(this.rdb_matOut_report_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "开始时间:";
            // 
            // dtp_Querydate
            // 
            this.dtp_Querydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Querydate.Location = new System.Drawing.Point(354, 47);
            this.dtp_Querydate.Name = "dtp_Querydate";
            this.dtp_Querydate.Size = new System.Drawing.Size(144, 26);
            this.dtp_Querydate.TabIndex = 4;
            // 
            // btn_Query
            // 
            this.btn_Query.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Query.Location = new System.Drawing.Point(750, 43);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(70, 34);
            this.btn_Query.TabIndex = 5;
            this.btn_Query.Text = "确定";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // mat_dayReportview
            // 
            reportDataSource9.Name = "ds_mat_stockReport";
            reportDataSource9.Value = null;
            this.mat_dayReportview.LocalReport.DataSources.Add(reportDataSource9);
            this.mat_dayReportview.LocalReport.ReportEmbeddedResource = "MTsystem_win.printForm.mat_dayoutReportview.rdlc";
            this.mat_dayReportview.Location = new System.Drawing.Point(8, 85);
            this.mat_dayReportview.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mat_dayReportview.Name = "mat_dayReportview";
            this.mat_dayReportview.ShowBackButton = false;
            this.mat_dayReportview.ShowFindControls = false;
            this.mat_dayReportview.ShowRefreshButton = false;
            this.mat_dayReportview.ShowStopButton = false;
            this.mat_dayReportview.Size = new System.Drawing.Size(812, 780);
            this.mat_dayReportview.TabIndex = 6;
            // 
            // txt_Queryid
            // 
            this.txt_Queryid.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Queryid.Location = new System.Drawing.Point(108, 46);
            this.txt_Queryid.Name = "txt_Queryid";
            this.txt_Queryid.Size = new System.Drawing.Size(144, 30);
            this.txt_Queryid.TabIndex = 8;
            this.txt_Queryid.DoubleClick += new System.EventHandler(this.txt_Queryid_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "材料编号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "结束时间:";
            // 
            // dtp_QuerydateEnd
            // 
            this.dtp_QuerydateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_QuerydateEnd.Location = new System.Drawing.Point(600, 47);
            this.dtp_QuerydateEnd.Name = "dtp_QuerydateEnd";
            this.dtp_QuerydateEnd.Size = new System.Drawing.Size(144, 26);
            this.dtp_QuerydateEnd.TabIndex = 10;
            // 
            // cb_date
            // 
            this.cb_date.AutoSize = true;
            this.cb_date.Checked = true;
            this.cb_date.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_date.Location = new System.Drawing.Point(427, 12);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(118, 23);
            this.cb_date.TabIndex = 11;
            this.cb_date.Text = "按日期排序";
            this.cb_date.UseVisualStyleBackColor = true;
            // 
            // rdb_matReturn_report
            // 
            this.rdb_matReturn_report.AutoSize = true;
            this.rdb_matReturn_report.Location = new System.Drawing.Point(322, 10);
            this.rdb_matReturn_report.Name = "rdb_matReturn_report";
            this.rdb_matReturn_report.Size = new System.Drawing.Size(99, 23);
            this.rdb_matReturn_report.TabIndex = 12;
            this.rdb_matReturn_report.Text = "退货报表";
            this.rdb_matReturn_report.UseVisualStyleBackColor = true;
            this.rdb_matReturn_report.CheckedChanged += new System.EventHandler(this.rdb_matReturn_report_CheckedChanged);
            // 
            // Frm_mat_dayReportview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 871);
            this.Controls.Add(this.rdb_matReturn_report);
            this.Controls.Add(this.cb_date);
            this.Controls.Add(this.dtp_QuerydateEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Queryid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mat_dayReportview);
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
            this.Name = "Frm_mat_dayReportview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "材料日报表窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_mat_dayReportview_FormClosed);
            this.Load += new System.EventHandler(this.Frm_mat_dayReportview_Load);
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
        private Microsoft.Reporting.WinForms.ReportViewer mat_dayReportview;
        private System.Windows.Forms.TextBox txt_Queryid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_QuerydateEnd;
        private System.Windows.Forms.CheckBox cb_date;
        private System.Windows.Forms.RadioButton rdb_matReturn_report;
    }
}