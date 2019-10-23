using System;
using System.Collections.Generic;
using System.Linq;


namespace EventOrganizer
{
    public class PeriodConflict : IPeriodConflict
    {

        public List<ConflictModel> ConflictDetermination(List<EventModel> events, List<ConflictModel> conflicts)
        {
            if (events == null)
                throw new ArgumentNullException("The list cant be null");

            for (int i = 0; i < events.Count(); i++)
            {
                for (int k = i + 1; k < events.Count(); k++)
                {
                    if (events[i].StartTime < events[k].FinishTime && events[i].FinishTime > events[k].StartTime)
                    {
                        conflicts.Add(new ConflictModel("\nTime conflict between " + events[i].EventName + " and " + events[k].EventName, events[i].StartTime, events[k].FinishTime));
                    }
                }
            }
            return conflicts;
        }
    }
}
