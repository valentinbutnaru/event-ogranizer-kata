using System;
using System.Collections.Generic;

namespace EventOrganizer
{
    public class EventControl
    {
        private List<Event> events = new List<Event>();
        public string Path { get; set; }
        public string Result { get; set; }

        private Organizer organizer;

        private Reader reader;
        public EventControl (string path)
        {
            this.Path = path;
        }
 
        public void SetCalendar ()
        {
            reader = new Reader(Path);
            events=reader.ReadingFile(events);
            organizer = new Organizer(events);
            Result = organizer.Arrange();         
        }
        public void DisplayEvent()
        {
            Console.WriteLine("The conflicts are \n" +Result);
        }
    }
}
