namespace MTsystem_win
{
    partial class Frm_product_info
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
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Productunit = new System.Windows.Forms.TextBox();
            this.txt_Productid = new System.Windows.Forms.TextBox();
            this.txt_Productname = new System.Windows.Forms.TextBox();
            this.txt_Systemid = new System.Windows.Forms.TextBox();
            this.rdb_update = new System.Windows.Forms.RadioButton();
            this.rdb_input = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Queryresult = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_QueryName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Queryid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Queryresult)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.txt_Productunit);
            this.groupBox1.Controls.Add(this.txt_Productid);
            this.groupBox1.Controls.Add(this.txt_Productname);
            this.groupBox1.Controls.Add(this.txt_Systemid);
            this.groupBox1.Controls.Add(this.rdb_update);
            this.groupBox1.Controls.Add(this.rdb_input);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(101, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "产品信息录入/修改";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "KG";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(306, 142);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 39);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "清 空";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(188, 142);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 39);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "保 存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Productunit
            // 
            this.txt_Productunit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Productunit.Location = new System.Drawing.Point(490, 106);
            this.txt_Productunit.Name = "txt_Productunit";
            this.txt_Productunit.Size = new System.Drawing.Size(35, 30);
            this.txt_Productunit.TabIndex = 9;
            this.txt_Productunit.Text = "20";
            this.txt_Productunit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Productunit_KeyPress);
            // 
            // txt_Productid
            // 
            this.txt_Productid.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Productid.Location = new System.Drawing.Point(347, 70);
            this.txt_Productid.Name = "txt_Productid";
            this.txt_Productid.Size = new System.Drawing.Size(196, 30);
            this.txt_Productid.TabIndex = 5;
            this.txt_Productid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Productid_KeyPress);
            // 
            // txt_Productname
            // 
            this.txt_Productname.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Productname.Location = new System.Drawing.Point(127, 106);
            this.txt_Productname.MaxLength = 30;
            this.txt_Productname.Name = "txt_Productname";
            this.txt_Productname.Size = new System.Drawing.Size(300, 30);
            this.txt_Productname.TabIndex = 7;
            this.txt_Productname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Productname_KeyPress);
            // 
            // txt_Systemid
            // 
            this.txt_Systemid.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_Systemid.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Systemid.ForeColor = System.Drawing.Color.Red;
            this.txt_Systemid.Location = new System.Drawing.Point(127, 70);
            this.txt_Systemid.Name = "txt_Systemid";
            this.txt_Systemid.Size = new System.Drawing.Size(118, 30);
            this.txt_Systemid.TabIndex = 3;
            // 
            // rdb_update
            // 
            this.rdb_update.AutoSize = true;
            this.rdb_update.Location = new System.Drawing.Point(140, 36);
            this.rdb_update.Name = "rdb_update";
            this.rdb_update.Size = new System.Drawing.Size(99, 23);
            this.rdb_update.TabIndex = 1;
            this.rdb_update.TabStop = true;
            this.rdb_update.Text = "信息修改";
            this.rdb_update.UseVisualStyleBackColor = true;
            this.rdb_update.CheckedChanged += new System.EventHandler(this.rdb_update_CheckedChanged);
            // 
            // rdb_input
            // 
            this.rdb_input.AutoSize = true;
            this.rdb_input.Location = new System.Drawing.Point(35, 36);
            this.rdb_input.Name = "rdb_input";
            this.rdb_input.Size = new System.Drawing.Size(99, 23);
            this.rdb_input.TabIndex = 0;
            this.rdb_input.TabStop = true;
            this.rdb_input.Text = "信息录入";
            this.rdb_input.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "规格:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "产品编号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "产品名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "系统编号:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Queryresult);
            this.groupBox2.Location = new System.Drawing.Point(12, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 388);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "产品信息";
            // 
            // dgv_Queryresult
            // 
            this.dgv_Queryresult.AllowUserToAddRows = false;
            this.dgv_Queryresult.AllowUserToDeleteRows = false;
            this.dgv_Queryresult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Queryresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Queryresult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Queryresult.Location = new System.Drawing.Point(3, 22);
            this.dgv_Queryresult.Name = "dgv_Queryresult";
            this.dgv_Queryresult.ReadOnly = true;
            this.dgv_Queryresult.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Queryresult.RowTemplate.Height = 23;
            this.dgv_Queryresult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Queryresult.Size = new System.Drawing.Size(740, 363);
            this.dgv_Queryresult.TabIndex = 0;
            this.dgv_Queryresult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Queryresult_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_QueryName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_Queryid);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(101, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(568, 70);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "产品信息查询";
            // 
            // txt_QueryName
            // 
            this.txt_QueryName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QueryName.Location = new System.Drawing.Point(365, 27);
            this.txt_QueryName.Name = "txt_QueryName";
            this.txt_QueryName.Size = new System.Drawing.Size(178, 30);
            this.txt_QueryName.TabIndex = 4;
            this.txt_QueryName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QueryName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "产品名称:";
            // 
            // txt_Queryid
            // 
            this.txt_Queryid.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Queryid.Location = new System.Drawing.Point(127, 26);
            this.txt_Queryid.Name = "txt_Queryid";
            this.txt_Queryid.Size = new System.Drawing.Size(136, 30);
            this.txt_Queryid.TabIndex = 1;
            this.txt_Queryid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Queryid_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "产品编号:";
            // 
            // Frm_product_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 684);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_product_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品信息录入窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_product_info_FormClosed);
            this.Load += new System.EventHandler(this.Frm_product_info_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Queryresult)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Productunit;
        private System.Windows.Forms.TextBox txt_Productid;
        private System.Windows.Forms.TextBox txt_Productname;
        private System.Windows.Forms.TextBox txt_Systemid;
        private System.Windows.Forms.RadioButton rdb_update;
        private System.Windows.Forms.RadioButton rdb_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Queryresult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Queryid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_QueryName;
        private System.Windows.Forms.Label label7;
    }
}