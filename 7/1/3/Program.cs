using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();

        // Разбиваем предложение на слова
        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length < 3)
        {
            Console.WriteLine("Предложение должно содержать минимум три слова.");
            return;
        }

        // Меняем местами первое и последнее слова
        (words[0], words[^1]) = (words[^1], words[0]);

        Console.WriteLine("Поменяли местами первое и последнее слова:");
        Console.WriteLine(string.Join(" ", words));

        // Склеиваем второе и третье слова
        string concatenated = words[1] + words[2];
        Console.WriteLine("Склеили второе и третье слова:");
        Console.WriteLine(concatenated);

        // Третье слово в обратном порядке
        string reversedThirdWord = new string(words[2].Reverse().ToArray());
        Console.WriteLine("Третье слово в обратном порядке:");
        Console.WriteLine(reversedThirdWord);

        // Вырезаем первые две буквы из первого слова
        string trimmedFirstWord = words[0].Length > 2 ? words[0][2..] : string.Empty;
        Console.WriteLine("Первое слово без первых двух букв:");
        Console.WriteLine(trimmedFirstWord);
    }
}
