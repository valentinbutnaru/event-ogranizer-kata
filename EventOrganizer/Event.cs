using System;

namespace EventOrganizer
{
    public class Event
    {

        public string EventName { get; }

        public DateTime StartTime { get; set; }

        public DateTime FinishTime { get; set; }

        public Event(string eventName, DateTime startTime, DateTime finishTime)
        {
            this.EventName = eventName;
            this.StartTime = startTime;
            this.FinishTime = finishTime;
        }

    }
}
