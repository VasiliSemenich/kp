using System;

class Program
{
    static void Main(string[] args)
    {
        // Получаем радиус окружности от пользователя
        Console.Write("Введите радиус окружности: ");
        double radius = double.Parse(Console.ReadLine());

        // Вычисляем длину окружности
        double circumference = 2 * Math.PI * radius;

        // Вычисляем площадь круга
        double area = Math.PI * radius * radius;

        // Выводим результаты
        Console.WriteLine($"Длина окружности: {circumference:F2}");
        Console.WriteLine($"Площадь круга: {area:F2}");
    }
}