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
    public class Spraak
    {
        public SpeechRecognitionEngine speechRec { get; set; }
        public SpeechSynthesizer speechSynth { get; set; } = new SpeechSynthesizer();
        public List<string> Keuzes { get; }
        public string Keuze { get; set; }
        public string Antwoord { get; set; }
        public List<string> Antwoorden { get; }
        public Spraak()
        {
            speechRec = new SpeechRecognitionEngine();
            speechSynth.SelectVoiceByHints(VoiceGender.Male);
            this.Keuzes = File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Vragen.txt")).ToList();
            this.Antwoorden = File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Antwoorden.txt")).ToList();
            Choices commandos = new Choices();
            commandos.Add(this.Keuzes.ToArray());
            GrammarBuilder grBuilder = new GrammarBuilder();
            grBuilder.Append(commandos);
            Grammar grammer = new Grammar(grBuilder);
            speechRec.LoadGrammarAsync(grammer);
            speechRec.SetInputToDefaultAudioDevice();
            speechRec.RecognizeAsync(RecognizeMode.Multiple);
        }
        public void Reageer(string vraag)
        {
            if (ValideVraag(vraag))
            {
                if (this.Keuzes.IndexOf(vraag) != -1)
                {
                    Zeg(this.Antwoorden[this.Keuzes.IndexOf(vraag)]);
                }
            }
            else
            {
                Zeg("I can't hear you, please ask me a better question");
            }
        }
        public bool ValideVraag(string vraag)
        {
            bool check = false;
            foreach (string keuze in this.Keuzes)
            {
                if (keuze == vraag || keuze.Contains(vraag))
                {
                    check = true;
                }
            }
            return check;
        }
        public void Zeg(string text)
        {
            this.speechSynth.SpeakAsync(text);
        }
        public void StopMetPraten()
        {
            if (this.speechSynth.State != SynthesizerState.Paused)
            {
                this.speechSynth.Pause();
            }
        }
        public void StartMetPraten()
        {
            if (this.speechSynth.State == SynthesizerState.Paused)
            {
                this.speechSynth.Resume();
            }
        }
        public void StopMetLuisteren(string text)
        {
            this.speechRec.RecognizeAsyncCancel();
            Reageer(text);
        }
        public void StartMetLuisteren()
        {
            Zeg("walli is awake, ask me a question");
            this.speechRec.RecognizeAsync(RecognizeMode.Multiple);
        }
        public void VoegVraagEnAntwoordtToe(string keuze, string antwoordt)
        {
            if (keuze != "" && antwoordt != "" && !this.Keuzes.Contains(keuze))
            {
                this.Keuzes.Add(keuze);
                this.Antwoorden.Add(antwoordt);
                speechSynth.SpeakAsync("question and answer are added to choices");
            }
            File.WriteAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Vragen.txt"), this.Keuzes);
            File.WriteAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Antwoorden.txt"), this.Antwoorden);
        }
    }



}
