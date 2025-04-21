using System;
using System.Linq;

class Program
{
    static int ReduceToSingleDigit(int number)
    {
        while (number >= 10)
        {
            number = number.ToString().Select(c => c - '0').Sum();
        }
        return number;
    }

    static void Main()
    {
        Console.WriteLine("Введите фамилию, имя и отчество пользователя:");
        string input = Console.ReadLine()
        string cleanedInput = new string(input.Where(char.IsLetter).ToArray()).ToLower()
        int sum = cleanedInput.Select(c => c - 'а' + 1).Sum()
        int personalCode = ReduceToSingleDigit(sum)
        Console.WriteLine($"Код личности: {personalCode}");
    }
}
