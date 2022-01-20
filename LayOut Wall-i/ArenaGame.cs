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
    public partial class ArenaGame : Form
    {
        Player player1;
        Player player2;

        bool turn = false;

        Random RandomKaart = new Random();
        Spraak spraak = new Spraak();
        List<Kaart> kaarten = new List<Kaart>();

        public ArenaGame()
        {
            InitializeComponent();
            spraak.speechRec.SpeechRecognized += SpeechRecognized;
            player1 = new Player("Cezar", Player.Karakter.Techneut);
            player2 = new Player("Zakria", Player.Karakter.Keizerin);

            Kaart kaart1 = new Kaart("Ridder");
            Kaart kaart2 = new Kaart("Schildknaap");
            Kaart kaart3 = new Kaart("Bandiet");
            Kaart kaart4 = new Kaart("Waterlady");
            Kaart kaart5 = new Kaart("Reaper");
            Kaart kaart6 = new Kaart("DOOM");
            Kaart kaart7 = new Kaart("Pest");

            kaarten.Add(kaart1);
            kaarten.Add(kaart2);
            kaarten.Add(kaart3);
            kaarten.Add(kaart4);
            kaarten.Add(kaart5);
            kaarten.Add(kaart6);
            kaarten.Add(kaart7);

            BtnAanUit();

            Status();

            ZetAlleLabelAchtergrondenTransparant(Color.Transparent);

            lblK1.Parent = pbAchtergrond;
            lblKar2.Parent = pbAchtergrond;
            lblVS.Parent = pbAchtergrond;
            lblType1.Parent = pbAchtergrond;
            lblType2.Parent = pbAchtergrond;
            lblScore1.Parent = pbAchtergrond;
            lblScore2.Parent = pbAchtergrond;
            lblScore3.Parent = pbAchtergrond;
            lblScore4.Parent = pbAchtergrond;
            lbVerhaal1.Parent = pbAchtergrond;
            lbVerhaal2.Parent = pbAchtergrond;
            lbVerhaal3.Parent = pbAchtergrond;
            lbVerhaal4.Parent = pbAchtergrond;
            lbVerhaal5.Parent = pbAchtergrond;
            lbVerhaal6.Parent = pbAchtergrond;
        }

        private void SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.Contains("back"))
            {
                spraak.Reageer(e.Result.Text);
                btnBackGameMenu_Click(sender,e);
            }
        }

        private void ZetAlleLabelAchtergrondenTransparant(Color color)
        {
            foreach (Control label in Controls)
            {
                Label lb = label as Label;
                if (lb != null)
                {
                    lb.BackColor = color;
                }
            }
        }

        private void BtnAanUit()
        {
            turn = !turn;
            if (turn)
            {
                btnAanval.Enabled = true;
                btnAanval2.Enabled = false;
            }
            else
            {
                btnAanval.Enabled = false;
                btnAanval2.Enabled = true;
            }
        }

        private void Status()
        {
            lblVerlies1.Text = player1.Verlies.ToString();
            lblVerlies2.Text = player2.Verlies.ToString();

            lblWinst1.Text = player1.Winst.ToString();
            lblWinst2.Text = player2.Winst.ToString();

            lblScore2.Text = player1.Score.ToString();
            lblScore4.Text = player2.Score.ToString();
        }

        public Kaart RandomkaartMethode()
        {
            return this.kaarten[RandomKaart.Next(this.kaarten.Count)];
        }

        public Color getColor1(Color color)
        {
            KleurBalk1.BackColor = color;
            return color;
        }

        public Color getColor2(Color color)
        {
            KleurBalk2.BackColor = color;
            return color;
        }

        private void btnAanval_Click(object sender, EventArgs e)
        {
            Kaart kaart = RandomkaartMethode();

            lblType1.Text = kaart.Naam;
            lbVerhaal1.Text = Convert.ToString(kaart.KaartVerhaal1());
            lbVerhaal2.Text = Convert.ToString(kaart.KaartVerhaal2());
            lbVerhaal3.Text = Convert.ToString(kaart.KaartVerhaal3());

            if (kaart.Naam == "Ridder")
            {
                pbMain.Image = Image.FromFile(@"C:\Users\Cezar Pop\Pictures\Camera Roll\RidderKaart.jpg");
                player1.PowerAttack(player2);
                lblScore4.Text = player2.Score.ToString();
                getColor1(Color.Cyan);
            }
            if (kaart.Naam == "Schildknaap")
            {
                pbMain.Image = Image.FromFile(@"C:\Users\Cezar Pop\Pictures\Camera Roll\Schildknaap.jpg");
                player1.NormalAttack(player2);
                lblScore4.Text = player2.Score.ToString();
                getColor1(Color.Magenta);
            }
            if (kaart.Naam == "Bandiet")
            {
                pbMain.Image = Image.FromFile(@"C:\Users\Cezar Pop\Pictures\Camera Roll\Bandit2.jpg");
                player1.BanditAttack(player2);
                lblScore2.Text = player1.Score.ToString();
                lblScore4.Text = player2.Score.ToString();
                getColor1(Color.Gold);
            }
            if (kaart.Naam == "Waterlady")
            {
                pbMain.Image = Image.FromFile(@"C:\Users\Cezar Pop\Pictures\Camera Roll\Waterlady.png");
                player1.Healen(player1);
                lblScore2.Text = player1.Score.ToString();
                getColor1(Color.Crimson);
            }
            if (kaart.Naam == "Reaper")
            {
                pbMain.Image = Image.FromFile(@"C:\Users\Cezar Pop\Pictures\Camera Roll\Reaper1.jpg");
                player1.SelfDmg1(player1);
                lblScore2.Text = player1.Score.ToString();
                getColor1(Color.SpringGreen);
            }
            if (kaart.Naam == "DOOM")
            {
                pbMain.Image = Image.FromFile(@"C:\Users\Cezar Pop\Pictures\Camera Roll\doom.jpg");
                player1.SelfDmg2(player1);
                lblScore2.Text = player1.Score.ToString();
                getColor1(Color.Black);
            }
            if (kaart.Naam == "Pest")
            {
                pbMain.Image = Image.FromFile(@"C:\Users\Cezar Pop\Pictures\Camera Roll\pes.jpg");
                player1.PestAttack(player2);
                lblScore4.Text = player2.Score.ToString();
                getColor1(Color.HotPink);
            }

            Status();

            player1.WinstOfVerlies(player2);

            BtnAanUit();
        }

        private void btnAanval2_Click(object sender, EventArgs e)
        {
            Kaart kaart = RandomkaartMethode();

            lblType2.Text = kaart.Naam;
            lbVerhaal4.Text = Convert.ToString(kaart.KaartVerhaal1());
            lbVerhaal5.Text = Convert.ToString(kaart.KaartVerhaal2());
            lbVerhaal6.Text = Convert.ToString(kaart.KaartVerhaal3());

            if (kaart.Naam == "Ridder")
            {
                pbMain2.Image = Image.FromFile(@"C:\Users\Cezar Pop\Pictures\Camera Roll\RidderKaart.jpg");
                player2.PowerAttack(player1);
                lblScore2.Text = player1.Score.ToString();
                getColor2(Color.Cyan);
            }
            if (kaart.Naam == "Schildknaap")
            {
                pbMain2.Image = Image.FromFile(@"C:\Users\Cezar Pop\Pictures\Camera Roll\Schildknaap.jpg");
                player2.NormalAttack(player1);
                lblScore2.Text = player1.Score.ToString();
                getColor2(Color.Magenta);
            }
            if (kaart.Naam == "Bandiet")
            {
                pbMain2.Image = Image.FromFile(@"C:\Users\Cezar Pop\Pictures\Camera Roll\Bandit2.jpg");
                player2.BanditAttack(player1);
                lblScore4.Text = player2.Score.ToString();
                lblScore2.Text = player1.Score.ToString();
                getColor2(Color.Gold);
            }
            if (kaart.Naam == "Waterlady")
            {
                pbMain2.Image = Image.FromFile(@"C:\Users\Cezar Pop\Pictures\Camera Roll\Waterlady.png");
                player2.Healen(player2);
                lblScore4.Text = player2.Score.ToString();
                getColor2(Color.Crimson);
            }
            if (kaart.Naam == "Reaper")
            {
                pbMain2.Image = Image.FromFile(@"C:\Users\Cezar Pop\Pictures\Camera Roll\Reaper1.jpg");
                player2.SelfDmg1(player2);
                lblScore4.Text = player2.Score.ToString();
                getColor2(Color.SpringGreen);
            }
            if (kaart.Naam == "DOOM")
            {
                pbMain2.Image = Image.FromFile(@"C:\Users\Cezar Pop\Pictures\Camera Roll\doom.jpg");
                player2.SelfDmg2(player2);
                lblScore4.Text = player2.Score.ToString();
                getColor2(Color.Black);
            }
            if (kaart.Naam == "Pest")
            {
                pbMain2.Image = Image.FromFile(@"C:\Users\Cezar Pop\Pictures\Camera Roll\pes.jpg");
                player2.PestAttack(player1);
                lblScore2.Text = player1.Score.ToString();
                getColor2(Color.HotPink);
            }

            Status();

            player2.WinstOfVerlies(player1);

            BtnAanUit();
        }

        private void btnBackGameMenu_Click(object sender, EventArgs e)
        {
            GameMenuOG games = new GameMenuOG();
            spraak.speechRec.RecognizeAsyncCancel();
            this.Hide();
            games.ShowDialog();
        }
    }
}


