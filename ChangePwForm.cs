using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_Advanced_Command
{
    public partial class ChangePwForm : Form
    {
        private string _curr_pw;
        private string _curr_acn;
        public ChangePwForm()
        {
            InitializeComponent();
        }
        public ChangePwForm(string acn, string pw)
        {
            this._curr_acn = acn;
            this._curr_pw = pw;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                ChangePWByAccountName(_curr_acn);
            }
        }
        private void ChangePWByAccountName(string accountName)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "Update Account set Password = @newps where AccoutName = @AccountName";

            sqlCommand.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100).Value = accountName;
            sqlCommand.Parameters.Add("@newps", SqlDbType.NVarChar, 200).Value = txt_new_pw_2.Text;


            sqlConnection.Open();
            int num = sqlCommand.ExecuteNonQuery();
            if (num > 0)
            {
                MessageBox.Show("Change Password Successful");
                ReserControl();
            }

        }
        private void ReserControl()
        {
            txt_curr_pw.ResetText();
            txt_new_pw_1.ResetText();
            txt_new_pw_2.ResetText();
        }
        private bool CheckInput()
        {
            bool check = false;
            lbl_1.Text = "";
            lbl_2.Text = "";
            if (txt_curr_pw.Text != _curr_pw)
                lbl_1.Text = "Sai mật khẩu";
            else if (txt_new_pw_1.Text != txt_new_pw_2.Text)
                lbl_2.Text = "Nhập lại mật khẩu";
            else check = true;
            return check;
        }

        private void ChangePwForm_Load(object sender, EventArgs e)
        {
            HindenTxt();
            //rd_show.Checked = true;
        }
        private void HindenTxt()
        {
            txt_curr_pw.PasswordChar = '*';
            txt_new_pw_1.PasswordChar = '*';
            txt_new_pw_2.PasswordChar = '*';
        }

    }
}
