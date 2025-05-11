using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int A = -6; // Начало отрезка
        int B = 6;  // Конец отрезка

        Console.WriteLine("Вычисление функции Sin(x) - Cos(x) на отрезке [-6, 6]:");

        Parallel.For(A, B + 1, x =>
        {
            double result = Math.Sin(x) - Math.Cos(x);
            Console.WriteLine($"x = {x}, Sin(x) - Cos(x) = {result:F4}");
        });

        Console.WriteLine("Вычисления завершены!");
    }
}
