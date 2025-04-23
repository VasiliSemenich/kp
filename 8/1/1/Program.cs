using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string text = "Пример текста. Второе предложение! А это третий пример?";

        var result = FindWordsAtSentenceEdges(text);

        foreach (var pair in result)
        {
            Console.WriteLine($"Начало: {pair.Item1}, Конец: {pair.Item2}");
        }
    }

    static List<Tuple<string, string>> FindWordsAtSentenceEdges(string text)
    {
        // Регулярное выражение для поиска предложений
        string pattern = @"\b(\w+).*?(\w+)[.!?]";
        Regex regex = new Regex(pattern);

        List<Tuple<string, string>> edges = new List<Tuple<string, string>>();

        // Выполняем поиск совпадений
        MatchCollection matches = regex.Matches(text);

        foreach (Match match in matches)
        {
            if (match.Groups.Count == 3)
            {
                string firstWord = match.Groups[1].Value;
                string lastWord = match.Groups[2].Value;
                edges.Add(new Tuple<string, string>(firstWord, lastWord));
            }
        }

        return edges;
    }
}
