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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_printSelectD = new System.Windows.Forms.RadioButton();
            this.rdb_printSelectC = new System.Windows.Forms.RadioButton();
            this.rdb_printSelectB = new System.Windows.Forms.RadioButton();
            this.rdb_printSelectA = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tagPrint_reportview = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_printSelectD);
            this.groupBox1.Controls.Add(this.rdb_printSelectC);
            this.groupBox1.Controls.Add(this.rdb_printSelectB);
            this.groupBox1.Controls.Add(this.rdb_printSelectA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "打印机选择";
            // 
            // rdb_printSelectD
            // 
            this.rdb_printSelectD.AutoSize = true;
            this.rdb_printSelectD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_printSelectD.Location = new System.Drawing.Point(741, 27);
            this.rdb_printSelectD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdb_printSelectD.Name = "rdb_printSelectD";
            this.rdb_printSelectD.Size = new System.Drawing.Size(122, 20);
            this.rdb_printSelectD.TabIndex = 6;
            this.rdb_printSelectD.Text = "DL-888D(NEW)";
            this.rdb_printSelectD.UseVisualStyleBackColor = true;
            this.rdb_printSelectD.Visible = false;
            // 
            // rdb_printSelectC
            // 
            this.rdb_printSelectC.AutoSize = true;
            this.rdb_printSelectC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_printSelectC.Location = new System.Drawing.Point(315, 27);
            this.rdb_printSelectC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdb_printSelectC.Name = "rdb_printSelectC";
            this.rdb_printSelectC.Size = new System.Drawing.Size(130, 20);
            this.rdb_printSelectC.TabIndex = 5;
            this.rdb_printSelectC.Text = "ESPON LQ-630K";
            this.rdb_printSelectC.UseVisualStyleBackColor = true;
            // 
            // rdb_printSelectB
            // 
            this.rdb_printSelectB.AutoSize = true;
            this.rdb_printSelectB.Checked = true;
            this.rdb_printSelectB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdb_printSelectB.Location = new System.Drawing.Point(7, 27);
            this.rdb_printSelectB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdb_printSelectB.Name = "rdb_printSelectB";
            this.rdb_printSelectB.Size = new System.Drawing.Size(162, 20);
            this.rdb_printSelectB.TabIndex = 4;
            this.rdb_printSelectB.TabStop = true;
            this.rdb_printSelectB.Text = "ESPON LQ-635K(新)";
            this.rdb_printSelectB.UseVisualStyleBackColor = true;
            this.rdb_printSelectB.CheckedChanged += new System.EventHandler(this.rdb_printSelectB_CheckedChanged);
            // 
            // rdb_printSelectA
            // 
            this.rdb_printSelectA.AutoSize = true;
            this.rdb_printSelectA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_printSelectA.Location = new System.Drawing.Point(177, 27);
            this.rdb_printSelectA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdb_printSelectA.Name = "rdb_printSelectA";
            this.rdb_printSelectA.Size = new System.Drawing.Size(130, 20);
            this.rdb_printSelectA.TabIndex = 3;
            this.rdb_printSelectA.Text = "ESPON LQ-635K";
            this.rdb_printSelectA.UseVisualStyleBackColor = true;
            this.rdb_printSelectA.CheckedChanged += new System.EventHandler(this.rdb_printSelectA_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tagPrint_reportview);
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 675);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "打印预览";
            // 
            // tagPrint_reportview
            // 
            this.tagPrint_reportview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagPrint_reportview.Location = new System.Drawing.Point(3, 22);
            this.tagPrint_reportview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tagPrint_reportview.Name = "tagPrint_reportview";
            this.tagPrint_reportview.ShowBackButton = false;
            this.tagPrint_reportview.ShowFindControls = false;
            this.tagPrint_reportview.ShowPageNavigationControls = false;
            this.tagPrint_reportview.ShowRefreshButton = false;
            this.tagPrint_reportview.ShowStopButton = false;
            this.tagPrint_reportview.ShowZoomControl = false;
            this.tagPrint_reportview.Size = new System.Drawing.Size(864, 650);
            this.tagPrint_reportview.TabIndex = 1;
            this.tagPrint_reportview.PrintingBegin += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.tagPrint_reportview_PrintingBegin);
            // 
            // Frm_tag_print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(894, 771);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_tag_print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品标签打印窗口";
            this.Load += new System.EventHandler(this.Frm_tag_print_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_printSelectB;
        private System.Windows.Forms.RadioButton rdb_printSelectA;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer tagPrint_reportview;
        private System.Windows.Forms.RadioButton rdb_printSelectC;
        private System.Windows.Forms.RadioButton rdb_printSelectD;
    }
}