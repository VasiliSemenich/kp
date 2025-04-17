using System;

namespace Fir
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем ввод трехзначного числа с различными цифрами
            Console.Write("Введите трехзначное число с различными цифрами: ");
            int originalNumber = int.Parse(Console.ReadLine());

            // Извлекаем цифры из числа
            int digit1 = originalNumber / 100;
            int digit2 = (originalNumber / 10) % 10;
            int digit3 = originalNumber % 10;

            // Выводим все возможные перестановки
            Console.WriteLine("Перестановки чисел:");
            Console.WriteLine($"{digit1}{digit2}{digit3}");
            Console.WriteLine($"{digit1}{digit3}{digit2}");
            Console.WriteLine($"{digit2}{digit1}{digit3}");
            Console.WriteLine($"{digit2}{digit3}{digit1}");
            Console.WriteLine($"{digit3}{digit1}{digit2}");
            Console.WriteLine($"{digit3}{digit2}{digit1}");
        }
    }
}