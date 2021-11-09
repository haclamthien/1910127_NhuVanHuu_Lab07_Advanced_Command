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
    public partial class RoleAccountForm : Form
    {
        public RoleAccountForm()
        {
            InitializeComponent();
        }
        public void LoadData(string AccountName)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "select ra.RoleID, r.RoleName, ra.AccountName, ra.Actived, ra.Notes, r.Path" +
                " from RoleAccount ra, Role r where ra.AccountName = @AccountName and r.ID = ra.RoleID";
            sqlCommand.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100).Value = AccountName;
            sqlConnection.Open();

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("RoleAccounts");
            da.Fill(dt);
            dgv_RoleAccounts.DataSource = dt;
            this.Text = "Danh sách vai trò của tài khoản: " + AccountName;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();

            dgv_RoleAccounts.Columns[0].HeaderText = "Mã Quyền";
            dgv_RoleAccounts.Columns[1].HeaderText = "Tên Quyền";
            dgv_RoleAccounts.Columns[2].HeaderText = "Tên tài khoản";
            dgv_RoleAccounts.Columns[3].HeaderText = "Trạng thái";
            dgv_RoleAccounts.Columns[4].HeaderText = "Mô tả";
            dgv_RoleAccounts.Columns[5].HeaderText = "Đường dẫn";
        }
    }
}
