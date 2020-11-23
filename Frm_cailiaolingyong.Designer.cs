namespace MTsystem_win
{
    partial class Frm_cailiaolingyong
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Materia_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Materia_name = new System.Windows.Forms.TextBox();
            this.txt_Lysl = new System.Windows.Forms.TextBox();
            this.txt_Materia_unit = new System.Windows.Forms.TextBox();
            this.txt_Lyzl = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_Queryid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_Query_result = new System.Windows.Forms.DataGridView();
            this.btn_Query = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Outid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Outdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Operator = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Query_result)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "材料编号:";
            // 
            // txt_Materia_id
            // 
            this.txt_Materia_id.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Materia_id.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Materia_id.Location = new System.Drawing.Point(110, 56);
            this.txt_Materia_id.Name = "txt_Materia_id";
            this.txt_Materia_id.ReadOnly = true;
            this.txt_Materia_id.Size = new System.Drawing.Size(206, 31);
            this.txt_Materia_id.TabIndex = 1;
            this.txt_Materia_id.DoubleClick += new System.EventHandler(this.txt_Materia_id_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "材料名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "领用数量:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "材料规格:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "领用总量:";
            // 
            // txt_Materia_name
            // 
            this.txt_Materia_name.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Materia_name.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Materia_name.Location = new System.Drawing.Point(110, 93);
            this.txt_Materia_name.Name = "txt_Materia_name";
            this.txt_Materia_name.ReadOnly = true;
            this.txt_Materia_name.Size = new System.Drawing.Size(206, 31);
            this.txt_Materia_name.TabIndex = 6;
            // 
            // txt_Lysl
            // 
            this.txt_Lysl.BackColor = System.Drawing.Color.Bisque;
            this.txt_Lysl.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lysl.Location = new System.Drawing.Point(110, 130);
            this.txt_Lysl.Name = "txt_Lysl";
            this.txt_Lysl.Size = new System.Drawing.Size(206, 31);
            this.txt_Lysl.TabIndex = 7;
            this.txt_Lysl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Lysl_KeyPress);
            this.txt_Lysl.Leave += new System.EventHandler(this.txt_Lysl_Leave);
            // 
            // txt_Materia_unit
            // 
            this.txt_Materia_unit.BackColor = System.Drawing.Color.Bisque;
            this.txt_Materia_unit.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Materia_unit.Location = new System.Drawing.Point(110, 167);
            this.txt_Materia_unit.Name = "txt_Materia_unit";
            this.txt_Materia_unit.Size = new System.Drawing.Size(206, 31);
            this.txt_Materia_unit.TabIndex = 8;
            this.txt_Materia_unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Materia_unit_KeyPress);
            this.txt_Materia_unit.Leave += new System.EventHandler(this.txt_Materia_unit_Leave);
            // 
            // txt_Lyzl
            // 
            this.txt_Lyzl.BackColor = System.Drawing.Color.Bisque;
            this.txt_Lyzl.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lyzl.Location = new System.Drawing.Point(110, 204);
            this.txt_Lyzl.Name = "txt_Lyzl";
            this.txt_Lyzl.ReadOnly = true;
            this.txt_Lyzl.Size = new System.Drawing.Size(206, 31);
            this.txt_Lyzl.TabIndex = 9;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Save.Location = new System.Drawing.Point(71, 336);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 30);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(185, 336);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Queryid
            // 
            this.txt_Queryid.Location = new System.Drawing.Point(475, 24);
            this.txt_Queryid.Name = "txt_Queryid";
            this.txt_Queryid.ReadOnly = true;
            this.txt_Queryid.Size = new System.Drawing.Size(206, 26);
            this.txt_Queryid.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "查询材料编号:";
            // 
            // dgv_Query_result
            // 
            this.dgv_Query_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Query_result.Location = new System.Drawing.Point(347, 62);
            this.dgv_Query_result.Name = "dgv_Query_result";
            this.dgv_Query_result.RowTemplate.Height = 23;
            this.dgv_Query_result.Size = new System.Drawing.Size(689, 304);
            this.dgv_Query_result.TabIndex = 14;
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(687, 22);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 30);
            this.btn_Query.TabIndex = 15;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "领用单号:";
            // 
            // txt_Outid
            // 
            this.txt_Outid.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Outid.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Outid.Location = new System.Drawing.Point(110, 19);
            this.txt_Outid.Name = "txt_Outid";
            this.txt_Outid.ReadOnly = true;
            this.txt_Outid.Size = new System.Drawing.Size(206, 31);
            this.txt_Outid.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "领用日期:";
            // 
            // txt_Outdate
            // 
            this.txt_Outdate.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Outdate.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Outdate.Location = new System.Drawing.Point(110, 241);
            this.txt_Outdate.Name = "txt_Outdate";
            this.txt_Outdate.ReadOnly = true;
            this.txt_Outdate.Size = new System.Drawing.Size(206, 31);
            this.txt_Outdate.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "领用人:";
            // 
            // txt_Operator
            // 
            this.txt_Operator.BackColor = System.Drawing.Color.Pink;
            this.txt_Operator.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Operator.Location = new System.Drawing.Point(110, 278);
            this.txt_Operator.Name = "txt_Operator";
            this.txt_Operator.Size = new System.Drawing.Size(206, 31);
            this.txt_Operator.TabIndex = 21;
            // 
            // Frm_cailiaolingyong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1048, 561);
            this.Controls.Add(this.txt_Operator);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Outdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Outid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.dgv_Query_result);
            this.Controls.Add(this.txt_Queryid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Lyzl);
            this.Controls.Add(this.txt_Materia_unit);
            this.Controls.Add(this.txt_Lysl);
            this.Controls.Add(this.txt_Materia_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Materia_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_cailiaolingyong";
            this.Text = "材料领用窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_cailiaolingyong_FormClosed);
            this.Load += new System.EventHandler(this.Frm_cailiaolingyong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Query_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Materia_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Materia_name;
        private System.Windows.Forms.TextBox txt_Lysl;
        private System.Windows.Forms.TextBox txt_Materia_unit;
        private System.Windows.Forms.TextBox txt_Lyzl;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_Queryid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_Query_result;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Outid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Outdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Operator;
    }
}