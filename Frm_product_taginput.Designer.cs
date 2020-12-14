namespace MTsystem_win
{
    partial class Frm_product_taginput
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Systemid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_unit = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Saveprint = new System.Windows.Forms.Button();
            this.txt_Shelflife = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_batchNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Unit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_Productdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Productid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_tagprint = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tagprint)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_num);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Systemid);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lb_unit);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Saveprint);
            this.groupBox1.Controls.Add(this.txt_Shelflife);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_batchNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Unit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_Productdate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ProductName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Productid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 258);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "标签录入";
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num.Location = new System.Drawing.Point(734, 165);
            this.txt_num.MaxLength = 5;
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(47, 30);
            this.txt_num.TabIndex = 30;
            this.txt_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(665, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "数 量:";
            // 
            // txt_Systemid
            // 
            this.txt_Systemid.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Systemid.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Systemid.Location = new System.Drawing.Point(293, 25);
            this.txt_Systemid.Name = "txt_Systemid";
            this.txt_Systemid.ReadOnly = true;
            this.txt_Systemid.Size = new System.Drawing.Size(132, 30);
            this.txt_Systemid.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "系统编码:";
            // 
            // lb_unit
            // 
            this.lb_unit.AutoSize = true;
            this.lb_unit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_unit.Location = new System.Drawing.Point(629, 133);
            this.lb_unit.Name = "lb_unit";
            this.lb_unit.Size = new System.Drawing.Size(30, 22);
            this.lb_unit.TabIndex = 26;
            this.lb_unit.Text = "KG";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(434, 209);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(96, 37);
            this.btn_Cancel.TabIndex = 25;
            this.btn_Cancel.Text = "取  消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Saveprint
            // 
            this.btn_Saveprint.Location = new System.Drawing.Point(308, 209);
            this.btn_Saveprint.Name = "btn_Saveprint";
            this.btn_Saveprint.Size = new System.Drawing.Size(96, 37);
            this.btn_Saveprint.TabIndex = 24;
            this.btn_Saveprint.Text = "保存打印";
            this.btn_Saveprint.UseVisualStyleBackColor = true;
            this.btn_Saveprint.Click += new System.EventHandler(this.btn_Saveprint_Click);
            // 
            // txt_Shelflife
            // 
            this.txt_Shelflife.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Shelflife.Location = new System.Drawing.Point(527, 165);
            this.txt_Shelflife.MaxLength = 8;
            this.txt_Shelflife.Name = "txt_Shelflife";
            this.txt_Shelflife.Size = new System.Drawing.Size(132, 30);
            this.txt_Shelflife.TabIndex = 23;
            this.txt_Shelflife.Text = "6个月";
            this.txt_Shelflife.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Shelflife_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "保 质 期:";
            // 
            // txt_batchNum
            // 
            this.txt_batchNum.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_batchNum.Location = new System.Drawing.Point(293, 163);
            this.txt_batchNum.MaxLength = 12;
            this.txt_batchNum.Name = "txt_batchNum";
            this.txt_batchNum.Size = new System.Drawing.Size(132, 30);
            this.txt_batchNum.TabIndex = 21;
            this.txt_batchNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_batchNum_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "生产批号:";
            // 
            // txt_Unit
            // 
            this.txt_Unit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Unit.Location = new System.Drawing.Point(527, 129);
            this.txt_Unit.MaxLength = 5;
            this.txt_Unit.Name = "txt_Unit";
            this.txt_Unit.Size = new System.Drawing.Size(96, 30);
            this.txt_Unit.TabIndex = 19;
            this.txt_Unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Unit_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "产品净重:";
            // 
            // dtp_Productdate
            // 
            this.dtp_Productdate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Productdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Productdate.Location = new System.Drawing.Point(293, 129);
            this.dtp_Productdate.Name = "dtp_Productdate";
            this.dtp_Productdate.Size = new System.Drawing.Size(132, 30);
            this.dtp_Productdate.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "生产日期:";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_ProductName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductName.Location = new System.Drawing.Point(293, 95);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.ReadOnly = true;
            this.txt_ProductName.Size = new System.Drawing.Size(366, 30);
            this.txt_ProductName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "产品名称:";
            // 
            // txt_Productid
            // 
            this.txt_Productid.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Productid.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Productid.Location = new System.Drawing.Point(293, 61);
            this.txt_Productid.Name = "txt_Productid";
            this.txt_Productid.ReadOnly = true;
            this.txt_Productid.Size = new System.Drawing.Size(132, 30);
            this.txt_Productid.TabIndex = 13;
            this.txt_Productid.DoubleClick += new System.EventHandler(this.txt_Productid_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "产品编号:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_tagprint);
            this.groupBox2.Location = new System.Drawing.Point(12, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(859, 475);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "待打印";
            // 
            // dgv_tagprint
            // 
            this.dgv_tagprint.AllowUserToAddRows = false;
            this.dgv_tagprint.AllowUserToDeleteRows = false;
            this.dgv_tagprint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tagprint.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_tagprint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tagprint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tagprint.Location = new System.Drawing.Point(3, 22);
            this.dgv_tagprint.Name = "dgv_tagprint";
            this.dgv_tagprint.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_tagprint.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tagprint.RowTemplate.Height = 23;
            this.dgv_tagprint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tagprint.Size = new System.Drawing.Size(853, 450);
            this.dgv_tagprint.TabIndex = 0;
            this.dgv_tagprint.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tagprint_CellDoubleClick);
            // 
            // Frm_product_taginput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 751);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_product_taginput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "标签打印录入窗口";
            this.Load += new System.EventHandler(this.Frm_product_taginput_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tagprint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Saveprint;
        private System.Windows.Forms.TextBox txt_Shelflife;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_batchNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Unit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_Productdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Productid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_tagprint;
        private System.Windows.Forms.Label lb_unit;
        private System.Windows.Forms.TextBox txt_Systemid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_num;

    }
}