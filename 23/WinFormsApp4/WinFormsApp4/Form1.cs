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

            // Заполняем матрицу случайными числами от 1 до 100
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    F[i, j] = rnd.Next(1, 100);
                    matrixText.Append($"{F[i, j],3} "); // Форматируем строку
                }
                matrixText.AppendLine(); // Переход на новую строку
            }

            // Находим минимальный элемент в каждом столбце
            int[] minElements = new int[7];

            for (int j = 0; j < 7; j++)
            {
                int min = F[0, j]; // Первый элемент столбца
                for (int i = 1; i < 7; i++)
                {
                    if (F[i, j] < min)
                    {
                        min = F[i, j];
                    }
                }
                minElements[j] = min;
            }

            // Формируем строку для вывода минимума
            minText.Append("Мин. элементы: ");
            foreach (int min in minElements)
            {
                minText.Append($"{min} ");
            }

            // Вывод результата в label
            label1.Text = matrixText.ToString() + Environment.NewLine + minText.ToString();
        


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
