using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем параметры функции
        double A = 0.1;
        double B = 2.1;
        int M = 20;

        // Вычисление шага
        double H = (B - A) / M;

        // Вычисление и вывод значений функции
        Console.WriteLine("x\tF(x)");
        for (int i = 1; i <= M; i++)
        {
            double x = A + (i - 1) * H;
            double F = EvaluateFunction(x);
            Console.WriteLine($"{x:F1}\t{F:F2}");
        }
    }

    static double EvaluateFunction(double x)
    {
        return x * Math.Exp(x * x);
    }
}