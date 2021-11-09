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
    public partial class AccountCatelogs : Form
    {
        private string _curr_account_Name;
        private List<string> _list_date;
        public AccountCatelogs()
        {
            InitializeComponent();
        }
        public void LoadDataByAccountName(string accountName)
        {
            _curr_account_Name = accountName;
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "exec GetCheckOutDayByAccount @AccountName";
            sqlCommand.CommandText = query;

            sqlCommand.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100).Value = _curr_account_Name;

            sqlConnection.Open();
            _list_date = new List<string>();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                _list_date.Add(sqlDataReader["CheckoutDate"].ToString());
            }
            sqlDataReader.Close();
            sqlCommand.CommandText = "exec GetSumSalaryVyDate @Date";
            sqlCommand.Parameters.Add("@Date", SqlDbType.SmallDateTime).Value = _list_date[0];
            lbl_amount.Text = sqlCommand.ExecuteScalar().ToString();

            sqlConnection.Close();
            sqlConnection.Dispose();
            lb_check_out_days.DataSource = _list_date;
            this.Text = "Nhật kí hoạt động của tài khoản: " + _curr_account_Name;
            lbl_count.Text = dgv_bills.Rows.Count.ToString();
            //lb_check_out_days.ValueMember = "CheckOutDay";
        }

        private void lb_check_out_days_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_check_out_days.SelectedItems.Count > 0)
            {
                string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                string query = "exec ShowBillByAccount @AccountName, @Date";
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100).Value = _curr_account_Name;
                sqlCommand.Parameters.Add("@Date", SqlDbType.SmallDateTime).Value =DateTime.Parse(lb_check_out_days.SelectedItems[0].ToString());
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                dgv_bills.DataSource = dt;
                dgv_bills.RowHeadersVisible = false;
                dgv_bills.AllowUserToAddRows = false;

                dgv_bills.Columns[0].HeaderText = "Mã hóa đơn";
                dgv_bills.Columns[1].HeaderText = "Tên hóa đơn";
                dgv_bills.Columns[2].HeaderText = "Mã số bàn";
                dgv_bills.Columns[3].HeaderText = "Trị giá";
                dgv_bills.Columns[4].HeaderText = "Giảm giá %";
                dgv_bills.Columns[5].HeaderText = "Thuế";
                dgv_bills.Columns[6].HeaderText = "Đã thanh toán";

                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }

        private void dgv_bills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_bills.SelectedRows.Count > 0)
            {
                string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                string query = "exec ShowBillDetailByBillID @BillID, @Date";
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.Add("@BillID", SqlDbType.Int).Value = int.Parse(dgv_bills.SelectedRows[0].Cells[0].Value.ToString());
                sqlCommand.Parameters.Add("@Date", SqlDbType.SmallDateTime).Value = DateTime.Parse(lb_check_out_days.SelectedItems[0].ToString());
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                dgv_bill_detail.DataSource = dt;
                dgv_bill_detail.RowHeadersVisible = false;
                dgv_bill_detail.AllowUserToAddRows = false;

                dgv_bill_detail.Columns[0].HeaderText = "Tên món ăn";
                dgv_bill_detail.Columns[1].HeaderText = "Đơn vị";
                dgv_bill_detail.Columns[2].HeaderText = "Số lượng";
                dgv_bill_detail.Columns[3].HeaderText = "Đơn giá";
                dgv_bill_detail.Columns[4].HeaderText = "Mô tả";

                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }
    }
}
