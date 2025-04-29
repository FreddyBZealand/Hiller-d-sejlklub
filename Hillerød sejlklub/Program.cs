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
                new Medlem(1, "12345678", "anna@example.com", "guldMedlem"),
                new Medlem(2, "87654321", "brian@example.com", "guldMedlem"),
                new Medlem(3, "11223344", "carla@example.com", "Medlem"),
                new Medlem(4, "44332211", "dan@example.com", "guldMedlem")
            };

            foreach (var medlem in medlemmer) //Går igennem hvert medlem i listen medlemmer én ad gangen.
            {
                medlem.VisInfo();
            }

            Console.ReadLine(); // Holder konsollen åben
        }
    }
}

