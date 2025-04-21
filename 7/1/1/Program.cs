using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();
        string processed = new string(input
            .Where(char.IsLetterOrDigit)
            .Select(char.ToLower)
            .ToArray());
        string reversed = new string(processed.Reverse().ToArray());
        bool isPalindrome = processed == reversed;

        if (isPalindrome)
        {
            Console.WriteLine("Введённый текст является палиндромом!");
        }
        else
        {
            Console.WriteLine("Введённый текст не является палиндромом.");
        }
    }
}
