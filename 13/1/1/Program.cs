using System;

namespace DelegateExample
{
    // Создаем делегат
    delegate void MessageDelegate();

    class Program
    {
        static void Main()
        {
            // Создаем экземпляр делегата и добавляем в него методы
            MessageDelegate messageDelegate = Message1;
            messageDelegate += Message2;
            messageDelegate += Message3;

            try
            {
                // Вызываем все три метода через делегат
                messageDelegate.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
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
