using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tetris
{
   
    public partial class GameOverForm : Form
    {
        SqlConnection conn;
        SqlCommand cmd; 
       
        private int score;

        public GameOverForm(int score)
        {

            InitializeComponent();
            this.score = score;
            label1.Text = "Score: " + score;
            label2.Text = "Level: " + score / 10;
            label3.Text = "Lines " + score;
            conn = new SqlConnection("Data Source=JUSTIN-JOSEPH\\SQLEXPRESS;Initial Catalog=LeaderBoard;Integrated Security=True");
            conn.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string playerName = textBox1.Text;
            string insertQuery = "INSERT INTO LeaderBoard (PlayerName, Score, Level, Lines) VALUES (@PlayerName, @Score, @Level, @Lines)";

            using(cmd =  new SqlCommand(insertQuery, conn))
            {
                cmd.Parameters.AddWithValue("@PlayerName", playerName);
                cmd.Parameters.AddWithValue("@Score", score);
                cmd.Parameters.AddWithValue("@Level", score / 10);
                cmd.Parameters.AddWithValue("@Lines", score);
                cmd.ExecuteNonQuery();
            }
            conn.Close();

            MainMenu mainMenu = new MainMenu();
            mainMenu.Show(this);
            this.Hide();
        }
    }
}
