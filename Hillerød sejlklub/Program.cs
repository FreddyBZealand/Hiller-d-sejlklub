using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                 new Båd(12, "Anna", "Sejlbåd", true),
                 new Båd(24, "Victoria", "Yacht", true),
                 new Båd(30, "Clara", "Speedbåd", false)


            };
               foreach (var båd in både)
            {
                båd.VisInfo();
            }

            List<Service> services = new List<Service>
               {
                   new Service("Huld i skrog", 32, "Anna", "Reparation"),
                   new Service("Ødelagt motor", 20, "Victoria", "Reparation"),
                   new Service("Skal males", 75, "Clara", "Vedligeholdelse"),


               };

            foreach (var service in services)
            {
                service.AddService();
            }

            List<Blog> blogge = new List<Blog>
            {
                new Blog("Kapsejlads", "Kom til årets første kapsejlads på søndag!", "billeder,kapsejlads.jpg", new DateTime(2025, 5, 4)),
                new Blog("Fællesmorgenmad", "Der er fællesmorgenmad d. 10/6. Tag lidt af hvert med.", "billeder/kapsejlads.jpg", new DateTime(2025, 6, 10)),
                new Blog("Kapsejlads", "Kom til årets sidste kapsejlads d. 4/10!", "billeder/kapsejlads.jpg", new DateTime(2025, 10, 4))


            };
            foreach (var blog in blogge)
            {
                blog.VisIndlæg();
            }



            Console.ReadLine(); // Holder konsollen åben
        } 
    }
}

