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
    public partial class FoodInfoForm : Form
    {
        public FoodInfoForm()
        {
            InitializeComponent();
        }

        private void FoodInfoForm_Load(object sender, EventArgs e)
        {
            InnitValues();
        }

        private void InnitValues()
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "Select  * from Category";
            sqlCommand.CommandText = query;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();

            sqlConnection.Open();

            sqlDataAdapter.Fill(ds, "Category");

            cbb_category_naem.DataSource = ds.Tables["Category"];
            cbb_category_naem.DisplayMember = "Name";
            cbb_category_naem.ValueMember = "ID";

            sqlConnection.Close();
            sqlConnection.Dispose();
        }
        private void ResetControl()
        {
            txt_food_id.Text = "";
            txt_name_food.Text = "";
            txt_notes_food.Text = "";
            txt_unit_food.Text = "";
            dud_prices.ResetText();
            cbb_category_naem.ResetText();
        }

        private void btn_Add_food_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "execute Food_Insert @ID output, @Name, @Unit,@FoodCategoryID, @Price, @Notes";
            sqlCommand.CommandText = query;

            sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 1000);
            sqlCommand.Parameters.Add("@Unit", SqlDbType.NChar, 100);
            sqlCommand.Parameters.Add("@FoodCategoryID", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Price", SqlDbType.Int);
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000);

            sqlCommand.Parameters["@ID"].Direction = ParameterDirection.Output;

            sqlCommand.Parameters["@Name"].Value = txt_name_food.Text;
            sqlCommand.Parameters["@Unit"].Value = txt_unit_food.Text;
            sqlCommand.Parameters["@FoodCategoryID"].Value = cbb_category_naem.SelectedValue;
            sqlCommand.Parameters["@Price"].Value = int.Parse(dud_prices.Text);
            sqlCommand.Parameters["@Notes"].Value = txt_notes_food.Text;

            //this.Text = (int.Parse(dud_prices.Text) + 4000).ToString();
            sqlConnection.Open();

            int num = 
                sqlCommand.ExecuteNonQuery();
            if (num > 0)
            {
                string foodID = sqlCommand.Parameters["@ID"].Value.ToString();
                MessageBox.Show("Successfully adding new food, food ID = " + foodID, "Message");
                this.ResetControl();
            }
            else
            {
                MessageBox.Show("Adding food failed");
            }
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
        public void DisplayFoodInfo(DataRowView rowView)
        {
            try
            {
                txt_food_id.Text = rowView["ID"].ToString();
                txt_name_food.Text = rowView["Name"].ToString();
                txt_unit_food.Text = rowView["Unit"].ToString();
                txt_notes_food.Text = rowView["Notes"].ToString();
                dud_prices.Text = rowView["Price"].ToString();

                cbb_category_naem.SelectedIndex = -1;
                for(int i = 0; i< cbb_category_naem.Items.Count; i++)
                {
                    DataRowView cat = cbb_category_naem.Items[i] as DataRowView;

                    if(cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
                    {
                        cbb_category_naem.SelectedIndex = i;
                        break;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (cbb_category_naem.Text != "")
            {
                string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                string query = "execute Food_Update @ID, @Name, @Unit,@FoodCategoryID, @Price, @Notes";
                sqlCommand.CommandText = query;

                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(txt_food_id.Text);
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 1000).Value = txt_name_food.Text;
                sqlCommand.Parameters.Add("@Unit", SqlDbType.NVarChar, 100).Value = txt_unit_food.Text;
                sqlCommand.Parameters.Add("@FoodCategoryID", SqlDbType.Int).Value = cbb_category_naem.SelectedValue;
                sqlCommand.Parameters.Add("@Price", SqlDbType.Int).Value = int.Parse(dud_prices.Text);
                sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000).Value = txt_notes_food.Text;

                sqlConnection.Open();

                int num = sqlCommand.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("Successfully updating food");
                    this.ResetControl();
                }
                else
                {
                    MessageBox.Show("Adding food failed");
                }
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_new_category_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.FormClosed += new FormClosedEventHandler(categoryForm_FormClose);
            categoryForm.Show(this);
        }
        private void categoryForm_FormClose(object sender, FormClosedEventArgs e)
        {
            InnitValues();
        }
    }
}
