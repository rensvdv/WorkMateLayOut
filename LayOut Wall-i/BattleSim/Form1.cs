using LayOut_Wall_i;
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
    public partial class Form1 : Form
    {
        Speler speler1;
        Speler speler2;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Speler1Selecteren()
        {
            if(rbSpeler1Swordsman.Checked)
            {
                speler1 = new Swordsman();
            }
            else if(rbSpeler1Tank.Checked)
            {
                speler1 = new Tank();
            }
            else if (rbSpeler1Medic.Checked)
            {
                speler1 = new Medic();
            }
            else if (rbSpeler1Assassin.Checked)
            {
                speler1 = new Assassin();
            }
        }
        private void Speler2Selecteren()
        {
            
            if (rbSpeler2Swordsman.Checked)
            {
                speler2 = new Swordsman();
            }
            else if (rbSpeler2Tank.Checked)
            {
                speler2 = new Tank();
            }
            else if (rbSpeler2Medic.Checked)
            {
                speler2 = new Medic();
            }
            else if (rbSpeler2Assassin.Checked)
            {
                speler2 = new Assassin();
            }
            
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Speler1Selecteren();
            Speler2Selecteren();
            Form2 f2 = new Form2(speler1, speler2);
            this.Hide();
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSurvivalBack_Click(object sender, EventArgs e)
        {
            //terug naar gameselect form
            GameMenuOG form = new GameMenuOG();
            this.Hide();
            form.ShowDialog();
        }
    }
}
