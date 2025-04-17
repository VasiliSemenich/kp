using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c;

        // Ввод длин сторон треугольника
        Console.Write("Введите длину стороны a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Введите длину стороны b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Введите длину стороны c: ");
        c = double.Parse(Console.ReadLine());

        // Проверка существования треугольника
        if (a + b > c && b + c > a && a + c > b)
        {
            Console.WriteLine("Треугольник с заданными длинами сторон существует.");
        }
        else
        {
            Console.WriteLine("Треугольник с заданными длинами сторон не существует.");
        }
    }
}