using System;
using System.Collections.Generic;

namespace Hillerød_sejlklub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Medlem> medlemmer = new List<Medlem>
            {
                new Medlem(1,"12345678", "anna@example.com", "guldMedlem"),
                new Medlem(2, "87654321", "brian@example.com", "guldMedlem"),
                new Medlem(3, "11223344", "carla@example.com", "medlem"),
                new Medlem(4, "44332211", "dan@example.com", "guldMedlem")
            };

            foreach (var medlem in medlemmer) //Går igennem hvert medlem i listen medlemmer én ad gangen.
            {
                medlem.VisInfo();
            }

            List<Båd> både = new List<Båd>
            {
                  new Båd(12, "Anna", "Sejlbåd"),
                 new Båd(24, "Victoria", "Yacht"),
                 new Båd(24, "Victoria", "Yacht")


            };
               foreach (var båd in både)
            {
                båd.VisInfo();
            }

            List<Service> services = new List<Service>
               {
                   new Service("Huld i skrog", 32, "Anna", "Reparation"),
                   new Service("Ødelagt motor", 20, "Victoria", "Reparation"),
                   new Service("Huld i skrog", 32, "Anna", "Reparation"),


               };
            foreach (var service in services)
            {
                service.AddService();
            }

            Console.ReadLine(); // Holder konsollen åben
        } 
    }
}

