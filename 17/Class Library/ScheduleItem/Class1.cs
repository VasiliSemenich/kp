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
}