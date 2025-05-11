using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static List<int> ComputePermutations(int number)
    {
        if (number < 100 || number > 999)
            throw new ArgumentException("Число должно быть трехзначным.");

        // Проверяем, что все цифры различны
        string numStr = number.ToString();
        if (numStr[0] == numStr[1] || numStr[0] == numStr[2] || numStr[1] == numStr[2])
            throw new ArgumentException("Все цифры числа должны быть различны.");

        List<int> permutations = new List<int>
        {
            int.Parse($"{numStr[0]}{numStr[1]}{numStr[2]}"),
            int.Parse($"{numStr[0]}{numStr[2]}{numStr[1]}"),
            int.Parse($"{numStr[1]}{numStr[0]}{numStr[2]}"),
            int.Parse($"{numStr[1]}{numStr[2]}{numStr[0]}"),
            int.Parse($"{numStr[2]}{numStr[0]}{numStr[1]}"),
            int.Parse($"{numStr[2]}{numStr[1]}{numStr[0]}")
        };

        return permutations;
    }

    static async Task Main()
    {
        int number = 123; // Исходное трехзначное число

        // Первый объект Task: вычисление перестановок
        Task<List<int>> task1 = Task.Run(() => ComputePermutations(number));

        // Второй объект Task: продолжение, вывод результата
        Task task2 = task1.ContinueWith(t =>
        {
            Console.WriteLine($"Перестановки для числа {number}:");
            foreach (int perm in t.Result)
            {
                Console.WriteLine(perm);
            }
        });

        await task2; // Ожидание завершения всей цепочки задач
    }
}
