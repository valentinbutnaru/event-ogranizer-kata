using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer
{
    public class EventWrapper : IEventWrapper
    {
        public List<EventModel> SetEvents(string[] array, List<EventModel> events)
        {
            if (array == null)
                throw new ArgumentNullException("The array cant be null");

            events.Add(new EventModel(array[0], Convert.ToDateTime(array[1]), Convert.ToDateTime(array[2])));
            return events;
        }
    }
}
