using System;

class MyList<T>
{
    private T[] items;
    private int count;

    public MyList()
    {
        items = new T[4]; // Начальный размер массива
        count = 0;
    }

    public void Add(T item)
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2); // Увеличение размера массива
        }
        items[count] = item;
        count++;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Индекс выходит за пределы списка.");
            return items[index];
        }
    }

    public int Count => count;
}

// Расширяющий метод
static class MyListExtensions
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        T[] array = new T[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            array[i] = list[i];
        }
        return array;
    }
}

class Program
{
    static void Main()
    {
        MyList<int> myList = new MyList<int>();
        myList.Add(10);
        myList.Add(20);
        myList.Add(30);

        // Используем расширяющий метод
        int[] array = myList.GetArray();

        Console.WriteLine("Элементы массива:");
        Console.WriteLine(string.Join(", ", array)); // Вывод: 10, 20, 30
    }
}
