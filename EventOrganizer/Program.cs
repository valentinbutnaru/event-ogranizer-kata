using System;


namespace EventOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            Console.WriteLine("Introduce the path to txt directory");
            path = Console.ReadLine();
            EventControl e = new EventControl(path);
            e.SetCalendar();
            e.DisplayEvent();
            Console.Read();
        }
    }
}
