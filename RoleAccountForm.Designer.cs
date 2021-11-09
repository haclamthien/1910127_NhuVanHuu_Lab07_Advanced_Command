
namespace Lab07_Advanced_Command
{
    partial class RoleAccountForm
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
            this.dgv_RoleAccounts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RoleAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_RoleAccounts
            // 
            this.dgv_RoleAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_RoleAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RoleAccounts.Location = new System.Drawing.Point(13, 13);
            this.dgv_RoleAccounts.Name = "dgv_RoleAccounts";
            this.dgv_RoleAccounts.RowHeadersWidth = 51;
            this.dgv_RoleAccounts.RowTemplate.Height = 24;
            this.dgv_RoleAccounts.Size = new System.Drawing.Size(862, 425);
            this.dgv_RoleAccounts.TabIndex = 0;
            // 
            // RoleAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.dgv_RoleAccounts);
            this.Name = "RoleAccountForm";
            this.Text = "RoleAccountForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RoleAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_RoleAccounts;
    }
}