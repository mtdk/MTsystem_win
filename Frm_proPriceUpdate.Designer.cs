namespace MTsystem_win
{
    partial class Frm_proPriceUpdate
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
            this.txt_CusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CusId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_productPrice = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_ProductPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ProductId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_proid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productPrice)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_CusName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_CusId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客户选择区";
            // 
            // txt_CusName
            // 
            this.txt_CusName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_CusName.Location = new System.Drawing.Point(319, 28);
            this.txt_CusName.MaxLength = 100;
            this.txt_CusName.Name = "txt_CusName";
            this.txt_CusName.Size = new System.Drawing.Size(305, 26);
            this.txt_CusName.TabIndex = 0;
            this.txt_CusName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CusName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "客户名称:";
            // 
            // txt_CusId
            // 
            this.txt_CusId.Location = new System.Drawing.Point(102, 28);
            this.txt_CusId.Name = "txt_CusId";
            this.txt_CusId.ReadOnly = true;
            this.txt_CusId.Size = new System.Drawing.Size(115, 26);
            this.txt_CusId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "客户编号:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_productPrice);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 382);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "结果选择区";
            // 
            // dgv_productPrice
            // 
            this.dgv_productPrice.AllowUserToAddRows = false;
            this.dgv_productPrice.AllowUserToDeleteRows = false;
            this.dgv_productPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_productPrice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_productPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_productPrice.Location = new System.Drawing.Point(3, 22);
            this.dgv_productPrice.Name = "dgv_productPrice";
            this.dgv_productPrice.ReadOnly = true;
            this.dgv_productPrice.RowTemplate.Height = 23;
            this.dgv_productPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productPrice.Size = new System.Drawing.Size(706, 357);
            this.dgv_productPrice.TabIndex = 0;
            this.dgv_productPrice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productPrice_CellDoubleClick);
            this.dgv_productPrice.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_productPrice_CellValidating);
            this.dgv_productPrice.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dgv_productPrice_PreviewKeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Cancel);
            this.groupBox3.Controls.Add(this.btn_Save);
            this.groupBox3.Controls.Add(this.txt_ProductPrice);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_ProductName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_ProductId);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_proid);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 478);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(709, 133);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "单价修改";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(410, 88);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "清  空";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(223, 88);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 28);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "保  存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_ProductPrice
            // 
            this.txt_ProductPrice.Location = new System.Drawing.Point(586, 54);
            this.txt_ProductPrice.Name = "txt_ProductPrice";
            this.txt_ProductPrice.Size = new System.Drawing.Size(100, 26);
            this.txt_ProductPrice.TabIndex = 7;
            this.txt_ProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ProductPrice_KeyPress);
            this.txt_ProductPrice.Leave += new System.EventHandler(this.txt_ProductPrice_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(614, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "单价";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(257, 54);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.ReadOnly = true;
            this.txt_ProductName.Size = new System.Drawing.Size(329, 26);
            this.txt_ProductName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "品名";
            // 
            // txt_ProductId
            // 
            this.txt_ProductId.Location = new System.Drawing.Point(124, 54);
            this.txt_ProductId.Name = "txt_ProductId";
            this.txt_ProductId.ReadOnly = true;
            this.txt_ProductId.Size = new System.Drawing.Size(133, 26);
            this.txt_ProductId.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "编号";
            // 
            // txt_proid
            // 
            this.txt_proid.Location = new System.Drawing.Point(24, 54);
            this.txt_proid.Name = "txt_proid";
            this.txt_proid.ReadOnly = true;
            this.txt_proid.Size = new System.Drawing.Size(100, 26);
            this.txt_proid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "系统码";
            // 
            // Frm_proPriceUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 621);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_proPriceUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品价格维护窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_proPriceUpdate_FormClosed);
            this.Load += new System.EventHandler(this.Frm_proPriceUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productPrice)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_CusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CusId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_productPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_ProductPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ProductId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_proid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
    }
}