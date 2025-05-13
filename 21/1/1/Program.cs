using System;

// Интерфейс состояния 
public interface IState
{
    void InsertQuarter();    // Бросить монету
    void EjectQuarter();     // Вернуть монету
    void TurnCrank();        // Дернуть рычаг
    void Dispense();         // Выдать шарик
}

// Конкретные состояния 
// Состояние "Нет монеты"
public class NoQuarterState : IState
{
    private readonly GumballMachine _machine;

    public NoQuarterState(GumballMachine machine) => _machine = machine;

    public void InsertQuarter()
    {
        Console.WriteLine("Монета принята!");
        _machine.SetState(_machine.HasQuarterState);
    }

    public void EjectQuarter() => Console.WriteLine("Вы не вставили монету!");

    public void TurnCrank() => Console.WriteLine("Сначала вставьте монету!");

    public void Dispense() => Console.WriteLine("Сначала заплатите!");
}

// "Монета вставлена"
public class HasQuarterState : IState
{
    private readonly GumballMachine _machine;
    private readonly Random _random = new Random();

    public HasQuarterState(GumballMachine machine) => _machine = machine;

    public void InsertQuarter() => Console.WriteLine("Монета уже вставлена!");

    public void EjectQuarter()
    {
        Console.WriteLine("Монета возвращена!");
        _machine.SetState(_machine.NoQuarterState);
    }

    public void TurnCrank()
    {
        Console.WriteLine("Рычаг повернут...");
        if (_random.Next(10) == 0 && _machine.Count > 1)
            _machine.SetState(_machine.WinnerState);
        else
            _machine.SetState(_machine.SoldState);
    }

    public void Dispense() => Console.WriteLine("Шарик не выдан!");
}

// Состояние "Шарик продан"
public class SoldState : IState
{
    private readonly GumballMachine _machine;

    public SoldState(GumballMachine machine) => _machine = machine;

    public void InsertQuarter() => Console.WriteLine("Подождите, шарик уже выдается!");

    public void EjectQuarter() => Console.WriteLine("Извините, вы уже дернули рычаг!");

    public void TurnCrank() => Console.WriteLine("Не дергайте дважды!");

    public void Dispense()
    {
        _machine.ReleaseBall();
        if (_machine.Count > 0)
            _machine.SetState(_machine.NoQuarterState);
        else
        {
            Console.WriteLine("Упс, шарики закончились!");
            _machine.SetState(_machine.SoldOutState);
        }
    }
}

// Состояние "Шарики закончились"
public class SoldOutState : IState
{
    private readonly GumballMachine _machine;

    public SoldOutState(GumballMachine machine) => _machine = machine;

    public void InsertQuarter() => Console.WriteLine("Автомат пуст, монета возвращена!");

    public void EjectQuarter() => Console.WriteLine("Вы не вставили монету!");

    public void TurnCrank() => Console.WriteLine("Шариков нет!");

    public void Dispense() => Console.WriteLine("Ничего не выдано!");
}

// Состояние "Выигрыш" (дополнительный шарик)
public class WinnerState : IState
{
    private readonly GumballMachine _machine;

    public WinnerState(GumballMachine machine) => _machine = machine;

    public void InsertQuarter() => Console.WriteLine("Подождите, шарик уже выдается!");

    public void EjectQuarter() => Console.WriteLine("Извините, вы уже дернули рычаг!");

    public void TurnCrank() => Console.WriteLine("Не дергайте дважды!");

    public void Dispense()
    {
        Console.WriteLine("ПОЗДРАВЛЯЕМ! Вы выиграли второй шарик!");
        _machine.ReleaseBall();
        if (_machine.Count == 0)
            _machine.SetState(_machine.SoldOutState);
        else
        {
            _machine.ReleaseBall();
            _machine.SetState(_machine.Count > 0 ? _machine.NoQuarterState : _machine.SoldOutState);
        }
    }
}

// Класс автомата (GumballMachine)
public class GumballMachine
{
    public IState NoQuarterState { get; }
    public IState HasQuarterState { get; }
    public IState SoldState { get; }
    public IState SoldOutState { get; }
    public IState WinnerState { get; }

    public IState CurrentState { get; private set; }
    public int Count { get; private set; }

    public GumballMachine(int count)
    {
        NoQuarterState = new NoQuarterState(this);
        HasQuarterState = new HasQuarterState(this);
        SoldState = new SoldState(this);
        SoldOutState = new SoldOutState(this);
        WinnerState = new WinnerState(this);

        Count = count;
        CurrentState = count > 0 ? NoQuarterState : SoldOutState;
    }

    public void InsertQuarter() => CurrentState.InsertQuarter();
    public void EjectQuarter() => CurrentState.EjectQuarter();
    public void TurnCrank()
    {
        CurrentState.TurnCrank();
        CurrentState.Dispense();
    }

    public void SetState(IState state) => CurrentState = state;

    public void ReleaseBall()
    {
        Console.WriteLine("Шарик выдан!");
        if (Count > 0) Count--;
    }
}

// Тестирование
class Program
{
    static void Main()
    {
        var gumballMachine = new GumballMachine(5);

        Console.WriteLine($"Шариков в автомате: {gumballMachine.Count}");

        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();

        gumballMachine.InsertQuarter();
        gumballMachine.EjectQuarter();
        gumballMachine.TurnCrank();

        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.EjectQuarter();

        Console.WriteLine($"Осталось шариков: {gumballMachine.Count}");
    }
}