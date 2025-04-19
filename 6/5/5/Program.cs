using System;

class Program
{
    static void Main()
    {
        // Ввод значения n с клавиатуры
        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        // Вычисление f(n) с использованием рекурсии
        double result = CalculateF(n);

        // Вывод результата
        Console.WriteLine($"f({n}) = {result}");
    }

    static double CalculateFactorial(int x)
    {
        // Рекурсивная функция для вычисления факториала
        if (x <= 1)
            return 1;
        return x * CalculateFactorial(x - 1);
    }

    static double CalculateF(int n)
    {
        // Вычисление f(n) = (n+2)! / (n+4)!
        double numerator = CalculateFactorial(n + 2);
        double denominator = CalculateFactorial(n + 4);
        return numerator / denominator;
    }
}
