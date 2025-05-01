using System;

class MyInfo
{
    private string _name;

    // Создаем событие для уведомления об изменении имени
    public event Action<string> NameChanged;

    public string Name
    {
        get => _name;
        set
        {
            if (_name != value)
            {
                _name = value;
                // Вызываем событие при изменении имени
                NameChanged?.Invoke(_name);
            }
        }
    }

    public MyInfo(string initialName)
    {
        _name = initialName;
    }
}

class Program
{
    static void Main()
    {
        MyInfo info = new MyInfo("Vasil");

        // Подписываемся на событие и выводим сообщение при изменении имени
        info.NameChanged += newName => Console.WriteLine($"Оповещение: Имя изменилось на {newName}");

        // Изменяем имя
        info.Name = "Alex";
        info.Name = "Elena";
    }
}
