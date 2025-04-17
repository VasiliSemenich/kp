using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрашиваем ввод числа N от пользователя
        Console.Write("Введите целое число N (1 <= N <= 20): ");
        int n = int.Parse(Console.ReadLine());

        // Вычисляем сумму 1 + 1/2 + 1/3 + ... + 1/N
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i;
        }

        // Выводим результат с точностью до 4 знаков после запятой
        Console.WriteLine($"Сумма 1 + 1/2 + 1/3 + ... + 1/N = {sum:F4}");
    }
}

