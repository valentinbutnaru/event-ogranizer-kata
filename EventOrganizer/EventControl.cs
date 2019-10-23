using System;
using System.Collections.Generic;

namespace EventOrganizer
{
    public class EventControl : IEventControl
    {
        private List<EventModel> _events;
        public string Result { get; set; }

        private readonly IOrganizer _organizer;

        private readonly IReader _reader;

        public EventControl(IOrganizer organizer, IReader reader,List<EventModel> events)
        {
            this._events = events;
            this._organizer = organizer;
            this._reader = reader;
        }

        public void SetCalendar(string path)
        {
            if (path == null)
                throw new ArgumentNullException("The path cant be null");

            _events = _reader.ReadingFile(path, _events);
            Result = _organizer.Arrange(_events);

            DisplayEvent();
        }
        private void DisplayEvent()
        {
            Console.WriteLine("The conflicts are \n" + Result);
        }
    }
}
