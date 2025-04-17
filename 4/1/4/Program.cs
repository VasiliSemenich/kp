using System;

class Program
{
    // Метод для нахождения наименьшего из двух чисел
    public static int Min(int a, int b)
    {
        return a < b ? a : b;
    }

    // Перегруженный метод для нахождения наименьшего из трех чисел
    public static int Min(int a, int b, int c)
    {
        return Min(Min(a, b), c);
    }

    static void Main(string[] args)
    {
        // Ввод значений с клавиатуры
        Console.WriteLine("Введите a1:");
        int a1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите b1:");
        int b1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите a2:");
        int a2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите b2:");
        int b2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите c2:");
        int c2 = int.Parse(Console.ReadLine());

        // Вычисление результата Min(a1, b1) * Min(a2, b2, c2)
        int result = Min(a1, b1) * Min(a2, b2, c2);

        Console.WriteLine($"Результат: {result}");
    }
}
