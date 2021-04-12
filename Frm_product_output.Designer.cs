namespace MTsystem_win
{
    partial class Frm_product_output
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_batchNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_outputDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cusid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_AmountMoney = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Cancel_B = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dgv_OutputView = new System.Windows.Forms.DataGridView();
            this.系统编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产品编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.重量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小计 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_OutputWeight = new System.Windows.Forms.TextBox();
            this.txt_OutputUnit = new System.Windows.Forms.TextBox();
            this.txt_OutputNum = new System.Windows.Forms.TextBox();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.txt_productId = new System.Windows.Forms.TextBox();
            this.txt_proId = new System.Windows.Forms.TextBox();
            this.txt_outputid = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OutputView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_outputid);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txt_batchNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_outputDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_CusName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Cusid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1385, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_batchNum
            // 
            this.txt_batchNum.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_batchNum.Location = new System.Drawing.Point(907, 30);
            this.txt_batchNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_batchNum.MaxLength = 20;
            this.txt_batchNum.Name = "txt_batchNum";
            this.txt_batchNum.Size = new System.Drawing.Size(162, 30);
            this.txt_batchNum.TabIndex = 2;
            this.txt_batchNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_batchNum_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(847, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "货号:";
            // 
            // txt_outputDate
            // 
            this.txt_outputDate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_outputDate.Location = new System.Drawing.Point(719, 30);
            this.txt_outputDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_outputDate.MaxLength = 8;
            this.txt_outputDate.Name = "txt_outputDate";
            this.txt_outputDate.Size = new System.Drawing.Size(122, 30);
            this.txt_outputDate.TabIndex = 1;
            this.txt_outputDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_outputDate_KeyPress);
            this.txt_outputDate.Leave += new System.EventHandler(this.txt_outputDate_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "出仓日期:";
            // 
            // txt_CusName
            // 
            this.txt_CusName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CusName.Location = new System.Drawing.Point(304, 30);
            this.txt_CusName.Name = "txt_CusName";
            this.txt_CusName.Size = new System.Drawing.Size(313, 30);
            this.txt_CusName.TabIndex = 0;
            this.txt_CusName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CusName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "客户名称:";
            // 
            // txt_Cusid
            // 
            this.txt_Cusid.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cusid.Location = new System.Drawing.Point(102, 30);
            this.txt_Cusid.Name = "txt_Cusid";
            this.txt_Cusid.ReadOnly = true;
            this.txt_Cusid.Size = new System.Drawing.Size(100, 30);
            this.txt_Cusid.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "客户编号:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txt_Remarks);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txt_AmountMoney);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_Price);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_Cancel_B);
            this.groupBox2.Controls.Add(this.btn_Cancel);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.dgv_OutputView);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_OutputWeight);
            this.groupBox2.Controls.Add(this.txt_OutputUnit);
            this.groupBox2.Controls.Add(this.txt_OutputNum);
            this.groupBox2.Controls.Add(this.txt_productName);
            this.groupBox2.Controls.Add(this.txt_productId);
            this.groupBox2.Controls.Add(this.txt_proId);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1391, 478);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(1165, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 19);
            this.label17.TabIndex = 20;
            this.label17.Text = "备注";
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Remarks.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_Remarks.Location = new System.Drawing.Point(1103, 53);
            this.txt_Remarks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Remarks.MaxLength = 15;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(168, 30);
            this.txt_Remarks.TabIndex = 5;
            this.txt_Remarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Remarks_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(1031, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 19);
            this.label16.TabIndex = 19;
            this.label16.Text = "金额";
            // 
            // txt_AmountMoney
            // 
            this.txt_AmountMoney.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AmountMoney.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_AmountMoney.Location = new System.Drawing.Point(1003, 53);
            this.txt_AmountMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_AmountMoney.Name = "txt_AmountMoney";
            this.txt_AmountMoney.ReadOnly = true;
            this.txt_AmountMoney.Size = new System.Drawing.Size(100, 30);
            this.txt_AmountMoney.TabIndex = 21;
            this.txt_AmountMoney.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(952, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 19);
            this.label15.TabIndex = 18;
            this.label15.Text = "单价";
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_Price.Location = new System.Drawing.Point(946, 53);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(57, 30);
            this.txt_Price.TabIndex = 4;
            this.txt_Price.Text = "0";
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress);
            this.txt_Price.Leave += new System.EventHandler(this.txt_Price_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(955, 418);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(859, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "重量合计:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(696, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(601, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "数量合计:";
            // 
            // btn_Cancel_B
            // 
            this.btn_Cancel_B.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel_B.Location = new System.Drawing.Point(1277, 54);
            this.btn_Cancel_B.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel_B.Name = "btn_Cancel_B";
            this.btn_Cancel_B.Size = new System.Drawing.Size(75, 28);
            this.btn_Cancel_B.TabIndex = 6;
            this.btn_Cancel_B.Text = "取 消";
            this.btn_Cancel_B.UseVisualStyleBackColor = true;
            this.btn_Cancel_B.Click += new System.EventHandler(this.btn_Cancel_B_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(176, 411);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 33);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "取  消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(94, 411);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 33);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "保  存";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // dgv_OutputView
            // 
            this.dgv_OutputView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_OutputView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_OutputView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OutputView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.系统编码,
            this.产品编号,
            this.产品名称,
            this.数量,
            this.规格,
            this.重量,
            this.单价,
            this.小计,
            this.备注});
            this.dgv_OutputView.Location = new System.Drawing.Point(6, 91);
            this.dgv_OutputView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_OutputView.Name = "dgv_OutputView";
            this.dgv_OutputView.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_OutputView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_OutputView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_OutputView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_OutputView.RowTemplate.Height = 23;
            this.dgv_OutputView.RowTemplate.ReadOnly = true;
            this.dgv_OutputView.Size = new System.Drawing.Size(1379, 306);
            this.dgv_OutputView.TabIndex = 7;
            this.dgv_OutputView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_OutputView_RowsRemoved);
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
            // 单价
            // 
            this.单价.HeaderText = "单价";
            this.单价.Name = "单价";
            this.单价.ReadOnly = true;
            // 
            // 小计
            // 
            this.小计.HeaderText = "小计";
            this.小计.Name = "小计";
            this.小计.ReadOnly = true;
            // 
            // 备注
            // 
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(855, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "重量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(737, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "规格";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(637, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "数量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(386, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "产品名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(135, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "产品编号";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(16, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 19);
            this.label14.TabIndex = 10;
            this.label14.Text = "系统编码";
            // 
            // txt_OutputWeight
            // 
            this.txt_OutputWeight.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OutputWeight.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_OutputWeight.Location = new System.Drawing.Point(809, 53);
            this.txt_OutputWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_OutputWeight.Name = "txt_OutputWeight";
            this.txt_OutputWeight.ReadOnly = true;
            this.txt_OutputWeight.Size = new System.Drawing.Size(137, 30);
            this.txt_OutputWeight.TabIndex = 3;
            this.txt_OutputWeight.Text = "0";
            // 
            // txt_OutputUnit
            // 
            this.txt_OutputUnit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OutputUnit.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_OutputUnit.Location = new System.Drawing.Point(709, 53);
            this.txt_OutputUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_OutputUnit.Name = "txt_OutputUnit";
            this.txt_OutputUnit.Size = new System.Drawing.Size(100, 30);
            this.txt_OutputUnit.TabIndex = 2;
            this.txt_OutputUnit.Text = "0";
            this.txt_OutputUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_OutputUnit_KeyPress);
            this.txt_OutputUnit.Leave += new System.EventHandler(this.txt_OutputUnit_Leave);
            // 
            // txt_OutputNum
            // 
            this.txt_OutputNum.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OutputNum.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_OutputNum.Location = new System.Drawing.Point(609, 53);
            this.txt_OutputNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_OutputNum.Name = "txt_OutputNum";
            this.txt_OutputNum.Size = new System.Drawing.Size(100, 30);
            this.txt_OutputNum.TabIndex = 1;
            this.txt_OutputNum.Text = "0";
            this.txt_OutputNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_OutputNum_KeyPress);
            this.txt_OutputNum.Leave += new System.EventHandler(this.txt_OutputNum_Leave);
            // 
            // txt_productName
            // 
            this.txt_productName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_productName.Location = new System.Drawing.Point(244, 53);
            this.txt_productName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.ReadOnly = true;
            this.txt_productName.Size = new System.Drawing.Size(365, 30);
            this.txt_productName.TabIndex = 0;
            // 
            // txt_productId
            // 
            this.txt_productId.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productId.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_productId.Location = new System.Drawing.Point(106, 53);
            this.txt_productId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_productId.Name = "txt_productId";
            this.txt_productId.Size = new System.Drawing.Size(138, 30);
            this.txt_productId.TabIndex = 13;
            this.txt_productId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productId_KeyPress);
            // 
            // txt_proId
            // 
            this.txt_proId.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proId.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_proId.Location = new System.Drawing.Point(6, 53);
            this.txt_proId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_proId.Name = "txt_proId";
            this.txt_proId.ReadOnly = true;
            this.txt_proId.Size = new System.Drawing.Size(100, 30);
            this.txt_proId.TabIndex = 11;
            // 
            // txt_outputid
            // 
            this.txt_outputid.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_outputid.Location = new System.Drawing.Point(1189, 30);
            this.txt_outputid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_outputid.MaxLength = 20;
            this.txt_outputid.Name = "txt_outputid";
            this.txt_outputid.ReadOnly = true;
            this.txt_outputid.Size = new System.Drawing.Size(174, 30);
            this.txt_outputid.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1075, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 19);
            this.label18.TabIndex = 24;
            this.label18.Text = "出仓记录号:";
            // 
            // Frm_product_output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 594);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_product_output";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品出仓窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_product_output_FormClosed);
            this.Load += new System.EventHandler(this.Frm_product_output_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OutputView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_CusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Cusid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_batchNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_outputDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Cancel_B;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dgv_OutputView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_OutputWeight;
        private System.Windows.Forms.TextBox txt_OutputUnit;
        private System.Windows.Forms.TextBox txt_OutputNum;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.TextBox txt_productId;
        private System.Windows.Forms.TextBox txt_proId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_AmountMoney;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn 系统编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产品编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产品名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 重量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小计;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.TextBox txt_outputid;
        private System.Windows.Forms.Label label18;
    }
}