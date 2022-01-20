using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayOut_Wall_i
{
    public class Kaart
    {

        public string Naam { get; set; }
        public string Verhaal1 { get; set; }
        public string Verhaal2 { get; set; }
        public string Verhaal3 { get; set; }

        public Kaart(string naam)
        {
            this.Naam = naam;
        }

        public string KaartVerhaal1()
        {
            if (this.Naam == "Ridder")
            {
                this.Verhaal1 = "Lang geleden was er een een machtige krijger,";
            }
            if (this.Naam == "Schildknaap")
            {
                this.Verhaal1 = "Hij rijsde over het gehele land op zoek naar goud.";
            }
            if (this.Naam == "Bandiet")
            {
                this.Verhaal1 = "Een meester in stelen en vermoming.";
            }
            if (this.Naam == "Waterlady")
            {
                this.Verhaal1 = "Lang geleden was ik een goede doctor,";
            }
            if (this.Naam == "Reaper")
            {
                this.Verhaal1 = "Hij komt stil en onverwachts, in het donker...";
            }
            if (this.Naam == "DOOM")
            {
                this.Verhaal1 = "Deze is pijnlijk :)";
            }
            if (this.Naam == "Pest")
            {
                this.Verhaal1 = "Even mijn medicijn testen.... Op jouw score!";
            }

            return this.Verhaal1;
        }

        public string KaartVerhaal2()
        {
            if (this.Naam == "Ridder")
            {
                this.Verhaal2 = "hij trok overal rond en ging elke strijd in zijn pad aan.";
            }
            if (this.Naam == "Schildknaap")
            {
                this.Verhaal2 = "De schildknaap is zo terecht gekomen in een strijd!";
            }
            if (this.Naam == "Bandiet")
            {
                this.Verhaal2 = "De gevreesde bandiet komt jou roven van je score!";
            }
            if (this.Naam == "Waterlady")
            {
                this.Verhaal2 = "waar ben ik nu in beland?.....";
            }
            if (this.Naam == "Reaper")
            {
                this.Verhaal2 = "altijd s'nachts";
            }

            return this.Verhaal2;
        }

        public string KaartVerhaal3()
        {
            if (this.Naam == "Ridder")
            {
                this.Verhaal3 = "Dit is zijn zwaarste tot nu toe!";
            }

            return this.Verhaal3;
        }
    }
}

