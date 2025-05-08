using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static string ProcessString(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in input)
        {
            if (ch == '#')
            {
                if (stack.Count > 0)
                    stack.Pop(); // Удаляем последний символ
            }
            else
            {
                stack.Push(ch); // Добавляем символ в стек
            }
        }

        // Собираем оставшиеся символы в строку
        StringBuilder result = new StringBuilder();
        foreach (char ch in stack)
        {
            result.Insert(0, ch); // Вставляем в начало, чтобы сохранить порядок
        }

        return result.ToString();
    }

    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        string processed = ProcessString(input);
        Console.WriteLine($"Результат: {processed}");
    }
}
