namespace MTsystem_win
{
    partial class Frm_productOutSelect
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
            this.dgv_productOutSelect = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productOutSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_productOutSelect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 538);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgv_productOutSelect
            // 
            this.dgv_productOutSelect.AllowUserToAddRows = false;
            this.dgv_productOutSelect.AllowUserToDeleteRows = false;
            this.dgv_productOutSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_productOutSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productOutSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_productOutSelect.Location = new System.Drawing.Point(3, 22);
            this.dgv_productOutSelect.Name = "dgv_productOutSelect";
            this.dgv_productOutSelect.ReadOnly = true;
            this.dgv_productOutSelect.RowHeadersVisible = false;
            this.dgv_productOutSelect.RowTemplate.Height = 23;
            this.dgv_productOutSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productOutSelect.Size = new System.Drawing.Size(989, 513);
            this.dgv_productOutSelect.TabIndex = 0;
            this.dgv_productOutSelect.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dgv_productOutSelect_PreviewKeyDown);
            // 
            // Frm_productOutSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 562);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_productOutSelect";
            this.Text = "产品选择窗口";
            this.Load += new System.EventHandler(this.Frm_productOutSelect_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productOutSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_productOutSelect;
    }
}