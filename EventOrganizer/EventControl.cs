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
                    events.Add(line);
                }
            }
        }
    }
}
