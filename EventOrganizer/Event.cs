using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        public void SetVariables()
        {

        }
        public void ReadingFile(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("The path cant be null or empty");

            using (StreamReader sr = new StreamReader(path))
            {
                string line;


                while ((line = sr.ReadLine()) != null)
                {
                    events.Add(line);
                }
            }
        }
    }
}
