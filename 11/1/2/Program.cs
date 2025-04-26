using System;

class Program
{
    // Абстрактный класс
    public abstract class BaseClass
    {
        public abstract string Name { get; }
        public abstract double GetIncome();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Класс: {Name}, Доход: {GetIncome()}");
        }
    }

    // Производный класс 1
    public class DerivedClass1 : BaseClass
    {
        public double Salary { get; set; }

        public override string Name => "DerivedClass1";

        public override double GetIncome()
        {
            return Salary;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Класс: {Name}, Зарплата: {Salary}, Доход: {GetIncome()}");
        }
    }

    // Производный класс 2
    public class DerivedClass2 : BaseClass
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public override string Name => "DerivedClass2";

        public override double GetIncome()
        {
            return HourlyRate * HoursWorked;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Класс: {Name}, Почасовая ставка: {HourlyRate}, Отработано часов: {HoursWorked}, Доход: {GetIncome()}");
        }
    }

    static void Main(string[] args)
    {
        // Создание объектов
        BaseClass obj1 = new DerivedClass1 { Salary = 50000 };
        BaseClass obj2 = new DerivedClass2 { HourlyRate = 20, HoursWorked = 160 };
        BaseClass obj3 = new DerivedClass1 { Salary = 75000 };
        BaseClass obj4 = new DerivedClass2 { HourlyRate = 25, HoursWorked = 120 };
        BaseClass obj5 = new DerivedClass2 { HourlyRate = 30, HoursWorked = 140 };

        // Полиморфный контейнер - массив объектов базового класса
        BaseClass[] objects = { obj1, obj2, obj3, obj4, obj5 };

        double totalIncome = 0;

        // Вывод протокола работы и расчет суммарного дохода
        Console.WriteLine("Протокол работы:");
        foreach (var obj in objects)
        {
            obj.DisplayInfo();
            totalIncome += obj.GetIncome();
        }

        Console.WriteLine($"\nСуммарный доход: {totalIncome}");
    }
}
