namespace MTsystem_win
{
    partial class Frm_mat_giveback
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
            this.txt_Outid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Lyzl = new System.Windows.Forms.TextBox();
            this.txt_Materia_unit = new System.Windows.Forms.TextBox();
            this.txt_Lysl = new System.Windows.Forms.TextBox();
            this.txt_Materia_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Materia_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_gbid = new System.Windows.Forms.TextBox();
            this.txt_gbdate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_backReason = new System.Windows.Forms.TextBox();
            this.txt_matid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Operator
            // 
            this.txt_Operator.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Operator.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Operator.Location = new System.Drawing.Point(421, 89);
            this.txt_Operator.MaxLength = 15;
            this.txt_Operator.Name = "txt_Operator";
            this.txt_Operator.Size = new System.Drawing.Size(206, 31);
            this.txt_Operator.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 44;
            this.label9.Text = "操作人:";
            // 
            // txt_Outdate
            // 
            this.txt_Outdate.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Outdate.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Outdate.Location = new System.Drawing.Point(421, 52);
            this.txt_Outdate.Name = "txt_Outdate";
            this.txt_Outdate.ReadOnly = true;
            this.txt_Outdate.Size = new System.Drawing.Size(206, 31);
            this.txt_Outdate.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "领用日期:";
            // 
            // txt_Outid
            // 
            this.txt_Outid.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Outid.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Outid.Location = new System.Drawing.Point(421, 15);
            this.txt_Outid.Name = "txt_Outid";
            this.txt_Outid.ReadOnly = true;
            this.txt_Outid.Size = new System.Drawing.Size(206, 31);
            this.txt_Outid.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "领用单号:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(507, 232);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_Cancel.TabIndex = 35;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Save.Location = new System.Drawing.Point(393, 232);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 30);
            this.btn_Save.TabIndex = 34;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Lyzl
            // 
            this.txt_Lyzl.BackColor = System.Drawing.Color.Bisque;
            this.txt_Lyzl.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lyzl.Location = new System.Drawing.Point(107, 237);
            this.txt_Lyzl.Name = "txt_Lyzl";
            this.txt_Lyzl.ReadOnly = true;
            this.txt_Lyzl.Size = new System.Drawing.Size(206, 31);
            this.txt_Lyzl.TabIndex = 33;
            // 
            // txt_Materia_unit
            // 
            this.txt_Materia_unit.BackColor = System.Drawing.Color.Bisque;
            this.txt_Materia_unit.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Materia_unit.Location = new System.Drawing.Point(107, 200);
            this.txt_Materia_unit.MaxLength = 10;
            this.txt_Materia_unit.Name = "txt_Materia_unit";
            this.txt_Materia_unit.Size = new System.Drawing.Size(206, 31);
            this.txt_Materia_unit.TabIndex = 32;
            this.txt_Materia_unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Materia_unit_KeyPress);
            this.txt_Materia_unit.Leave += new System.EventHandler(this.txt_Materia_unit_Leave);
            // 
            // txt_Lysl
            // 
            this.txt_Lysl.BackColor = System.Drawing.Color.Bisque;
            this.txt_Lysl.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lysl.Location = new System.Drawing.Point(107, 163);
            this.txt_Lysl.MaxLength = 10;
            this.txt_Lysl.Name = "txt_Lysl";
            this.txt_Lysl.Size = new System.Drawing.Size(206, 31);
            this.txt_Lysl.TabIndex = 31;
            this.txt_Lysl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Lysl_KeyPress);
            this.txt_Lysl.Leave += new System.EventHandler(this.txt_Lysl_Leave);
            // 
            // txt_Materia_name
            // 
            this.txt_Materia_name.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Materia_name.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Materia_name.Location = new System.Drawing.Point(107, 126);
            this.txt_Materia_name.Name = "txt_Materia_name";
            this.txt_Materia_name.ReadOnly = true;
            this.txt_Materia_name.Size = new System.Drawing.Size(206, 31);
            this.txt_Materia_name.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "领用总量:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "材料规格:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "领用数量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "材料名称:";
            // 
            // txt_Materia_id
            // 
            this.txt_Materia_id.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Materia_id.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Materia_id.Location = new System.Drawing.Point(107, 89);
            this.txt_Materia_id.Name = "txt_Materia_id";
            this.txt_Materia_id.ReadOnly = true;
            this.txt_Materia_id.Size = new System.Drawing.Size(206, 31);
            this.txt_Materia_id.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "材料编号:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 46;
            this.label10.Text = "回退单号:";
            // 
            // txt_gbid
            // 
            this.txt_gbid.BackColor = System.Drawing.Color.LightCyan;
            this.txt_gbid.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gbid.Location = new System.Drawing.Point(107, 15);
            this.txt_gbid.Name = "txt_gbid";
            this.txt_gbid.ReadOnly = true;
            this.txt_gbid.Size = new System.Drawing.Size(206, 31);
            this.txt_gbid.TabIndex = 47;
            // 
            // txt_gbdate
            // 
            this.txt_gbdate.BackColor = System.Drawing.Color.LightCyan;
            this.txt_gbdate.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gbdate.Location = new System.Drawing.Point(421, 126);
            this.txt_gbdate.Name = "txt_gbdate";
            this.txt_gbdate.ReadOnly = true;
            this.txt_gbdate.Size = new System.Drawing.Size(206, 31);
            this.txt_gbdate.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 19);
            this.label11.TabIndex = 48;
            this.label11.Text = "回退时间:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(325, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 19);
            this.label12.TabIndex = 50;
            this.label12.Text = "回退原因:";
            // 
            // txt_backReason
            // 
            this.txt_backReason.BackColor = System.Drawing.Color.LightPink;
            this.txt_backReason.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_backReason.Location = new System.Drawing.Point(421, 163);
            this.txt_backReason.Name = "txt_backReason";
            this.txt_backReason.Size = new System.Drawing.Size(206, 31);
            this.txt_backReason.TabIndex = 51;
            // 
            // txt_matid
            // 
            this.txt_matid.BackColor = System.Drawing.Color.LightCyan;
            this.txt_matid.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matid.Location = new System.Drawing.Point(107, 52);
            this.txt_matid.Name = "txt_matid";
            this.txt_matid.ReadOnly = true;
            this.txt_matid.Size = new System.Drawing.Size(206, 31);
            this.txt_matid.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 52;
            this.label6.Text = "系统编号:";
            // 
            // Frm_mat_giveback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(639, 286);
            this.Controls.Add(this.txt_matid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_backReason);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_gbdate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_gbid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Operator);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Outdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Outid);
            this.Controls.Add(this.label7);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_mat_giveback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "材料退回窗口";
            this.Load += new System.EventHandler(this.Frm_mat_giveback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Operator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Outdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Outid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Lyzl;
        private System.Windows.Forms.TextBox txt_Materia_unit;
        private System.Windows.Forms.TextBox txt_Lysl;
        private System.Windows.Forms.TextBox txt_Materia_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Materia_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_gbid;
        private System.Windows.Forms.TextBox txt_gbdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_backReason;
        private System.Windows.Forms.TextBox txt_matid;
        private System.Windows.Forms.Label label6;
    }
}