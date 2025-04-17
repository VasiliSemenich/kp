using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрашиваем ввод числа от пользователя
        Console.Write("Введите четырехзначное число: ");
        string input = Console.ReadLine();

        // Проверяем, что введено четырехзначное число
        if (input.Length != 4)
        {
            Console.WriteLine("Ошибка: Число должно быть четырехзначным.");
            return;
        }

        // Проверяем, что число читается одинаково слева направо и справа налево
        bool isEqual = true;
        for (int i = 0; i < 2; i++)
        {
            if (input[i] != input[3 - i])
            {
                isEqual = false;
                break;
            }
        }

        // Выводим результат
        if (isEqual)
        {
            Console.WriteLine("Данное четырехзначное число читается одинаково слева направо и справа налево.");
        }
        else
        {
            Console.WriteLine("Данное четырехзначное число не читается одинаково слева направо и справа налево.");
        }
    }
}