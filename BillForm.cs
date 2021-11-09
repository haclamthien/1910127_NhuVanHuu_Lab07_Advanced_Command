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
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "exec GetBillByDate @Date";
            sqlCommand.CommandText = query;

            sqlCommand.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_date.Value.Date;
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dgv_bills.DataSource = dt;

            dgv_bills.Columns[0].HeaderText = "Mã hóa đơn";
            dgv_bills.Columns[1].HeaderText = "Tên hóa đơn";
            dgv_bills.Columns[2].HeaderText = "Mã bàn";
            dgv_bills.Columns[3].HeaderText = "Trị giá hóa đơn";
            dgv_bills.Columns[4].HeaderText = "Giảm giá %";
            dgv_bills.Columns[5].HeaderText = "Thuế";
            dgv_bills.Columns[6].HeaderText = "Đã thanh toán";
            dgv_bills.Columns[7].HeaderText = "Ngày thanh toán";
            dgv_bills.Columns[8].HeaderText = "Tên tài khoản";

            if (dt.Rows.Count > 0)
            {
                sqlCommand.CommandText = "exec GetSumSalaryVyDate @Date";
                lbl_sum.Text = sqlCommand.ExecuteScalar().ToString();
            }

            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        private void dgv_bills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_bills.SelectedRows.Count > 0)
            {
                BillDetailForm billDetail = new BillDetailForm();
                billDetail.Show();
                billDetail.LoadFoods(int.Parse( dgv_bills.SelectedRows[0].Cells[0].Value.ToString()));
            }
        }
    }
}
