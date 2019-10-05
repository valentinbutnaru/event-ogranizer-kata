using System;


namespace EventOrganizer
{
    public class Period
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Period() { }
        public Period(DateTime start, DateTime end)
        {
            StartTime = start;
            EndTime = end;
        }
    }
}
