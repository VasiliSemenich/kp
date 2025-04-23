using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string text = "Пример текста содержит согласные буквы.";

        var consonants = FindConsonantsUsingRegex(text);

        Console.WriteLine($"Количество согласных: {consonants.Count}");
        Console.WriteLine("Согласные буквы:");
        foreach (var consonant in consonants)
        {
            Console.WriteLine(consonant);
        }
    }

    static List<char> FindConsonantsUsingRegex(string text)
    {
        // Регулярное выражение для поиска согласных букв
        Regex regex = new Regex(@"[бвгджзйклмнпрстфхцчшщ]");
        List<char> consonants = new List<char>();

        // Выполняем поиск совпадений
        MatchCollection matches = regex.Matches(text.ToLower());

        foreach (Match match in matches)
        {
            consonants.Add(match.Value[0]);
        }

        return consonants;
    }
}
