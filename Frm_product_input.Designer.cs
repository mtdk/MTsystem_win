namespace MTsystem_win
{
    partial class Frm_product_input
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Cancel_B = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dgv_inputView = new System.Windows.Forms.DataGridView();
            this.系统编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产品编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.重量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_inputWeight = new System.Windows.Forms.TextBox();
            this.txt_inputUnit = new System.Windows.Forms.TextBox();
            this.txt_inputNum = new System.Windows.Forms.TextBox();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.txt_productId = new System.Windows.Forms.TextBox();
            this.txt_proId = new System.Windows.Forms.TextBox();
            this.txt_batchNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_inputDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Inputid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inputView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_Cancel_B);
            this.groupBox2.Controls.Add(this.btn_Cancel);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.dgv_inputView);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_inputWeight);
            this.groupBox2.Controls.Add(this.txt_inputUnit);
            this.groupBox2.Controls.Add(this.txt_inputNum);
            this.groupBox2.Controls.Add(this.txt_productName);
            this.groupBox2.Controls.Add(this.txt_productId);
            this.groupBox2.Controls.Add(this.txt_proId);
            this.groupBox2.Controls.Add(this.txt_batchNum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_inputDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_Inputid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1104, 496);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(955, 451);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(859, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "重量合计:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(696, 451);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(601, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "数量合计:";
            // 
            // btn_Cancel_B
            // 
            this.btn_Cancel_B.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel_B.Location = new System.Drawing.Point(993, 91);
            this.btn_Cancel_B.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel_B.Name = "btn_Cancel_B";
            this.btn_Cancel_B.Size = new System.Drawing.Size(75, 28);
            this.btn_Cancel_B.TabIndex = 21;
            this.btn_Cancel_B.Text = "取 消";
            this.btn_Cancel_B.UseVisualStyleBackColor = true;
            this.btn_Cancel_B.Click += new System.EventHandler(this.btn_Cancel_B_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(176, 444);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 33);
            this.btn_Cancel.TabIndex = 18;
            this.btn_Cancel.Text = "取  消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(94, 444);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 33);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "保  存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dgv_inputView
            // 
            this.dgv_inputView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_inputView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_inputView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inputView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.系统编码,
            this.产品编号,
            this.产品名称,
            this.数量,
            this.规格,
            this.重量});
            this.dgv_inputView.Location = new System.Drawing.Point(6, 124);
            this.dgv_inputView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_inputView.Name = "dgv_inputView";
            this.dgv_inputView.ReadOnly = true;
            this.dgv_inputView.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_inputView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_inputView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_inputView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_inputView.RowTemplate.Height = 23;
            this.dgv_inputView.RowTemplate.ReadOnly = true;
            this.dgv_inputView.Size = new System.Drawing.Size(1092, 306);
            this.dgv_inputView.TabIndex = 16;
            this.dgv_inputView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_inputView_RowsRemoved);
            // 
            // 系统编码
            // 
            this.系统编码.HeaderText = "系统编码";
            this.系统编码.Name = "系统编码";
            this.系统编码.ReadOnly = true;
            this.系统编码.Width = 130;
            // 
            // 产品编号
            // 
            this.产品编号.HeaderText = "产品编号";
            this.产品编号.Name = "产品编号";
            this.产品编号.ReadOnly = true;
            this.产品编号.Width = 130;
            // 
            // 产品名称
            // 
            this.产品名称.HeaderText = "产品名称";
            this.产品名称.Name = "产品名称";
            this.产品名称.ReadOnly = true;
            this.产品名称.Width = 400;
            // 
            // 数量
            // 
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            this.数量.ReadOnly = true;
            this.数量.Width = 130;
            // 
            // 规格
            // 
            this.规格.HeaderText = "规格";
            this.规格.Name = "规格";
            this.规格.ReadOnly = true;
            this.规格.Width = 130;
            // 
            // 重量
            // 
            this.重量.HeaderText = "重量";
            this.重量.Name = "重量";
            this.重量.ReadOnly = true;
            this.重量.Width = 130;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(896, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "重量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(778, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "规格";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(678, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "数量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(427, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "产品名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(176, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "产品编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(57, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "系统编码";
            // 
            // txt_inputWeight
            // 
            this.txt_inputWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_inputWeight.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inputWeight.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_inputWeight.Location = new System.Drawing.Point(850, 91);
            this.txt_inputWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_inputWeight.Name = "txt_inputWeight";
            this.txt_inputWeight.ReadOnly = true;
            this.txt_inputWeight.Size = new System.Drawing.Size(137, 30);
            this.txt_inputWeight.TabIndex = 15;
            this.txt_inputWeight.Text = "0";
            this.txt_inputWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_inputWeight_KeyPress);
            // 
            // txt_inputUnit
            // 
            this.txt_inputUnit.BackColor = System.Drawing.SystemColors.Control;
            this.txt_inputUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_inputUnit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inputUnit.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_inputUnit.Location = new System.Drawing.Point(750, 91);
            this.txt_inputUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_inputUnit.Name = "txt_inputUnit";
            this.txt_inputUnit.Size = new System.Drawing.Size(100, 30);
            this.txt_inputUnit.TabIndex = 4;
            this.txt_inputUnit.Text = "0";
            this.txt_inputUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_inputUnit_KeyPress);
            this.txt_inputUnit.Leave += new System.EventHandler(this.txt_inputUnit_Leave);
            // 
            // txt_inputNum
            // 
            this.txt_inputNum.BackColor = System.Drawing.SystemColors.Control;
            this.txt_inputNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_inputNum.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inputNum.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_inputNum.Location = new System.Drawing.Point(650, 91);
            this.txt_inputNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_inputNum.Name = "txt_inputNum";
            this.txt_inputNum.Size = new System.Drawing.Size(100, 30);
            this.txt_inputNum.TabIndex = 3;
            this.txt_inputNum.Text = "0";
            this.txt_inputNum.Enter += new System.EventHandler(this.txt_inputNum_Enter);
            this.txt_inputNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_inputNum_KeyPress);
            this.txt_inputNum.Leave += new System.EventHandler(this.txt_inputNum_Leave);
            // 
            // txt_productName
            // 
            this.txt_productName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_productName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_productName.Location = new System.Drawing.Point(285, 91);
            this.txt_productName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.ReadOnly = true;
            this.txt_productName.Size = new System.Drawing.Size(365, 30);
            this.txt_productName.TabIndex = 20;
            // 
            // txt_productId
            // 
            this.txt_productId.BackColor = System.Drawing.SystemColors.Control;
            this.txt_productId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_productId.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productId.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_productId.Location = new System.Drawing.Point(147, 91);
            this.txt_productId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_productId.Name = "txt_productId";
            this.txt_productId.Size = new System.Drawing.Size(138, 30);
            this.txt_productId.TabIndex = 2;
            this.txt_productId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productId_KeyPress);
            // 
            // txt_proId
            // 
            this.txt_proId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_proId.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proId.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_proId.Location = new System.Drawing.Point(47, 91);
            this.txt_proId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_proId.Name = "txt_proId";
            this.txt_proId.ReadOnly = true;
            this.txt_proId.Size = new System.Drawing.Size(100, 30);
            this.txt_proId.TabIndex = 14;
            // 
            // txt_batchNum
            // 
            this.txt_batchNum.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_batchNum.Location = new System.Drawing.Point(583, 18);
            this.txt_batchNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_batchNum.MaxLength = 20;
            this.txt_batchNum.Name = "txt_batchNum";
            this.txt_batchNum.Size = new System.Drawing.Size(162, 30);
            this.txt_batchNum.TabIndex = 1;
            this.txt_batchNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_batchNum_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "货号:";
            // 
            // txt_inputDate
            // 
            this.txt_inputDate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inputDate.Location = new System.Drawing.Point(396, 18);
            this.txt_inputDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_inputDate.MaxLength = 8;
            this.txt_inputDate.Name = "txt_inputDate";
            this.txt_inputDate.Size = new System.Drawing.Size(122, 30);
            this.txt_inputDate.TabIndex = 0;
            this.txt_inputDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_inputDate_KeyPress);
            this.txt_inputDate.Leave += new System.EventHandler(this.txt_inputDate_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "进仓日期:";
            // 
            // txt_Inputid
            // 
            this.txt_Inputid.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Inputid.Location = new System.Drawing.Point(120, 18);
            this.txt_Inputid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Inputid.MaxLength = 20;
            this.txt_Inputid.Name = "txt_Inputid";
            this.txt_Inputid.ReadOnly = true;
            this.txt_Inputid.Size = new System.Drawing.Size(174, 30);
            this.txt_Inputid.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "进仓记录号:";
            // 
            // Frm_product_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1128, 514);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_product_input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品进仓窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_product_input_FormClosed);
            this.Load += new System.EventHandler(this.Frm_product_input_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inputView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_batchNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_inputDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Inputid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_inputWeight;
        private System.Windows.Forms.TextBox txt_inputUnit;
        private System.Windows.Forms.TextBox txt_inputNum;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.TextBox txt_productId;
        private System.Windows.Forms.TextBox txt_proId;
        private System.Windows.Forms.DataGridView dgv_inputView;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel_B;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn 系统编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产品编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产品名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 重量;
    }
}