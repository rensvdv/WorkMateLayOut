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
    public partial class AgendaForm : Form
    {
        Spraak spraak = new Spraak();
        Gebruiker gebruiker;
        private Agenda.Agenda agenda;
        private Agenda.Afspraak afspraak;
        public AgendaForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
            agenda = new Agenda.Agenda(gebruiker,gebruiker.Klas,gebruiker.Docenten,gebruiker.Lokaal,gebruiker.Vak);
            ZetAlleLabelAchtergrondenTransparant(Color.Transparent);

            lbAfspraak.Parent = pbAchtergrond;
            lbAfspraaksduur.Parent = pbAchtergrond;
            lbxAfspraken.Parent = pbAchtergrond;
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
            lbKlas2.Parent = pbAchtergrond;
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

        private void AgendaForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.WindowState = FormWindowState.Maximized;

            Form.CheckForIllegalCrossThreadCalls = false;
            spraak.speechRec.SpeechRecognized += Recoginition;
            lbNaam.Text = $"Welkom {gebruiker.Naam}";
        }

        private void Recoginition(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.Contains("back") || e.Result.Text.Contains("menu"))
            {
                spraak.Reageer(e.Result.Text);
                Form1 form = new Form1();
                //KeerTerug(form);
            }
            if (e.Result.Text.Contains("show"))
            {
                spraak.Reageer("show");
            }
        }

        private void btnZieAfspraken_Click(object sender, EventArgs e)
        {
            lbxAfspraken.Items.Clear();
            agenda.Afspraken.Clear();
            agenda.HaalAfsprakenOp();
            if (agenda.Afspraken.Count > 0)
            {
                foreach (var afspraak in agenda.Afspraken)
                {
                    lbxAfspraken.Items.Add(afspraak);
                }
            }
            else
            {
                lbxAfspraken.Items.Add("Je hebt geen afspraken");
            }
        }
    

        private void btnDagplanning_Click(object sender, EventArgs e)
        {
            agenda.HaalLeerlingGegevensOp();
            lbDatum3.Text = DateTime.Today.ToString();
            lbDocent2.Text = agenda.Docent;
            lbKlas2.Text = agenda.Klas;
            lbVak2.Text = agenda.Vak;
            lbLokaal2.Text = agenda.Lokaal;
        }

        private void btnAfspraakMaken_Click(object sender, EventArgs e)
        {
            string titel = tbTitel.Text;
            string beschrijving = tbKorteBeschrijving.Text;
            string ontvanger = tbOntvanger.Text;
            if (titel != "" && ontvanger != "" && beschrijving != "" || beschrijving.Length > 40)
            {
                afspraak = new Agenda.Afspraak(this.gebruiker, ontvanger, titel, beschrijving, Convert.ToInt32(cbDuur.SelectedItem));
                afspraak.MaakAfspraak();
                MessageBox.Show("Afspraak succesvol gemaakt");
            }
            else
            {
                MessageBox.Show("Voer aub alle velden in en zorg ervoor dat de beschrijving maar maximaal 40 karakters lang is.");
            }
            btnZieAfspraken_Click(sender, e);
        }

        private void btnEmailSturen_Click(object sender, EventArgs e)
        {
            string email = tbMailOntvanger.Text;
            string beschrijving = tbKorteBeschrijving.Text;
            string titel = tbTitelMail.Text;
            if (titel != "" && beschrijving != "" && email != "")
            {
                afspraak = new Agenda.Afspraak(email, titel, datePicker.Value.Hour, beschrijving);
                afspraak.StuurEmail();
                afspraak.Email.Client.SendCompleted += new System.Net.Mail.SendCompletedEventHandler(SendCallBack);
            }
            btnZieAfspraken_Click(sender, e);
        }

        private void SendCallBack(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show($"{e.UserState} Bericht is gecancellend\nProbeer het opnieuw", "Verzenden mislukt");
            }
            if (e.Error != null)
            {
                MessageBox.Show($"Sta 'minder beveiligde apps' toe in je google account.\nEr kan op dit moment geen email worden verzonden.", $"{e.UserState}");
            }
            else
            {
                MessageBox.Show($"Bericht succesvol verzonden");
            }
        }

        private void lbAfspraken_SelectedIndexChanged(object sender, EventArgs e)
        {
            Agenda.Afspraak afspraak = lbxAfspraken.SelectedItem as Agenda.Afspraak;
            MessageBox.Show($"Titel: {afspraak.Titel}\nBeschrijving: {afspraak.Beschrijving}\n TijdsDuur: {afspraak.Tijd}", "Afspraakgegevens");
        }

        private void pbAchtergrond_Click(object sender, EventArgs e)
        {

        }
    }
}
