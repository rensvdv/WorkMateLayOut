using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LayOut_Wall_i.Agenda
{
    public class Afspraak
    {
        public Gebruiker Ontvanger { get; set; }
        public Gebruiker Verzender { get; set; }
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public int Tijd { get; set; }
        public string email { get; set; }
        public Mail Email { get; set; }
        public DatabaseConnectie DatabaseCon { get; set; }

        public Afspraak(Gebruiker gebruiker, string ontvanger, string titel, string beschrijving, int tijd)
        {
            this.Titel = titel;
            this.Beschrijving = beschrijving;
            this.Tijd = tijd;
            this.DatabaseCon = new DatabaseConnectie();
            this.Ontvanger = new Gebruiker(ontvanger);
            this.Verzender = gebruiker;
        }
        public Afspraak(string titel, int tijd, string beschrijving)
        {
            this.Titel = titel;
            this.Beschrijving = beschrijving;
            this.Tijd = tijd;
            this.DatabaseCon = new DatabaseConnectie();
        }
        public Afspraak(string email, string titel, int tijd, string beschrijving)
        {
            this.DatabaseCon = new DatabaseConnectie();
            this.email = email;
            this.Titel = titel;
            this.Tijd = tijd;
            this.Beschrijving = beschrijving;
            this.Email = new Mail(email);
        }
        public bool ValideLengte(string text, int eindlengte)
        {
            bool valid = false;
            if (text.Length > 0 && text.Length <= eindlengte)
            {
                valid = true;
            }
            return valid;
        }
        public bool BestaandeOntvanger()
        {
            bool bestaand = false;
            this.DatabaseCon.Connect();
            string query = "SELECT * FROM Leerling WHERE Naam = @naamOntvanger";
            SqlCommand command = new SqlCommand(query, this.DatabaseCon.conn);
            command.Parameters.AddWithValue("@naamOntvanger", this.Ontvanger.Naam);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                bestaand = true;
                while (reader.Read())
                {
                    this.Ontvanger.LeerlingNummer = Convert.ToInt32(reader["Leerlingnummer"]);
                }
            }
            this.DatabaseCon.Disconnect();
            return bestaand;
        }
        public void MaakAfspraak()
        {
            if (ValideLengte(this.Beschrijving, 40) && BestaandeOntvanger() && ValideLengte(this.Titel, 20))
            {
                this.DatabaseCon.Connect();
                string query = "INSERT INTO Afspraak(AfspraakID,Leerlingnummer,Titel,[Tijd(uren)],Beschrijving,LeerlingnummerVerz) VALUES(@AfspraakID,@Leerlingnummer,@Titel,@Tijd,@Beschrijving,@Leerlingnummerverzender)";
                SqlCommand command = new SqlCommand(query, this.DatabaseCon.conn);
                command.Parameters.AddWithValue("@AfspraakID", 20);
                command.Parameters.AddWithValue("@Leerlingnummer", this.Ontvanger.LeerlingNummer);
                command.Parameters.AddWithValue("@Titel", this.Titel);
                command.Parameters.AddWithValue("@Tijd", this.Tijd);
                command.Parameters.AddWithValue("@Beschrijving", this.Beschrijving);
                command.Parameters.AddWithValue("@Leerlingnummerverzender", this.Verzender.LeerlingNummer);
                command.ExecuteNonQuery();
                this.DatabaseCon.Disconnect();
            }
        }

        public void StuurEmail()
        {
            this.Email.MailVersturen(this.Titel, this.Beschrijving, this.Tijd);
        }

        public override string ToString()
        {
            return $"{this.Titel}\n{this.Beschrijving}\n{this.Tijd}";
        }
    }
}
