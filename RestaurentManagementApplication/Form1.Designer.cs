
namespace RestaurentManagementApplication
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.fpn_tables = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_account_info = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_discount = new System.Windows.Forms.Button();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.dud_discount = new System.Windows.Forms.DomainUpDown();
            this.dud_quantity = new System.Windows.Forms.DomainUpDown();
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_add_food_to_table = new System.Windows.Forms.Button();
            this.cbb_food = new System.Windows.Forms.ComboBox();
            this.cbb_category = new System.Windows.Forms.ComboBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lv_bill_detail = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_delete_food_from_table = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpn_tables
            // 
            this.fpn_tables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpn_tables.AutoScroll = true;
            this.fpn_tables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpn_tables.Location = new System.Drawing.Point(13, 31);
            this.fpn_tables.Name = "fpn_tables";
            this.fpn_tables.Size = new System.Drawing.Size(469, 544);
            this.fpn_tables.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Admin,
            this.tsm_account_info});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm_Admin
            // 
            this.tsm_Admin.Name = "tsm_Admin";
            this.tsm_Admin.Size = new System.Drawing.Size(67, 24);
            this.tsm_Admin.Text = "Admin";
            this.tsm_Admin.Click += new System.EventHandler(this.tsm_Admin_Click);
            // 
            // tsm_account_info
            // 
            this.tsm_account_info.Name = "tsm_account_info";
            this.tsm_account_info.Size = new System.Drawing.Size(159, 24);
            this.tsm_account_info.Text = "Account Information";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_discount);
            this.panel1.Controls.Add(this.txt_total);
            this.panel1.Controls.Add(this.dud_discount);
            this.panel1.Controls.Add(this.dud_quantity);
            this.panel1.Controls.Add(this.btn_pay);
            this.panel1.Controls.Add(this.btn_add_food_to_table);
            this.panel1.Controls.Add(this.cbb_food);
            this.panel1.Controls.Add(this.cbb_category);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.lv_bill_detail);
            this.panel1.Location = new System.Drawing.Point(489, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 544);
            this.panel1.TabIndex = 2;
            // 
            // btn_discount
            // 
            this.btn_discount.Location = new System.Drawing.Point(160, 508);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.Size = new System.Drawing.Size(99, 30);
            this.btn_discount.TabIndex = 6;
            this.btn_discount.Text = "% Giảm giá";
            this.btn_discount.UseVisualStyleBackColor = true;
            this.btn_discount.Click += new System.EventHandler(this.btn_discount_Click);
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(160, 481);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(182, 22);
            this.txt_total.TabIndex = 5;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dud_discount
            // 
            this.dud_discount.Items.Add("0.7");
            this.dud_discount.Items.Add("0.6");
            this.dud_discount.Items.Add("0.5");
            this.dud_discount.Items.Add("0.4");
            this.dud_discount.Items.Add("0.3");
            this.dud_discount.Items.Add("0.2");
            this.dud_discount.Items.Add("0.1");
            this.dud_discount.Items.Add("0.0");
            this.dud_discount.Location = new System.Drawing.Point(265, 511);
            this.dud_discount.Name = "dud_discount";
            this.dud_discount.Size = new System.Drawing.Size(77, 22);
            this.dud_discount.TabIndex = 4;
            this.dud_discount.Text = "0.0";
            // 
            // dud_quantity
            // 
            this.dud_quantity.Items.Add("20");
            this.dud_quantity.Items.Add("19");
            this.dud_quantity.Items.Add("18");
            this.dud_quantity.Items.Add("17");
            this.dud_quantity.Items.Add("16");
            this.dud_quantity.Items.Add("15");
            this.dud_quantity.Items.Add("14");
            this.dud_quantity.Items.Add("13");
            this.dud_quantity.Items.Add("12");
            this.dud_quantity.Items.Add("11");
            this.dud_quantity.Items.Add("10");
            this.dud_quantity.Items.Add("9");
            this.dud_quantity.Items.Add("8");
            this.dud_quantity.Items.Add("7");
            this.dud_quantity.Items.Add("6");
            this.dud_quantity.Items.Add("5");
            this.dud_quantity.Items.Add("4");
            this.dud_quantity.Items.Add("3");
            this.dud_quantity.Items.Add("2");
            this.dud_quantity.Items.Add("1");
            this.dud_quantity.Location = new System.Drawing.Point(376, 32);
            this.dud_quantity.Name = "dud_quantity";
            this.dud_quantity.Size = new System.Drawing.Size(77, 22);
            this.dud_quantity.TabIndex = 4;
            this.dud_quantity.Text = "1";
            // 
            // btn_pay
            // 
            this.btn_pay.Enabled = false;
            this.btn_pay.Location = new System.Drawing.Point(348, 480);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(109, 54);
            this.btn_pay.TabIndex = 3;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_add_food_to_table
            // 
            this.btn_add_food_to_table.Location = new System.Drawing.Point(261, 31);
            this.btn_add_food_to_table.Name = "btn_add_food_to_table";
            this.btn_add_food_to_table.Size = new System.Drawing.Size(109, 54);
            this.btn_add_food_to_table.TabIndex = 3;
            this.btn_add_food_to_table.Text = "Thêm món";
            this.btn_add_food_to_table.UseVisualStyleBackColor = true;
            this.btn_add_food_to_table.Click += new System.EventHandler(this.btn_add_food_to_table_Click);
            // 
            // cbb_food
            // 
            this.cbb_food.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_food.FormattingEnabled = true;
            this.cbb_food.Location = new System.Drawing.Point(8, 60);
            this.cbb_food.Name = "cbb_food";
            this.cbb_food.Size = new System.Drawing.Size(247, 24);
            this.cbb_food.TabIndex = 2;
            // 
            // cbb_category
            // 
            this.cbb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_category.FormattingEnabled = true;
            this.cbb_category.Location = new System.Drawing.Point(8, 30);
            this.cbb_category.Name = "cbb_category";
            this.cbb_category.Size = new System.Drawing.Size(247, 24);
            this.cbb_category.TabIndex = 2;
            this.cbb_category.SelectedIndexChanged += new System.EventHandler(this.cbb_category_SelectedIndexChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(460, 17);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Vui lòng chọn bàn để thêm món ăn";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lv_bill_detail
            // 
            this.lv_bill_detail.CheckBoxes = true;
            this.lv_bill_detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_bill_detail.ContextMenuStrip = this.contextMenuStrip1;
            this.lv_bill_detail.FullRowSelect = true;
            this.lv_bill_detail.GridLines = true;
            this.lv_bill_detail.HideSelection = false;
            this.lv_bill_detail.Location = new System.Drawing.Point(3, 103);
            this.lv_bill_detail.Name = "lv_bill_detail";
            this.lv_bill_detail.Size = new System.Drawing.Size(453, 371);
            this.lv_bill_detail.TabIndex = 0;
            this.lv_bill_detail.UseCompatibleStateImageBehavior = false;
            this.lv_bill_detail.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món ăn";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_delete_food_from_table});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 28);
            // 
            // tsm_delete_food_from_table
            // 
            this.tsm_delete_food_from_table.Name = "tsm_delete_food_from_table";
            this.tsm_delete_food_from_table.Size = new System.Drawing.Size(104, 24);
            this.tsm_delete_food_from_table.Text = "Xóa";
            this.tsm_delete_food_from_table.Click += new System.EventHandler(this.tsm_delete_food_from_table_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fpn_tables);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Restaurent Management Appliction";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpn_tables;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_Admin;
        private System.Windows.Forms.ToolStripMenuItem tsm_account_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lv_bill_detail;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DomainUpDown dud_quantity;
        private System.Windows.Forms.Button btn_add_food_to_table;
        private System.Windows.Forms.ComboBox cbb_food;
        private System.Windows.Forms.ComboBox cbb_category;
        private System.Windows.Forms.Button btn_discount;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.DomainUpDown dud_discount;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_delete_food_from_table;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

