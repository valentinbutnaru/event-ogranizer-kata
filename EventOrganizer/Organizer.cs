using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer
{
    public class Organizer
    {
        private List<Event> Events = new List<Event>();
        public Organizer(List<Event> events)
        {
            Events = events;
        }
        public void Arrange()
        {

        }
    }
}
