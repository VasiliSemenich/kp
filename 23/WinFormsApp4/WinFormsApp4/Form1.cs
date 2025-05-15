using System.Text;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] F = new int[7, 7];
            Random rnd = new Random();
            StringBuilder matrixText = new StringBuilder();
            StringBuilder minText = new StringBuilder();

            // ��������� ������� ���������� ������� �� 1 �� 100
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    F[i, j] = rnd.Next(1, 100);
                    matrixText.Append($"{F[i, j],3} "); // ����������� ������
                }
                matrixText.AppendLine(); // ������� �� ����� ������
            }

            // ������� ����������� ������� � ������ �������
            int[] minElements = new int[7];

            for (int j = 0; j < 7; j++)
            {
                int min = F[0, j]; // ������ ������� �������
                for (int i = 1; i < 7; i++)
                {
                    if (F[i, j] < min)
                    {
                        min = F[i, j];
                    }
                }
                minElements[j] = min;
            }

            // ��������� ������ ��� ������ ��������
            minText.Append("���. ��������: ");
            foreach (int min in minElements)
            {
                minText.Append($"{min} ");
            }

            // ����� ���������� � label
            label1.Text = matrixText.ToString() + Environment.NewLine + minText.ToString();
        


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
