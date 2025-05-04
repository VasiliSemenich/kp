using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string filePath = "filtered_text.txt";

        // Ввод предложения пользователем
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();

        // Удаление всех цифр из строки
        string filteredText = Regex.Replace(input, @"\d", "");

        // Запись очищенного текста в файл
        File.WriteAllText(filePath, filteredText);

        // Чтение и вывод содержимого файла
        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine("\nСодержимое файла:");
        Console.WriteLine(fileContent);
    }
}
