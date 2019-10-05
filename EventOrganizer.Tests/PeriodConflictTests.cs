using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using EventOrganizer;
namespace EventOrganizer.Tests
{
    public class PeriodConflictTests
    {
        [Fact]
        public void ConflictDetermination_ShouldReturnCorrectlist()
        {
            List<Event> events = new List<Event>
            {
                new Event("Gala", Convert.ToDateTime("2009-06-15 16:32:00"), Convert.ToDateTime("2009-06-15 19:32:00")),
                new Event("Lunch",Convert.ToDateTime("2009-06-15 16:32:00"), Convert.ToDateTime("2009-06-15 19:32:00"))
            };

            PeriodConflict p = new PeriodConflict();

            List<Conflict> expected = new List<Conflict>
            {
                new Conflict("\nTime conflict between " + "Gala" + " and " + "Lunch", Convert.ToDateTime("2009-06-15 16:32:00"), Convert.ToDateTime("2009-06-15 19:32:00"))
            };

            List<Conflict> act = p.ConflictDetermination(events);

            Assert.Equal(expected, act);
        }

        [Fact]
        public void ConflictDetermination_NullListException()
        {
            List<Event> e = null;

            PeriodConflict p = new PeriodConflict();

            Action act = () => p.ConflictDetermination(e);

            Assert.Throws<ArgumentNullException>("The list cant be null", act);
        }

        [Fact]
        public void ConflictDetermination_EmptyListException()
        {
            List<Event> e = new List<Event>();

            PeriodConflict p = new PeriodConflict();

            Action act = () => p.ConflictDetermination(e);

            Assert.Throws<ArgumentException>("The lsit cant be empty", act);
        }
    }
}
