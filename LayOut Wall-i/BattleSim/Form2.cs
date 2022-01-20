using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnBasedGame
{
    public partial class Form2 : Form
    {
        Speler speler1;
        Speler speler2;

        public Form2(Speler speler1, Speler speler2)
        {
            InitializeComponent();
            this.speler1 = speler1;
            this.speler2 = speler2;

            //labels en progressbar bijwerken
            lblKarakterSpeler1.Text = this.speler1.ToString();
            lblKarakterSpeler2.Text = this.speler2.ToString();

            lblHpSpeler1.Text = this.speler1.Hp.ToString();
            lblHpSpeler2.Text = this.speler2.Hp.ToString();

            pbHpSpeler1.Maximum = this.speler1.Hp;
            pbHpSpeler2.Maximum = this.speler2.Hp;
            pbHpSpeler1.Value = this.speler1.Hp;
            pbHpSpeler2.Value = this.speler2.Hp;

        }

        //na 1 knop indrukken spelers knoppen uitzetten
        private void ButtonsSpeler1Uitzetten()
        {
            
            btnSpeler1LichteAanval.Enabled = false;
            btnSpeler1ZwareAanval.Enabled = false;
            btnSpeler1Heal.Enabled = false;
           

            
            btnSpeler2LichteAanval.Enabled = true;
            Speler2HealBtnEnZwareAanval();
            

        }

        private void ButtonsSpeler2Uitzetten()
        {
            
            btnSpeler2ZwareAanval.Enabled = false;
            btnSpeler2LichteAanval.Enabled = false;
            btnSpeler2Heal.Enabled = false;

            btnSpeler1LichteAanval.Enabled = true;
            Speler1HealBtnEnZwareAanval();

        }

        private void Speler1HealBtnEnZwareAanval()
        {
            //speler 1 heal uitzetten voor 3 beurten na het gebruiken
            if (speler1.Heal == true)
            {
                btnSpeler1Heal.Enabled = false;
                
                if(speler1.HealCount > 1)
                {
                    speler1.Heal = !speler1.Heal;
                }
            }
            else
            {
                btnSpeler1Heal.Enabled = true;
            }
            //beurt wachten na zware aanval
            if (speler1.ZwareAanvalGebruikt == true)
            {
                btnSpeler1ZwareAanval.Enabled = false;
                speler1.ZwareAanvalGebruikt = !speler1.ZwareAanvalGebruikt;
            }
            else
            {
                btnSpeler1ZwareAanval.Enabled = true;
            }
        }

        private void Speler2HealBtnEnZwareAanval()
        {
            //speler 2 heal uitzetten voor 3 beurten na het gebruiken
            if (speler2.Heal == true)
            {
                btnSpeler2Heal.Enabled = false;

                if (speler2.HealCount > 1)
                {
                    speler2.Heal = !speler2.Heal;
                }
            }
            else
            {
                btnSpeler2Heal.Enabled = true;
            }

            //speler 2 beurt wachten na zware aanval
            if (speler2.ZwareAanvalGebruikt == true)
            {
                btnSpeler2ZwareAanval.Enabled = false;
                speler2.ZwareAanvalGebruikt = !speler2.ZwareAanvalGebruikt;
            }
            else
            {
                btnSpeler2ZwareAanval.Enabled = true;
            }
        }

        private void Winst()
        {
            //als er een winnaar is, terug naar game kiezen form
            if (speler1.CheckVoorWinst())
            {
                MessageBox.Show("De " + speler2.ToString() + " heeft gewonnen!");
                TerugNaarGameSelectie();
            }
            else if (speler2.CheckVoorWinst())
            {
                MessageBox.Show("De " + speler1.ToString() + " heeft gewonnen!");
                TerugNaarGameSelectie();
            }
        }

        private void ProgressBarBijwerken()
        {
            //progressbar bijwerken na attacks
            if(speler1.Hp > 0)
            {
                pbHpSpeler1.Value = speler1.Hp;
            }
            
            if(speler2.Hp > 0)
            {
                pbHpSpeler2.Value = speler2.Hp;
            }
        }

        private void TerugNaarGameSelectie()
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }
        private void btnSpeler1LichteAanval_Click(object sender, EventArgs e)
        {
            speler1.LichteAanval(speler2);
            lblHpSpeler2.Text = speler2.Hp.ToString();
            ProgressBarBijwerken();
            Winst();
            ButtonsSpeler1Uitzetten();

        }

        private void btnSpeler1ZwareAanval_Click(object sender, EventArgs e)
        {
            speler1.ZwareAanval(speler2);
            lblHpSpeler2.Text = speler2.Hp.ToString();
            ProgressBarBijwerken();
            Winst();
            ButtonsSpeler1Uitzetten();

        }
        private void btnSpeler1Heal_Click(object sender, EventArgs e)
        {
            speler1.Healen();
            lblHpSpeler1.Text = speler1.Hp.ToString();
            ProgressBarBijwerken();
            Winst();
            ButtonsSpeler1Uitzetten();

        }

        private void btnSpeler2LichteAanval_Click(object sender, EventArgs e)
        {
            speler2.LichteAanval(speler1);
            lblHpSpeler1.Text = speler1.Hp.ToString();
            ProgressBarBijwerken();
            Winst();
            ButtonsSpeler2Uitzetten();

        }

        private void btnSpeler2ZwareAanval_Click(object sender, EventArgs e)
        {
            speler2.ZwareAanval(speler1);
            lblHpSpeler1.Text = speler1.Hp.ToString();
            ProgressBarBijwerken();
            Winst();
            ButtonsSpeler2Uitzetten();

        }

        private void btnSpeler2Heal_Click(object sender, EventArgs e)
        {
            speler2.Healen();
            lblHpSpeler2.Text = speler2.Hp.ToString();
            ProgressBarBijwerken();
            Winst();
            ButtonsSpeler2Uitzetten();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TerugNaarGameSelectie();
        }
    }
}
