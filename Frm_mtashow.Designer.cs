namespace MTsystem_win
{
    partial class Frm_mtashow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_Queryid = new System.Windows.Forms.RadioButton();
            this.rdb_Queryname = new System.Windows.Forms.RadioButton();
            this.txt_Querycondition = new System.Windows.Forms.TextBox();
            this.btn_Query = new System.Windows.Forms.Button();
            this.dgv_Queryresult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Queryresult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "查询选择:";
            // 
            // rdb_Queryid
            // 
            this.rdb_Queryid.AutoSize = true;
            this.rdb_Queryid.Checked = true;
            this.rdb_Queryid.Location = new System.Drawing.Point(108, 14);
            this.rdb_Queryid.Name = "rdb_Queryid";
            this.rdb_Queryid.Size = new System.Drawing.Size(117, 23);
            this.rdb_Queryid.TabIndex = 3;
            this.rdb_Queryid.TabStop = true;
            this.rdb_Queryid.Text = "按编号查询";
            this.rdb_Queryid.UseVisualStyleBackColor = true;
            // 
            // rdb_Queryname
            // 
            this.rdb_Queryname.AutoSize = true;
            this.rdb_Queryname.Location = new System.Drawing.Point(231, 14);
            this.rdb_Queryname.Name = "rdb_Queryname";
            this.rdb_Queryname.Size = new System.Drawing.Size(117, 23);
            this.rdb_Queryname.TabIndex = 4;
            this.rdb_Queryname.TabStop = true;
            this.rdb_Queryname.Text = "按名称查询";
            this.rdb_Queryname.UseVisualStyleBackColor = true;
            // 
            // txt_Querycondition
            // 
            this.txt_Querycondition.Location = new System.Drawing.Point(354, 13);
            this.txt_Querycondition.Name = "txt_Querycondition";
            this.txt_Querycondition.Size = new System.Drawing.Size(190, 26);
            this.txt_Querycondition.TabIndex = 0;
            this.txt_Querycondition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Querycondition_KeyPress);
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(550, 11);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 30);
            this.btn_Query.TabIndex = 1;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // dgv_Queryresult
            // 
            this.dgv_Queryresult.AllowUserToAddRows = false;
            this.dgv_Queryresult.AllowUserToDeleteRows = false;
            this.dgv_Queryresult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Queryresult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Queryresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Queryresult.Location = new System.Drawing.Point(12, 43);
            this.dgv_Queryresult.Name = "dgv_Queryresult";
            this.dgv_Queryresult.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Queryresult.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Queryresult.RowTemplate.Height = 25;
            this.dgv_Queryresult.RowTemplate.ReadOnly = true;
            this.dgv_Queryresult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Queryresult.Size = new System.Drawing.Size(760, 506);
            this.dgv_Queryresult.TabIndex = 5;
            this.dgv_Queryresult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Queryresult_CellDoubleClick);
            // 
            // Frm_mtashow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgv_Queryresult);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.txt_Querycondition);
            this.Controls.Add(this.rdb_Queryname);
            this.Controls.Add(this.rdb_Queryid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_mtashow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "材料选择窗口";
            this.Load += new System.EventHandler(this.Frm_mtashow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Queryresult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_Queryid;
        private System.Windows.Forms.RadioButton rdb_Queryname;
        private System.Windows.Forms.TextBox txt_Querycondition;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.DataGridView dgv_Queryresult;
    }
}