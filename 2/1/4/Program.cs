using System;

class Program
{
    static void Main(string[] args)
    {
        double x;
        double y;

        Console.Write("Введите значение x: ");
        x = double.Parse(Console.ReadLine());

        if (x <= Math.PI)
        {
            y = x + 2 * Math.Sin(3 * x);
            Console.WriteLine($"При x <= π, y = {y:F2}");
        }
        else
        {
            y = Math.Cos(x + 2);
            Console.WriteLine($"При x > π, y = {y:F2}");
        }
    }
}