namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Исходные данные
                double x = 1.825 * Math.Pow(10, 2);
                double y = 18.225;
                double z = 3.298 * Math.Pow(10, -2);

                // Вычисление по формуле
                double psi = Math.Abs((y / (Math.Pow(x, x) - 3)) * Math.Sqrt(y / x)) +
                             (y - x) * ((Math.Cos(y) - (z / (y - x))) / (1 + Math.Pow(y - x, 2)));

                // Вывод результата в label1
                label1.Text = $"Результат: {psi:F4}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка вычисления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
