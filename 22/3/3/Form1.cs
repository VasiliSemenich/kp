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

        // ������� f(x), ������� ����� �������� ��� �������������
        private double f(double x)
        {
            return Math.Sin(x); // ������ ������� f(x)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // �������� x � p �� ��������� �����
                double x = Convert.ToDouble(textBox1.Text);
                double p = Convert.ToDouble(textBox2.Text);

                // ��������� l(x, p) �� �������� �������
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

                // ����� ���������� � label1
                label1.Text = $"���������: {l:F4}";
            }
            catch (FormatException)
            {
                MessageBox.Show("������� ���������� �����!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
