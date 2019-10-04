using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer
{
    public class Conflict
    {
        public string ConflictName { get; set; }
        public DateTime StartingTimeOfConflict { get; set; }
        public DateTime FinishingTimeOfConflict { get; set; }

        public Conflict(string conflictName,DateTime startingTimeOfConflict,DateTime finishingTimeOfConflict)
        {
            this.ConflictName = conflictName;
            this.StartingTimeOfConflict = startingTimeOfConflict;
            this.FinishingTimeOfConflict = finishingTimeOfConflict;
        }
    }
}
