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
using RestaurentManagementApplication.Model;

namespace RestaurentManagementApplication
{
    public partial class CategoryForm : Form
    {
        private List<RestaurentManagementApplication.Model.Type> types = new List<Model.Type>();
        public CategoryForm()
        {
            types.Add(new Model.Type("Đồ ăn", 1));
            types.Add(new Model.Type("Đồ uống", 0));
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            cbb_type.DataSource = types;
            cbb_type.DisplayMember = "Name";
            cbb_type.ValueMember = "Value";
            cbb_type.SelectedIndex = 0;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-5BF7AN67\\SQLEXPRESS; database = RestaurentManagement;uid=sa; pwd=sa";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "execute Catagory_Insert_ @ID output, @Name, @Type";
            sqlCommand.CommandText = query;

            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 1000).Value = txt_name_category.Text;
            sqlCommand.Parameters.Add("@Type", SqlDbType.Int).Value = cbb_type.SelectedValue;

            sqlConnection.Open();
            int num = sqlCommand.ExecuteNonQuery();
            if (num > 0)
            {
                string id = sqlCommand.Parameters["@ID"].Value.ToString();
                MessageBox.Show("Successfully adding new category, category ID = " + id, "Message");
                this.ResetControl();
            }
            else
            {
                MessageBox.Show("Adding category failed");
            }
            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        private void ResetControl()
        {
            txt_category_id.ResetText();
            txt_name_category.ResetText();
            cbb_type.ResetText();
        }
    }
}
