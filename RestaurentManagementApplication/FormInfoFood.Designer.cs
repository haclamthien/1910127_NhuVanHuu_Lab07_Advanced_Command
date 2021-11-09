
namespace RestaurentManagementApplication
{
    partial class FormInfoFood
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
            this.btn_add_new_category = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add_food = new System.Windows.Forms.Button();
            this.dud_prices = new System.Windows.Forms.DomainUpDown();
            this.cbb_category_naem = new System.Windows.Forms.ComboBox();
            this.txt_notes_food = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_unit_food = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name_food = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_food_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add_new_category
            // 
            this.btn_add_new_category.Location = new System.Drawing.Point(500, 95);
            this.btn_add_new_category.Name = "btn_add_new_category";
            this.btn_add_new_category.Size = new System.Drawing.Size(156, 23);
            this.btn_add_new_category.TabIndex = 21;
            this.btn_add_new_category.Text = "Add New";
            this.btn_add_new_category.UseVisualStyleBackColor = true;
            this.btn_add_new_category.Click += new System.EventHandler(this.btn_add_new_category_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(581, 197);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_Cancel.TabIndex = 18;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(382, 197);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 30);
            this.btn_Update.TabIndex = 19;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add_food
            // 
            this.btn_Add_food.Location = new System.Drawing.Point(175, 197);
            this.btn_Add_food.Name = "btn_Add_food";
            this.btn_Add_food.Size = new System.Drawing.Size(75, 30);
            this.btn_Add_food.TabIndex = 20;
            this.btn_Add_food.Text = "Add";
            this.btn_Add_food.UseVisualStyleBackColor = true;
            this.btn_Add_food.Click += new System.EventHandler(this.btn_Add_food_Click);
            // 
            // dud_prices
            // 
            this.dud_prices.Items.Add("500000");
            this.dud_prices.Items.Add("400000");
            this.dud_prices.Items.Add("300000");
            this.dud_prices.Items.Add("200000");
            this.dud_prices.Items.Add("100000");
            this.dud_prices.Items.Add("90000");
            this.dud_prices.Items.Add("80000");
            this.dud_prices.Items.Add("70000");
            this.dud_prices.Items.Add("60000");
            this.dud_prices.Items.Add("50000");
            this.dud_prices.Items.Add("40000");
            this.dud_prices.Items.Add("30000");
            this.dud_prices.Items.Add("20000");
            this.dud_prices.Items.Add("10000");
            this.dud_prices.Location = new System.Drawing.Point(175, 124);
            this.dud_prices.Name = "dud_prices";
            this.dud_prices.Size = new System.Drawing.Size(481, 22);
            this.dud_prices.TabIndex = 17;
            this.dud_prices.Text = "0";
            // 
            // cbb_category_naem
            // 
            this.cbb_category_naem.FormattingEnabled = true;
            this.cbb_category_naem.Location = new System.Drawing.Point(175, 96);
            this.cbb_category_naem.Name = "cbb_category_naem";
            this.cbb_category_naem.Size = new System.Drawing.Size(322, 24);
            this.cbb_category_naem.TabIndex = 16;
            // 
            // txt_notes_food
            // 
            this.txt_notes_food.Location = new System.Drawing.Point(175, 152);
            this.txt_notes_food.Name = "txt_notes_food";
            this.txt_notes_food.Size = new System.Drawing.Size(481, 22);
            this.txt_notes_food.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Notes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category Name";
            // 
            // txt_unit_food
            // 
            this.txt_unit_food.Location = new System.Drawing.Point(175, 68);
            this.txt_unit_food.Name = "txt_unit_food";
            this.txt_unit_food.Size = new System.Drawing.Size(481, 22);
            this.txt_unit_food.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Unit";
            // 
            // txt_name_food
            // 
            this.txt_name_food.Location = new System.Drawing.Point(175, 40);
            this.txt_name_food.Name = "txt_name_food";
            this.txt_name_food.Size = new System.Drawing.Size(481, 22);
            this.txt_name_food.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // txt_food_id
            // 
            this.txt_food_id.Location = new System.Drawing.Point(175, 12);
            this.txt_food_id.Name = "txt_food_id";
            this.txt_food_id.ReadOnly = true;
            this.txt_food_id.Size = new System.Drawing.Size(481, 22);
            this.txt_food_id.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "FoodID";
            // 
            // FormInfoFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 249);
            this.Controls.Add(this.btn_add_new_category);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add_food);
            this.Controls.Add(this.dud_prices);
            this.Controls.Add(this.cbb_category_naem);
            this.Controls.Add(this.txt_notes_food);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_unit_food);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name_food);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_food_id);
            this.Controls.Add(this.label1);
            this.Name = "FormInfoFood";
            this.Text = "FormInfoFood";
            this.Load += new System.EventHandler(this.FormInfoFood_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_new_category;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add_food;
        private System.Windows.Forms.DomainUpDown dud_prices;
        private System.Windows.Forms.ComboBox cbb_category_naem;
        private System.Windows.Forms.TextBox txt_notes_food;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_unit_food;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name_food;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_food_id;
        private System.Windows.Forms.Label label1;
    }
}