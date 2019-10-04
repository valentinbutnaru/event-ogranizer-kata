using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer
{
    public class Period
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Period()
        {
                
        }
        public Period(DateTime start, DateTime end)
        {
            StartTime = start;
            EndTime = end;
        }
    }
}
