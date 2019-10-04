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
        public void ReadingFile_NullListException()
        {
            string path = null;
            List<Event> e = null;

            Reader reader = new Reader(path);

            Action act = () => reader.ReadingFile(e);

            Assert.Throws<ArgumentNullException>("The list cant be null", act);
        }
    }
}
