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
            this.btn_Query = new System.Windows.Forms.Button();
            this.rdb_sortDatetime = new System.Windows.Forms.RadioButton();
            this.rdb_sortProid = new System.Windows.Forms.RadioButton();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Querydate = new System.Windows.Forms.CheckBox();
            this.txt_cusName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.product_outputallReportview = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Query);
            this.groupBox1.Controls.Add(this.rdb_sortDatetime);
            this.groupBox1.Controls.Add(this.rdb_sortProid);
            this.groupBox1.Controls.Add(this.dtp_end);
            this.groupBox1.Controls.Add(this.dtp_start);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_Querydate);
            this.groupBox1.Controls.Add(this.txt_cusName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1168, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询选择区";
            // 
            // btn_Query
            // 
            this.btn_Query.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Query.Location = new System.Drawing.Point(1072, 35);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 49);
            this.btn_Query.TabIndex = 10;
            this.btn_Query.Text = "开始\r\n查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // rdb_sortDatetime
            // 
            this.rdb_sortDatetime.AutoSize = true;
            this.rdb_sortDatetime.Location = new System.Drawing.Point(913, 66);
            this.rdb_sortDatetime.Name = "rdb_sortDatetime";
            this.rdb_sortDatetime.Size = new System.Drawing.Size(153, 23);
            this.rdb_sortDatetime.TabIndex = 12;
            this.rdb_sortDatetime.TabStop = true;
            this.rdb_sortDatetime.Text = "按产品时间排序";
            this.rdb_sortDatetime.UseVisualStyleBackColor = true;
            // 
            // rdb_sortProid
            // 
            this.rdb_sortProid.AutoSize = true;
            this.rdb_sortProid.Location = new System.Drawing.Point(913, 32);
            this.rdb_sortProid.Name = "rdb_sortProid";
            this.rdb_sortProid.Size = new System.Drawing.Size(153, 23);
            this.rdb_sortProid.TabIndex = 11;
            this.rdb_sortProid.TabStop = true;
            this.rdb_sortProid.Text = "按产品编号排序";
            this.rdb_sortProid.UseVisualStyleBackColor = true;
            // 
            // dtp_end
            // 
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(732, 66);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(175, 26);
            this.dtp_end.TabIndex = 10;
            // 
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(732, 29);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(175, 26);
            this.dtp_start.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(638, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "结束时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "开始时间：";
            // 
            // cb_Querydate
            // 
            this.cb_Querydate.AutoSize = true;
            this.cb_Querydate.Location = new System.Drawing.Point(496, 52);
            this.cb_Querydate.Name = "cb_Querydate";
            this.cb_Querydate.Size = new System.Drawing.Size(136, 23);
            this.cb_Querydate.TabIndex = 2;
            this.cb_Querydate.Text = "添加查询时间";
            this.cb_Querydate.UseVisualStyleBackColor = true;
            // 
            // txt_cusName
            // 
            this.txt_cusName.Location = new System.Drawing.Point(148, 50);
            this.txt_cusName.Name = "txt_cusName";
            this.txt_cusName.Size = new System.Drawing.Size(342, 26);
            this.txt_cusName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "按客户名称查询：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.product_outputallReportview);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1168, 795);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "报表显示区";
            // 
            // product_outputallReportview
            // 
            this.product_outputallReportview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_outputallReportview.Location = new System.Drawing.Point(3, 20);
            this.product_outputallReportview.Name = "product_outputallReportview";
            this.product_outputallReportview.Size = new System.Drawing.Size(1162, 772);
            this.product_outputallReportview.TabIndex = 0;
            // 
            // Frm_product_outputReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 941);
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
        private System.Windows.Forms.TextBox txt_cusName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_Querydate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb_sortDatetime;
        private System.Windows.Forms.RadioButton rdb_sortProid;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer product_outputallReportview;
    }
}