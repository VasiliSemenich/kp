using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string text = "Пример текста с словами: шедевре, дерево, звездочка, елочка, еврейские.";

        var wordsWithThreeE = FindWordsWithThreeEUsingRegex(text);

        Console.WriteLine("Слова, в которых буква 'е' встречается ровно три раза: ");
        foreach (var word in wordsWithThreeE)
        {
            Console.WriteLine(word);
        }
    }

    static List<string> FindWordsWithThreeEUsingRegex(string text)
    {
        // Регулярное выражение для поиска слов с ровно тремя буквами 'е'
        Regex regex = new Regex(@"\b\w*[еЕ]\w*[еЕ]\w*[еЕ]\w*\b", RegexOptions.IgnoreCase);
        List<string> words = new List<string>();

        // Выполняем поиск совпадений в тексте
        MatchCollection matches = regex.Matches(text);

        foreach (Match match in matches)
        {
            string word = match.Value;

            // Подтверждаем, что ровно три буквы 'е' в слове
            int countE = Regex.Matches(word, "[еЕ]", RegexOptions.IgnoreCase).Count;
            if (countE == 3)
            {
                words.Add(word);
            }
        }

        return words;
    }
}
