using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;

namespace EventOrganizer.Tests
{
    public class PeriodConflictTests
    {
        [Fact]
        public void ConflictDetermination_NullListException()
        {
            List<EventModel> e = null;
            List<ConflictModel> conflicts = new List<ConflictModel>();
            PeriodConflict p = new PeriodConflict();

            Action act = () => p.ConflictDetermination(e, conflicts);

            Assert.Throws<ArgumentNullException>("The list cant be null", act);
        }

        [Fact]
        public void ConflictDetermination_WithEvent_ReturnCorrectConflicts()
        {
            List<EventModel> e = new List<EventModel>
            {
                new EventModel("sala", Convert.ToDateTime("2009-06-15 16:32:00"), Convert.ToDateTime("2009-06-15 18:32:00")),
                new EventModel("lunch", Convert.ToDateTime("2009-06-15 17:32:00"), Convert.ToDateTime("2009-06-15 20:32:00"))
            };
            List<ConflictModel> conflicts = new List<ConflictModel>();

            List<ConflictModel> conflictsRes = new List<ConflictModel>()
            {
                new ConflictModel("\nTime conflict between sala and lunch", Convert.ToDateTime("2009-06-15 16:32:00"), Convert.ToDateTime("2009-06-15 20:32:00"))
            };


            PeriodConflict p = new PeriodConflict();

            var act = p.ConflictDetermination(e, conflicts);

            Assert.Equal(conflictsRes.ToString(), act.ToString());
        }
    }
}
