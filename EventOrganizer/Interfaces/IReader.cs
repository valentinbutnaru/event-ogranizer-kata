using System.Collections.Generic;

namespace EventOrganizer
{
    public interface IReader
    {

        List<EventModel> ReadingFile(string path, List<EventModel> events);
    }
}