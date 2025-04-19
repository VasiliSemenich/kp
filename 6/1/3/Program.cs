using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Пример двумерного массива
        int[,] matrix = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

        // Ввод значения G
        Console.Write("Введите значение G: ");
        int G = int.Parse(Console.ReadLine());

        // Вычисление среднего арифметического элементов, больших G
        var greaterThanG = matrix.Cast<int>().Where(x => x > G).ToList();
        double average = greaterThanG.Any() ? greaterThanG.Average() : 0;
        Console.WriteLine($"Среднее арифметическое элементов, больших {G}: {average}");

        // Ввод значения k (номер строки)
        Console.Write("Введите номер строки k (начиная с 1): ");
        int k = int.Parse(Console.ReadLine()) - 1; // Приведение к индексации массива (с 0)

        if (k >= 0 && k < matrix.GetLength(0))
        {
            // Количество четных элементов в k-той строке
            int evenCount = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[k, j] % 2 == 0)
                {
                    evenCount++;
                }
            }
            Console.WriteLine($"Количество чётных элементов в {k + 1}-й строке: {evenCount}");
        }
        else
        {
            Console.WriteLine("Ошибка: такого номера строки не существует.");
        }
    }
}
