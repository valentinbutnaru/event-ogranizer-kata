using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using EventOrganizer;

namespace EventOrganizer.Tests
{
    public class ReaderTests
    {
        [Fact]
        public void ReadingFile_EmptyPathException()
        {
            List<Event> e = new List<Event>
            {
                new Event("Gala", Convert.ToDateTime("2009-06-15 16:32:00"), Convert.ToDateTime("2009-06-15 19:32:00"))
            };

            string path = string.Empty;

            Reader reader = new Reader(path);

            Action act = () => reader.ReadingFile(e);

            Assert.Throws<ArgumentException>("The path cant be empty", act);
        }

        [Fact]
        public void ReadingFile_NullListException()
        {
            string path = null;
            List<Event> e = null;

            Reader reader = new Reader(path);

            Action act = () => reader.ReadingFile(e);

            Assert.Throws<ArgumentNullException>("The list cant be null", act);
        }

        [Fact]
        public void ReadingFile_NullPathException ()
        {
            string path = null;

            List<Event> e = new List<Event>();

            Reader reader = new Reader(path);

            Action act = () => reader.ReadingFile(e);

            Assert.Throws<ArgumentNullException>("The path cant be null", act);
        }

        [Fact]
        public void SetEvents_ArrayNullException()
        {
            List<Event> e = new List<Event>();

            string[] array = null;

            string path = "path";

            Reader reader = new Reader(path);

            Action act = () => reader.SetEvents(array, e);

            Assert.Throws<ArgumentNullException>("The array cant be null", act);
        }

        [Fact]
        public void SetEvents_ShouldReturnCorrectList()
        {
            string path = "path";

            Reader reader = new Reader(path);

            string[] array = new string[3];

            array[0] = "Gala";

            array[1] = "2009-06-15 16:32:00";

            array[2] = "2009-06-15 19:32:00";

            List<Event> expected = new List<Event>
            {
                new Event("Gala", Convert.ToDateTime("2009-06-15 16:32:00"), Convert.ToDateTime("2009-06-15 19:32:00"))
            };

            List<Event> actual = new List<Event>();

            actual = reader.SetEvents(array, actual);

            Assert.Equal(expected, actual);
        }
    }
}
