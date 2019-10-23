using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventOrganizer
{
    public class Organizer : IOrganizer
    {
        private  List<ConflictModel> _conflicts ;

        private readonly IPeriodConflict _periodConflict;

        public Organizer(IPeriodConflict periodConflict, List<ConflictModel> conflicts)
        {
            this._conflicts = conflicts;
            this._periodConflict = periodConflict;
        }

        public string Arrange(List<EventModel> events)
        {
            if (events == null)
                throw new ArgumentNullException("Theres cant be null lists");

            _conflicts = _periodConflict.ConflictDetermination(events, _conflicts);

            return SettingResult();
        }

        private string SettingResult()
        {
            string result;
            StringBuilder sb = new StringBuilder();
            if (_conflicts.Count() == 0)
                sb.Append("All ok no conflicts founded");

            foreach (var s in _conflicts)
            {
                sb.Append(s.ConflictName + " " + s.StartingTimeOfConflict + " " + s.FinishingTimeOfConflict);
            }
            result = sb.ToString();
            return result;
        }
    }
}
