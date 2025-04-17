using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрашиваем ввод цены 1 кг конфет
        Console.Write("Введите цену 1 кг конфет (1 <= A <= 100): ");
        int pricePerKg = int.Parse(Console.ReadLine());

        // Выводим стоимость 1, 2, ..., 10 кг конфет
        Console.WriteLine("Стоимость конфет:");
        for (int i = 1; i <= 10; i++)
        {
            int cost = i * pricePerKg;
            Console.WriteLine($"{i} кг - {cost} руб.");
        }
    }
}