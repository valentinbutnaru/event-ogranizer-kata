using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace EventOrganizer
{
    public static class ContainerConfig
    {
        public static IContainer Config ()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<EventWrapper>().As<IEventWrapper>();
            builder.RegisterType<List<ConflictModel>>();
            builder.RegisterType<List<EventModel>>();
            builder.RegisterType<Organizer>().As<IOrganizer>();
            builder.RegisterType<FileReader>().As<IReader>();
            builder.RegisterType<EventControl>().As<IEventControl>();
            builder.RegisterType<PeriodConflict>().As<IPeriodConflict>();

            return builder.Build();
        }
    }
}
