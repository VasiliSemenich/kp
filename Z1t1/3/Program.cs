using System;
using static System.Math;

namespace Fir
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 2.7;
            double y = Log(x + Sqrt(x * x + 9)) - (x + 1) / Pow(x, 3);
            Console.WriteLine($"Результат: y = {y:F2}");
        }
    }
}