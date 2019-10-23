using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EventOrganizer.Tests
{
    public class ReaderTests
    {
        [Fact]
        public void ReadingFile_NullPathException()
        {
            string path = null;
            var wrapper = new Mock<IEventWrapper>();
            FileReader reader = new FileReader(wrapper.Object);
            List<EventModel> events = new List<EventModel>();
            Action act = () => reader.ReadingFile(path, events);

            Assert.Throws<ArgumentNullException>("The path cant be null", act);
        }

        [Fact]
        public void ReadingFile_CallingSetEventsOnce()
        {
            string[] arr = new string [10];
            string path = @"C:\Users\vbutnaru\Desktop\EventOrganizer\event-ogranizer-kata\Eveniments.txt";
            var wrapper = new Mock<IEventWrapper>();
            FileReader reader = new FileReader(wrapper.Object);
            List<EventModel> events = new List<EventModel>();

            reader.ReadingFile(path, events);

            wrapper.Verify(w => w.SetEvents(arr, events), Times.AtLeastOnce());

        }
    }
}
