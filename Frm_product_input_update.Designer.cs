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
            this.txt_batchNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_inputDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Inputid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_batchNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_inputDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Inputid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1126, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "整单记录状态修改";
            // 
            // txt_batchNum
            // 
            this.txt_batchNum.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_batchNum.Location = new System.Drawing.Point(583, 31);
            this.txt_batchNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_batchNum.MaxLength = 20;
            this.txt_batchNum.Name = "txt_batchNum";
            this.txt_batchNum.Size = new System.Drawing.Size(162, 30);
            this.txt_batchNum.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
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
            this.txt_inputDate.Size = new System.Drawing.Size(122, 30);
            this.txt_inputDate.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
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
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "进仓记录号:";
            // 
            // Frm_product_input_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 594);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_product_input_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "产品进仓修改窗口";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}