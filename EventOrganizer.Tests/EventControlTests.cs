using System;
using Xunit;

namespace EventOrganizer.Tests
{
    public class EventControlTests
    {

        [Fact]
        public void SetCalendar_ShouldReturnNullPathException ()
        {
            string path = null;
            EventControl e = new EventControl(path);

            Action act = () => e.SetCalendar();

            Assert.Throws<ArgumentNullException>("The path cant be null", act);

        }

        [Fact]
        public void SetCalendar_ShouldReturnEmptyPathException()
        {
            EventControl e = new EventControl(string.Empty);

            Action act = () => e.SetCalendar();

            Assert.Throws<ArgumentException>("The path cant be empty", act);
        }
    }
}
