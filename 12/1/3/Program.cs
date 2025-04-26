using System;

namespace StringDelegateExample
{
    // Определяем тип делегата
    public delegate string StringOperation(string input);

    class Program
    {
        // Метод 1: Изменение регистра строки на верхний
        public static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        // Метод 2: Реверс строки
        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Метод 3: Удаление пробелов из строки
        public static string RemoveSpaces(string input)
        {
            return input.Replace(" ", string.Empty);
        }

        static void Main(string[] args)
        {
            // Создаем экземпляр делегата и присваиваем ему первый метод
            StringOperation stringDelegate;

            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            // Вызываем метод ToUpperCase
            stringDelegate = ToUpperCase;
            Console.WriteLine("Верхний регистр: " + stringDelegate(input));

            // Вызываем метод ReverseString
            stringDelegate = ReverseString;
            Console.WriteLine("Реверс строки: " + stringDelegate(input));

            // Вызываем метод RemoveSpaces
            stringDelegate = RemoveSpaces;
            Console.WriteLine("Без пробелов: " + stringDelegate(input));
        }
    }
}
