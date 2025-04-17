using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрашиваем у пользователя ввод курса доллара
        Console.Write("Введите текущий курс доллара (1 USD = ? RUB): ");
        double usdToRubRate = double.Parse(Console.ReadLine());

        // Запрашиваем у пользователя выбор метода
        Console.WriteLine("\nВыберите метод для вывода таблицы:");
        Console.WriteLine("1. Цикл while");
        Console.WriteLine("2. Цикл do-while");
        Console.WriteLine("3. Цикл for");
        Console.Write("Введите номер метода (1-3): ");
        int choice = int.Parse(Console.ReadLine());

        // Выводим таблицу перевода в зависимости от выбранного метода
        Console.WriteLine("\nТаблица перевода долларов США в рубли:");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Доллары США | Рубли");
        Console.WriteLine("------------------------------------");

        switch (choice)
        {
            case 1:
                PrintTableWithWhile(usdToRubRate);
                break;
            case 2:
                PrintTableWithDoWhile(usdToRubRate);
                break;
            case 3:
                PrintTableWithFor(usdToRubRate);
                break;
            default:
                Console.WriteLine("Неверный выбор метода.");
                return;
        }

        Console.WriteLine("------------------------------------");
    }

    static void PrintTableWithWhile(double usdToRubRate)
    {
        int dollars = 5;
        while (dollars <= 500)
        {
            double rubles = dollars * usdToRubRate;
            Console.WriteLine($"{dollars,10} | {rubles,10:F2}");
            dollars += 5;
        }
    }

    static void PrintTableWithDoWhile(double usdToRubRate)
    {
        int dollars = 5;
        do
        {
            double rubles = dollars * usdToRubRate;
            Console.WriteLine($"{dollars,10} | {rubles,10:F2}");
            dollars += 5;
        } while (dollars <= 500);
    }

    static void PrintTableWithFor(double usdToRubRate)
    {
        for (int dollars = 5; dollars <= 500; dollars += 5)
        {
            double rubles = dollars * usdToRubRate;
            Console.WriteLine($"{dollars,10} | {rubles,10:F2}");
        }
    }
}