using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LayOut_Wall_i.Agenda
{
    public class Agenda
    {
        public string Klas { get; set; }
        public string Docent { get; set; }
        public string Lokaal { get; set; }
        public string Vak { get; set; }
        public int Tijd { get; set; }
        public List<Afspraak> Afspraken { get; set; } = new List<Afspraak>();
        public Gebruiker DeGebruiker { get; }
        public DatabaseConnectie DatabaseCon { get; set; }

        public Agenda(Gebruiker gebruiker, string klas, string docent, string lokaal, string vak)
        {
            this.DeGebruiker = gebruiker;
            this.Klas = klas;
            this.Docent = docent;
            this.Lokaal = lokaal;
            this.Vak = vak;
        }

        public void HaalAfsprakenOp()
        {
            this.DatabaseCon.Connect();
            string query = "SELECT * FROM Afspraak WHERE Leerlingnummer = @Leerlingnummer OR Leerlingnummerverzender = @Leerlingnummer";
            SqlCommand command = new SqlCommand(query, this.DatabaseCon.conn);
            command.Parameters.AddWithValue("@Leerlingnummer", this.DeGebruiker.LeerlingNummer);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Afspraak afspraak = new Afspraak(
                    Convert.ToString(reader["Titel"]),
                    Convert.ToInt32(reader["Tijd"]),
                    Convert.ToString(reader["Beschrijving"]));
                this.Afspraken.Add(afspraak);
            }
            this.DatabaseCon.Disconnect();
        }

        public void HaalLeerlingGegevensOp()
        {
            this.DatabaseCon.Connect();
            string query = "SELECT * FROM Leerling WHERE Leerlingnummer = @leerlingnummer";
            SqlCommand command = new SqlCommand(query, this.DatabaseCon.conn);
            command.Parameters.AddWithValue("@leerlingnummer", this.DeGebruiker.LeerlingNummer);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.Klas = reader["Klas"].ToString();
                this.Docent = reader["Docenten"].ToString();
                this.Vak = reader["Vak"].ToString();
                this.Lokaal = reader["Lokaal"].ToString();
            }
            this.DatabaseCon.Disconnect();
        }
    }
}
