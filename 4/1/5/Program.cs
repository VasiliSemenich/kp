using System;
using System.Collections.Generic;
using System.IO;

class SubjectIndex
{
    private Dictionary<string, List<int>> index;

    public SubjectIndex()
    {
        index = new Dictionary<string, List<int>>();
    }

    // Метод для добавления слова и номеров страниц
    public void AddEntry(string word, List<int> pages)
    {
        if (pages.Count > 10)
        {
            throw new ArgumentException("Количество номеров страниц должно быть от одного до десяти.");
        }

        index[word] = new List<int>(pages);
    }

    // Метод для удаления слова из указателя
    public void RemoveEntry(string word)
    {
        if (index.ContainsKey(word))
        {
            index.Remove(word);
        }
        else
        {
            Console.WriteLine("Слово не найдено в указателе.");
        }
    }

    // Метод для вывода указателя
    public void DisplayIndex()
    {
        foreach (var entry in index)
        {
            Console.WriteLine($"{entry.Key}: {string.Join(", ", entry.Value)}");
        }
    }

    // Метод для поиска номеров страниц по слову
    public void FindPages(string word)
    {
        if (index.ContainsKey(word))
        {
            Console.WriteLine($"Слово '{word}' встречается на страницах: {string.Join(", ", index[word])}");
        }
        else
        {
            Console.WriteLine($"Слово '{word}' не найдено в указателе.");
        }
    }

    // Метод для загрузки указателя из файла
    public void LoadFromFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("Файл не найден.");
        }

        foreach (var line in File.ReadLines(filePath))
        {
            var parts = line.Split(':');
            if (parts.Length == 2)
            {
                var word = parts[0].Trim();
                var pages = Array.ConvertAll(parts[1].Split(','), int.Parse);
                AddEntry(word, new List<int>(pages));
            }
        }
    }
}

class Program
{
    static void Main()
    {
        SubjectIndex index = new SubjectIndex();

        // Формирование указателя с клавиатуры
        Console.WriteLine("Введите слово:");
        string word = Console.ReadLine();
        Console.WriteLine("Введите номера страниц (через запятую):");
        List<int> pages = new List<int>(Array.ConvertAll(Console.ReadLine().Split(','), int.Parse));
        index.AddEntry(word, pages);

        // Загрузка указателя из файла (пример: "index.txt")
        try
        {
            index.LoadFromFile("index.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при загрузке из файла: {ex.Message}");
        }

        // Вывод указателя
        Console.WriteLine("Указатель:");
        index.DisplayIndex();

        // Поиск номеров страниц для заданного слова
        Console.WriteLine("Введите слово для поиска:");
        string searchWord = Console.ReadLine();
        index.FindPages(searchWord);

        // Удаление элемента из указателя
        Console.WriteLine("Введите слово для удаления:");
        string removeWord = Console.ReadLine();
        index.RemoveEntry(removeWord);

        // Вывод после удаления
        Console.WriteLine("Указатель после удаления:");
        index.DisplayIndex();
    }
}
