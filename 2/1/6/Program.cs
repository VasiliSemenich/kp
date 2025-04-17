using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрашиваем день
        Console.Write("Введите порядковый номер дня месяца: ");
        int dayNumber = int.Parse(Console.ReadLine());

        // Определяем количество дней в месяце
        int daysInMonth;
        switch (DateTime.Now.Month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                daysInMonth = 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                daysInMonth = 30;
                break;
            case 2:
                if (DateTime.Now.Year % 4 == 0 && (DateTime.Now.Year % 100 != 0 || DateTime.Now.Year % 400 == 0))
                    daysInMonth = 29;
                else
                    daysInMonth = 28;
                break;
            default:
                throw new Exception("Ошибка: неверный месяц");
        }

        // Вычисляем дни до конца месяца
        int daysRemaining = daysInMonth - dayNumber + 1;

        // результат
        Console.WriteLine($"Количество дней, оставшихся до конца месяца: {daysRemaining}");
    }
}