using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;



namespace Task1
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=BDTur_firmSQL;Integrated Security=True;";



        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTours();
        }

        private void LoadTours()
        {
            using (SqlConnection connection = new(connectionString))
            {
                SqlDataAdapter adapter = new("SELECT * FROM Туры", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void buttonAddTourist_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new(connectionString))
            {
                string sql = "INSERT INTO Туристы (Фамилия, Имя, Отчество) VALUES (@f, @i, @o)";
                SqlCommand cmd = new(sql, connection);
                cmd.Parameters.AddWithValue("@f", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@i", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@o", textBoxMiddleName.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Турист добавлен.");
            }
        }

        private void buttonUpdateTourist_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new(connectionString))
            {
                string sql = "UPDATE Туристы SET Имя = @name WHERE Код_туриста = @id";
                SqlCommand cmd = new(sql, connection);
                cmd.Parameters.AddWithValue("@name", textBoxNewName.Text);
                cmd.Parameters.AddWithValue("@id", int.Parse(textBoxTouristId.Text));

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Имя туриста обновлено.");
            }
        }

        private void buttonDeleteTour_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new(connectionString))
            {
                string sql = "DELETE FROM Туры WHERE Код_тура = @id";
                SqlCommand cmd = new(sql, connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(textBoxTourId.Text));

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Тур удален.");
                LoadTours();
            }
        }

        private void buttonLoadTours_Click(object sender, EventArgs e)
        {
            LoadTours();
        }
    }
}
