using System;

namespace EventOrganizer
{
    public class EventModel
    {

        public string EventName { get; }

        public DateTime StartTime { get; set; }

        public DateTime FinishTime { get; set; }

        public EventModel(string eventName, DateTime startTime, DateTime finishTime)
        {
            this.EventName = eventName;
            this.StartTime = startTime;
            this.FinishTime = finishTime;
        }

    }
}
