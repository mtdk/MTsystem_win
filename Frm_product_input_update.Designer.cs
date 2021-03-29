namespace MTsystem_win
{
    partial class Frm_product_input_update
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
            this.btn_MoveLast = new System.Windows.Forms.Button();
            this.btn_MoveFirst = new System.Windows.Forms.Button();
            this.btn_MoveNext = new System.Windows.Forms.Button();
            this.btn_MovePrevious = new System.Windows.Forms.Button();
            this.txt_batchNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_inputDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Inputid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_SelectResult = new System.Windows.Forms.DataGridView();
            this.txt_SelectCondition = new System.Windows.Forms.TextBox();
            this.rdb_SelectName = new System.Windows.Forms.RadioButton();
            this.rdb_SelectID = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_MoveLast);
            this.groupBox1.Controls.Add(this.btn_MoveFirst);
            this.groupBox1.Controls.Add(this.btn_MoveNext);
            this.groupBox1.Controls.Add(this.btn_MovePrevious);
            this.groupBox1.Controls.Add(this.txt_batchNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_inputDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Inputid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1126, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_MoveLast
            // 
            this.btn_MoveLast.Location = new System.Drawing.Point(755, 74);
            this.btn_MoveLast.Name = "btn_MoveLast";
            this.btn_MoveLast.Size = new System.Drawing.Size(75, 32);
            this.btn_MoveLast.TabIndex = 32;
            this.btn_MoveLast.Text = ">>|";
            this.btn_MoveLast.UseVisualStyleBackColor = true;
            this.btn_MoveLast.Click += new System.EventHandler(this.btn_MoveLast_Click);
            // 
            // btn_MoveFirst
            // 
            this.btn_MoveFirst.Location = new System.Drawing.Point(304, 74);
            this.btn_MoveFirst.Name = "btn_MoveFirst";
            this.btn_MoveFirst.Size = new System.Drawing.Size(75, 32);
            this.btn_MoveFirst.TabIndex = 31;
            this.btn_MoveFirst.Text = "|<<";
            this.btn_MoveFirst.UseVisualStyleBackColor = true;
            this.btn_MoveFirst.Click += new System.EventHandler(this.btn_MoveFirst_Click);
            // 
            // btn_MoveNext
            // 
            this.btn_MoveNext.Location = new System.Drawing.Point(632, 74);
            this.btn_MoveNext.Name = "btn_MoveNext";
            this.btn_MoveNext.Size = new System.Drawing.Size(75, 32);
            this.btn_MoveNext.TabIndex = 30;
            this.btn_MoveNext.Text = ">>";
            this.btn_MoveNext.UseVisualStyleBackColor = true;
            this.btn_MoveNext.Click += new System.EventHandler(this.btn_MoveNext_Click);
            // 
            // btn_MovePrevious
            // 
            this.btn_MovePrevious.Location = new System.Drawing.Point(420, 74);
            this.btn_MovePrevious.Name = "btn_MovePrevious";
            this.btn_MovePrevious.Size = new System.Drawing.Size(75, 32);
            this.btn_MovePrevious.TabIndex = 29;
            this.btn_MovePrevious.Text = "<<";
            this.btn_MovePrevious.UseVisualStyleBackColor = true;
            this.btn_MovePrevious.Click += new System.EventHandler(this.btn_MovePrevious_Click);
            // 
            // txt_batchNum
            // 
            this.txt_batchNum.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_batchNum.Location = new System.Drawing.Point(583, 31);
            this.txt_batchNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_batchNum.MaxLength = 20;
            this.txt_batchNum.Name = "txt_batchNum";
            this.txt_batchNum.ReadOnly = true;
            this.txt_batchNum.Size = new System.Drawing.Size(162, 30);
            this.txt_batchNum.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(523, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "货号:";
            // 
            // txt_inputDate
            // 
            this.txt_inputDate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inputDate.Location = new System.Drawing.Point(396, 31);
            this.txt_inputDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_inputDate.MaxLength = 8;
            this.txt_inputDate.Name = "txt_inputDate";
            this.txt_inputDate.ReadOnly = true;
            this.txt_inputDate.Size = new System.Drawing.Size(122, 30);
            this.txt_inputDate.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(300, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "进仓日期:";
            // 
            // txt_Inputid
            // 
            this.txt_Inputid.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Inputid.Location = new System.Drawing.Point(120, 31);
            this.txt_Inputid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Inputid.MaxLength = 20;
            this.txt_Inputid.Name = "txt_Inputid";
            this.txt_Inputid.ReadOnly = true;
            this.txt_Inputid.Size = new System.Drawing.Size(174, 30);
            this.txt_Inputid.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "进仓记录号:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txt_SelectCondition);
            this.groupBox2.Controls.Add(this.rdb_SelectName);
            this.groupBox2.Controls.Add(this.rdb_SelectID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1126, 450);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "记录状态修改区";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_SelectResult);
            this.groupBox3.Location = new System.Drawing.Point(6, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1114, 379);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // dgv_SelectResult
            // 
            this.dgv_SelectResult.AllowUserToAddRows = false;
            this.dgv_SelectResult.AllowUserToDeleteRows = false;
            this.dgv_SelectResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_SelectResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_SelectResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SelectResult.Location = new System.Drawing.Point(3, 22);
            this.dgv_SelectResult.Name = "dgv_SelectResult";
            this.dgv_SelectResult.ReadOnly = true;
            this.dgv_SelectResult.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            this.dgv_SelectResult.RowTemplate.Height = 23;
            this.dgv_SelectResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SelectResult.Size = new System.Drawing.Size(1108, 354);
            this.dgv_SelectResult.TabIndex = 0;
            this.dgv_SelectResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SelectResult_CellDoubleClick);
            this.dgv_SelectResult.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_SelectResult_CellFormatting);
            // 
            // txt_SelectCondition
            // 
            this.txt_SelectCondition.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SelectCondition.Location = new System.Drawing.Point(348, 33);
            this.txt_SelectCondition.Name = "txt_SelectCondition";
            this.txt_SelectCondition.Size = new System.Drawing.Size(201, 30);
            this.txt_SelectCondition.TabIndex = 0;
            this.txt_SelectCondition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SelectCondition_KeyPress);
            // 
            // rdb_SelectName
            // 
            this.rdb_SelectName.AutoSize = true;
            this.rdb_SelectName.Location = new System.Drawing.Point(225, 36);
            this.rdb_SelectName.Name = "rdb_SelectName";
            this.rdb_SelectName.Size = new System.Drawing.Size(117, 23);
            this.rdb_SelectName.TabIndex = 2;
            this.rdb_SelectName.Text = "按品名查询";
            this.rdb_SelectName.UseVisualStyleBackColor = true;
            // 
            // rdb_SelectID
            // 
            this.rdb_SelectID.AutoSize = true;
            this.rdb_SelectID.Checked = true;
            this.rdb_SelectID.Location = new System.Drawing.Point(102, 36);
            this.rdb_SelectID.Name = "rdb_SelectID";
            this.rdb_SelectID.Size = new System.Drawing.Size(117, 23);
            this.rdb_SelectID.TabIndex = 1;
            this.rdb_SelectID.TabStop = true;
            this.rdb_SelectID.Text = "按编号查询";
            this.rdb_SelectID.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "查询选项:";
            // 
            // Frm_product_input_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 594);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_product_input_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "产品进仓修改窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_product_input_update_FormClosed);
            this.Load += new System.EventHandler(this.Frm_product_input_update_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_batchNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_inputDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Inputid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_MoveNext;
        private System.Windows.Forms.Button btn_MovePrevious;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdb_SelectName;
        private System.Windows.Forms.RadioButton rdb_SelectID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_SelectResult;
        private System.Windows.Forms.TextBox txt_SelectCondition;
        private System.Windows.Forms.Button btn_MoveLast;
        private System.Windows.Forms.Button btn_MoveFirst;
    }
}