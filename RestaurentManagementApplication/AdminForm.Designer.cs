
namespace RestaurentManagementApplication
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_search_by_name = new System.Windows.Forms.TextBox();
            this.lbl_category_name = new System.Windows.Forms.Label();
            this.lbl_quantily = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_foods = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_caculater_quantily = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_add_food = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_update_food = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_foods)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 530);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_search_by_name);
            this.tabPage1.Controls.Add(this.lbl_category_name);
            this.tabPage1.Controls.Add(this.lbl_quantily);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbb_category);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgv_foods);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(888, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý thức ăn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_search_by_name
            // 
            this.txt_search_by_name.Location = new System.Drawing.Point(611, 6);
            this.txt_search_by_name.Name = "txt_search_by_name";
            this.txt_search_by_name.Size = new System.Drawing.Size(244, 24);
            this.txt_search_by_name.TabIndex = 13;
            this.txt_search_by_name.TextChanged += new System.EventHandler(this.txt_search_by_name_TextChanged);
            // 
            // lbl_category_name
            // 
            this.lbl_category_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_category_name.AutoSize = true;
            this.lbl_category_name.Location = new System.Drawing.Point(305, 469);
            this.lbl_category_name.Name = "lbl_category_name";
            this.lbl_category_name.Size = new System.Drawing.Size(20, 18);
            this.lbl_category_name.TabIndex = 9;
            this.lbl_category_name.Text = "...";
            // 
            // lbl_quantily
            // 
            this.lbl_quantily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_quantily.AutoSize = true;
            this.lbl_quantily.Location = new System.Drawing.Point(93, 469);
            this.lbl_quantily.Name = "lbl_quantily";
            this.lbl_quantily.Size = new System.Drawing.Size(20, 18);
            this.lbl_quantily.TabIndex = 10;
            this.lbl_quantily.Text = "...";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "món ăn thuộc nhóm";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Có tất cả";
            // 
            // cbb_category
            // 
            this.cbb_category.FormattingEnabled = true;
            this.cbb_category.Location = new System.Drawing.Point(164, 6);
            this.cbb_category.Name = "cbb_category";
            this.cbb_category.Size = new System.Drawing.Size(244, 26);
            this.cbb_category.TabIndex = 8;
            this.cbb_category.SelectedIndexChanged += new System.EventHandler(this.cbb_category_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tìm kiếm theo tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn nhóm món ăn";
            // 
            // dgv_foods
            // 
            this.dgv_foods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_foods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_foods.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_foods.Location = new System.Drawing.Point(9, 52);
            this.dgv_foods.MultiSelect = false;
            this.dgv_foods.Name = "dgv_foods";
            this.dgv_foods.ReadOnly = true;
            this.dgv_foods.RowHeadersWidth = 51;
            this.dgv_foods.RowTemplate.Height = 24;
            this.dgv_foods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_foods.Size = new System.Drawing.Size(866, 414);
            this.dgv_foods.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_caculater_quantily,
            this.toolStripSeparator1,
            this.tsm_add_food,
            this.tsm_update_food});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 110);
            // 
            // tsm_caculater_quantily
            // 
            this.tsm_caculater_quantily.Name = "tsm_caculater_quantily";
            this.tsm_caculater_quantily.Size = new System.Drawing.Size(218, 24);
            this.tsm_caculater_quantily.Text = "Tính số lượng đã bán";
            this.tsm_caculater_quantily.Click += new System.EventHandler(this.tsm_caculater_quantily_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // tsm_add_food
            // 
            this.tsm_add_food.Name = "tsm_add_food";
            this.tsm_add_food.Size = new System.Drawing.Size(218, 24);
            this.tsm_add_food.Text = "Thêm món ăn";
            this.tsm_add_food.Click += new System.EventHandler(this.tsm_add_food_Click);
            // 
            // tsm_update_food
            // 
            this.tsm_update_food.Name = "tsm_update_food";
            this.tsm_update_food.Size = new System.Drawing.Size(218, 24);
            this.tsm_update_food.Text = "Cập nhật món ăn";
            this.tsm_update_food.Click += new System.EventHandler(this.tsm_update_food_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý bàn ăn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(888, 499);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản lý hóa đơn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(888, 499);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Quản lý tài khoản";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 530);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Text = "Giao diện quản lý";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_foods)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txt_search_by_name;
        private System.Windows.Forms.Label lbl_category_name;
        private System.Windows.Forms.Label lbl_quantily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_foods;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_caculater_quantily;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsm_add_food;
        private System.Windows.Forms.ToolStripMenuItem tsm_update_food;
    }
}