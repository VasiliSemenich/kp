using System.Data.OleDb;
using System.Windows.Forms;


namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DBday30.accdb;";
        private void btnShowTours_Click(object sender, EventArgs e)
        {
            listBoxTours.Items.Clear();
            using var conn = new OleDbConnection(connStr);
            conn.Open();
            var cmd = new OleDbCommand("SELECT * FROM Туры", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listBoxTours.Items.Add($"{reader["Код тура"]} - {reader["Название"]} - {reader["Цена"]}");
            }
        }

        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            using var conn = new OleDbConnection(connStr);
            conn.Open();
            var cmd = new OleDbCommand("DELETE FROM Туры WHERE [Код тура] = ?", conn);
            cmd.Parameters.AddWithValue("?", int.Parse(txtDeleteTourId.Text));
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show($"Удалено: {result}");
        }

        private void btnUpdateTourist_Click(object sender, EventArgs e)
        {
            using var conn = new OleDbConnection(connStr);
            conn.Open();
            var cmd = new OleDbCommand("UPDATE Туристы SET Фамилия=?, Имя=?, Отчество=? WHERE [Код туриста]=?", conn);
            cmd.Parameters.AddWithValue("?", txtLastName.Text);
            cmd.Parameters.AddWithValue("?", txtFirstName.Text);
            cmd.Parameters.AddWithValue("?", txtMiddleName.Text);
            cmd.Parameters.AddWithValue("?", int.Parse(txtUpdateTouristId.Text));
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show($"Изменено: {result}");
        }

        private void btnAddTourist_Click(object sender, EventArgs e)
        {
            using var conn = new OleDbConnection(connStr);
            conn.Open();
            var cmd = new OleDbCommand("INSERT INTO Туристы (Фамилия, Имя, Отчество) VALUES (?, ?, ?)", conn);
            cmd.Parameters.AddWithValue("?", txtLastName.Text);
            cmd.Parameters.AddWithValue("?", txtFirstName.Text);
            cmd.Parameters.AddWithValue("?", txtMiddleName.Text);
            int result = cmd.ExecuteNonQuery();
            MessageBox.Show($"Добавлено: {result}");
        }
    }
}
