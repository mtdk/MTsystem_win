namespace MTsystem_win
{
    partial class Frm_productSelect
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
            this.dgv_Queryresult = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_Queryid = new System.Windows.Forms.RadioButton();
            this.rdb_Queryname = new System.Windows.Forms.RadioButton();
            this.txt_Querycondition = new System.Windows.Forms.TextBox();
            this.btn_Query = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Queryresult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Queryresult);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 491);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询结果";
            // 
            // dgv_Queryresult
            // 
            this.dgv_Queryresult.AllowUserToAddRows = false;
            this.dgv_Queryresult.AllowUserToDeleteRows = false;
            this.dgv_Queryresult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Queryresult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Queryresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Queryresult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Queryresult.Location = new System.Drawing.Point(3, 22);
            this.dgv_Queryresult.Name = "dgv_Queryresult";
            this.dgv_Queryresult.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Queryresult.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Queryresult.RowTemplate.Height = 25;
            this.dgv_Queryresult.RowTemplate.ReadOnly = true;
            this.dgv_Queryresult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Queryresult.Size = new System.Drawing.Size(754, 466);
            this.dgv_Queryresult.TabIndex = 6;
            this.dgv_Queryresult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Queryresult_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询选择:";
            // 
            // rdb_Queryid
            // 
            this.rdb_Queryid.AutoSize = true;
            this.rdb_Queryid.Location = new System.Drawing.Point(108, 25);
            this.rdb_Queryid.Name = "rdb_Queryid";
            this.rdb_Queryid.Size = new System.Drawing.Size(117, 23);
            this.rdb_Queryid.TabIndex = 1;
            this.rdb_Queryid.TabStop = true;
            this.rdb_Queryid.Text = "按编号查询";
            this.rdb_Queryid.UseVisualStyleBackColor = true;
            // 
            // rdb_Queryname
            // 
            this.rdb_Queryname.AutoSize = true;
            this.rdb_Queryname.Location = new System.Drawing.Point(231, 25);
            this.rdb_Queryname.Name = "rdb_Queryname";
            this.rdb_Queryname.Size = new System.Drawing.Size(117, 23);
            this.rdb_Queryname.TabIndex = 2;
            this.rdb_Queryname.TabStop = true;
            this.rdb_Queryname.Text = "按名称查询";
            this.rdb_Queryname.UseVisualStyleBackColor = true;
            // 
            // txt_Querycondition
            // 
            this.txt_Querycondition.Location = new System.Drawing.Point(354, 24);
            this.txt_Querycondition.Name = "txt_Querycondition";
            this.txt_Querycondition.Size = new System.Drawing.Size(190, 26);
            this.txt_Querycondition.TabIndex = 3;
            this.txt_Querycondition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Querycondition_KeyPress);
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(550, 22);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 30);
            this.btn_Query.TabIndex = 4;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // Frm_productSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.txt_Querycondition);
            this.Controls.Add(this.rdb_Queryname);
            this.Controls.Add(this.rdb_Queryid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_productSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品选择窗口";
            this.Load += new System.EventHandler(this.Frm_productSelect_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Queryresult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Queryresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_Queryid;
        private System.Windows.Forms.RadioButton rdb_Queryname;
        private System.Windows.Forms.TextBox txt_Querycondition;
        private System.Windows.Forms.Button btn_Query;
    }
}