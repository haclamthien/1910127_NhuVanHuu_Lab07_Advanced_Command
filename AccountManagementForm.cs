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
using Lab07_Advanced_Command.Model;

namespace Lab07_Advanced_Command
{
    public partial class AccountManagementForm : Form
    {
        private List<Role> _list_roles;
        public AccountManagementForm()
        {
            InitializeComponent();
        }

        private void AccountManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadRoleAccountToCbb();
        }
        private void LoadRoleAccountToCbb()
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "select * from Role";
            sqlCommand.CommandText = query;
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            _list_roles = new List<Role>();
            while (sqlDataReader.Read())
            {
                _list_roles.Add(new Role(sqlDataReader["ID"].ToString(), sqlDataReader["RoleName"].ToString()));
            }
            cbb_Group.DataSource = _list_roles;
            cbb_Group.DisplayMember = "RoleName";
            cbb_Group.ValueMember = "ID";
            cbb_Group.Text = "";
            cbb_role.DataSource = _list_roles;
            cbb_role.DisplayMember = "RoleName";
            cbb_role.ValueMember = "ID";
            cbb_role.Text = "";
        }
        private void LoadData()
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "select a.AccoutName, a.FullName, a.Email, a.Tell, a.DateCreated, r.RoleName, ra.Actived " +
                "from Role r, Account a, RoleAccount ra " +
                "where r.ID=ra.RoleID and ra.AccountName = a.AccoutName";
            sqlCommand.CommandText = query;
            sqlConnection.Open();

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Accounts");
            da.Fill(dt);
            dgv_Accounts.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();

            SetHeaderTextGDV();
        }
        private void SetHeaderTextGDV()
        {
            dgv_Accounts.Columns[0].HeaderText = "Tên tài khoản";
            //dgv_Accounts.Columns[1].HeaderText = "Mật khẩu";
            dgv_Accounts.Columns[1].HeaderText = "Tên đầy đủ";
            dgv_Accounts.Columns[1].Width = 200;
            dgv_Accounts.Columns[2].HeaderText = "Email";
            dgv_Accounts.Columns[3].HeaderText = "Số điện thoại";
            dgv_Accounts.Columns[4].HeaderText = "Ngày tạo tài khoản";
            dgv_Accounts.Columns[5].HeaderText = "Quyền";
            dgv_Accounts.Columns[6].HeaderText = "Trạng thái";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "";

            string status = "";//= cbb_Status.Text == "Actived" ? "1" : "0";
            string role_id = "";// = _list_roles.Find(s => s.RoleName == cbb_Group.Text).ID;

            sqlCommand.Parameters.Add("@status", SqlDbType.Bit).Value =-1;
            sqlCommand.Parameters.Add("@roleid", SqlDbType.Int).Value =-1;
            if (cbb_Group.Text != "" && cbb_Status.Text != "")
            {
                sqlCommand.Parameters["@status"].Value = cbb_Status.Text == "Actived" ? 1 : 0;
                sqlCommand.Parameters["@roleid"].Value = int.Parse( _list_roles.Find(s => s.RoleName == cbb_Group.Text).ID);

                query = "select a.AccoutName, a.FullName, a.Email, a.Tell, a.DateCreated, r.RoleName, ra.Actived " +
                "from Role r, Account a, RoleAccount ra " +
                "where r.ID=ra.RoleID and ra.AccountName = a.AccoutName and " +
                "ra.Actived = @status and r.ID =@roleid";

            }
            else if (cbb_Group.Text == "" && cbb_Status.Text != "")
            {
                sqlCommand.Parameters["@status"].Value = cbb_Status.Text == "Actived" ? 1 : 0;
                query = "select a.AccoutName, a.FullName, a.Email, a.Tell, a.DateCreated, r.RoleName, ra.Actived " +
                "from Role r, Account a, RoleAccount ra " +
                "where r.ID=ra.RoleID and ra.AccountName = a.AccoutName and " +
                "ra.Actived = @status";
            }
            else if (cbb_Group.Text != "" && cbb_Status.Text == "")
            {
                sqlCommand.Parameters["@roleid"].Value = int.Parse(_list_roles.Find(s => s.RoleName == cbb_Group.Text).ID);
                query = "select a.AccoutName, a.FullName, a.Email, a.Tell, a.DateCreated, r.RoleName, ra.Actived " +
                "from Role r, Account a, RoleAccount ra " +
                "where r.ID=ra.RoleID and ra.AccountName = a.AccoutName and " +
                " r.ID =@roleid";
            }
            else
            {
                query = "select a.AccoutName, a.FullName, a.Email, a.Tell, a.DateCreated, r.RoleName, ra.Actived " +
                "from Role r, Account a, RoleAccount ra " +
                "where r.ID=ra.RoleID and ra.AccountName = a.AccoutName";
            }
            sqlCommand.CommandText = query;
            sqlConnection.Open();

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Accounts");
            da.Fill(dt);
            dgv_Accounts.DataSource = dt;

            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
            SetHeaderTextGDV();
        }

        private void dgv_Accounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Accounts.SelectedRows.Count > 0)
            {
                txt_account_name.Text = dgv_Accounts.SelectedRows[0].Cells[0].Value.ToString();
               // txt_password.Text = dgv_Accounts.SelectedRows[0].Cells[1].Value.ToString();
                txt_fullname.Text = dgv_Accounts.SelectedRows[0].Cells[1].Value.ToString();
                txt_email.Text = dgv_Accounts.SelectedRows[0].Cells[2].Value.ToString();
                txt_tell.Text = dgv_Accounts.SelectedRows[0].Cells[3].Value.ToString();
                if (dgv_Accounts.SelectedRows[0].Cells[4].Value.ToString() != "")
                    dtp_create_Date.Value = DateTime.Parse(dgv_Accounts.SelectedRows[0].Cells[4].Value.ToString());
                else dtp_create_Date.Value = DateTime.Now;
                cbb_role.Text = dgv_Accounts.SelectedRows[0].Cells[5].Value.ToString();
                cbb_stt.Text = dgv_Accounts.SelectedRows[0].Cells[6].Value.ToString() == "True" ? "Actived" : "Nonactived";
            }
        }

        private void btn_Clear_click(object sender, EventArgs e)
        {
            ResetControls();
        }
        private void ResetControls()
        {
            txt_account_name.Text = "";
            txt_fullname.Text = "";
            txt_password.Text = "";
            txt_email.Text = "";
            txt_tell.Text = "";
            cbb_role.Text = "";
            cbb_stt.Text = "";
            dtp_create_Date.Value = DateTime.Now;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string role_id = _list_roles.Find(s => s.RoleName == cbb_role.Text).ID;
            string stt = cbb_stt.Text == "Actived" ? "1" : "0";

            sqlCommand.CommandText = "Exec Insert_Account @AccountName, @FullName, @Email, @Tell, @RoleId, @Active";

            sqlCommand.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100).Value = txt_account_name.Text;
            sqlCommand.Parameters.Add("@FullName", SqlDbType.NVarChar, 1000).Value = txt_fullname.Text;
            sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 1000).Value = txt_email.Text;
            sqlCommand.Parameters.Add("@Tell", SqlDbType.NVarChar, 200).Value = txt_tell.Text;

            sqlCommand.Parameters.Add("@Active", SqlDbType.Bit).Value = cbb_stt.Text == "Actived" ? 1 : 0;
            try { sqlCommand.Parameters.Add("@RoleId", SqlDbType.Int).Value = int.Parse(_list_roles.Find(s => s.RoleName == cbb_role.Text).ID); } catch (Exception ex) { }


            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            sqlConnection.Dispose();

            LoadData();
            ResetControls();

        }

        private void tsm_Remove_Click(object sender, EventArgs e)
        {
            if (dgv_Accounts.SelectedRows.Count > 0)
            {
                string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                string roleID = _list_roles.Find(s => s.RoleName == dgv_Accounts.SelectedRows[0].Cells[5].Value.ToString()).ID;

                sqlCommand.CommandText = "Update RoleAccount set Actived = 'false' where AccountName =  @AccountName and RoleID = @RoleId";

                sqlCommand.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100).Value = txt_account_name.Text;
                sqlCommand.Parameters.Add("@RoleId", SqlDbType.Int).Value = int.Parse(roleID);
                sqlConnection.Open();

               
                int num = sqlCommand.ExecuteNonQuery();
                if (num == 1)
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                    LoadData();
                    ResetControls();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản không thành công!");
                }
                sqlConnection.Close();
                sqlConnection.Dispose();
            }

        }

        private void tsm_viewDetail_Click(object sender, EventArgs e)
        {
            RoleAccountForm roleAccountForm = new RoleAccountForm();
            roleAccountForm.Show();
            roleAccountForm.LoadData(txt_account_name.Text);
        }

        private void btn_Change_Pasword_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select Password from Account where AccoutName = @AccountName";
            sqlCommand.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100).Value = txt_account_name.Text;
            sqlConnection.Open();
            string pass = sqlCommand.ExecuteScalar().ToString();
            ChangePwForm changePwForm = new ChangePwForm(txt_account_name.Text, pass);

            if(changePwForm.ShowDialog()== DialogResult.OK)
            {
                button1.PerformClick();
            }

        }

        private void tsm_view_catalogs_Click(object sender, EventArgs e)
        {
            if (dgv_Accounts.SelectedRows.Count > 0)
            {
                AccountCatelogs accountCatelogs = new AccountCatelogs();
                accountCatelogs.Show();
                accountCatelogs.LoadDataByAccountName(dgv_Accounts.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
