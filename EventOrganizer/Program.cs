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
            string path = @"C:\Users\vbutnaru\Desktop\EventOrganizer\EventOrganizer\Eveniments.txt";
            //EventControl e = new EventControl();
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    string line;


            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        string[] array = line.Split(',');
            //        foreach (var w in array)
            //            Console.WriteLine(w);
            //    }
            //}
            foreach (string line in File.ReadAllLines(path))
            {
                string[] parts = line.Split(",");
                foreach (string part in parts )
                {
                    Console.WriteLine(part);
                }
            }
        }
    }
}
