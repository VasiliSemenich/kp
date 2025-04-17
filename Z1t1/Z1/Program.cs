    using System;

    namespace Fir

    {
        class Program
        {
            static void Main(string[] args)
            {
                double num1, num2;

                Console.Write("Введите первое число: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                num2 = double.Parse(Console.ReadLine());

                double sum = num1 + num2;

                Console.WriteLine($"Сумма чисел: {sum:F2}");
            }
        }
    }