using System;
using System.Collections.Generic;
using Xunit;
using Moq;

namespace EventOrganizer.Tests
{
   public class EventControlsTests
    {
        [Fact]
        public void SetCalendar_CallingArrange()
        {
            var read = new Mock<IReader>();
            var org = new Mock<IOrganizer>();
            string path = "path";
            var events = new List<EventModel>();
            read.Setup(r => r.ReadingFile(path, events)).Returns(events);
            EventControl e = new EventControl(org.Object, read.Object, events);

            e.SetCalendar(path);

            org.Verify(o => o.Arrange(events), Times.Once());

        }
        [Fact]
        public void SetCalendar_CallingReadingFile()
        {
            var read = new Mock<IReader>();
            var org = new Mock<IOrganizer>();
            string path = "path";
            var events = new List<EventModel>();
            EventControl e = new EventControl(org.Object, read.Object, events);

            e.SetCalendar(path);

            read.Verify(r => r.ReadingFile(path, events), Times.Once());
        }

        [Fact]
        public void SetCalendar_ShouldReturnNullPathException()
        {
            var read = new Mock<IReader>();
            var org = new Mock<IOrganizer>();
            string path = null;
            var events = new List<EventModel>();
            EventControl e = new EventControl(org.Object, read.Object, events);


            Action act = () => e.SetCalendar(path);

            Assert.Throws<ArgumentNullException>("The path cant be null", act);
        }
    }
}
