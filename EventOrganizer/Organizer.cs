using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventOrganizer
{
    public class Organizer
    {
        private List<Conflict> conflicts = new List<Conflict>();

        public Organizer() { }

        public string Arrange(List<Event> events)
        {
            if (events == null)
                throw new ArgumentNullException("Theres cant be null lists");

            if (events.Count() == 0)
                throw new ArgumentException("Lists cant be empty");

                PeriodConflict p = new PeriodConflict();
                conflicts = p.ConflictDetermination(events);

                return SettingResult();          
        }       

        public string SettingResult()
        {
            string result;
            StringBuilder sb = new StringBuilder();
            if (conflicts.Count()==0)
                sb.Append("All ok no conflicts founded");

            foreach (var s in conflicts)
            {
                sb.Append(s.ConflictName+" "+s.StartingTimeOfConflict+" "+s.FinishingTimeOfConflict);
            }
            result = sb.ToString();
            return result;
        }
    }
}
