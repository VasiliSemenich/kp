using System;

namespace EventObserverExample
{
    // Определяем делегат
    public delegate void MyEventHandler(string message);

    // Класс с событием
    class EventSource
    {
        public event MyEventHandler EventOccurred;

        public void TriggerEvent(string message)
        {
            EventOccurred?.Invoke(message);
        }
    }

    // Первый класс-наблюдатель
    class ObserverA
    {
        public void HandlerOne(string message)
        {
            Console.WriteLine($"ObserverA: Первый обработчик получил сообщение: {message}");
        }

        public void HandlerTwo(string message)
        {
            Console.WriteLine($"ObserverA: Второй обработчик получил сообщение: {message}");
        }
    }

    // Второй класс-наблюдатель
    class ObserverB
    {
        public void HandlerThree(string message)
        {
            Console.WriteLine($"ObserverB: Обработчик получил сообщение: {message}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Создаем источник события
            EventSource source = new EventSource();

            // Создаем наблюдателей
            ObserverA observerA = new ObserverA();
            ObserverB observerB = new ObserverB();

            // Добавляем два обработчика из ObserverA
            source.EventOccurred += observerA.HandlerOne;
            source.EventOccurred += observerA.HandlerTwo;

            // Добавляем один обработчик из ObserverB
            source.EventOccurred += observerB.HandlerThree;

            Console.WriteLine("Вызываем событие с тремя обработчиками:");
            source.TriggerEvent("Событие произошло!");

            // Удаляем один обработчик события
            source.EventOccurred -= observerA.HandlerOne;

            Console.WriteLine("\nВызываем событие после удаления одного обработчика:");
            source.TriggerEvent("Событие снова произошло!");
        }
    }
}
