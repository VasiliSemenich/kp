using System;
using System.Threading;

class Program
{
    static int A, N;

    static void SumOfPowers()
    {
        double sum = 0;
        for (int i = 0; i <= N; i++)
        {
            sum += Math.Pow(A, i);
            Thread.Sleep(100); // Искусственная задержка
        }
        Console.WriteLine($"[Поток {Thread.CurrentThread.ManagedThreadId}] Сумма степеней = {sum}");
    }

    static void ProductOfPowers()
    {
        double product = 1;
        for (int i = 0; i <= N; i++)
        {
            product *= Math.Pow(A, i);
            Thread.Sleep(100); // Искусственная задержка
        }
        Console.WriteLine($"[Поток {Thread.CurrentThread.ManagedThreadId}] Произведение степеней = {product}");
    }

    static void Main()
    {
        // Ввод значений A и N
        Console.Write("Введите A: ");
        A = int.Parse(Console.ReadLine());

        Console.Write("Введите N: ");
        N = int.Parse(Console.ReadLine());

        // Запуск двух потоков для суммирования степеней
        Thread thread1 = new Thread(SumOfPowers);
        Thread thread2 = new Thread(SumOfPowers);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        // Запуск одного потока для произведения степеней
        Thread thread3 = new Thread(ProductOfPowers);
        thread3.Start();
        thread3.Join();

        Console.WriteLine("Все потоки завершены.");
    }
}
