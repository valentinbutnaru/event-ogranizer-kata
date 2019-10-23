using System;
using System.Collections.Generic;
using System.IO;

namespace EventOrganizer
{
    public class FileReader : IReader
    {
        private readonly IEventWrapper _eventSetter;

        public FileReader(IEventWrapper eventSetter)
        {
            this._eventSetter = eventSetter;
        }
        public List<EventModel> ReadingFile(string path, List<EventModel> _events)
        {
            if (path == null)
                throw new ArgumentNullException("The path cant be null");


            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] array = line.Split(',');

                    _events = _eventSetter.SetEvents(array, _events);
                }

            }
            return _events;
        }
     
    }
}
