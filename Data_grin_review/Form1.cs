using System.Data;
using System.Data.SqlClient;

namespace Data_grin_review
{
    public partial class Form1 : Form
    {

        private readonly string _connectionString = "Server=DAVIDWORK;Database=dataReview;User Id=sa;Password=1234;";
        public Form1()
        {
            InitializeComponent();
            GetAllEmployees();
        }


        public  DataTable GetAllEmployees()
        {
            string connectionString = "Server=DAVIDWORK;Database=dataReview;User Id=sa;Password=1234;"; // Update with your server details

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT FirstName, LastName FROM Users";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridUsers.DataSource = dataTable;

                return dataTable;
            }
        }
    }
}
