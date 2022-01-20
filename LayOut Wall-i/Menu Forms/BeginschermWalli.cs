using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HetWeer;

namespace LayOut_Wall_i
{
    public partial class BeginschermWalli : Form
    {
        Gebruiker gebruiker;
        Spraak spraak = new Spraak();
        Spraak spraakAchtergrond = new Spraak();
        bool status = false;
        public BeginschermWalli()
        {
            InitializeComponent();
            spraak.Zeg("Welcome to the home menu, where do you want to go.");
            spraak.speechRec.SpeechRecognized += SpeechRecognized;
        }
        //2 constructors om gebruiker mee te geven als er ingelogd is
        public BeginschermWalli(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            spraak.Zeg("Welcome to the home menu, where do you want to go.");
            spraak.speechRec.SpeechRecognized += SpeechRecognized;
        }

        private void SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if(e.Result.Text.Contains("games") || e.Result.Text.Contains("arcade"))
            {
                spraak.Reageer(e.Result.Text);
                btnGames_Click_1(sender,e);
            }
            if(e.Result.Text.Contains("weather"))
            {
                spraak.Reageer(e.Result.Text);
                btnWeer_Click_1(sender,e);
            }
            if(e.Result.Text.Contains("login"))
            {
                spraak.Reageer(e.Result.Text);
                btnInlog_Click(sender,e);
            }
            if(e.Result.Text == "stop listening")
            {
                spraak.StopMetLuisteren(e.Result.Text);
                if(spraakAchtergrond == null)
                spraakAchtergrond.speechRec.SpeechRecognized += SpeechRecognized2;
                else
                {
                    spraakAchtergrond.StartMetLuisteren();
                }
            }
        }

        private void SpeechRecognized2(object sender, SpeechRecognizedEventArgs e)
        {
            if(e.Result.Text == "start listening")
            {
                spraak.StartMetLuisteren();
                spraakAchtergrond.StopMetLuisteren(e.Result.Text);
            }
        }

        private void BeginschermWalli_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void btnGames_Click_1(object sender, EventArgs e)
        {
            GameMenuOG games = new GameMenuOG();
            spraak.speechRec.RecognizeAsyncCancel();
            this.Hide();
            games.ShowDialog();
        }

        private void btnWeer_Click_1(object sender, EventArgs e)
        {
            HetWeer.Form1 weer = new HetWeer.Form1();
            spraak.speechRec.RecognizeAsyncCancel();
            this.Hide();
            weer.ShowDialog();
        }

        private void btnInlog_Click(object sender, EventArgs e)
        {
            Inlogscherm inlog = new Inlogscherm();
            spraak.speechRec.RecognizeAsyncCancel();
            this.Hide();
            inlog.ShowDialog();
        }
    }
}
