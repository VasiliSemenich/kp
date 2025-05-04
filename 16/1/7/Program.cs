using System;
using System.IO;

class Program
{
    static void Main()
    {
        string sourceFilePath = @"D:\!КУРСАЧ ЗАДАНИЯ\1\kp\16\1\7\Текстовый документ.txt";
        string evenFilePath = @"D:\!КУРСАЧ ЗАДАНИЯ\1\kp\16\1\7\even_lines.txt";
        string oddFilePath = @"D:\!КУРСАЧ ЗАДАНИЯ\1\kp\16\1\7\odd_lines.txt";

        // Проверяем, существует ли исходный файл
        if (!File.Exists(sourceFilePath))
        {
            Console.WriteLine($"❌ Ошибка: Файл \"{sourceFilePath}\" не найден!");
            return;
        }

        // Чтение строк из файла
        string[] lines = File.ReadAllLines(sourceFilePath);

        // Запись четных строк в один файл, а нечетных — в другой
        using (StreamWriter evenWriter = new StreamWriter(evenFilePath))
        using (StreamWriter oddWriter = new StreamWriter(oddFilePath))
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 == 0) // Четные строки
                    evenWriter.WriteLine(lines[i]);
                else // Нечетные строки
                    oddWriter.WriteLine(lines[i]);
            }
        }

        Console.WriteLine($"✅ Разделение строк завершено!\nЧетные строки → \"{evenFilePath}\"\nНечетные строки → \"{oddFilePath}\"");
    }
}
