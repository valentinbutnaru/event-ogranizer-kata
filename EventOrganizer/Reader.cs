using System;
using System.Collections.Generic;
using System.IO;

namespace EventOrganizer
{
    public class Reader
    {
        public string Path { get; set; }


        public Reader(string Path)
        {
            this.Path = Path;
        }
        public List<Event> ReadingFile(List<Event> events)
        {
            if (events == null)
                throw new ArgumentNullException("The list cant be null");

            if (string.IsNullOrEmpty(Path))
                throw new ArgumentException("The path cant be null or empty");

            using (StreamReader sr = new StreamReader(Path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] array = line.Split(',');

                    events=SetEvents(array,events);
                }

            }
            return events;
        }
        public List<Event> SetEvents (string [] array,List<Event> events)
        {
            events.Add(new Event(array[0], Convert.ToDateTime(array[1]), Convert.ToDateTime(array[2])));
            return events;
        }
    }
}
