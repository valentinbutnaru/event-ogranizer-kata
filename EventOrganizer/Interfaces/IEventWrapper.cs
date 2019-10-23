using System.Collections.Generic;

namespace EventOrganizer
{
    public interface IEventWrapper
    {
        List<EventModel> SetEvents(string[] array, List<EventModel> events);
    }
}