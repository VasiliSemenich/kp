namespace _3
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

        // Функция f(x), которую можно изменить при необходимости
        private double f(double x)
        {
            return Math.Sin(x); // Пример функции f(x)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем x и p из текстовых полей
                double x = Convert.ToDouble(textBox1.Text);
                double p = Convert.ToDouble(textBox2.Text);

                // Вычисляем l(x, p) по кусочной функции
                double l;
                if (x >= Math.Abs(p))
                {
                    l = 2 * Math.Pow(f(x), 3) + 3 * Math.Pow(p, 2);
                }
                else if (3 * x < Math.Abs(p))
                {
                    l = f(x) - p;
                }
                else // x == |p|
                {
                    l = Math.Pow(f(x) - p, 2);
                }

                // Вывод результата в label1
                label1.Text = $"Результат: {l:F4}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
