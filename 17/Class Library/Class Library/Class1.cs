using System;

namespace ScheduleLibrary
{
    public class ScheduleItem
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public ScheduleItem(string title, DateTime date)
        {
            Title = title;
            Date = date;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Событие: {Title}, Дата: {Date}");
        }
    }
    public class Meeting : ScheduleItem
    {
        public string Location { get; set; }

        public Meeting(string title, DateTime date, string location)
            : base(title, date)
        {
            Location = location;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Встреча: {Title}, Дата: {Date}, Место: {Location}");
        }
    }
    public class Task : ScheduleItem
    {
        public bool IsCompleted { get; set; }

        public Task(string title, DateTime date, bool isCompleted)
            : base(title, date)
        {
            IsCompleted = isCompleted;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Задача: {Title}, Дата: {Date}, Статус: {(IsCompleted ? "Выполнено" : "Не выполнено")}");
        }
    }
}
