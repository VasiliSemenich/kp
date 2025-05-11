using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 3, 5, 9, 30, 67 }; // Исходный список значений
        int sumLimit = 535; // Условие выхода для суммы
        int productLimit = 535; // Условие выхода для произведения

        Console.WriteLine("Параллельное вычисление суммы и произведения:");

        Parallel.ForEach(numbers, (N, state) =>
        {
            int sum = 0;
            int product = 1;

            for (int i = 1; i <= N; i++)
            {
                sum += i;
                product *= i;

                if (sum > sumLimit || product > productLimit)
                {
                    Console.WriteLine($"Прерывание вычислений для N = {N}: сумма = {sum}, произведение = {product}");
                    state.Break(); // Прерываем выполнение
                    return;
                }
            }

            Console.WriteLine($"N = {N}, сумма = {sum}, произведение = {product}");
        });

        Console.WriteLine("Вычисления завершены!");
    }
}
