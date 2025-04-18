using System;

public class NumberManipulator
{
    public static void Main(string[] args)
    {
        try
        {
            int K = GetUserInput("Введите целое положительное число K: ");
            int D1 = GetUserDigit("Введите первую цифру D1 (1-9): ");
            int D2 = GetUserDigit("Введите вторую цифру D2 (1-9): ");

            int result1 = AddLeftDigit(D1, K);
            Console.WriteLine($"Число K после добавления цифры D1 = {result1}");

            int result2 = AddLeftDigit(D2, result1);
            Console.WriteLine($"Число K после добавления цифры D2 = {result2}");
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

    private static int GetUserInput(string prompt)
    {
        Console.Write(prompt);
        int value = int.Parse(Console.ReadLine());
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException("Число K должно быть положительным");
        }
        return value;
    }

    private static int GetUserDigit(string prompt)
    {
        Console.Write(prompt);
        int digit = int.Parse(Console.ReadLine());
        if (digit < 1 || digit > 9)
        {
            throw new ArgumentOutOfRangeException("Цифра должна быть в диапазоне от 1 до 9");
        }
        return digit;
    }

    public static int AddLeftDigit(int D, int K)
    {
        if (D < 1 || D > 9)
        {
            throw new ArgumentOutOfRangeException("Цифра должна быть в диапазоне от 1 до 9");
        }

        int newNumber = D * (int)Math.Pow(10, (int)Math.Log10(K) + 1) + K;
        return newNumber;
    }
}