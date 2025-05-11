using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void ComputeFunction1()
    {
        Console.WriteLine("Задача 1 начала выполнение...");
        Thread.Sleep(3000); // Имитация задержки 3 секунды
        Console.WriteLine("Задача 1 завершена.");
    }

    static void ComputeFunction2()
    {
        Console.WriteLine("Задача 2 начала выполнение...");
        Thread.Sleep(5000); // Имитация задержки 5 секунд
        Console.WriteLine("Задача 2 завершена.");
    }

    static async Task Main()
    {
        // Создаем массив задач
        Task[] tasks = new Task[2]
        {
            Task.Run(() => ComputeFunction1()),
            Task.Run(() => ComputeFunction2())
        };

        // 1. Дождаться выполнения всех задач
        Console.WriteLine("Ожидание завершения всех задач...");
        await Task.WhenAll(tasks);
        Console.WriteLine("Все задачи завершены!\n");

        // 2. Дождаться выполнения хотя бы одной задачи
        Console.WriteLine("Ожидание завершения хотя бы одной задачи...");
        await Task.WhenAny(tasks);
        Console.WriteLine("Хотя бы одна задача завершена!");
    }
}
