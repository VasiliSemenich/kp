using System;

class Program
{
    static void Main()
    {
        int[] A = { -3, 5, -2, 9, -8, 1, 4 }; // Пример массива
        int count = 0;

        foreach (int number in A)
        {
            if (number < 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество отрицательных элементов: {count}");
    }
}
