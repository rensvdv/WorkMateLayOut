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
    public partial class AgendaForm : Form
    {
        Gebruiker gebruiker;
        public AgendaForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;

            ZetAlleLabelAchtergrondenTransparant(Color.Transparent);

            lbAfspraak.Parent = pbAchtergrond;
            lbAfspraaksduur.Parent = pbAchtergrond;
            lbAfspraken.Parent = pbAchtergrond;
            lbAgenda.Parent = pbAchtergrond;
            lbBeschrijving.Parent = pbAchtergrond;
            lbDatum.Parent = pbAchtergrond;
            lbDatum2.Parent = pbAchtergrond;
            lbDocent1.Parent = pbAchtergrond;
            lbDocent2.Parent = pbAchtergrond;
            lbKlas.Parent = pbAchtergrond;
            lbKorteBeschrijving.Parent = pbAchtergrond;
            lbLokaal1.Parent = pbAchtergrond;
            lbLokaal2.Parent = pbAchtergrond;
            lbMailOntvanger.Parent = pbAchtergrond;
            lbNaamOntvanger.Parent = pbAchtergrond;
            lbTitel.Parent = pbAchtergrond;
            lbTitel2.Parent = pbAchtergrond;
            lbVak1.Parent = pbAchtergrond;
            lbVak2.Parent = pbAchtergrond;
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AgendaForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
