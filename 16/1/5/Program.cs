using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string file1 = "f1.txt";
        string file2 = "f2.txt";
        string file3 = "f3.txt";

        // Создание и запись чисел в f1
        File.WriteAllLines(file1, new string[] { "1", "3", "5", "7", "9" });

        // Создание и запись чисел в f2
        File.WriteAllLines(file2, new string[] { "2", "4", "6", "8", "10" });

        // Чтение и объединение с сортировкой
        int[] numbers1 = File.ReadAllLines(file1).Select(int.Parse).ToArray();
        int[] numbers2 = File.ReadAllLines(file2).Select(int.Parse).ToArray();

        int[] mergedNumbers = numbers1.Concat(numbers2).OrderBy(n => n).ToArray();

        // Запись отсортированных данных в f3
        File.WriteAllLines(file3, mergedNumbers.Select(n => n.ToString()));

        Console.WriteLine("Файл f3 успешно создан с отсортированными числами!");
    }
}
