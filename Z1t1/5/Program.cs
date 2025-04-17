using System;

namespace Fir
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем ввод времени в минутах
            Console.Write("Введите величину временного интервала (в минутах): ");
            int minutes = int.Parse(Console.ReadLine());

            // Вычисляем часы и минуты
            int hours = minutes / 60;
            int remainingMinutes = minutes % 60;

            // Выводим результат
            Console.WriteLine($"{minutes} минут — это {hours}ч. {remainingMinutes}мин.");
        }
    }
}