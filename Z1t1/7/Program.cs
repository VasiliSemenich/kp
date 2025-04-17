using System;


namespace Fir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение m: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите значение n: ");
            int n = int.Parse(Console.ReadLine());

            double i1 = Math.Sqrt(Math.Pow(m * n + 2, 2) - 24) / Math.Sqrt(2);
            double i2 = Math.Sqrt(m);

            Console.WriteLine($"Результат по первой формуле: i1 = {i1:F2}");
            Console.WriteLine($"Результат по второй формуле: i2 = {i2:F2}");
        }
    }
}