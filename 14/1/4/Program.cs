using System;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Ввод размера массива
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        // Генерация массива случайных натуральных чисел
        int[] numbers = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1, 101); // Числа от 1 до 100
        }

        // Вывод массива
        Console.WriteLine("Массив: " + string.Join(", ", numbers));

        // Количество потоков (можно выбрать динамически)
        int threadCount = Environment.ProcessorCount;

        // Разбиваем массив на части для обработки
        int chunkSize = size / threadCount;
        Task<int>[] tasks = new Task<int>[threadCount];

        for (int i = 0; i < threadCount; i++)
        {
            int start = i * chunkSize;
            int end = (i == threadCount - 1) ? size : start + chunkSize;

            tasks[i] = Task.Run(() => FindEvenSum(numbers, start, end));
        }

        // Дожидаемся выполнения всех потоков
        Task.WaitAll(tasks);

        // Итоговая сумма четных чисел
        int totalSum = tasks.Sum(t => t.Result);
        Console.WriteLine($"Сумма четных чисел = {totalSum}");
    }

    static int FindEvenSum(int[] arr, int start, int end)
    {
        int sum = 0;
        for (int i = start; i < end; i++)
        {
            if (arr[i] % 2 == 0)
            {
                sum += arr[i];
            }
        }
        return sum;
    }
}
