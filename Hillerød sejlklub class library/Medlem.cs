using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_sejlklub
{

    public class Medlem
    {
        public int MedlemId { get; set; }
        public string Navn { get; set; }
        public string Telefonnummer { get; set; }
        public string Email { get; set; }
        public bool ErGuldMedlem { get; set; }

        public Medlem(int medlemId, string telefonnummer, string email, bool erGuldMedlem, string navn)
        {
            MedlemId = medlemId;
            Telefonnummer = telefonnummer;
            Email = email;
            ErGuldMedlem = erGuldMedlem;
            Navn = navn;
        }

        public void VisInfo()
        {
            Console.WriteLine($"Medlem ID: {MedlemId}");
            Console.WriteLine($"Navn: {Navn}");
            Console.WriteLine($"Telefonnummer: {Telefonnummer}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Medlemsgrad: {(ErGuldMedlem ? "Guldmedlem" : "Standardmedlem")}");
            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"{Navn} ({Email}) - {(ErGuldMedlem ? "Guld" : "Standard")}";

            
        }
       

    }
}