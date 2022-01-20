using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayOut_Wall_i
{
    public class Gebruiker
    {
        public string Naam { get; set; }

        public int Leeftijd { get; set; }

        public string Email { get; set; }

        public string Wachtwoord { get; set; }

        public string Klas { get; set; }
        public string Vak { get; set; }
        public string Lokaal { get; set; }

        public int LeerlingNummer { get; set; }

        public string Docenten { get; set; }

        public bool Ingelogd { get; set; }

        public Gebruiker()
        {
            Ingelogd = false;
        }
        public Gebruiker(string naam)
        {
            this.Naam = naam;
            Ingelogd = false;
        }
    }
}
