using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tetris
{
    public partial class LeaderBoardForm : Form
    {
        public LeaderBoardForm()
        {
            InitializeComponent();
            LoadData();

            // Change the DataGridView appearance
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // This makes the columns fill the available width
            dataGridView1.AllowUserToAddRows = false;
        }

        private void LoadData()
        {
            string connectionString = "Data Source=JUSTIN-JOSEPH\\SQLEXPRESS;Initial Catalog=LeaderBoard;Integrated Security=True";
            string query = "SELECT * FROM LeaderBoard";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}