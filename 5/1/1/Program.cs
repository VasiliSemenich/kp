using System;

public class MathExpressionCalculator
{
    public static void Main(string[] args)
    {
        try
        {
            double x = GetUserInput("Введите значение x: ");
            CalculateAndPrintExpression1(x);
            CalculateAndPrintExpression2(x);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: Деление на ноль");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Неверный формат ввода");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    private static double GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return double.Parse(Console.ReadLine());
    }

    private static void CalculateAndPrintExpression1(double x)
    {
        double y = x + 2 * x / (4 * Math.Sin(x));
        Console.WriteLine($"Выражение 1: y = {y}");
    }

    private static void CalculateAndPrintExpression2(double x)
    {
        double y = x - 3 + 1 / Math.Tan(x - 1);
        Console.WriteLine($"Выражение 2: y = {y}");
    }
}