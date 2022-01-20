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
        Gebruiker gebruiker = new Gebruiker();
        public Inlogscherm()
        {
            InitializeComponent();

            lblGebr.Parent = pbAchtergrondInlog;
            lblGebr.BackColor = Color.Transparent;

            lblWw.Parent = pbAchtergrondInlog;
            lblWw.BackColor = Color.Transparent;

            lblVulGegevensIn.Parent = pbAchtergrondInlog;
            lblVulGegevensIn.BackColor = Color.Transparent;
    }

        private void btnBackGameMenu_Click(object sender, EventArgs e)
        {
            BeginschermWalli beginscherm = new BeginschermWalli();
            this.Hide();
            beginscherm.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string emailInput = tbxEmail.Text;
            string wwInput = tbxWachtwoord.Text;

            database.Inloggen(emailInput, wwInput, gebruiker);

            string gbEmail = gebruiker.Email.Trim();
            string gbWw = gebruiker.Email.Trim();

            if (gbEmail == emailInput && gbWw == wwInput && gebruiker.Ingelogd)
            {
                BeginschermNaInloggen overzicht = new BeginschermNaInloggen();
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
