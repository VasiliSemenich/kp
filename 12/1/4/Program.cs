using System;

namespace AnonymousDelegateExample
{
    // Тип делегата, который возвращает значение типа int
    public delegate int RandomValueDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем массив делегатов
            RandomValueDelegate[] delegates = new RandomValueDelegate[5];

            Random random = new Random();

            // Инициализируем массив делегатов, сообщая методы, возвращающие случайное значение
            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = () => random.Next(1, 101); // Случайное число от 1 до 100
            }

            // Анонимный метод для вычисления среднего арифметического
            Func<RandomValueDelegate[], double> CalculateAverage = delegate (RandomValueDelegate[] delArray)
            {
                double sum = 0;
                int count = delArray.Length;

                foreach (var del in delArray)
                {
                    sum += del();
                }

                return sum / count;
            };

            // Вычисляем среднее арифметическое и выводим результат
            double average = CalculateAverage(delegates);
            Console.WriteLine($"Среднее арифметическое: {average:F2}");
        }
    }
}
