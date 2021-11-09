
namespace Lab07_Advanced_Command
{
    partial class AccountManagementForm
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
            this.dgv_Accounts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_viewDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_create_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_tell = new System.Windows.Forms.TextBox();
            this.cbb_stt = new System.Windows.Forms.ComboBox();
            this.cbb_role = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_account_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_Status = new System.Windows.Forms.ComboBox();
            this.cbb_Group = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Change_pasword = new System.Windows.Forms.Button();
            this.tsm_view_catalogs = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Accounts
            // 
            this.dgv_Accounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Accounts.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Accounts.Location = new System.Drawing.Point(16, 228);
            this.dgv_Accounts.Name = "dgv_Accounts";
            this.dgv_Accounts.RowHeadersWidth = 51;
            this.dgv_Accounts.RowTemplate.Height = 24;
            this.dgv_Accounts.Size = new System.Drawing.Size(1137, 442);
            this.dgv_Accounts.TabIndex = 0;
            this.dgv_Accounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Accounts_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Remove,
            this.tsm_viewDetail,
            this.tsm_view_catalogs});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(242, 76);
            // 
            // tsm_Remove
            // 
            this.tsm_Remove.Name = "tsm_Remove";
            this.tsm_Remove.Size = new System.Drawing.Size(241, 24);
            this.tsm_Remove.Text = "Xóa Tài Khoản";
            this.tsm_Remove.Click += new System.EventHandler(this.tsm_Remove_Click);
            // 
            // tsm_viewDetail
            // 
            this.tsm_viewDetail.Name = "tsm_viewDetail";
            this.tsm_viewDetail.Size = new System.Drawing.Size(241, 24);
            this.tsm_viewDetail.Text = "Xem Danh Sách Vai Trò";
            this.tsm_viewDetail.Click += new System.EventHandler(this.tsm_viewDetail_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1019, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lấy Danh Sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_create_Date);
            this.groupBox1.Controls.Add(this.txt_fullname);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.txt_tell);
            this.groupBox1.Controls.Add(this.cbb_stt);
            this.groupBox1.Controls.Add(this.cbb_role);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_account_name);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // dtp_create_Date
            // 
            this.dtp_create_Date.Enabled = false;
            this.dtp_create_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_create_Date.Location = new System.Drawing.Point(457, 95);
            this.dtp_create_Date.Name = "dtp_create_Date";
            this.dtp_create_Date.Size = new System.Drawing.Size(164, 22);
            this.dtp_create_Date.TabIndex = 2;
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(115, 96);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(164, 22);
            this.txt_fullname.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(115, 58);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.ReadOnly = true;
            this.txt_password.Size = new System.Drawing.Size(164, 22);
            this.txt_password.TabIndex = 1;
            // 
            // txt_tell
            // 
            this.txt_tell.Location = new System.Drawing.Point(457, 58);
            this.txt_tell.Name = "txt_tell";
            this.txt_tell.Size = new System.Drawing.Size(164, 22);
            this.txt_tell.TabIndex = 1;
            // 
            // cbb_stt
            // 
            this.cbb_stt.FormattingEnabled = true;
            this.cbb_stt.Items.AddRange(new object[] {
            "Actived",
            "Nonactived"});
            this.cbb_stt.Location = new System.Drawing.Point(749, 58);
            this.cbb_stt.Name = "cbb_stt";
            this.cbb_stt.Size = new System.Drawing.Size(166, 24);
            this.cbb_stt.TabIndex = 2;
            // 
            // cbb_role
            // 
            this.cbb_role.FormattingEnabled = true;
            this.cbb_role.Location = new System.Drawing.Point(749, 19);
            this.cbb_role.Name = "cbb_role";
            this.cbb_role.Size = new System.Drawing.Size(166, 24);
            this.cbb_role.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(457, 21);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(164, 22);
            this.txt_email.TabIndex = 1;
            // 
            // txt_account_name
            // 
            this.txt_account_name.Location = new System.Drawing.Point(115, 21);
            this.txt_account_name.Name = "txt_account_name";
            this.txt_account_name.Size = new System.Drawing.Size(164, 22);
            this.txt_account_name.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày Tạo Tài Khoản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điện Thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(662, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Trạng Thái";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(662, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quyền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ Và Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Tài Khoản";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(1019, 52);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(153, 30);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Xóa Trắng";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(1019, 88);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(153, 30);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_Status);
            this.groupBox2.Controls.Add(this.cbb_Group);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(971, 76);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc";
            // 
            // cbb_Status
            // 
            this.cbb_Status.FormattingEnabled = true;
            this.cbb_Status.Items.AddRange(new object[] {
            "Actived",
            "Nonactived"});
            this.cbb_Status.Location = new System.Drawing.Point(473, 33);
            this.cbb_Status.Name = "cbb_Status";
            this.cbb_Status.Size = new System.Drawing.Size(251, 24);
            this.cbb_Status.TabIndex = 8;
            // 
            // cbb_Group
            // 
            this.cbb_Group.FormattingEnabled = true;
            this.cbb_Group.Location = new System.Drawing.Point(84, 33);
            this.cbb_Group.Name = "cbb_Group";
            this.cbb_Group.Size = new System.Drawing.Size(251, 24);
            this.cbb_Group.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhóm";
            // 
            // btn_Change_pasword
            // 
            this.btn_Change_pasword.Location = new System.Drawing.Point(1019, 124);
            this.btn_Change_pasword.Name = "btn_Change_pasword";
            this.btn_Change_pasword.Size = new System.Drawing.Size(153, 30);
            this.btn_Change_pasword.TabIndex = 3;
            this.btn_Change_pasword.Text = "Đổi mật khẩu";
            this.btn_Change_pasword.UseVisualStyleBackColor = true;
            this.btn_Change_pasword.Click += new System.EventHandler(this.btn_Change_Pasword_Click);
            // 
            // tsm_view_catalogs
            // 
            this.tsm_view_catalogs.Name = "tsm_view_catalogs";
            this.tsm_view_catalogs.Size = new System.Drawing.Size(241, 24);
            this.tsm_view_catalogs.Text = "Xem Nhật Ký Hoạt Động";
            this.tsm_view_catalogs.Click += new System.EventHandler(this.tsm_view_catalogs_Click);
            // 
            // AccountManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 674);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Change_pasword);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_Accounts);
            this.Name = "AccountManagementForm";
            this.Text = "AccountManagementForm";
            this.Load += new System.EventHandler(this.AccountManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Accounts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_create_Date;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_tell;
        private System.Windows.Forms.ComboBox cbb_stt;
        private System.Windows.Forms.ComboBox cbb_role;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_account_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_Remove;
        private System.Windows.Forms.ToolStripMenuItem tsm_viewDetail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_Status;
        private System.Windows.Forms.ComboBox cbb_Group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Change_pasword;
        private System.Windows.Forms.ToolStripMenuItem tsm_view_catalogs;
    }
}