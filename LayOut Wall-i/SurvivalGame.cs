using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayOut_Wall_i
{
    public partial class SurvivalGame : Form
    {
        string naam;
        private Speler speler;
        private LeaderBoard lb = new LeaderBoard();
        public SurvivalGame()
        {
            InitializeComponent();
            btnTerug.Enabled = true;
        }

        private void CharacterStats(Speler player)
        {
            lbLeven.Text = $"Leven: {player.Leven}";
            lbDamage.Text = $"Damage: {player.Damage}";
            lbMovement.Text = $"Movement: {player.BewegingSnelheid}";
            lbBullets.Text = $"Bullets: {player.Kogels}";
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            GameMenuOG game = new GameMenuOG();
            this.Hide();
            game.ShowDialog();
        }

        private void btnSaveName_Click_1(object sender, EventArgs e)
        {
            naam = tbNaam.Text.Replace(" ", "-");
            if (naam != "")
            {
                gbCharacters.Enabled = true;
            }
        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            Survival_Game sur = new Survival_Game(speler, pbCharacter);
            this.Hide();
            sur.ShowDialog();
        }

        private void SurvivalGame_Load(object sender, EventArgs e)
        {
            foreach (string score in lb.Scores)
            {
                string[] scor = score.Split(' ');
                if (scor.Length != 3)
                {
                    lbxLeaderBoard.Items.Add(score);
                }
                else
                {
                    lbxLeaderBoard.Items.Add($"{scor[0]} \t        {scor[1]} \t         {scor[2]}");
                }
            }
        }

        private void rbtnCatWoman_CheckedChanged(object sender, EventArgs e)
        {
            btnSignIn.Enabled = true;
            if (rbtnMonkey.Checked)
            {
                pbCharacter.Image = Properties.Resources.YogaAap;
                speler = new Speler(naam, 80, 20, 10, 5, Speler.PowerAttack.MonkeyJumper);
                CharacterStats(speler);
            }
            else if (rbtnGorilla.Checked)
            {
                pbCharacter.Image = Properties.Resources.AngryMonkey;
                speler = new Speler(naam, 130, 40, 5, 5, Speler.PowerAttack.Beast);
                CharacterStats(speler);
            }
            else if (rbtnCatWoman.Checked)
            {
                pbCharacter.Image = Properties.Resources.Catwoman;
                speler = new Speler(naam, 100, 25, 20, 6, Speler.PowerAttack.Catelyzer);
                CharacterStats(speler);
            }
            else
            {
                pbCharacter.Image = Properties.Resources.Superman;
                speler = new Speler(naam, 110, 30, 15, 6, Speler.PowerAttack.SuperDuper);
                CharacterStats(speler);
            }
        }
    }
}
