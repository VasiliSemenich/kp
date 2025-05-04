using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "numbers.txt";

        // Ввод чисел
        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();

        // Запись в файл
        File.WriteAllText(filePath, input);

        // Чтение данных из файла
        string fileData = File.ReadAllText(filePath);
        int[] numbers = fileData.Split(' ')
                                .Select(int.Parse)
                                .ToArray();

        // Поиск максимального числа
        int maxNumber = numbers.Max();

        // Подсчет количества отрицательных чисел
        int negativeCount = numbers.Count(n => n < 0);

        Console.WriteLine($"Максимальное число: {maxNumber}");
        Console.WriteLine($"Количество отрицательных чисел: {negativeCount}");
    }
}
