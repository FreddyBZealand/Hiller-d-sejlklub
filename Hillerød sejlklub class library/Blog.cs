using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_sejlklub
{
    public class Blog
    {
        public string Titel { get; set; }
        public string Indhold { get; set; }
        public string BilledeSti { get; set; } // f.eks. "billeder/kapsejlads.jpg"
        public DateTime Dato { get; set; }

        public Blog(string titel, string indhold, string billedeSti, DateTime dato)

        {
            Titel = titel;
            Indhold = indhold;
            BilledeSti = billedeSti;
            Dato = DateTime.Now;
        }

        public void Rediger(string nytIndhold, string nyBilledeSti)
        {
            Indhold = nytIndhold;
            BilledeSti = nyBilledeSti;
            Dato = DateTime.Now;
        }

        public void VisIndlæg()
        {
            Console.WriteLine($"Titel: {Titel}");
            Console.WriteLine($"Dato: {Dato}");
            Console.WriteLine($"Indhold: {Indhold}");
            Console.WriteLine($"Billede: {BilledeSti}");
            Console.WriteLine(); //for mellemrum når vi runner 
        }
    }
}
