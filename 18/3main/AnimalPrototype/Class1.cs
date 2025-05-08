using System;
using System.Collections.Generic;

namespace AnimalLibrary
{
    // Интерфейс для клонирования
    public interface IPrototype<T>
    {
        T Clone();
    }

    // Базовый класс "Животное"
    public class AnimalPrototype : IPrototype<AnimalPrototype>
    {
        public string Name { get; set; }
        public int? Age { get; set; } // Обнуляемый тип (nullable)
        public string Species { get; set; }

        public AnimalPrototype(string name, int? age, string species)
        {
            Name = name;
            Age = age;
            Species = species;
        }

        // Метод клонирования
        public AnimalPrototype Clone()
        {
            return new AnimalPrototype(Name, Age, Species);
        }

        public override string ToString()
        {
            return $"Животное: {Name}, Возраст: {(Age.HasValue ? Age.ToString() : "Неизвестно")}, Вид: {Species}";
        }
    }
}
