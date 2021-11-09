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
    public partial class BillDetailForm : Form
    {
        public BillDetailForm()
        {
            InitializeComponent();
        }

        public void LoadFoods(int billID)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "exec GetFoodFromBill @BillID";
            sqlCommand.CommandText = query;

            sqlCommand.Parameters.Add("@BillID", SqlDbType.Int).Value = billID;
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dgv_foods_from_bill.DataSource = dt;

            dgv_foods_from_bill.Columns[0].HeaderText = "Mã số";
            dgv_foods_from_bill.Columns[1].HeaderText = "Tên món ăn";
            dgv_foods_from_bill.Columns[2].HeaderText = "Đơn vị";
            dgv_foods_from_bill.Columns[3].HeaderText = "Mô tả";
            dgv_foods_from_bill.Columns[4].HeaderText = "Đơn giá";
            dgv_foods_from_bill.Columns[5].HeaderText = "Số lượng";

            sqlConnection.Close();
            sqlConnection.Dispose();
            this.Text = "Danh Sách món ăn của bill số: " + billID;
        }
    }
}
