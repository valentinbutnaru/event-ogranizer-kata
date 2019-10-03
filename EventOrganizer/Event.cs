using System;

namespace EventOrganizer
{
    public class Event
    {

        public string EventName { get; }

        public DateTime StartTime { get; set; }

        public DateTime FinishTime { get; set; }

        public Event(string EventName, DateTime StartTime, DateTime FinishTime)
        {
            this.EventName = EventName;
            this.StartTime = StartTime;
            this.FinishTime = FinishTime;
        }

    }
}
