using System;
using System.Collections.Generic;
using System.IO;

namespace EventOrganizer
{
    public class Reader
    {
        public List<Event> Events = new List<Event>();
        public string Path { get; set; }

        public Reader(string Path)
        {
            this.Path = Path;
        }
        public List<Event> ReadingFile()
        {

            if (string.IsNullOrEmpty(Path))
                throw new ArgumentException("The path cant be null or empty");

            using (StreamReader sr = new StreamReader(Path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] array = line.Split(',');

                    Events=SetEvents(array);
                }

            }
            return Events;
        }
        public List<Event> SetEvents (string [] array)
        {
            Events.Add(new Event(array[0], Convert.ToDateTime(array[1]), Convert.ToDateTime(array[2])));
            return Events;
        }
    }
}
