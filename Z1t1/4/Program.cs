using System;

namespace Fir
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных
            Console.Write("Введите начальную скорость v0 (м/с): ");
            double v0 = double.Parse(Console.ReadLine());

            Console.Write("Введите ускорение a (м/с^2): ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите время t (с): ");
            double t = double.Parse(Console.ReadLine());

            // Вычисления
            double S = v0 * t + 0.5 * a * Math.Pow(t, 2);
            double v = v0 + a * t;

            // Вывод результатов
            Console.WriteLine($"Пройденное расстояние S = {S:F2} м");
            Console.WriteLine($"Конечная скорость v = {v:F2} м/с");
        }
    }
}