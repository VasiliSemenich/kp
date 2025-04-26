using System;

class A
{
    private int a;
    private int b;

    // Свойство вычисляет выражение: a + b
    public int C
    {
        get { return a + b; }
    }

    // Конструктор по умолчанию
    public A()
    {
        a = 0;
        b = 0;
    }

    // Конструктор с параметрами для инициализации полей
    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
}

class B : A
{
    private int d;

    // Свойство вычисляет выражение: (a + b) * d, использует управляющий оператор While
    public int C2
    {
        get
        {
            int result = 0;
            int count = d;
            while (count > 0)
            {
                result += C;
                count--;
            }
            return result;
        }
    }

    // Конструктор наследуемый от класса A
    public B(int a, int b) : base(a, b)
    {
        d = 1; // Значение по умолчанию для поля d
    }

    // Собственный конструктор для инициализации всех полей
    public B(int a, int b, int d) : base(a, b)
    {
        this.d = d;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта класса A
        A objA = new A(2, 3);
        Console.WriteLine($"Значение свойства C в классе A: {objA.C}");

        // Создание объекта класса B с использованием наследуемого конструктора
        B objB1 = new B(4, 5);
        Console.WriteLine($"Значение свойства C2 в классе B (конструктор 1): {objB1.C2}");

        // Создание объекта класса B с использованием собственного конструктора
        B objB2 = new B(6, 7, 2);
        Console.WriteLine($"Значение свойства C2 в классе B (конструктор 2): {objB2.C2}");
    }
}
