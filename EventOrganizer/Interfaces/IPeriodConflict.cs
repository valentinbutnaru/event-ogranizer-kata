using System;
using System.Collections.Generic;

namespace EventOrganizer
{
    public interface IPeriodConflict
    {
        List<ConflictModel> ConflictDetermination(List<EventModel> events , List<ConflictModel> conflicts);
    }
}