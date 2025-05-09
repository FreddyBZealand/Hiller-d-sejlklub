﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_sejlklub
{
    public class Begivenhed
    {
        public string Navn { get; set; }
        public DateTime Dato { get; set; }
        public string Beskrivelse { get; set; }
        public List<Medlem> Tilmeldte { get; set; } //Setter og Returner tilmeldte fra Medlems klassen.

        public Begivenhed(string navn, DateTime dato, string beskrivelse)
        {
            Navn = navn;
            Dato = dato;
            Beskrivelse = beskrivelse;
            Tilmeldte = new List<Medlem>(); //<Medlem> tager fat i vores Medlem.cs
        }

        public void TilmeldMedlem(Medlem medlem)
        {
            if (!Tilmeldte.Contains(medlem)) //! betyder ikke. dvs. metoden her siger, hvis medlemmet allerede er tilmeldt. 
            {
                Tilmeldte.Add(medlem);
                Console.WriteLine($"{medlem.Email} er tilmeldt {Navn}."); //Hvis et medlem allerede deltager til begivenheden. If tjekker hvis medlemmet allerede er tilmeldt.

            }
            else
            {
                Console.WriteLine($"{medlem.Navn} er allerede tilmeldt {Navn}.");
            }
        }

        public void VisInfo()
        {
            Console.WriteLine($"Begivenhed: {Navn}");
            Console.WriteLine($"Dato: {Dato}");
            Console.WriteLine($"Beskrivelse: {Beskrivelse}");
            Console.WriteLine($"Antal tilmeldte: {Tilmeldte.Count}");
            Console.WriteLine();
            


            foreach (var medlem in Tilmeldte)
            {
                Console.WriteLine("Tilmeldte");
                Console.WriteLine($"- {medlem.Navn} ({medlem.Email})");
                Console.WriteLine();
                Console.WriteLine($"- {medlem}");
                Console.WriteLine();
            }
        }
    }
}