using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string text = "Пример текста с цифрой 123.";

        bool containsDigits = ContainsDigitsUsingRegex(text);

        Console.WriteLine(containsDigits
            ? "Текст содержит цифры."
            : "Текст не содержит цифр.");
    }

    static bool ContainsDigitsUsingRegex(string text)
    {
        // Регулярное выражение для поиска цифр
        Regex regex = new Regex(@"\d");
        return regex.IsMatch(text);
    }
}
