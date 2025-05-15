namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] c = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
                        16, 17, 18, 19, 20, 21, 22, 23 };


            double average = c.Average();
            label1.Text = $"Среднее арифметическое: {average:F2}";
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
