using System;


namespace EventOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\vbutnaru\Desktop\EventOrganizer\event-ogranizer-kata\Eveniments.txt";
            EventControl e = new EventControl(path);
            e.SetCalendar();
            e.DisplayEvent();
            Console.Read();
        }
    }
}
