using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("введите число: ");
        int originalNumber = int.Parse(Console.ReadLine());
        int modifiedNumber = RemoveEvenDigits(originalNumber);
        Console.WriteLine($"Исходное число: {originalNumber}");
        Console.WriteLine($"Модифицированное число: {modifiedNumber}");
    }

    static int RemoveEvenDigits(int number)
    {
        int result = 0;
        int power = 1;

        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 != 0)
            {
                result += digit * power;
                power *= 10;
            }
            number /= 10;
        }

        return result;
    }
}