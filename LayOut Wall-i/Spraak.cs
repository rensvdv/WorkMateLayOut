using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HetWeer
{
    class Spraak
    {
        SpeechSynthesizer speechSynth = new SpeechSynthesizer();
        public List<string> Keuzes { get; private set; }
        public string Keuze { get; set; }
        public string Antwoord { get; set; }
        public List<string> Antwoorden { get; private set; }
        public Spraak()
        {
            speechSynth.SelectVoiceByHints(VoiceGender.Female);
            this.Keuzes = File.ReadAllLines(@"C:\Users\Cezar Pop\source\repos\HetWeer\HetWeer\Vragen.txt").ToList();
            this.Antwoorden = File.ReadAllLines(@"C:\Users\Cezar Pop\source\repos\HetWeer\HetWeer\Antwoorden.txt").ToList();
        }

        public void Reageer(List<string> keuzes, string vraag)
        {
            bool bevat = false;
            for (int i = 0; i < this.Keuzes.Count; i++)
            {
                if (keuzes[i] == vraag)
                {
                    speechSynth.SpeakAsync(this.Antwoorden[i]);
                    bevat = true;
                }
            }
            if (!bevat)
            {
                speechSynth.SpeakAsync("Ask me another question");
            }
        }
        public void Zeg(string text)
        {
            speechSynth.SpeakAsync(text);
        }
        public void VoegVraagEnAntwoordtToe(string keuze, string antwoordt)
        {
            if (keuze != "" && antwoordt != "" && !this.Keuzes.Contains(keuze))
            {
                this.Keuzes.Add(keuze);
                this.Antwoorden.Add(antwoordt);
            }
            File.WriteAllLines(@"C:\Users\Cezar Pop\source\repos\HetWeer\HetWeer\Vragen.txt", this.Keuzes);
            File.WriteAllLines(@"C:\Users\Cezar Pop\source\repos\HetWeer\HetWeer\Antwoorden.txt", this.Antwoorden);
        }
    }



}
