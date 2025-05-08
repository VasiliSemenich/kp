using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void ProcessFile()
    {
        string filePath = @"D:\!КУРСАЧ ЗАДАНИЯ\1\kp\18\18kz.txt"; // Заданный путь к файлу

        Queue<char> lettersQueue = new Queue<char>();
        Queue<char> digitsQueue = new Queue<char>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    foreach (char ch in line)
                    {
                        if (char.IsDigit(ch))
                            digitsQueue.Enqueue(ch); // Добавляем цифры в очередь
                        else
                            lettersQueue.Enqueue(ch); // Добавляем остальные символы
                    }
                }
            }

            // Вывод сначала букв и символов, затем цифр
            Console.Write("Результат: ");
            while (lettersQueue.Count > 0)
                Console.Write(lettersQueue.Dequeue());

            while (digitsQueue.Count > 0)
                Console.Write(digitsQueue.Dequeue());

            Console.WriteLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static void Main()
    {
        ProcessFile();
    }
}
