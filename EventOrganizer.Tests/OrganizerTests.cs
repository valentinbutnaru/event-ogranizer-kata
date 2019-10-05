using System;
using System.Collections.Generic;
using Xunit;

namespace EventOrganizer.Tests
{
    public class OrganizerTests
    {
        [Fact]
        public void Arrange_NoConflictResult ()
        {
            string expected = "All ok no conflicts founded";

            List<Event> events = new List<Event>();

            events.Add(new Event("Gala", Convert.ToDateTime("2009-06-15 16:32:00"), Convert.ToDateTime("2009-06-15 19:32:00")));

            events.Add(new Event("Lunch", Convert.ToDateTime("2001-06-15 12:32:00"), Convert.ToDateTime("2001-06-15 17:32:00")));

            Organizer o = new Organizer();

            string act = o.Arrange(events);

            Assert.Equal(expected, act);
        }

        [Fact]
        public void Arrange_FoundConflictResult()
        {
            string expected = "\nTime conflict between Gala and Sala 6/15/2009 4:32:00 PM 6/15/2009 7:32:00 PM";

            List<Event> events = new List<Event>();

            events.Add(new Event("Gala", Convert.ToDateTime("2009-06-15 16:32:00"), Convert.ToDateTime("2009-06-15 19:32:00")));

            events.Add(new Event("Lunch", Convert.ToDateTime("2009-06-15 16:32:00"), Convert.ToDateTime("2009-06-15 19:32:00")));

            Organizer o = new Organizer();

            string act = o.Arrange(events);

            Assert.Equal(expected, act);
        }
        [Fact]
        public void Arrange_NullListException()
        {
            List<Event> events = null;

            Organizer o = new Organizer();

            Action act = () => o.Arrange(events);

            Assert.Throws<ArgumentNullException>("Theres cant be null lists",act);
        }
        
        [Fact]
        public void Arrange_EmptyListException()
        {
            List<Event> events = new List<Event>();

            Organizer o = new Organizer();

            Action act = () => o.Arrange(events);

            Assert.Throws<ArgumentException>("Lists cant be empty", act);
        }
    }
}
