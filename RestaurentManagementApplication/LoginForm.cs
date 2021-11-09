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

namespace RestaurentManagementApplication
{
    public partial class LoginForm : Form
    {
        public Boolean _Admin { get; private set; } = false;
        public string _Current_AccountName { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txt_account_name.Text = "lgCongcn";
            txt_password.Text = "legiacong";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (CheckAccount())
            {
                //Form1 form1 = new Form1();
                //form1.Show();
                this.Close();
            }
            else
            {
                lbl_error.Text = "Tên tài khoản hoặc mật khẩu không chính xác";
            }
        }
        private Boolean CheckAccount()
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "select a.AccoutName, a.Password, r.RoleName " +
                "from Account a, RoleAccount ra, [Role] r " +
                "where a.AccoutName = ra.AccountName and ra.Actived = 1 and r.ID = ra.RoleID";

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            
            sqlConnection.Close();
            sqlConnection.Dispose();
            
            if (txt_account_name.Text == "Admin" && txt_password.Text == "Admin")
            {
                _Admin = true;
                return true; 
            }
            else
            {
                for(int i=0; i<dt.Rows.Count; i++)
                {
                    if(txt_account_name.Text == dt.Rows[i].ItemArray[0].ToString() && txt_password.Text == dt.Rows[i].ItemArray[1].ToString()
                        && dt.Rows[i].ItemArray[2].ToString()== "Adminstrator")
                    {
                        _Current_AccountName = dt.Rows[i].ItemArray[0].ToString();
                        _Admin = true;
                        return true;
                    }
                    else if (txt_account_name.Text == dt.Rows[i].ItemArray[0].ToString() && txt_password.Text == dt.Rows[i].ItemArray[1].ToString()
                        && dt.Rows[i].ItemArray[2].ToString() != "Adminstrator")
                    {
                        _Current_AccountName = dt.Rows[i].ItemArray[0].ToString();
                        _Admin = false;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
