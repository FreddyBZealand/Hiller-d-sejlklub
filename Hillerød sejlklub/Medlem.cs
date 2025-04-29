using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_sejlklub
{
    internal class Medlem
    {
        public int MedlemId { get; set; }
        public string Telefonnummer { get; set; }
        public string Email { get; set; }

        public Medlem(int medlemId, string telefonnummer, string email)
        {
            MedlemId = medlemId;
            Telefonnummer = telefonnummer;
            Email = email;
        }

        public void VisInfo()
        {
            Console.WriteLine($"Medlem ID: {MedlemId}");
            Console.WriteLine($"Telefonnummer: {Telefonnummer}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
    

