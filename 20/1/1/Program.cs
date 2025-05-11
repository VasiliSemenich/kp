using System;
using System.Collections.Generic;

class Task
{
    public int Number { get; set; }

    public Task(int number)
    {
        if (number < 100 || number > 999)
            throw new ArgumentException("Число должно быть трехзначным.");

        // Проверяем, что все цифры различны
        string numStr = number.ToString();
        if (numStr[0] == numStr[1] || numStr[0] == numStr[2] || numStr[1] == numStr[2])
            throw new ArgumentException("Все цифры числа должны быть различны.");

        Number = number;
    }

    public List<int> GetPermutations()
    {
        string numStr = Number.ToString();
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
}

class Program
{
    static void Main()
    {
        try
        {
            // Вариант 1: Создание объекта через конструктор
            Task task1 = new Task(123);
            PrintPermutations(task1);

            // Вариант 2: Создание объекта через `new`
            Task task2 = new Task(456);
            PrintPermutations(task2);

            // Вариант 3: Создание объекта через `var`
            var task3 = new Task(789);
            PrintPermutations(task3);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static void PrintPermutations(Task task)
    {
        Console.WriteLine($"Перестановки для числа {task.Number}:");
        foreach (int perm in task.GetPermutations())
        {
            Console.WriteLine(perm);
        }
        Console.WriteLine();
    }
}
