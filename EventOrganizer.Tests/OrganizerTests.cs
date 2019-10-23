using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;

namespace EventOrganizer.Tests
{
    public class OrganizerTests
    {
        [Fact]
        public void Arrange_NullListExeption()
        {
            List<ConflictModel> conflicts = new List<ConflictModel>();
            List<EventModel> events = null;
            var periodConflict = new Mock<IPeriodConflict>();
            Organizer org = new Organizer(periodConflict.Object, conflicts);

            Action act = () => org.Arrange(events);

            Assert.Throws<ArgumentNullException>("Theres cant be null lists", act);
        }

        [Fact]
        public void Arrange_CallingOnceConflictDetermination()
        {
            var periodConflict = new Mock<IPeriodConflict>();
            List<ConflictModel> conflicts = new List<ConflictModel>();
            List<EventModel> events = new List<EventModel>
            {
                new EventModel("sala", Convert.ToDateTime("2009-06-15 16:32:00"), Convert.ToDateTime("2009-06-15 16:32:00"))
            };
            periodConflict.Setup(p => p.ConflictDetermination(It.IsAny<List<EventModel>>(), conflicts)).Returns(conflicts);
            Organizer org = new Organizer(periodConflict.Object, conflicts);

            org.Arrange(events);

            periodConflict.Verify(p => p.ConflictDetermination(events, conflicts), Times.Once());
        }

        [Fact]
        public void Arrange_WithConflicts_ShouldReturnCorrectString()
        {
            List<ConflictModel> conflicts = new List<ConflictModel>
            {
                new ConflictModel("sala", Convert.ToDateTime("2009-06-15 16:32:00"), Convert.ToDateTime("2009-06-15 16:32:00"))
            };

            string expected = "sala 6/15/2009 4:32:00 PM 6/15/2009 4:32:00 PM";

            List<EventModel> eventModels = new List<EventModel>
            {
                new EventModel("sala", Convert.ToDateTime("2009-06-15 16:32:00"), Convert.ToDateTime("2009-06-15 16:32:00"))
            };

            var periodConflict = new Mock<IPeriodConflict>();

            periodConflict.Setup(p => p.ConflictDetermination(It.IsAny<List<EventModel>>(), conflicts)).Returns(conflicts);

            Organizer org = new Organizer(periodConflict.Object, conflicts);

            var act = org.Arrange(eventModels);

            Assert.Equal(expected, act);
        }
    }
}

