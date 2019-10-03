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
        private List<Event> events = new List<Event>();
        public string Path { get; set; }

        private Reader reader;
        public EventControl (string path)
        {
            this.Path = path;
        }
 
        public void SetList ()
        {
            reader = new Reader(Path);
            events = reader.ReadingFile();
        }

    }
}
