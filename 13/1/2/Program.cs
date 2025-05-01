using System;

namespace DelegateExample
{
    // Определяем делегат
    delegate void MessageDelegate();

    class Program
    {
        static void Main()
        {
            // Создаем экземпляр делегата, добавляя в него методы
            MessageDelegate messageDelegate = Message1;
            messageDelegate += Message2;
            messageDelegate += Message3;

            try
            {
                // Передаем делегат в метод и вызываем все методы
                ExecuteMessages(messageDelegate);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void ExecuteMessages(MessageDelegate messageDelegate)
        {
            Console.WriteLine("Вызываем делегат внутри метода:");
            messageDelegate.Invoke();
        }

         static void Message1()
        {
            Console.WriteLine("Первое сообщение: первое");
        }

        static void Message2()
        {
            Console.WriteLine("Второе сообщение: второе");
        }

        static void Message3()
        {
            Console.WriteLine("Третье сообщение: третье");
        }
    }
}
