using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Пример последовательности чисел от a1 до a99
        int[] numbers = Enumerable.Range(1, 99).ToArray();

        // Найдем минимальный и максимальный элементы
        int min = numbers.Min();
        int max = numbers.Max();

        // Создадим новую последовательность без минимального и максимального элементов
        int[] filteredNumbers = numbers.Where(n => n != min && n != max).ToArray();

        // Вывод новой последовательности
        Console.WriteLine("Новая последовательность:");
        Console.WriteLine(string.Join(", ", filteredNumbers));
    }
}
