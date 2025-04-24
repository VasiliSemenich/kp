using System;
using System.Linq;

class Program
{
    // Структура TRAIN
    struct TRAIN
    {
        public string Destination; // Название пункта назначения
        public int TrainNumber;    // Номер поезда
        public string DepartureTime; // Время отправления
    }
        
    static void Main(string[] args)
    {
        const int SIZE = 8;
        TRAIN[] trains = new TRAIN[SIZE];

        // Ввод данных о поездах
        for (int i = 0; i < SIZE; i++)
        {
            Console.WriteLine($"Введите данные для поезда {i + 1}:");
            Console.Write("Пункт назначения: ");
            trains[i].Destination = Console.ReadLine();
            Console.Write("Номер поезда: ");
            trains[i].TrainNumber = int.Parse(Console.ReadLine());
            Console.Write("Время отправления (например, 14:30): ");
            trains[i].DepartureTime = Console.ReadLine();
            Console.WriteLine();
        }

        // Сортировка массива поездов по номерам
        trains = trains.OrderBy(t => t.TrainNumber).ToArray();

        // Запрос номера поезда для поиска
        Console.Write("Введите номер поезда для поиска: ");
        int searchNumber = int.Parse(Console.ReadLine());

        // Поиск информации о поезде
        var foundTrain = trains.FirstOrDefault(t => t.TrainNumber == searchNumber);
        if (foundTrain.TrainNumber != 0)
        {
            Console.WriteLine("Поезд найден!");
            Console.WriteLine($"Пункт назначения: {foundTrain.Destination}");
            Console.WriteLine($"Номер поезда: {foundTrain.TrainNumber}");
            Console.WriteLine($"Время отправления: {foundTrain.DepartureTime}");
        }
        else
        {
            Console.WriteLine($"Поезд с номером {searchNumber} не найден.");
        }
    }
}
