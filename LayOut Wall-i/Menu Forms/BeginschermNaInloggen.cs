using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HetWeer;

namespace LayOut_Wall_i
{
    public partial class BeginschermNaInloggen : Form
    {
        Gebruiker gebruiker;
        Spraak spraak = new Spraak();
        public BeginschermNaInloggen(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
        }

        public BeginschermNaInloggen()
        {
            InitializeComponent();
            this.gebruiker = new Gebruiker("ludo");
        }


        private void SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.Contains("games") || e.Result.Text.Contains("arcade"))
            {
                spraak.Reageer(e.Result.Text);
                btnGames_Click(sender, e);
            }
            if (e.Result.Text.Contains("weather"))
            {
                spraak.Reageer(e.Result.Text);
                btnWeer_Click(sender, e);
            }
            if (e.Result.Text.Contains("agenda"))
            {
                spraak.Reageer(e.Result.Text);
                btnNaarAgenda_Click(sender, e);
            }
        }

        private void btnNaarAgenda_Click(object sender, EventArgs e)
        {
            AgendaForm agenda = new AgendaForm(gebruiker);
            spraak.speechRec.RecognizeAsyncCancel();
            this.Hide();
            agenda.ShowDialog();
        }

        private void BeginschermNaInloggen_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.WindowState = FormWindowState.Maximized;
            Form.CheckForIllegalCrossThreadCalls = false;
            spraak.Zeg("Welcome to the home menu, where do you want to go.");
            spraak.speechRec.SpeechRecognized += SpeechRecognized;
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            GameMenuOG ver = new GameMenuOG(gebruiker);
            spraak.speechRec.RecognizeAsyncCancel();
            this.Hide();
            ver.ShowDialog();
        }

        private void btnWeer_Click(object sender, EventArgs e)
        {
            Form1 ver = new Form1(gebruiker);
            spraak.speechRec.RecognizeAsyncCancel();
            this.Hide();
            ver.ShowDialog();
        }
    }
}
