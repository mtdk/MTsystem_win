﻿namespace MTsystem_win
{
    partial class Frm_main
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
            this.main_menuStrip = new System.Windows.Forms.MenuStrip();
            this.system_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.user_Additem = new System.Windows.Forms.ToolStripMenuItem();
            this.user_Updateitem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchase_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.workshop_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mat_Receive = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouse_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.stock_Viewitem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menuStrip
            // 
            this.main_menuStrip.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.system_Item,
            this.purchase_Item,
            this.workshop_Item,
            this.warehouse_Item,
            this.stock_Viewitem});
            this.main_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.main_menuStrip.Name = "main_menuStrip";
            this.main_menuStrip.Size = new System.Drawing.Size(473, 27);
            this.main_menuStrip.TabIndex = 1;
            this.main_menuStrip.Text = "菜单";
            // 
            // system_Item
            // 
            this.system_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.user_Additem,
            this.user_Updateitem});
            this.system_Item.Name = "system_Item";
            this.system_Item.Size = new System.Drawing.Size(93, 23);
            this.system_Item.Text = "系统菜单";
            // 
            // user_Additem
            // 
            this.user_Additem.Name = "user_Additem";
            this.user_Additem.Size = new System.Drawing.Size(186, 24);
            this.user_Additem.Text = "新建用户";
            // 
            // user_Updateitem
            // 
            this.user_Updateitem.Name = "user_Updateitem";
            this.user_Updateitem.Size = new System.Drawing.Size(186, 24);
            this.user_Updateitem.Text = "用户信息修改";
            // 
            // purchase_Item
            // 
            this.purchase_Item.Name = "purchase_Item";
            this.purchase_Item.Size = new System.Drawing.Size(57, 23);
            this.purchase_Item.Text = "采购";
            // 
            // workshop_Item
            // 
            this.workshop_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_mat_Receive});
            this.workshop_Item.Name = "workshop_Item";
            this.workshop_Item.Size = new System.Drawing.Size(57, 23);
            this.workshop_Item.Text = "车间";
            // 
            // tsmi_mat_Receive
            // 
            this.tsmi_mat_Receive.Name = "tsmi_mat_Receive";
            this.tsmi_mat_Receive.Size = new System.Drawing.Size(152, 24);
            this.tsmi_mat_Receive.Text = "材料领用";
            this.tsmi_mat_Receive.Click += new System.EventHandler(this.tsmi_mat_Receive_Click);
            // 
            // warehouse_Item
            // 
            this.warehouse_Item.Name = "warehouse_Item";
            this.warehouse_Item.Size = new System.Drawing.Size(57, 23);
            this.warehouse_Item.Text = "仓库";
            // 
            // stock_Viewitem
            // 
            this.stock_Viewitem.Name = "stock_Viewitem";
            this.stock_Viewitem.Size = new System.Drawing.Size(93, 23);
            this.stock_Viewitem.Text = "库存查询";
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 479);
            this.Controls.Add(this.main_menuStrip);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.main_menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Frm_main";
            this.Text = "系统主窗口";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_main_FormClosed);
            this.main_menuStrip.ResumeLayout(false);
            this.main_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem system_Item;
        private System.Windows.Forms.ToolStripMenuItem user_Additem;
        private System.Windows.Forms.ToolStripMenuItem user_Updateitem;
        private System.Windows.Forms.ToolStripMenuItem purchase_Item;
        private System.Windows.Forms.ToolStripMenuItem workshop_Item;
        private System.Windows.Forms.ToolStripMenuItem warehouse_Item;
        private System.Windows.Forms.ToolStripMenuItem stock_Viewitem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mat_Receive;
    }
}