using HetWeer;
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

namespace LayOut_Wall_i
{
    public partial class GameMenuOG : Form
    {
        Gebruiker gebruiker;
        Spraak spraak = new Spraak();
        public GameMenuOG()
        {
            InitializeComponent();
            spraak.speechRec.SpeechRecognized += SpeechRecognized;
        }

        private void SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if(e.Result.Text.Contains("turn based"))
            {
                spraak.Reageer(e.Result.Text);
                button3_Click(sender,e);
            }
            else if(e.Result.Text.Contains("survival"))
            {
                spraak.Reageer(e.Result.Text);
                button2_Click(sender,e);
            }
            else if(e.Result.Text.Contains("arena"))
            {
                spraak.Reageer(e.Result.Text);
                button1_Click(sender,e);
            }
            else if(e.Result.Text.Contains("back"))
            {
                spraak.Reageer(e.Result.Text);
                btnBackGameMenu_Click(sender,e);
            }
        }

        //2e constructor om gebruiker mee te geven na inloggen
        public GameMenuOG(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TurnBasedGame.Form1 battle = new TurnBasedGame.Form1();
            spraak.speechRec.RecognizeAsyncCancel();
            this.Hide();
            battle.ShowDialog();
        }

        private void btnBackGameMenu_Click(object sender, EventArgs e)
        {
            BeginschermWalli form = new BeginschermWalli();
            spraak.speechRec.RecognizeAsyncCancel();
            this.Hide();
            form.ShowDialog();      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArenaGame form = new ArenaGame();
            spraak.speechRec.RecognizeAsyncCancel();
            this.Hide();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SurvivalGame sur = new SurvivalGame();
            spraak.speechRec.RecognizeAsyncCancel();
            this.Hide();
            sur.ShowDialog();
        }
    }
}
