using System;

class Program
{
    // Базовый класс
    public class BaseClass
    {
        public virtual string Name => "BaseClass";
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Класс: {Name}, Поля: Нет дополнительных полей");
        }
    }

    // Производный класс 1
    public class DerivedClass1 : BaseClass
    {
        public int Field1 { get; set; }
        public override string Name => "DerivedClass1";

        public override void DisplayInfo()
        {
            Console.WriteLine($"Класс: {Name}, Поле: Field1 = {Field1}");
        }
    }

    // Производный класс 2
    public class DerivedClass2 : BaseClass
    {
        public string Field2 { get; set; }
        public override string Name => "DerivedClass2";

        public override void DisplayInfo()
        {
            Console.WriteLine($"Класс: {Name}, Поле: Field2 = {Field2}");
        }
    }

    static void Main(string[] args)
    {
        // Создание объектов
        BaseClass obj1 = new BaseClass();
        BaseClass obj2 = new DerivedClass1 { Field1 = 42 };
        BaseClass obj3 = new DerivedClass2 { Field2 = "Hello" };
        BaseClass obj4 = new DerivedClass1 { Field1 = 15 };
        BaseClass obj5 = new DerivedClass2 { Field2 = "World" };

        // Полиморфный контейнер - массив ссылок базового класса
        BaseClass[] objects = { obj1, obj2, obj3, obj4, obj5 };

        // Вывод результатов работы методов на экран
        Console.WriteLine("Протокол работы:");
        foreach (var obj in objects)
        {
            obj.DisplayInfo();
        }
    }
}
