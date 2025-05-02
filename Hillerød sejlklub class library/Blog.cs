using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_sejlklub
{
    internal class Blog
    {
        private string Titel { get; set; }
        private string Indhold { get; set; }
        private string BilledeSti { get; set; } // f.eks. "billeder/kapsejlads.jpg"
        private DateTime Dato { get; set; }

        private Blog(string titel, string indhold, string billedeSti)
        {
            Titel = titel;
            Indhold = indhold;
            BilledeSti = billedeSti;
            Dato = DateTime.Now;
        }

        private void Rediger(string nytIndhold, string nyBilledeSti)
        {
            Indhold = nytIndhold;
            BilledeSti = nyBilledeSti;
            Dato = DateTime.Now;
        }

        private void VisIndlæg()
        {
            Console.WriteLine($"Titel: {Titel}");
            Console.WriteLine($"Dato: {Dato}");
            Console.WriteLine($"Indhold: {Indhold}");
            Console.WriteLine($"Billede: {BilledeSti}");
        }
    }
}
