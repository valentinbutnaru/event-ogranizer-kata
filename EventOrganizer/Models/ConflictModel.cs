using System;

namespace EventOrganizer
{
    public class ConflictModel
    {
        public string ConflictName { get; set; }
        public DateTime StartingTimeOfConflict { get; set; }
        public DateTime FinishingTimeOfConflict { get; set; }

        public ConflictModel(string conflictName,DateTime startingTimeOfConflict,DateTime finishingTimeOfConflict)
        {
            this.ConflictName = conflictName;
            this.StartingTimeOfConflict = startingTimeOfConflict;
            this.FinishingTimeOfConflict = finishingTimeOfConflict;
        }
    }
}
