using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "textfile.txt";
        string newFilePath = "newfile.txt";
        string reversedFilePath = "reversedfile.txt";

        // Создание файла и запись 5 строк
        File.WriteAllLines(filePath, new string[]
        {
            "Первая строка",
            "Вторая строка, немного длиннее",
            "Третья строка",
            "Четвертая строка",
            "Пятая, самая длинная строка, с большим количеством символов"
        });

        // Вывод всего файла на экран
        Console.WriteLine("Содержимое файла:");
        string[] lines = File.ReadAllLines(filePath);
        foreach (var line in lines) Console.WriteLine(line);

        // Подсчет количества строк
        Console.WriteLine($"\nКоличество строк: {lines.Length}");

        // Подсчет количества символов в каждой строке
        Console.WriteLine("\nКоличество символов в каждой строке:");
        for (int i = 0; i < lines.Length; i++)
            Console.WriteLine($"Строка {i + 1}: {lines[i].Length} символов");

        // Удаление последней строки и запись в новый файл
        File.WriteAllLines(newFilePath, lines.Take(lines.Length - 1));
        Console.WriteLine("\nПоследняя строка удалена. Создан новый файл.");

        // Вывод строк с заданными индексами (s1 по s2)
        Console.Write("\nВведите индекс начальной строки (s1): ");
        int s1 = int.Parse(Console.ReadLine());
        Console.Write("Введите индекс конечной строки (s2): ");
        int s2 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nВыбранные строки:");
        for (int i = s1; i <= s2 && i < lines.Length; i++)
            Console.WriteLine(lines[i]);

        // Поиск самой длинной строки
        string longestLine = lines.OrderByDescending(line => line.Length).First();
        Console.WriteLine($"\nСамая длинная строка ({longestLine.Length} символов): {longestLine}");

        // Вывод строк, начинающихся с заданной буквы
        Console.Write("\nВведите букву для поиска строк: ");
        char searchChar = Console.ReadLine()[0];

        Console.WriteLine("\nСтроки, начинающиеся с заданной буквы:");
        foreach (var line in lines.Where(l => l.StartsWith(searchChar.ToString(), StringComparison.OrdinalIgnoreCase)))
            Console.WriteLine(line);

        // Запись строк в другой файл в обратном порядке
        File.WriteAllLines(reversedFilePath, lines.Reverse());
        Console.WriteLine("\nФайл с строками в обратном порядке успешно создан.");
    }
}
        