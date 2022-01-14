using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayOut_Wall_i
{
   public class Kaart
    {
        public enum KaartKleur
        {
            Rood,
            Zwart,
            Navy,
            Groen,
            Paars,
            Roze,
            Cyan
        }

        public string Naam { get; set; }
        public int Damage { get; set; }
        public KaartKleur Kleur { get; set; }

        public Kaart(string naam)
        {
            this.Naam = naam;
        }

        public void JuisteKleurBijType()
        {
            if (this.Naam == "Ridder")
            {
                this.Kleur = KaartKleur.Navy;
            }
            else if (this.Naam == "Schildknaap")
            {
                this.Kleur = KaartKleur.Rood;
            }
            else if (this.Naam == "Bandiet")
            {
                this.Kleur = KaartKleur.Groen;
            }
            else if (this.Naam == "Reaper")
            {
                this.Kleur = KaartKleur.Paars;
            }
            else if (this.Naam == "Waterlady")
            {
                this.Kleur = KaartKleur.Zwart;
            }
            else if (this.Naam == "DOOM")
            {
                this.Kleur = KaartKleur.Roze;
            }
            else if (this.Naam == "Pest")
            {
                this.Kleur = KaartKleur.Cyan;
            }
        }
    }
}
