using System;

namespace DelegateExample
{
    // Определяем тип делегата
    public delegate double CalcFigure(double radius);

    class Program
    {
        // Статический метод для вычисления длины окружности
        public static double Get_Length(double radius)
        {
            return 2 * Math.PI * radius;
        }

        // Статический метод для вычисления площади круга
        public static double Get_Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Статический метод для вычисления объема шара
        public static double Get_Volume(double radius)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        static void Main(string[] args)
        {
            // Создаем экземпляр делегата, ссылаясь на метод
            CalcFigure CF;

            // Радиус для вычислений
            double radius = 5.0;

            // Вычисляем длину окружности
            CF = Get_Length;
            Console.WriteLine($"Длина окружности: {CF(radius):F2}");

            // Вычисляем площадь круга
            CF = Get_Area;
            Console.WriteLine($"Площадь круга: {CF(radius):F2}");

            // Вычисляем объем шара
            CF = Get_Volume;
            Console.WriteLine($"Объем шара: {CF(radius):F2}");
        }
    }
}
