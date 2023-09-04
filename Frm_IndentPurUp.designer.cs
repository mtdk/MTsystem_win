namespace MTsystem_win
{
    partial class Frm_IndentPurUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_IndentPurUp));
            this.lbTotalSum = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtConsignee = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dtpRADate = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSupplierFax = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSupplierMan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbSupplierID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbIndentID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStateUp = new System.Windows.Forms.Button();
            this.dgvIndentList = new System.Windows.Forms.DataGridView();
            this.lbKdDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIndentStatus = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFormStatus = new System.Windows.Forms.Label();
            this.txtConvention = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndentList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTotalSum
            // 
            this.lbTotalSum.AutoSize = true;
            this.lbTotalSum.Location = new System.Drawing.Point(716, 323);
            this.lbTotalSum.Name = "lbTotalSum";
            this.lbTotalSum.Size = new System.Drawing.Size(0, 20);
            this.lbTotalSum.TabIndex = 96;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(659, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 95;
            this.label11.Text = "合计：";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(677, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 30);
            this.btnSave.TabIndex = 93;
            this.btnSave.Text = "保  存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtConsignee
            // 
            this.txtConsignee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsignee.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtConsignee.Location = new System.Drawing.Point(553, 320);
            this.txtConsignee.MaxLength = 10;
            this.txtConsignee.Name = "txtConsignee";
            this.txtConsignee.Size = new System.Drawing.Size(100, 26);
            this.txtConsignee.TabIndex = 82;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(482, 323);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 20);
            this.label25.TabIndex = 81;
            this.label25.Text = "收货人：";
            // 
            // txtPrompt
            // 
            this.txtPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrompt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPrompt.Location = new System.Drawing.Point(372, 320);
            this.txtPrompt.MaxLength = 10;
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(100, 26);
            this.txtPrompt.TabIndex = 80;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(293, 323);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 20);
            this.label24.TabIndex = 79;
            this.label24.Text = "结款方式：";
            // 
            // dtpRADate
            // 
            this.dtpRADate.CalendarFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpRADate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRADate.Location = new System.Drawing.Point(154, 320);
            this.dtpRADate.Name = "dtpRADate";
            this.dtpRADate.Size = new System.Drawing.Size(133, 26);
            this.dtpRADate.TabIndex = 78;
            this.dtpRADate.Value = new System.DateTime(2012, 4, 27, 0, 0, 0, 0);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(41, 322);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 20);
            this.label23.TabIndex = 77;
            this.label23.Text = "要求送达时间：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 20);
            this.label15.TabIndex = 60;
            this.label15.Text = "订购时间：";
            // 
            // txtSupplierFax
            // 
            this.txtSupplierFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierFax.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSupplierFax.Location = new System.Drawing.Point(488, 74);
            this.txtSupplierFax.Name = "txtSupplierFax";
            this.txtSupplierFax.Size = new System.Drawing.Size(151, 26);
            this.txtSupplierFax.TabIndex = 59;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(415, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 58;
            this.label14.Text = "传    真：";
            // 
            // txtSupplierMan
            // 
            this.txtSupplierMan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSupplierMan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierMan.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSupplierMan.Location = new System.Drawing.Point(290, 74);
            this.txtSupplierMan.Name = "txtSupplierMan";
            this.txtSupplierMan.ReadOnly = true;
            this.txtSupplierMan.Size = new System.Drawing.Size(119, 26);
            this.txtSupplierMan.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(203, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 56;
            this.label13.Text = "联  系  人：";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSupplierName.Location = new System.Drawing.Point(298, 37);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.ReadOnly = true;
            this.txtSupplierName.Size = new System.Drawing.Size(292, 26);
            this.txtSupplierName.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(203, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 20);
            this.label12.TabIndex = 54;
            this.label12.Text = "供应商名称：";
            // 
            // lbSupplierID
            // 
            this.lbSupplierID.AutoSize = true;
            this.lbSupplierID.ForeColor = System.Drawing.Color.Red;
            this.lbSupplierID.Location = new System.Drawing.Point(114, 40);
            this.lbSupplierID.Name = "lbSupplierID";
            this.lbSupplierID.Size = new System.Drawing.Size(93, 20);
            this.lbSupplierID.TabIndex = 53;
            this.lbSupplierID.Text = "供应商编号！";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "供应商编号：";
            // 
            // lbIndentID
            // 
            this.lbIndentID.AutoSize = true;
            this.lbIndentID.ForeColor = System.Drawing.Color.Red;
            this.lbIndentID.Location = new System.Drawing.Point(263, 11);
            this.lbIndentID.Name = "lbIndentID";
            this.lbIndentID.Size = new System.Drawing.Size(65, 20);
            this.lbIndentID.TabIndex = 50;
            this.lbIndentID.Text = "订单号！";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "订单号:";
            // 
            // btnStateUp
            // 
            this.btnStateUp.ForeColor = System.Drawing.Color.Red;
            this.btnStateUp.Location = new System.Drawing.Point(596, 34);
            this.btnStateUp.Name = "btnStateUp";
            this.btnStateUp.Size = new System.Drawing.Size(75, 30);
            this.btnStateUp.TabIndex = 98;
            this.btnStateUp.Text = "状态修改";
            this.btnStateUp.UseVisualStyleBackColor = true;
            this.btnStateUp.Click += new System.EventHandler(this.btnStateUp_Click);
            // 
            // dgvIndentList
            // 
            this.dgvIndentList.AllowUserToAddRows = false;
            this.dgvIndentList.AllowUserToDeleteRows = false;
            this.dgvIndentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndentList.Location = new System.Drawing.Point(18, 108);
            this.dgvIndentList.Name = "dgvIndentList";
            this.dgvIndentList.RowTemplate.Height = 23;
            this.dgvIndentList.Size = new System.Drawing.Size(814, 206);
            this.dgvIndentList.TabIndex = 99;
            this.dgvIndentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIndentList_CellDoubleClick);
            this.dgvIndentList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIndentList_CellEndEdit);
            this.dgvIndentList.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvIndentList_CellValidating);
            // 
            // lbKdDate
            // 
            this.lbKdDate.AutoSize = true;
            this.lbKdDate.Location = new System.Drawing.Point(100, 77);
            this.lbKdDate.Name = "lbKdDate";
            this.lbKdDate.Size = new System.Drawing.Size(50, 20);
            this.lbKdDate.TabIndex = 100;
            this.lbKdDate.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "订单状态：";
            // 
            // lbIndentStatus
            // 
            this.lbIndentStatus.AutoSize = true;
            this.lbIndentStatus.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbIndentStatus.ForeColor = System.Drawing.Color.Red;
            this.lbIndentStatus.Location = new System.Drawing.Point(100, 11);
            this.lbIndentStatus.Name = "lbIndentStatus";
            this.lbIndentStatus.Size = new System.Drawing.Size(79, 19);
            this.lbIndentStatus.TabIndex = 102;
            this.lbIndentStatus.Text = "订单状态！";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(753, 34);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(70, 30);
            this.btnPrint.TabIndex = 103;
            this.btnPrint.Text = "打  印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 104;
            this.label2.Text = "订单状态：";
            // 
            // lbFormStatus
            // 
            this.lbFormStatus.AutoSize = true;
            this.lbFormStatus.Location = new System.Drawing.Point(737, 77);
            this.lbFormStatus.Name = "lbFormStatus";
            this.lbFormStatus.Size = new System.Drawing.Size(50, 20);
            this.lbFormStatus.TabIndex = 105;
            this.lbFormStatus.Text = "label3";
            // 
            // txtConvention
            // 
            this.txtConvention.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConvention.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtConvention.Location = new System.Drawing.Point(6, 352);
            this.txtConvention.Multiline = true;
            this.txtConvention.Name = "txtConvention";
            this.txtConvention.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConvention.Size = new System.Drawing.Size(826, 203);
            this.txtConvention.TabIndex = 106;
            this.txtConvention.Text = resources.GetString("txtConvention.Text");
            // 
            // Frm_IndentPurUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 561);
            this.Controls.Add(this.txtConvention);
            this.Controls.Add(this.lbFormStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lbIndentStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbKdDate);
            this.Controls.Add(this.dgvIndentList);
            this.Controls.Add(this.btnStateUp);
            this.Controls.Add(this.lbTotalSum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConsignee);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtPrompt);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dtpRADate);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSupplierFax);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSupplierMan);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbSupplierID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbIndentID);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_IndentPurUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "采购订单修改";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_IndentPurUp_FormClosed);
            this.Load += new System.EventHandler(this.Frm_IndentPurUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTotalSum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtConsignee;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtpRADate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSupplierFax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSupplierMan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbSupplierID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbIndentID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStateUp;
        private System.Windows.Forms.DataGridView dgvIndentList;
        private System.Windows.Forms.Label lbKdDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIndentStatus;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFormStatus;
        private System.Windows.Forms.TextBox txtConvention;
    }
}