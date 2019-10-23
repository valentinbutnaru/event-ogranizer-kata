namespace EventOrganizer
{
    public interface IEventControl
    {
        string Result { get; set; }

        void SetCalendar(string path);
    }
}