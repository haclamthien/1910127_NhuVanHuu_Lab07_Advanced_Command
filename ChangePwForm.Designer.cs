
namespace Lab07_Advanced_Command
{
    partial class ChangePwForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_curr_pw = new System.Windows.Forms.TextBox();
            this.txt_new_pw_1 = new System.Windows.Forms.TextBox();
            this.txt_new_pw_2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // txt_curr_pw
            // 
            this.txt_curr_pw.Location = new System.Drawing.Point(192, 13);
            this.txt_curr_pw.Name = "txt_curr_pw";
            this.txt_curr_pw.Size = new System.Drawing.Size(193, 22);
            this.txt_curr_pw.TabIndex = 1;
            // 
            // txt_new_pw_1
            // 
            this.txt_new_pw_1.Location = new System.Drawing.Point(192, 62);
            this.txt_new_pw_1.Name = "txt_new_pw_1";
            this.txt_new_pw_1.Size = new System.Drawing.Size(193, 22);
            this.txt_new_pw_1.TabIndex = 1;
            // 
            // txt_new_pw_2
            // 
            this.txt_new_pw_2.Location = new System.Drawing.Point(192, 90);
            this.txt_new_pw_2.Name = "txt_new_pw_2";
            this.txt_new_pw_2.Size = new System.Drawing.Size(193, 22);
            this.txt_new_pw_2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.ForeColor = System.Drawing.Color.Red;
            this.lbl_1.Location = new System.Drawing.Point(192, 39);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(0, 17);
            this.lbl_1.TabIndex = 5;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.ForeColor = System.Drawing.Color.Red;
            this.lbl_2.Location = new System.Drawing.Point(192, 115);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(0, 17);
            this.lbl_2.TabIndex = 5;
            // 
            // ChangePwForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 260);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_new_pw_2);
            this.Controls.Add(this.txt_new_pw_1);
            this.Controls.Add(this.txt_curr_pw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePwForm";
            this.Text = "ChangePwForm";
            this.Load += new System.EventHandler(this.ChangePwForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_curr_pw;
        private System.Windows.Forms.TextBox txt_new_pw_1;
        private System.Windows.Forms.TextBox txt_new_pw_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
    }
}