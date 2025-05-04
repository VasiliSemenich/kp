using System;
using System.IO;

class Program
{
    static void Main()
    {
        string folderPath = "New_folder";

        // Создание папки
        Directory.CreateDirectory(folderPath);

        Console.WriteLine($"Папка '{folderPath}' успешно создана.");
    }
}
