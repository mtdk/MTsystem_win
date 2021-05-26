namespace MTsystem_win
{
    partial class Frm_pro_outStatus_update
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Upstatus = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_pro_outview = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Pro_outmain_view = new System.Windows.Forms.DataGridView();
            this.txt_Outputid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pro_outview)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pro_outmain_view)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_Outputid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1490, 761);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询区";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Upstatus);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(599, 481);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(576, 271);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "状态修改";
            // 
            // btn_Upstatus
            // 
            this.btn_Upstatus.ForeColor = System.Drawing.Color.Red;
            this.btn_Upstatus.Location = new System.Drawing.Point(145, 82);
            this.btn_Upstatus.Name = "btn_Upstatus";
            this.btn_Upstatus.Size = new System.Drawing.Size(75, 29);
            this.btn_Upstatus.TabIndex = 5;
            this.btn_Upstatus.Text = "修改";
            this.btn_Upstatus.UseVisualStyleBackColor = true;
            this.btn_Upstatus.Click += new System.EventHandler(this.btn_Upstatus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "NULL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "NULL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "货号：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_pro_outview);
            this.groupBox3.Location = new System.Drawing.Point(596, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(883, 414);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "货单明细";
            // 
            // dgv_pro_outview
            // 
            this.dgv_pro_outview.AllowUserToAddRows = false;
            this.dgv_pro_outview.AllowUserToDeleteRows = false;
            this.dgv_pro_outview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_pro_outview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pro_outview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_pro_outview.Location = new System.Drawing.Point(3, 22);
            this.dgv_pro_outview.Name = "dgv_pro_outview";
            this.dgv_pro_outview.ReadOnly = true;
            this.dgv_pro_outview.RowTemplate.Height = 23;
            this.dgv_pro_outview.Size = new System.Drawing.Size(877, 389);
            this.dgv_pro_outview.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Pro_outmain_view);
            this.groupBox2.Location = new System.Drawing.Point(10, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 694);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "结果显示区";
            // 
            // dgv_Pro_outmain_view
            // 
            this.dgv_Pro_outmain_view.AllowUserToAddRows = false;
            this.dgv_Pro_outmain_view.AllowUserToDeleteRows = false;
            this.dgv_Pro_outmain_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Pro_outmain_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pro_outmain_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Pro_outmain_view.Location = new System.Drawing.Point(3, 22);
            this.dgv_Pro_outmain_view.Name = "dgv_Pro_outmain_view";
            this.dgv_Pro_outmain_view.ReadOnly = true;
            this.dgv_Pro_outmain_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Pro_outmain_view.Size = new System.Drawing.Size(574, 669);
            this.dgv_Pro_outmain_view.TabIndex = 0;
            this.dgv_Pro_outmain_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pro_outmain_view_CellClick);
            // 
            // txt_Outputid
            // 
            this.txt_Outputid.Location = new System.Drawing.Point(111, 29);
            this.txt_Outputid.Name = "txt_Outputid";
            this.txt_Outputid.Size = new System.Drawing.Size(274, 26);
            this.txt_Outputid.TabIndex = 1;
            this.txt_Outputid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Outputid_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "货号查询：";
            // 
            // Frm_pro_outStatus_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 785);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_pro_outStatus_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出货单状态修改窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_pro_outStatus_update_FormClosed);
            this.Load += new System.EventHandler(this.Frm_pro_outStatus_update_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pro_outview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pro_outmain_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Outputid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Pro_outmain_view;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_pro_outview;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Upstatus;
    }
}