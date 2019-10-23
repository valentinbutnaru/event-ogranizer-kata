using Autofac;
using System;


namespace EventOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            Console.WriteLine("Introduce the path to the file : ");
            path = Console.ReadLine();

            var container = ContainerConfig.Config();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IEventControl>();
                app.SetCalendar(path);
            }

            Console.Read();
        }
    }
}
