namespace MTsystem_win
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
            this.purchaseInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.sale_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.workshop_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mat_Receive = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mat_Givbackquery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mat_ReceiveQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouse_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.cus_info_input = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Material = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mat_In = new System.Windows.Forms.ToolStripMenuItem();
            this.mat_returnPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.mat_giveback = new System.Windows.Forms.ToolStripMenuItem();
            this.mat_Basestock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.pro_info_input = new System.Windows.Forms.ToolStripMenuItem();
            this.pro_input_update = new System.Windows.Forms.ToolStripMenuItem();
            this.pro_price_update = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ProductBillstatus = new System.Windows.Forms.ToolStripMenuItem();
            this.tms_ReportView = new System.Windows.Forms.ToolStripMenuItem();
            this.mat_Dayreport = new System.Windows.Forms.ToolStripMenuItem();
            this.mat_stock_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.pro_all_report = new System.Windows.Forms.ToolStripMenuItem();
            this.pro_stock_report = new System.Windows.Forms.ToolStripMenuItem();
            this.pro_input = new System.Windows.Forms.ToolStripMenuItem();
            this.pro_output = new System.Windows.Forms.ToolStripMenuItem();
            this.pro_returnGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.envelope_print = new System.Windows.Forms.ToolStripMenuItem();
            this.tag_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.sys_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mat_Inventory_query = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menuStrip
            // 
            this.main_menuStrip.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.system_Item,
            this.purchase_Item,
            this.sale_Item,
            this.workshop_Item,
            this.warehouse_Item,
            this.tms_ReportView,
            this.pro_input,
            this.pro_output,
            this.pro_returnGoods,
            this.envelope_print,
            this.tag_Item,
            this.sys_exit});
            this.main_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.main_menuStrip.Name = "main_menuStrip";
            this.main_menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.main_menuStrip.Size = new System.Drawing.Size(1136, 27);
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
            this.purchase_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseInfor,
            this.supplierInfor,
            this.purchaseOrder});
            this.purchase_Item.Name = "purchase_Item";
            this.purchase_Item.Size = new System.Drawing.Size(57, 23);
            this.purchase_Item.Text = "采购";
            // 
            // purchaseInfor
            // 
            this.purchaseInfor.Name = "purchaseInfor";
            this.purchaseInfor.Size = new System.Drawing.Size(168, 24);
            this.purchaseInfor.Text = "材料信息";
            this.purchaseInfor.Click += new System.EventHandler(this.purchaseInfor_Click);
            // 
            // supplierInfor
            // 
            this.supplierInfor.Name = "supplierInfor";
            this.supplierInfor.Size = new System.Drawing.Size(168, 24);
            this.supplierInfor.Text = "供应商信息";
            this.supplierInfor.Click += new System.EventHandler(this.supplierInfor_Click);
            // 
            // purchaseOrder
            // 
            this.purchaseOrder.Name = "purchaseOrder";
            this.purchaseOrder.Size = new System.Drawing.Size(168, 24);
            this.purchaseOrder.Text = "采购订单";
            this.purchaseOrder.Click += new System.EventHandler(this.purchaseOrder_Click);
            // 
            // sale_Item
            // 
            this.sale_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerInfor});
            this.sale_Item.Name = "sale_Item";
            this.sale_Item.Size = new System.Drawing.Size(57, 23);
            this.sale_Item.Text = "销售";
            // 
            // customerInfor
            // 
            this.customerInfor.Name = "customerInfor";
            this.customerInfor.Size = new System.Drawing.Size(150, 24);
            this.customerInfor.Text = "客户信息";
            this.customerInfor.Click += new System.EventHandler(this.customerInfor_Click);
            // 
            // workshop_Item
            // 
            this.workshop_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_mat_Receive,
            this.tsmi_mat_Givbackquery,
            this.tsmi_mat_ReceiveQuery});
            this.workshop_Item.Name = "workshop_Item";
            this.workshop_Item.Size = new System.Drawing.Size(57, 23);
            this.workshop_Item.Text = "车间";
            // 
            // tsmi_mat_Receive
            // 
            this.tsmi_mat_Receive.Name = "tsmi_mat_Receive";
            this.tsmi_mat_Receive.Size = new System.Drawing.Size(186, 24);
            this.tsmi_mat_Receive.Text = "材料领用";
            this.tsmi_mat_Receive.Click += new System.EventHandler(this.tsmi_mat_Receive_Click);
            // 
            // tsmi_mat_Givbackquery
            // 
            this.tsmi_mat_Givbackquery.Name = "tsmi_mat_Givbackquery";
            this.tsmi_mat_Givbackquery.Size = new System.Drawing.Size(186, 24);
            this.tsmi_mat_Givbackquery.Text = "材料退回查询";
            this.tsmi_mat_Givbackquery.Click += new System.EventHandler(this.tsmi_mat_Givbackquery_Click);
            // 
            // tsmi_mat_ReceiveQuery
            // 
            this.tsmi_mat_ReceiveQuery.Name = "tsmi_mat_ReceiveQuery";
            this.tsmi_mat_ReceiveQuery.Size = new System.Drawing.Size(186, 24);
            this.tsmi_mat_ReceiveQuery.Text = "领料记录查询";
            this.tsmi_mat_ReceiveQuery.Click += new System.EventHandler(this.tsmi_mat_ReceiveQuery_Click);
            // 
            // warehouse_Item
            // 
            this.warehouse_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cus_info_input,
            this.tsm_Material,
            this.tsm_Product,
            this.tsm_ProductBillstatus});
            this.warehouse_Item.Name = "warehouse_Item";
            this.warehouse_Item.Size = new System.Drawing.Size(57, 23);
            this.warehouse_Item.Text = "仓库";
            // 
            // cus_info_input
            // 
            this.cus_info_input.Name = "cus_info_input";
            this.cus_info_input.Size = new System.Drawing.Size(186, 24);
            this.cus_info_input.Text = "客户信息";
            this.cus_info_input.Click += new System.EventHandler(this.cus_info_input_Click);
            // 
            // tsm_Material
            // 
            this.tsm_Material.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_mat_In,
            this.mat_Inventory_query,
            this.mat_returnPurchase,
            this.mat_giveback,
            this.mat_Basestock});
            this.tsm_Material.Name = "tsm_Material";
            this.tsm_Material.Size = new System.Drawing.Size(186, 24);
            this.tsm_Material.Text = "原材料";
            // 
            // tsmi_mat_In
            // 
            this.tsmi_mat_In.Name = "tsmi_mat_In";
            this.tsmi_mat_In.Size = new System.Drawing.Size(186, 24);
            this.tsmi_mat_In.Text = "材料进仓";
            this.tsmi_mat_In.Click += new System.EventHandler(this.tsmi_mat_In_Click);
            // 
            // mat_returnPurchase
            // 
            this.mat_returnPurchase.Name = "mat_returnPurchase";
            this.mat_returnPurchase.Size = new System.Drawing.Size(186, 24);
            this.mat_returnPurchase.Text = "材料退货";
            this.mat_returnPurchase.Click += new System.EventHandler(this.mat_returnPurchase_Click);
            // 
            // mat_giveback
            // 
            this.mat_giveback.Name = "mat_giveback";
            this.mat_giveback.Size = new System.Drawing.Size(186, 24);
            this.mat_giveback.Text = "材料退回确认";
            this.mat_giveback.Click += new System.EventHandler(this.mat_giveback_Click);
            // 
            // mat_Basestock
            // 
            this.mat_Basestock.Name = "mat_Basestock";
            this.mat_Basestock.Size = new System.Drawing.Size(186, 24);
            this.mat_Basestock.Text = "材料期初库存";
            this.mat_Basestock.Click += new System.EventHandler(this.mat_Basestock_Click);
            // 
            // tsm_Product
            // 
            this.tsm_Product.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pro_info_input,
            this.pro_input_update,
            this.pro_price_update});
            this.tsm_Product.Name = "tsm_Product";
            this.tsm_Product.Size = new System.Drawing.Size(186, 24);
            this.tsm_Product.Text = "产品";
            // 
            // pro_info_input
            // 
            this.pro_info_input.Name = "pro_info_input";
            this.pro_info_input.Size = new System.Drawing.Size(186, 24);
            this.pro_info_input.Text = "产品信息维护";
            this.pro_info_input.Click += new System.EventHandler(this.pro_info_input_Click);
            // 
            // pro_input_update
            // 
            this.pro_input_update.Name = "pro_input_update";
            this.pro_input_update.Size = new System.Drawing.Size(186, 24);
            this.pro_input_update.Text = "产品进仓修改";
            this.pro_input_update.Click += new System.EventHandler(this.pro_input_update_Click);
            // 
            // pro_price_update
            // 
            this.pro_price_update.Name = "pro_price_update";
            this.pro_price_update.Size = new System.Drawing.Size(186, 24);
            this.pro_price_update.Text = "产品价格维护";
            this.pro_price_update.Click += new System.EventHandler(this.pro_price_update_Click);
            // 
            // tsm_ProductBillstatus
            // 
            this.tsm_ProductBillstatus.Name = "tsm_ProductBillstatus";
            this.tsm_ProductBillstatus.Size = new System.Drawing.Size(186, 24);
            this.tsm_ProductBillstatus.Text = "单据状态处理";
            this.tsm_ProductBillstatus.Click += new System.EventHandler(this.tsm_ProductBillstatus_Click);
            // 
            // tms_ReportView
            // 
            this.tms_ReportView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mat_Dayreport,
            this.mat_stock_Report,
            this.pro_all_report,
            this.pro_stock_report});
            this.tms_ReportView.Name = "tms_ReportView";
            this.tms_ReportView.Size = new System.Drawing.Size(57, 23);
            this.tms_ReportView.Text = "报表";
            // 
            // mat_Dayreport
            // 
            this.mat_Dayreport.Name = "mat_Dayreport";
            this.mat_Dayreport.Size = new System.Drawing.Size(186, 24);
            this.mat_Dayreport.Text = "材料日报表";
            this.mat_Dayreport.Click += new System.EventHandler(this.mat_Dayreport_Click);
            // 
            // mat_stock_Report
            // 
            this.mat_stock_Report.Name = "mat_stock_Report";
            this.mat_stock_Report.Size = new System.Drawing.Size(186, 24);
            this.mat_stock_Report.Text = "材料库存报表";
            this.mat_stock_Report.Click += new System.EventHandler(this.mat_stock_Report_Click);
            // 
            // pro_all_report
            // 
            this.pro_all_report.Name = "pro_all_report";
            this.pro_all_report.Size = new System.Drawing.Size(186, 24);
            this.pro_all_report.Text = "成品出库报表";
            this.pro_all_report.Click += new System.EventHandler(this.pro_all_report_Click);
            // 
            // pro_stock_report
            // 
            this.pro_stock_report.Name = "pro_stock_report";
            this.pro_stock_report.Size = new System.Drawing.Size(186, 24);
            this.pro_stock_report.Text = "成品库存报表";
            this.pro_stock_report.Click += new System.EventHandler(this.pro_stock_report_Click);
            // 
            // pro_input
            // 
            this.pro_input.Name = "pro_input";
            this.pro_input.Size = new System.Drawing.Size(93, 23);
            this.pro_input.Text = "产品进仓";
            this.pro_input.Click += new System.EventHandler(this.pro_input_Click);
            // 
            // pro_output
            // 
            this.pro_output.Name = "pro_output";
            this.pro_output.Size = new System.Drawing.Size(93, 23);
            this.pro_output.Text = "产品出仓";
            this.pro_output.Click += new System.EventHandler(this.pro_output_Click);
            // 
            // pro_returnGoods
            // 
            this.pro_returnGoods.Name = "pro_returnGoods";
            this.pro_returnGoods.Size = new System.Drawing.Size(93, 23);
            this.pro_returnGoods.Text = "销售退货";
            this.pro_returnGoods.Click += new System.EventHandler(this.pro_returnGoods_Click);
            // 
            // envelope_print
            // 
            this.envelope_print.Name = "envelope_print";
            this.envelope_print.Size = new System.Drawing.Size(93, 23);
            this.envelope_print.Text = "信封打印";
            this.envelope_print.Click += new System.EventHandler(this.envelope_print_Click);
            // 
            // tag_Item
            // 
            this.tag_Item.Name = "tag_Item";
            this.tag_Item.Size = new System.Drawing.Size(93, 23);
            this.tag_Item.Text = "标签打印";
            this.tag_Item.Click += new System.EventHandler(this.tag_Item_Click);
            // 
            // sys_exit
            // 
            this.sys_exit.Name = "sys_exit";
            this.sys_exit.Size = new System.Drawing.Size(93, 23);
            this.sys_exit.Text = "退出系统";
            this.sys_exit.Click += new System.EventHandler(this.sys_exit_Click);
            // 
            // mat_Inventory_query
            // 
            this.mat_Inventory_query.Name = "mat_Inventory_query";
            this.mat_Inventory_query.Size = new System.Drawing.Size(186, 24);
            this.mat_Inventory_query.Text = "库存查询";
            this.mat_Inventory_query.Click += new System.EventHandler(this.mat_Inventory_query_Click);
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1136, 749);
            this.Controls.Add(this.main_menuStrip);
            this.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.main_menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.ToolStripMenuItem tsmi_mat_Receive;
        private System.Windows.Forms.ToolStripMenuItem sys_exit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mat_ReceiveQuery;
        private System.Windows.Forms.ToolStripMenuItem tag_Item;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mat_Givbackquery;
        private System.Windows.Forms.ToolStripMenuItem purchaseInfor;
        private System.Windows.Forms.ToolStripMenuItem supplierInfor;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrder;
        private System.Windows.Forms.ToolStripMenuItem sale_Item;
        private System.Windows.Forms.ToolStripMenuItem customerInfor;
        private System.Windows.Forms.ToolStripMenuItem cus_info_input;
        private System.Windows.Forms.ToolStripMenuItem tsm_Material;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mat_In;
        private System.Windows.Forms.ToolStripMenuItem mat_returnPurchase;
        private System.Windows.Forms.ToolStripMenuItem mat_giveback;
        private System.Windows.Forms.ToolStripMenuItem tsm_Product;
        private System.Windows.Forms.ToolStripMenuItem mat_Basestock;
        private System.Windows.Forms.ToolStripMenuItem pro_info_input;
        private System.Windows.Forms.ToolStripMenuItem pro_input_update;
        private System.Windows.Forms.ToolStripMenuItem envelope_print;
        private System.Windows.Forms.ToolStripMenuItem pro_price_update;
        private System.Windows.Forms.ToolStripMenuItem pro_output;
        private System.Windows.Forms.ToolStripMenuItem tms_ReportView;
        private System.Windows.Forms.ToolStripMenuItem mat_Dayreport;
        private System.Windows.Forms.ToolStripMenuItem mat_stock_Report;
        private System.Windows.Forms.ToolStripMenuItem pro_all_report;
        private System.Windows.Forms.ToolStripMenuItem pro_returnGoods;
        private System.Windows.Forms.ToolStripMenuItem tsm_ProductBillstatus;
        private System.Windows.Forms.ToolStripMenuItem pro_input;
        private System.Windows.Forms.ToolStripMenuItem pro_stock_report;
        private System.Windows.Forms.ToolStripMenuItem mat_Inventory_query;
    }
}