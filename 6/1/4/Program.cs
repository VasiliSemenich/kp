using System;

class Program
{
    static void Main()
    {
        // Пример двумерного массива
        int[,] matrix = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        // Подсчитываем сумму элементов в первой строке
        int firstRowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            firstRowSum += matrix[0, j];
        }

        // Подсчитываем сумму элементов в предпоследней строке
        int penultimateRowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            penultimateRowSum += matrix[matrix.GetLength(0) - 2, j];
        }

        // Сравниваем суммы
        if (firstRowSum > penultimateRowSum)
        {
            Console.WriteLine("Сумма элементов больше в первой строке.");
        }
        else if (firstRowSum < penultimateRowSum)
        {
            Console.WriteLine("Сумма элементов больше в предпоследней строке.");
        }
        else
        {
            Console.WriteLine("Сумма элементов в первой и предпоследней строках равна.");
        }
    }
}
