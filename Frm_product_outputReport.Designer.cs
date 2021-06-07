namespace MTsystem_win
{
    partial class Frm_product_outputReport
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
            this.rdb_Productid = new System.Windows.Forms.RadioButton();
            this.rdb_Account_Statement = new System.Windows.Forms.RadioButton();
            this.rdb_all = new System.Windows.Forms.RadioButton();
            this.btn_Query = new System.Windows.Forms.Button();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_QueryCondition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.product_outputallReportview = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdb_Productid);
            this.groupBox1.Controls.Add(this.rdb_Account_Statement);
            this.groupBox1.Controls.Add(this.rdb_all);
            this.groupBox1.Controls.Add(this.btn_Query);
            this.groupBox1.Controls.Add(this.dtp_end);
            this.groupBox1.Controls.Add(this.dtp_start);
            this.groupBox1.Controls.Add(this.txt_QueryCondition);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1168, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询选择区";
            // 
            // rdb_Productid
            // 
            this.rdb_Productid.AutoSize = true;
            this.rdb_Productid.Location = new System.Drawing.Point(264, 22);
            this.rdb_Productid.Name = "rdb_Productid";
            this.rdb_Productid.Size = new System.Drawing.Size(117, 23);
            this.rdb_Productid.TabIndex = 13;
            this.rdb_Productid.Text = "按品名查找";
            this.rdb_Productid.UseVisualStyleBackColor = true;
            // 
            // rdb_Account_Statement
            // 
            this.rdb_Account_Statement.AutoSize = true;
            this.rdb_Account_Statement.Location = new System.Drawing.Point(141, 22);
            this.rdb_Account_Statement.Name = "rdb_Account_Statement";
            this.rdb_Account_Statement.Size = new System.Drawing.Size(117, 23);
            this.rdb_Account_Statement.TabIndex = 12;
            this.rdb_Account_Statement.Text = "客户对账单";
            this.rdb_Account_Statement.UseVisualStyleBackColor = true;
            // 
            // rdb_all
            // 
            this.rdb_all.AutoSize = true;
            this.rdb_all.Checked = true;
            this.rdb_all.Location = new System.Drawing.Point(36, 22);
            this.rdb_all.Name = "rdb_all";
            this.rdb_all.Size = new System.Drawing.Size(99, 23);
            this.rdb_all.TabIndex = 11;
            this.rdb_all.TabStop = true;
            this.rdb_all.Text = "出货报表";
            this.rdb_all.UseVisualStyleBackColor = true;
            // 
            // btn_Query
            // 
            this.btn_Query.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Query.Location = new System.Drawing.Point(958, 36);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 49);
            this.btn_Query.TabIndex = 10;
            this.btn_Query.Text = "开始\r\n查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // dtp_end
            // 
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(678, 62);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(175, 26);
            this.dtp_end.TabIndex = 10;
            // 
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(678, 25);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(175, 26);
            this.dtp_start.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "结束时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "开始时间：";
            // 
            // txt_QueryCondition
            // 
            this.txt_QueryCondition.Location = new System.Drawing.Point(141, 58);
            this.txt_QueryCondition.Name = "txt_QueryCondition";
            this.txt_QueryCondition.Size = new System.Drawing.Size(392, 26);
            this.txt_QueryCondition.TabIndex = 1;
            this.txt_QueryCondition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cusName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询条件：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.product_outputallReportview);
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1168, 814);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "报表显示区";
            // 
            // product_outputallReportview
            // 
            this.product_outputallReportview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_outputallReportview.Location = new System.Drawing.Point(3, 20);
            this.product_outputallReportview.Name = "product_outputallReportview";
            this.product_outputallReportview.ShowBackButton = false;
            this.product_outputallReportview.ShowExportButton = false;
            this.product_outputallReportview.ShowFindControls = false;
            this.product_outputallReportview.ShowRefreshButton = false;
            this.product_outputallReportview.ShowStopButton = false;
            this.product_outputallReportview.Size = new System.Drawing.Size(1162, 791);
            this.product_outputallReportview.TabIndex = 0;
            // 
            // Frm_product_outputReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_product_outputReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品出库报表";
            this.Load += new System.EventHandler(this.Frm_product_outputReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_QueryCondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer product_outputallReportview;
        private System.Windows.Forms.RadioButton rdb_Account_Statement;
        private System.Windows.Forms.RadioButton rdb_all;
        private System.Windows.Forms.RadioButton rdb_Productid;
    }
}