using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст, содержащий только цифры и буквы:");
        string input = Console.ReadLine();

        if (!input.All(char.IsLetterOrDigit))
        {
            Console.WriteLine("Текст должен состоять только из цифр и букв.");
            return;
        }

        int sumOfDigits = input
            .Where(char.IsDigit)
            .Select(c => c - '0')
            .Sum(); // Суммируем числовые значения цифр в тексте

        int textLength = input.Length; // Длина текста

        Console.WriteLine($"Сумма цифр: {sumOfDigits}");
        Console.WriteLine($"Длина текста: {textLength}");

        if (sumOfDigits == textLength)
        {
            Console.WriteLine("Сумма числовых значений цифр равна длине текста.");
        }
        else
        {
            Console.WriteLine("Сумма числовых значений цифр не равна длине текста.");
        }
    }
}
