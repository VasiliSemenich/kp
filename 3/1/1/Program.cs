using System;

public class A
{
    // Поля класса
    public int a;
    public int b;

    // Конструктор для инициализации a и b
    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public double CalculateExpression()
    {
        return Math.Sin(b) + 4;
    }

    public int SquareSum()
    {
        return (a + b) * (a + b);
    }
}

// Использование класса A
class Program
{
    static void Main(string[] args)
    {
        // Создаем объект класса A
        A obj = new A(5, 10);
        double result1 = obj.CalculateExpression();
        Console.WriteLine("Результат выражения sin(b) + 4: " + result1);
        int result2 = obj.SquareSum();
        Console.WriteLine("Результат возведения в квадрат суммы a и b: " + result2);
    }
}