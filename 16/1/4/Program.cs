using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "source.txt";        // Исходный файл
        string evenFile = "even_lines.txt";    // Файл для четных строк
        string oddFile = "odd_lines.txt";      // Файл для нечетных строк

        // Проверяем существование исходного файла
        if (!File.Exists(inputFile))
        {
            Console.WriteLine("Исходный файл не найден!");
            return;
        }

        string[] lines = File.ReadAllLines(inputFile);

        using (StreamWriter evenWriter = new StreamWriter(evenFile))
        using (StreamWriter oddWriter = new StreamWriter(oddFile))
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 == 0) // Четные строки (начиная с 0)
                    evenWriter.WriteLine(lines[i]);
                else // Нечетные строки
                    oddWriter.WriteLine(lines[i]);
            }
        }

        Console.WriteLine("Разделение строк завершено!");
    }
}
