using System;

namespace LambdaArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Лямбда операторы для арифметических действий
            Func<double, double, double> Add = (a, b) => a + b;
            Func<double, double, double> Sub = (a, b) => a - b;
            Func<double, double, double> Mul = (a, b) => a * b;
            Func<double, double, double> Div = (a, b) =>
            {
                if (b == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    return double.NaN;
                }
                return a / b;
            };

            // Запрос у пользователя ввода
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию (+, -, *, /):");
            string operation = Console.ReadLine();

            // Выполнение выбранной операции
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = Add(num1, num2);
                    break;
                case "-":
                    result = Sub(num1, num2);
                    break;
                case "*":
                    result = Mul(num1, num2);
                    break;
                case "/":
                    result = Div(num1, num2);
                    break;
                default:
                    Console.WriteLine("Неизвестная операция.");
                    return;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}
