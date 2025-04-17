using System;

public class GigaChat
{
    public static void Main(string[] args)
    {
        // Запрашиваем у пользователя ввод параметров a, b и h
        Console.Write("Введите значение a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите значение b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите значение h: ");
        double h = double.Parse(Console.ReadLine());

        // Создаем таблицу для отображения результатов
        Console.WriteLine("x\ty");
        Console.WriteLine("---\t---");

        // Вычисляем и выводим значения функции f(x)
        for (double x = a; x <= b; x += h)
        {
            double y;
            if (3 * x <= 1)
            {
                y = Math.Pow(a + x, 1.0 / 3.0) - Math.Log(Math.Pow(x, 3));
            }
            else if (1 < 3 * x && 3 * x <= 10)
            {
                y = 6 * Math.Pow(x, 2) - a * x;
            }
            else
            {
                y = Math.Pow(b + x, 1.0 / 3.0) + 1.0 / Math.Pow(x, 3);
            }
            Console.WriteLine($"{x:F2}\t{y:F2}");
        }
    }
}