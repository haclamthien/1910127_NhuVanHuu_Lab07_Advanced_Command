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
    public partial class Form1 : Form
    {
        private DataTable foodTable;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
        private void LoadCategory()
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "Select ID, Name from Category";
            sqlCommand.CommandText = query;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sqlConnection.Open();

            sqlDataAdapter.Fill(dt);

            sqlConnection.Close();
            sqlConnection.Dispose();

            cbb_category.DataSource = dt;
            cbb_category.DisplayMember = "Name";
            cbb_category.ValueMember = "ID";
        }

        private void cbb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_category.SelectedIndex == -1) return;

            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "Select * from food where FoodCategoryId = @categoryId";
            sqlCommand.CommandText = query;

            sqlCommand.Parameters.Add("@categoryId", SqlDbType.Int);
            if(cbb_category.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbb_category.SelectedValue as DataRowView;
                sqlCommand.Parameters["@categoryId"].Value = rowView["ID"];
            }
            else
            {
                sqlCommand.Parameters["@categoryId"].Value = cbb_category.SelectedValue;
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            foodTable = dt;
            sqlConnection.Open();
            sqlDataAdapter.Fill(dt);

            sqlConnection.Close();
            sqlConnection.Dispose();

            dgv_foods.DataSource = dt;

            dgv_foods.Columns[0].HeaderText = "Mã số";
            dgv_foods.Columns[1].HeaderText = "Tên món ăn";
            dgv_foods.Columns[2].HeaderText = "Đơn vị";
            dgv_foods.Columns[3].HeaderText = "Mã số nhóm";
            dgv_foods.Columns[4].HeaderText = "Đơn giá";
            dgv_foods.Columns[5].HeaderText = "Mô tả";
            lbl_quantily.Text = dt.Rows.Count.ToString();
            lbl_category_name.Text = cbb_category.Text;
        }

        private void tsm_caculater_quantily_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "Select @numQuantily = sum(Quantily) from BillDetails where FoodID = @foodID";
            sqlCommand.CommandText = query;

            if (dgv_foods.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_foods.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                sqlCommand.Parameters.Add("@foodID", SqlDbType.Int).Value = rowView["ID"];
                sqlCommand.Parameters.Add("@numQuantily", SqlDbType.Int).Direction = ParameterDirection.Output;

                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();

                string result = sqlCommand.Parameters["@numQuantily"].Value.ToString();
                if (result == "") result = "0";
                MessageBox.Show("Tổng số lượng món " + rowView["Name"] + " đã bán là " + result + " " + rowView["Unit"]);
                sqlConnection.Close();

            }
            sqlCommand.Dispose();
            sqlConnection.Dispose();
        }

        private void tsm_add_food_Click(object sender, EventArgs e)
        {
            FoodInfoForm foodInfoForm = new FoodInfoForm();
            foodInfoForm.FormClosed += new FormClosedEventHandler(foodForm_FormClose);
            foodInfoForm.Show(this);
        }
        private void foodForm_FormClose(object sender, FormClosedEventArgs e)
        {
            int index = cbb_category.SelectedIndex;
            cbb_category.SelectedIndex = -1;
            
            LoadCategory();
            cbb_category.SelectedIndex = index;
        }

        private void tsm_update_food_Click(object sender, EventArgs e)
        {
            if (dgv_foods.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_foods.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                FoodInfoForm foodInfoForm = new FoodInfoForm();
                foodInfoForm.FormClosed += new FormClosedEventHandler(foodForm_FormClose);

                foodInfoForm.Show(this);
                foodInfoForm.DisplayFoodInfo(rowView);
            }
        }

        private void txt_search_by_name_TextChanged(object sender, EventArgs e)
        {
            if (foodTable == null) return;
            string filterExpression = "Name like '%" + txt_search_by_name.Text + "%'";
            string sortExpression = "Price DESC";
            DataViewRowState rowState = DataViewRowState.OriginalRows;
            DataView dataView = new DataView(foodTable, filterExpression, sortExpression, rowState);
            dgv_foods.DataSource = dataView;
        }
    }
}
