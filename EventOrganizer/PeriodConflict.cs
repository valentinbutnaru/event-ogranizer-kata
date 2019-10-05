using System;
using System.Collections.Generic;
using System.Linq;


namespace EventOrganizer
{
    public class PeriodConflict
    {
        public DateTime StartOfTheConflict { get; set; }
        public DateTime EndOfTheConflict { get; set; }
        
        public PeriodConflict(){}

        public List<Conflict> ConflictDetermination (List<Event> events)
        {
            if (events == null)
                throw new ArgumentNullException("The list cant be null");

            if (events.Count == 0)
                throw new ArgumentException("The list cant be empty");

            List<Conflict> conflicts = new List<Conflict>();
            for (int i = 0; i < events.Count(); i++)
            {
                for(int k = i + 1; k < events.Count(); k++)
                {
                    Period p = new Period();
                    if (events[i].StartTime < events[k].FinishTime && events[i].FinishTime > events[k].StartTime)
                    {
                        p = PeriodOfConflict(events[i], events[k]);
                        conflicts.Add(new Conflict("\nTime conflict between " + events[i].EventName + " and " + events[k].EventName, p.StartTime, p.EndTime));
                    }                   
                }
            }
            return conflicts;
        }
        public Period PeriodOfConflict (Event e1,Event e2)
        {
                return new Period(e1.StartTime, e2.FinishTime);
        }
    }
}
