
namespace Lab07_Advanced_Command
{
    partial class BillDetailForm
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
            this.dgv_foods_from_bill = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_foods_from_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_foods_from_bill
            // 
            this.dgv_foods_from_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_foods_from_bill.Location = new System.Drawing.Point(13, 13);
            this.dgv_foods_from_bill.Name = "dgv_foods_from_bill";
            this.dgv_foods_from_bill.RowHeadersWidth = 51;
            this.dgv_foods_from_bill.RowTemplate.Height = 24;
            this.dgv_foods_from_bill.Size = new System.Drawing.Size(815, 425);
            this.dgv_foods_from_bill.TabIndex = 0;
            // 
            // BillDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.dgv_foods_from_bill);
            this.Name = "BillDetailForm";
            this.Text = "BillDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_foods_from_bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_foods_from_bill;
    }
}