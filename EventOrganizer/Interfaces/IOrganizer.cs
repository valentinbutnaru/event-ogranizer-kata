using System.Collections.Generic;

namespace EventOrganizer
{
    public interface IOrganizer
    {
        string Arrange(List<EventModel> events);
    }
}