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

class Program
{
    static void Main()
    {
        MyList<int> myList = new MyList<int>();

        myList.Add(10);
        myList.Add(20);
        myList.Add(30);

        Console.WriteLine($"Элемент с индексом 1: {myList[1]}"); // Вывод: 20
        Console.WriteLine($"Общее количество элементов: {myList.Count}"); // Вывод: 3
    }
}
