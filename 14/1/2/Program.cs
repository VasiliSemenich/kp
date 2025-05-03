using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void SumNumbers()
    {
        Stopwatch stopwatch = Stopwatch.StartNew(); // Запуск таймера

        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
            Thread.Sleep(100); // Искусственная задержка для имитации нагрузки
        }

        stopwatch.Stop(); // Остановка таймера
        Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: Сумма = {sum}, Время выполнения = {stopwatch.ElapsedMilliseconds} мс");
    }

    static void Main()
    {
        Thread thread1 = new Thread(SumNumbers);
        Thread thread2 = new Thread(SumNumbers);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Оба потока завершены.");
    }
}
