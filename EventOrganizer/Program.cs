using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EventOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\alaha\Desktop\event\event-ogranizer-kata\Eveniments.txt";

            EventControl e = new EventControl();
            e.ReadingFileEvents(path);
            e.Display();
            Console.Read();
        }
    }
}
