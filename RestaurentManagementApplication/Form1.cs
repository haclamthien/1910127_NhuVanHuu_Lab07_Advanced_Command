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
    public partial class Form1 : Form
    {
        private int _current_table_id=-1;
        private string _current_account_name;
        private int _prv_table_id;
        private int _curr_bill_id=-1;
        private string _current_table_name;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            if (loginForm._Admin) tsm_Admin.Enabled = true;
            else tsm_Admin.Enabled = false;
            _current_account_name = loginForm._Current_AccountName;
            this.Text = "Phiên đăng nhập của tài khoản: " + loginForm._Current_AccountName;
            LoadDinningTable();
            InitView();
        }
        private void InitView()
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "select * from Category";
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            cbb_category.DataSource = dt;
            cbb_category.DisplayMember = "Name";
            cbb_category.ValueMember = "ID";
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
        private void LoadDinningTable()
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "select * from DiningTable";
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            fpn_tables.Controls.Clear();
            while (sqlDataReader.Read())
            {
                CreateButtonTable(sqlDataReader["ID"].ToString(),
                    sqlDataReader["Name"].ToString(), sqlDataReader["Status"].ToString(),
                    sqlDataReader["Capacity"].ToString());
            }
            
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
        private void CreateButtonTable(string id, string table_name, string active, string capacity)
        {
            string stt = active == "1" ? "Có Người" : "Trống";
            Button button = new Button();
            button.Size = new Size(100, 50);
            if (stt == "Trống")
                button.BackColor = Color.MediumSeaGreen;
            else
                button.BackColor = Color.DarkOrange;
            button.Text = table_name + " \n [" +capacity + "] \n " + stt;
            button.Tag = id;
            button.Click += Button_Click;
            fpn_tables.Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            lbl_title.Text ="Thêm món ăn cho bàn: "+ (sender as Button).Text;
            if (_current_table_id == -1) _prv_table_id = -1;//int.Parse((sender as Button).Tag.ToString());
            else _prv_table_id = _current_table_id;
            _current_table_id = int.Parse( (sender as Button).Tag.ToString());
            LoadFoodHavedAdd();
            this.Text = _prv_table_id.ToString() + ", " + _current_table_id.ToString() + ", " + _current_table_id + ", " + _curr_bill_id;

            CaculateTotalPayment();
        }

        private void LoadFoodHavedAdd()
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Select f.Name, b.Quantily, f.Price, (b.Quantily * f.Price) as sum, b.ID" +
                    " from Food f, BillDetails b , Bill c" +
                    " where f.ID = b.FoodID and c.ID = b.BillID and c.TableID = @tableID and c.Status = 0";
            sqlCommand.Parameters.Add("@tableID", SqlDbType.Int).Value = _current_table_id;
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            LoadDataForLvFood(reader);
            reader.Close();
            sqlCommand.CommandText = "select b.ID from Bill b where b.TableID = @TableID and b.Status =0";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            try { _curr_bill_id = int.Parse(dt.Rows[0].ItemArray[0].ToString()); } catch (Exception ex) { }
            sqlConnection.Close();
            sqlConnection.Dispose();


        }
        private void LoadDataForLvFood(SqlDataReader reader)
        {
            lv_bill_detail.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["Name"].ToString());
                item.SubItems.Add(reader["Quantily"].ToString());
                item.SubItems.Add(reader["Price"].ToString());
                item.SubItems.Add(reader["sum"].ToString());
                item.SubItems.Add(reader["ID"].ToString());
                lv_bill_detail.Items.Add(item);
            }
            
        }

        private void cbb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                sqlCommand.CommandText = "select * from Food where FoodCategoryID = @foodCategoryID";
                sqlCommand.Parameters.Add("@foodCategoryID", SqlDbType.Int).Value = cbb_category.SelectedValue;
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                cbb_food.DataSource = dt;
                cbb_food.DisplayMember = "Name";
                cbb_food.ValueMember = "ID";
                sqlConnection.Close();
                sqlConnection.Dispose();
            }catch(Exception ex) { }
            
        }

        private void btn_add_food_to_table_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            if (_prv_table_id != _current_table_id)
            {
                sqlCommand.CommandText = "exec Bill_Insert @ID output, N'Hóa đơn thanh toán', @TableID, 0, null, null, 0, null, @AccountName";
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add("@TableID", SqlDbType.Int).Value = _current_table_id;
                sqlCommand.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100).Value = _current_account_name;

                sqlConnection.Open();

                int num=   sqlCommand.ExecuteNonQuery();
                if (num > 0) {
                    _curr_bill_id = int.Parse(sqlCommand.Parameters["@ID"].Value.ToString());
                    _prv_table_id = _current_table_id;
                    LoadDinningTable();
                }
               
            }
            //string str = sqlCommand.Parameters["@ID"].Value.ToString();
            //int billId = int.Parse(sqlCommand.Parameters["@ID"].Value.ToString());
            sqlCommand.CommandText = "exec BillDetails_Insert @IDD output, @BillID, @FoodID, @Quantity";
            sqlCommand.Parameters.Add("@IDD", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add("@BillID", SqlDbType.Int).Value = _curr_bill_id;
            sqlCommand.Parameters.Add("@FoodID", SqlDbType.Int).Value = cbb_food.SelectedValue;
            sqlCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = int.Parse(dud_quantity.Text);
            try { sqlConnection.Open(); } catch (Exception ex) { }
            int num1 = sqlCommand.ExecuteNonQuery();
            if (num1 > 0)
            {
                //int billDetailId = int.Parse(sqlCommand.Parameters["@ID"].Value.ToString());
                sqlCommand.CommandText = "Select f.Name, b.Quantily, f.Price, (b.Quantily * f.Price) as sum, b.ID " +
                    "from Food f, BillDetails b " +
                    "where f.ID = b.FoodID and b.BillID = @billID";
                //sqlCommand.Parameters.Add("@billID", SqlDbType.Int).Value = _curr_bill_id;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                LoadDataForLvFood(reader);
            }
            sqlConnection.Close();
            sqlConnection.Dispose();
            CaculateTotalPayment();
        }

        private void CaculateTotalPayment()
        {
            int sum = 0;
            for(int i =0; i<lv_bill_detail.Items.Count; i++)
            {
                sum += int.Parse( lv_bill_detail.Items[i].SubItems[3].Text);
            }
            txt_total.Text = sum.ToString();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "exec pay @tableID, @BillID, @Amount, @Discount";
            sqlCommand.Parameters.Add("@tableID", SqlDbType.Int).Value = _current_table_id;
            sqlCommand.Parameters.Add("@BillID", SqlDbType.Int).Value = _curr_bill_id;
            sqlCommand.Parameters.Add("@Amount", SqlDbType.Int).Value = int.Parse(txt_total.Text);
            sqlCommand.Parameters.Add("@Discount", SqlDbType.Float).Value = float.Parse(dud_discount.Text);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            lv_bill_detail.Items.Clear();
            LoadDinningTable();
            btn_pay.Enabled = false;
            _curr_bill_id = -1;
            dud_discount.Enabled = true;
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            double prv_sum = Double.Parse(txt_total.Text);
            double discount = double.Parse( dud_discount.Text);
            double final_sum = prv_sum - prv_sum * discount;
            txt_total.Text = final_sum.ToString();
            btn_pay.Enabled = true;
            dud_discount.Enabled = false;
        }

        private void tsm_delete_food_from_table_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "";
            sqlConnection.Open();
            if (lv_bill_detail.CheckedItems.Count > 0)
            {
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
                for (int i =0; i<lv_bill_detail.CheckedItems.Count; i++)
                {
                    sqlCommand.CommandText = "delete BillDetails where ID = @ID";
                    sqlCommand.Parameters["@ID"].Value = int.Parse(
                        lv_bill_detail.CheckedItems[i].SubItems[4].Text);
                    sqlCommand.ExecuteNonQuery();
                    lv_bill_detail.Items.Remove(lv_bill_detail.CheckedItems[i]);
                }
            }
            if (lv_bill_detail.Items.Count == 0)
            {
                sqlCommand.CommandText = "delete Bill where ID = @BillID";
                sqlCommand.Parameters.Add("@BillID", SqlDbType.Int).Value = _curr_bill_id;
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "Update DiningTable Set Status = 0 where ID = @TableID";
                sqlCommand.Parameters.Add("@TableID", SqlDbType.Int).Value = _current_table_id;
                sqlCommand.ExecuteNonQuery();
                LoadDinningTable();
            }
            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        private void tsm_Admin_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
    }
}
