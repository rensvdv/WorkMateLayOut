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
    public partial class Inlogscherm : Form
    {
        DatabaseConnectie database = new DatabaseConnectie();
        Gebruiker gebruiker;
        public Inlogscherm()
        {
            InitializeComponent();

            lblGebr.Parent = pbAchtergrondInlog;
            lblGebr.BackColor = Color.Transparent;

            lblWw.Parent = pbAchtergrondInlog;
            lblWw.BackColor = Color.Transparent;

            lblVulGegevensIn.Parent = pbAchtergrondInlog;
            lblVulGegevensIn.BackColor = Color.Transparent;
            gebruiker = new Gebruiker();
        }

        private void btnBackGameMenu_Click(object sender, EventArgs e)
        {
            BeginschermWalli beginscherm = new BeginschermWalli(gebruiker);
            this.Hide();
            beginscherm.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string emailInput = tbxEmail.Text;
            string wwInput = tbxWachtwoord.Text;

            database.Inloggen(emailInput, wwInput, gebruiker);

            //trim de database gegevens, want er komen spaties achter de rijen
            string gbEmail = gebruiker.Email.Trim();
            string gbWw = gebruiker.Email.Trim();

            if (gbEmail == emailInput && gbWw == wwInput && gebruiker.Ingelogd)
            {
                //als inloggegevens kloppen door naar volgende form
                BeginschermNaInloggen overzicht = new BeginschermNaInloggen(gebruiker);
                this.Hide();
                overzicht.ShowDialog();
            }
            else
            {
                MessageBox.Show("Uw email/wachtwoord komt niet overeen.");
            }
        }
    }
}
