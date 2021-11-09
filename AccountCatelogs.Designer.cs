
namespace Lab07_Advanced_Command
{
    partial class AccountCatelogs
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
            this.lb_check_out_days = new System.Windows.Forms.ListBox();
            this.dgv_bills = new System.Windows.Forms.DataGridView();
            this.dgv_bill_detail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_check_out_days
            // 
            this.lb_check_out_days.FormattingEnabled = true;
            this.lb_check_out_days.ItemHeight = 16;
            this.lb_check_out_days.Location = new System.Drawing.Point(13, 13);
            this.lb_check_out_days.Name = "lb_check_out_days";
            this.lb_check_out_days.Size = new System.Drawing.Size(180, 420);
            this.lb_check_out_days.TabIndex = 0;
            this.lb_check_out_days.SelectedIndexChanged += new System.EventHandler(this.lb_check_out_days_SelectedIndexChanged);
            // 
            // dgv_bills
            // 
            this.dgv_bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bills.Location = new System.Drawing.Point(200, 13);
            this.dgv_bills.Name = "dgv_bills";
            this.dgv_bills.ReadOnly = true;
            this.dgv_bills.RowHeadersWidth = 51;
            this.dgv_bills.RowTemplate.Height = 24;
            this.dgv_bills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bills.Size = new System.Drawing.Size(634, 420);
            this.dgv_bills.TabIndex = 1;
            this.dgv_bills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bills_CellClick);
            // 
            // dgv_bill_detail
            // 
            this.dgv_bill_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bill_detail.Location = new System.Drawing.Point(840, 12);
            this.dgv_bill_detail.Name = "dgv_bill_detail";
            this.dgv_bill_detail.ReadOnly = true;
            this.dgv_bill_detail.RowHeadersWidth = 51;
            this.dgv_bill_detail.RowTemplate.Height = 24;
            this.dgv_bill_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bill_detail.Size = new System.Drawing.Size(641, 420);
            this.dgv_bill_detail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng số hóa đơn: ";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(331, 440);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(20, 17);
            this.lbl_count.TabIndex = 3;
            this.lbl_count.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng thành tiền";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(503, 440);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(20, 17);
            this.lbl_amount.TabIndex = 3;
            this.lbl_amount.Text = "...";
            // 
            // AccountCatelogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 459);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_bill_detail);
            this.Controls.Add(this.dgv_bills);
            this.Controls.Add(this.lb_check_out_days);
            this.Name = "AccountCatelogs";
            this.Text = "AccountCatelogs";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_check_out_days;
        private System.Windows.Forms.DataGridView dgv_bills;
        private System.Windows.Forms.DataGridView dgv_bill_detail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_amount;
    }
}