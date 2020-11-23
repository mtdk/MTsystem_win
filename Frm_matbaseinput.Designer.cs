namespace MTsystem_win
{
    partial class Frm_matbaseinput
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
            this.txt_Operator = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Outdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Query = new System.Windows.Forms.Button();
            this.dgv_Query_result = new System.Windows.Forms.DataGridView();
            this.txt_Queryid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Lyzl = new System.Windows.Forms.TextBox();
            this.txt_Materia_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Materia_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Query_result)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Operator
            // 
            this.txt_Operator.BackColor = System.Drawing.Color.Pink;
            this.txt_Operator.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Operator.Location = new System.Drawing.Point(110, 204);
            this.txt_Operator.Name = "txt_Operator";
            this.txt_Operator.Size = new System.Drawing.Size(206, 31);
            this.txt_Operator.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 42;
            this.label9.Text = "操作人:";
            // 
            // txt_Outdate
            // 
            this.txt_Outdate.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Outdate.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Outdate.Location = new System.Drawing.Point(110, 167);
            this.txt_Outdate.Name = "txt_Outdate";
            this.txt_Outdate.ReadOnly = true;
            this.txt_Outdate.Size = new System.Drawing.Size(206, 31);
            this.txt_Outdate.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "录入日期:";
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(687, 22);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 30);
            this.btn_Query.TabIndex = 37;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            // 
            // dgv_Query_result
            // 
            this.dgv_Query_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Query_result.Location = new System.Drawing.Point(347, 62);
            this.dgv_Query_result.Name = "dgv_Query_result";
            this.dgv_Query_result.RowTemplate.Height = 23;
            this.dgv_Query_result.Size = new System.Drawing.Size(689, 304);
            this.dgv_Query_result.TabIndex = 36;
            // 
            // txt_Queryid
            // 
            this.txt_Queryid.Location = new System.Drawing.Point(475, 24);
            this.txt_Queryid.Name = "txt_Queryid";
            this.txt_Queryid.ReadOnly = true;
            this.txt_Queryid.Size = new System.Drawing.Size(206, 26);
            this.txt_Queryid.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "查询材料编号:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(185, 336);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_Cancel.TabIndex = 33;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Save.Location = new System.Drawing.Point(71, 336);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 30);
            this.btn_Save.TabIndex = 32;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // txt_Lyzl
            // 
            this.txt_Lyzl.BackColor = System.Drawing.Color.Bisque;
            this.txt_Lyzl.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lyzl.Location = new System.Drawing.Point(110, 130);
            this.txt_Lyzl.Name = "txt_Lyzl";
            this.txt_Lyzl.ReadOnly = true;
            this.txt_Lyzl.Size = new System.Drawing.Size(206, 31);
            this.txt_Lyzl.TabIndex = 31;
            // 
            // txt_Materia_name
            // 
            this.txt_Materia_name.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Materia_name.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Materia_name.Location = new System.Drawing.Point(110, 93);
            this.txt_Materia_name.Name = "txt_Materia_name";
            this.txt_Materia_name.ReadOnly = true;
            this.txt_Materia_name.Size = new System.Drawing.Size(206, 31);
            this.txt_Materia_name.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "期初总量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "材料名称:";
            // 
            // txt_Materia_id
            // 
            this.txt_Materia_id.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Materia_id.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Materia_id.Location = new System.Drawing.Point(110, 56);
            this.txt_Materia_id.Name = "txt_Materia_id";
            this.txt_Materia_id.ReadOnly = true;
            this.txt_Materia_id.Size = new System.Drawing.Size(206, 31);
            this.txt_Materia_id.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "材料编号:";
            // 
            // Frm_matstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 561);
            this.Controls.Add(this.txt_Operator);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Outdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.dgv_Query_result);
            this.Controls.Add(this.txt_Queryid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Lyzl);
            this.Controls.Add(this.txt_Materia_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Materia_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_matstock";
            this.Text = "材料期初数据录入";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Query_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Operator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Outdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.DataGridView dgv_Query_result;
        private System.Windows.Forms.TextBox txt_Queryid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Lyzl;
        private System.Windows.Forms.TextBox txt_Materia_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Materia_id;
        private System.Windows.Forms.Label label1;
    }
}