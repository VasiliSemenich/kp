namespace ScheduleLibrary
{
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
}