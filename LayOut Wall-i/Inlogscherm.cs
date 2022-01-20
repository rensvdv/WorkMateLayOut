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
            BeginschermWalli beginscherm = new BeginschermWalli(gebruiker);
            this.Hide();
            beginscherm.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string emailInput = tbxEmail.Text;
            string wwInput = tbxWachtwoord.Text;
            string gbEmail = "";
            string gbWw = "";

            database.Inloggen(emailInput, wwInput, gebruiker);

            //checken of email en ww niet null zijn
            if (gebruiker.Email != null && gebruiker.Wachtwoord != null)
            {
                //trim de database gegevens, want er komen spaties achter de rijen
                gbEmail = gebruiker.Email.Trim();
                gbWw = gebruiker.Wachtwoord.Trim();
            }
            if (gbEmail == emailInput && gbWw == wwInput)
            {
                //als inloggegevens kloppen door naar volgende form
                MessageBox.Show("Goed ingelogd!");
                BeginschermNaInloggen overzicht = new BeginschermNaInloggen(gebruiker);
                this.Hide();
                overzicht.ShowDialog();
            }
            else
            {
                MessageBox.Show("Uw email/wachtwoord komen niet overeen.");
            }


        }

        private void Inlogscherm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
