using System;
using System.Collections.Generic;
using AnimalLibrary;

class Program
{
    static void Main()
    {
        // Список животных (List<T>)
        List<AnimalPrototype> animals = new List<AnimalPrototype>();

        // Словарь животных (Dictionary<Key, Value>)
        Dictionary<int, AnimalPrototype> animalDictionary = new Dictionary<int, AnimalPrototype>();

        // Добавление животных
        AnimalPrototype lion = new AnimalPrototype("Лев", 5, "Хищник");
        AnimalPrototype elephant = new AnimalPrototype("Слон", null, "Травоядное"); // Обнуляемый тип (возраст неизвестен)

        animals.Add(lion);
        animals.Add(elephant);

        animalDictionary.Add(1, lion);
        animalDictionary.Add(2, elephant);

        // Клонирование животного
        AnimalPrototype clonedLion = lion.Clone();
        animals.Add(clonedLion);

        // Вывод списка животных
        Console.WriteLine("Список животных:");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }

        // Удаление животного
        animals.Remove(elephant);

        Console.WriteLine("\nПосле удаления:");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }

        // Вывод словаря животных
        Console.WriteLine("\nСловарь животных:");
        foreach (var kvp in animalDictionary)
        {
            Console.WriteLine($"ID: {kvp.Key}, {kvp.Value}");
        }
    }
}
