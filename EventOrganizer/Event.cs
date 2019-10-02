using System;

namespace EventOrganizer
{
    public class Event: IEvent 
    {
        private string eventName;
        private DateTime startTime;
        private DateTime finishTime;
        public Event (string eventName,DateTime startTime,DateTime finishTime)
        {
            this.eventName = eventName;
            this.startTime = startTime;
            this.finishTime = finishTime;
        }

        public DateTime GetFinishTime()
        {
            return finishTime;
        }

        public string GetEventName()
        {
            return eventName;
        }

        public DateTime GetStartTime()
        {
            return startTime;
        }
        public void SetEventName(string e)
        {
            eventName = e;            
        }
        public void SetEventStart(DateTime start)
        {
            startTime = start;
        }
        public void SetEventFinish (DateTime finish)
        {
            finishTime = finish;
        }
    }
}
