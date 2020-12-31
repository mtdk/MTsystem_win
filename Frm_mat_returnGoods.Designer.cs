namespace MTsystem_win
{
    partial class Frm_mat_returnGoods
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
            this.txt_mat_id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Operator = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Inputdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Inputid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Query = new System.Windows.Forms.Button();
            this.dgv_Query_result = new System.Windows.Forms.DataGridView();
            this.txt_Queryid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Inputzl = new System.Windows.Forms.TextBox();
            this.txt_Materia_unit = new System.Windows.Forms.TextBox();
            this.txt_Inputsl = new System.Windows.Forms.TextBox();
            this.txt_Materia_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Materia_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Query_result)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mat_id
            // 
            this.txt_mat_id.BackColor = System.Drawing.Color.LightCyan;
            this.txt_mat_id.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mat_id.Location = new System.Drawing.Point(109, 52);
            this.txt_mat_id.Name = "txt_mat_id";
            this.txt_mat_id.ReadOnly = true;
            this.txt_mat_id.Size = new System.Drawing.Size(206, 31);
            this.txt_mat_id.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 70;
            this.label10.Text = "系统码:";
            // 
            // txt_Operator
            // 
            this.txt_Operator.BackColor = System.Drawing.Color.Pink;
            this.txt_Operator.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Operator.Location = new System.Drawing.Point(109, 311);
            this.txt_Operator.Name = "txt_Operator";
            this.txt_Operator.ReadOnly = true;
            this.txt_Operator.Size = new System.Drawing.Size(206, 31);
            this.txt_Operator.TabIndex = 69;
            this.txt_Operator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Operator_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 68;
            this.label9.Text = "操作人:";
            // 
            // txt_Inputdate
            // 
            this.txt_Inputdate.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Inputdate.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Inputdate.Location = new System.Drawing.Point(109, 274);
            this.txt_Inputdate.Name = "txt_Inputdate";
            this.txt_Inputdate.ReadOnly = true;
            this.txt_Inputdate.Size = new System.Drawing.Size(206, 31);
            this.txt_Inputdate.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 66;
            this.label8.Text = "退回日期:";
            // 
            // txt_Inputid
            // 
            this.txt_Inputid.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Inputid.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Inputid.Location = new System.Drawing.Point(109, 15);
            this.txt_Inputid.Name = "txt_Inputid";
            this.txt_Inputid.ReadOnly = true;
            this.txt_Inputid.Size = new System.Drawing.Size(206, 31);
            this.txt_Inputid.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 64;
            this.label7.Text = "退回单号:";
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(686, 16);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(108, 30);
            this.btn_Query.TabIndex = 63;
            this.btn_Query.Text = "查询/刷新";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // dgv_Query_result
            // 
            this.dgv_Query_result.AllowUserToAddRows = false;
            this.dgv_Query_result.AllowUserToDeleteRows = false;
            this.dgv_Query_result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Query_result.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Query_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Query_result.Location = new System.Drawing.Point(346, 58);
            this.dgv_Query_result.Name = "dgv_Query_result";
            this.dgv_Query_result.ReadOnly = true;
            this.dgv_Query_result.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Query_result.RowTemplate.Height = 23;
            this.dgv_Query_result.RowTemplate.ReadOnly = true;
            this.dgv_Query_result.Size = new System.Drawing.Size(689, 487);
            this.dgv_Query_result.TabIndex = 62;
            this.dgv_Query_result.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Query_result_CellFormatting);
            // 
            // txt_Queryid
            // 
            this.txt_Queryid.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Queryid.Location = new System.Drawing.Point(474, 16);
            this.txt_Queryid.Name = "txt_Queryid";
            this.txt_Queryid.Size = new System.Drawing.Size(206, 30);
            this.txt_Queryid.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 60;
            this.label6.Text = "查询材料编号:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(184, 369);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_Cancel.TabIndex = 59;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Save.Location = new System.Drawing.Point(70, 369);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 30);
            this.btn_Save.TabIndex = 58;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Inputzl
            // 
            this.txt_Inputzl.BackColor = System.Drawing.Color.Bisque;
            this.txt_Inputzl.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Inputzl.Location = new System.Drawing.Point(109, 237);
            this.txt_Inputzl.Name = "txt_Inputzl";
            this.txt_Inputzl.ReadOnly = true;
            this.txt_Inputzl.Size = new System.Drawing.Size(206, 31);
            this.txt_Inputzl.TabIndex = 57;
            // 
            // txt_Materia_unit
            // 
            this.txt_Materia_unit.BackColor = System.Drawing.Color.Bisque;
            this.txt_Materia_unit.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Materia_unit.Location = new System.Drawing.Point(109, 200);
            this.txt_Materia_unit.MaxLength = 10;
            this.txt_Materia_unit.Name = "txt_Materia_unit";
            this.txt_Materia_unit.Size = new System.Drawing.Size(206, 31);
            this.txt_Materia_unit.TabIndex = 56;
            this.txt_Materia_unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Materia_unit_KeyPress);
            this.txt_Materia_unit.Leave += new System.EventHandler(this.txt_Materia_unit_Leave);
            // 
            // txt_Inputsl
            // 
            this.txt_Inputsl.BackColor = System.Drawing.Color.Bisque;
            this.txt_Inputsl.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Inputsl.Location = new System.Drawing.Point(109, 163);
            this.txt_Inputsl.MaxLength = 10;
            this.txt_Inputsl.Name = "txt_Inputsl";
            this.txt_Inputsl.Size = new System.Drawing.Size(206, 31);
            this.txt_Inputsl.TabIndex = 55;
            this.txt_Inputsl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Inputsl_KeyPress);
            this.txt_Inputsl.Leave += new System.EventHandler(this.txt_Inputsl_Leave);
            // 
            // txt_Materia_name
            // 
            this.txt_Materia_name.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Materia_name.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Materia_name.Location = new System.Drawing.Point(109, 126);
            this.txt_Materia_name.Name = "txt_Materia_name";
            this.txt_Materia_name.ReadOnly = true;
            this.txt_Materia_name.Size = new System.Drawing.Size(206, 31);
            this.txt_Materia_name.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "退回总量:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 52;
            this.label4.Text = "材料规格:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "退回数量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "材料名称:";
            // 
            // txt_Materia_id
            // 
            this.txt_Materia_id.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Materia_id.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Materia_id.Location = new System.Drawing.Point(109, 89);
            this.txt_Materia_id.Name = "txt_Materia_id";
            this.txt_Materia_id.ReadOnly = true;
            this.txt_Materia_id.Size = new System.Drawing.Size(206, 31);
            this.txt_Materia_id.TabIndex = 49;
            this.txt_Materia_id.DoubleClick += new System.EventHandler(this.txt_Materia_id_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "材料编号:";
            // 
            // Frm_mat_returnGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1048, 561);
            this.Controls.Add(this.txt_mat_id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Operator);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Inputdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Inputid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.dgv_Query_result);
            this.Controls.Add(this.txt_Queryid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Inputzl);
            this.Controls.Add(this.txt_Materia_unit);
            this.Controls.Add(this.txt_Inputsl);
            this.Controls.Add(this.txt_Materia_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Materia_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_mat_returnGoods";
            this.Text = "原材料退货窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_mat_returnGoods_FormClosed);
            this.Load += new System.EventHandler(this.Frm_mat_returnGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Query_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mat_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Operator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Inputdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Inputid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.DataGridView dgv_Query_result;
        private System.Windows.Forms.TextBox txt_Queryid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Inputzl;
        private System.Windows.Forms.TextBox txt_Materia_unit;
        private System.Windows.Forms.TextBox txt_Inputsl;
        private System.Windows.Forms.TextBox txt_Materia_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Materia_id;
        private System.Windows.Forms.Label label1;
    }
}