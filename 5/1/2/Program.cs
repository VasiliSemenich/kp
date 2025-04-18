using System;

public class FunctionCalculator
{
    public static void Main(string[] args)
    {
        try
        {
            double x = GetUserInput("Введите значение x: ");
            double result = CalculateFunction(x);
            Console.WriteLine($"Значение функции f(x) = {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: Деление на ноль");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Неверный формат ввода");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
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

    private static double CalculateFunction(double x)
    {
        if (x < -3 || x > 1)
        {
            throw new ArgumentOutOfRangeException("Значение x должно быть в диапазоне [-3, 1]");
        }

        if (x >= -3 && x < -5)
        {
            return (x - 3) / (x * x);
        }
        else if (x >= -5 && x < 1)
        {
            return 3 * x - 9;
        }
        else // x >= 1
        {
            return 1 / (3 * x - 9);
        }
    }
} 