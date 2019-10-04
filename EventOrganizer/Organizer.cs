using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer
{
    public class Organizer
    {
        private List<Event> events = new List<Event>();
        private List<Conflict> conflicts = new List<Conflict>();
        public Organizer(List<Event> events)
        {
            this.events = events;
        }
        public string Arrange()
        {
            if (ConflictExisting(events) ==true)
            {
                PeriodConflict p = new PeriodConflict();
                conflicts = p.ConflictDetermination(events);
                return SettingResult();
            }
            else return "All ok no conflicts found";
        }

        public bool ConflictExisting(List<Event> events)
        {
            
            for (int i = 0;i<events.Count;i++)
            {
                for (int k =0; k <events.Count;k++)
                {
                    if (events[i].FinishTime<=events[k].StartTime && events[k].FinishTime<=events[i].StartTime)
                        return false;

                }
            }
            return true;
        }
        public string SettingResult()
        {
            string result;
            StringBuilder sb = new StringBuilder();
            foreach (var s in conflicts)
            {
                sb.Append(s.ConflictName+" "+s.StartingTimeOfConflict+" "+s.FinishingTimeOfConflict);
            }
            result = sb.ToString();
            return result;
        }
    }
}
