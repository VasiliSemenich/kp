using System;

class Student
{
    private string name;
    private double averageScore;

    public Student(string name, double averageScore)
    {
        this.name = name;
        this.averageScore = averageScore;
    }

    public string Name
    {
        get { return name; }
    }

    public double AverageScore
    {
        get { return averageScore; }
    }

    public virtual double CalculateScholarship()
    {
        return 300000 + 10000 * (averageScore - 5);
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Студент: {name}, Средний балл: {averageScore}, Стипендия: {CalculateScholarship()}");
    }
}

class Master : Student
{
    private string specialization;
    private double scholarshipIncrease;

    public Master(string name, double averageScore, string specialization, double scholarshipIncrease)
        : base(name, averageScore)
    {
        this.specialization = specialization;
        this.scholarshipIncrease = scholarshipIncrease;
    }

    public string Specialization
    {
        get { return specialization; }
    }

    public override double CalculateScholarship()
    {
        return base.CalculateScholarship() + scholarshipIncrease;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Магистр: {Name}, Средний балл: {AverageScore}, Специальность: {specialization}, Стипендия: {CalculateScholarship()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта базового класса
        Student student = new Student("Иван Иванов", 7);
        student.DisplayInfo();

        // Создание объекта производного класса
        Master master = new Master("Петр Петров", 8, "Программирование", 5000);
        master.DisplayInfo();
    }
}
