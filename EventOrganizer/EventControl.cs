using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EventOrganizer
{
    public class EventControl
    {
        private List<IEvent> events = new List<IEvent>();
        public void ReadingFileEvents(string path)
        {

            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("The path cant be null or empty");
                
            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[]  array = line.Split(',');

                    DateTime first = DateTime.ParseExact(array[1], "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    DateTime second = DateTime.Parse(array[2]);
                    SetEvents(array);
                }
            
            }

        }
        public void SetEvents(string[] array)
        {
            //DateTime first = DateTime.Parse(array[1]);
            //DateTime second = DateTime.Parse(array[2]);
           // events.Add(new Event(array[0],dt,dt2));

        }
        public void Display()
        {
            foreach (var e in events)
                Console.WriteLine(e.GetEventName(), e.GetStartTime(), e.GetFinishTime());
        }
    }
}
