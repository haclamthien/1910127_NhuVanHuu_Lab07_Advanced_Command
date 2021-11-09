
namespace Lab07_Advanced_Command
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
            this.dgv_foods = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_caculater_quantily = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_add_food = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_update_food = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_quantily = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_category_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_search_by_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_foods)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_foods
            // 
            this.dgv_foods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_foods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_foods.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_foods.Location = new System.Drawing.Point(13, 58);
            this.dgv_foods.MultiSelect = false;
            this.dgv_foods.Name = "dgv_foods";
            this.dgv_foods.RowHeadersWidth = 51;
            this.dgv_foods.RowTemplate.Height = 24;
            this.dgv_foods.Size = new System.Drawing.Size(846, 412);
            this.dgv_foods.TabIndex = 0;
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 82);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn nhóm món ăn";
            // 
            // cbb_category
            // 
            this.cbb_category.FormattingEnabled = true;
            this.cbb_category.Location = new System.Drawing.Point(166, 12);
            this.cbb_category.Name = "cbb_category";
            this.cbb_category.Size = new System.Drawing.Size(244, 24);
            this.cbb_category.TabIndex = 2;
            this.cbb_category.SelectedIndexChanged += new System.EventHandler(this.cbb_category_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Có tất cả";
            // 
            // lbl_quantily
            // 
            this.lbl_quantily.AutoSize = true;
            this.lbl_quantily.Location = new System.Drawing.Point(83, 486);
            this.lbl_quantily.Name = "lbl_quantily";
            this.lbl_quantily.Size = new System.Drawing.Size(20, 17);
            this.lbl_quantily.TabIndex = 3;
            this.lbl_quantily.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "món ăn thuộc nhóm";
            // 
            // lbl_category_name
            // 
            this.lbl_category_name.AutoSize = true;
            this.lbl_category_name.Location = new System.Drawing.Point(248, 486);
            this.lbl_category_name.Name = "lbl_category_name";
            this.lbl_category_name.Size = new System.Drawing.Size(20, 17);
            this.lbl_category_name.TabIndex = 3;
            this.lbl_category_name.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tìm kiếm theo tên";
            // 
            // txt_search_by_name
            // 
            this.txt_search_by_name.Location = new System.Drawing.Point(578, 12);
            this.txt_search_by_name.Name = "txt_search_by_name";
            this.txt_search_by_name.Size = new System.Drawing.Size(281, 22);
            this.txt_search_by_name.TabIndex = 4;
            this.txt_search_by_name.TextChanged += new System.EventHandler(this.txt_search_by_name_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 515);
            this.Controls.Add(this.txt_search_by_name);
            this.Controls.Add(this.lbl_category_name);
            this.Controls.Add(this.lbl_quantily);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_category);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_foods);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_foods)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_foods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_quantily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_category_name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_caculater_quantily;
        private System.Windows.Forms.ToolStripMenuItem tsm_add_food;
        private System.Windows.Forms.ToolStripMenuItem tsm_update_food;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_search_by_name;
    }
}

