using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LayOut_Wall_i
{
    public class DatabaseConnectie
    {

        private static string connectionString = @"Data Source=SQL1\SQLEXPRESS;Initial Catalog=workmate;Integrated Security=True; TrustServerCertificate=True";
        public SqlConnection conn { get; set; }
        public void Connect()
        {
            //connect met de database
            try
            {
                this.conn = new SqlConnection(connectionString);
                this.conn.Open();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        public void Disconnect()
        {
            //disconnect met de database
            try
            {
                this.conn.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        public void ConnectieTesten()
        {
            Connect();
            Disconnect();
        }
        public void Inloggen(string email, string wachtwoord, Gebruiker gebruiker)
        {
            try
            {
                this.Connect();
                string query = "SELECT * FROM Leerling WHERE Email = @email AND Wachtwoord = @wachtwoord";
                SqlCommand command = new SqlCommand(query, this.conn);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@wachtwoord", wachtwoord);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) //als inloggegevens kloppen, zet alle gegevens in gebruiker
                {
                    while (reader.Read())
                    {
                        gebruiker.LeerlingNummer = Convert.ToInt32(reader["Leerlingnummer"]);
                        gebruiker.Naam = reader["Naam"].ToString();
                        gebruiker.Email = reader["Email"].ToString();
                        gebruiker.Wachtwoord = reader["Wachtwoord"].ToString();
                        gebruiker.Klas = reader["Klas"].ToString();
                        gebruiker.Docenten = reader["Docenten"].ToString();
                        gebruiker.Lokaal = reader["Lokaal"].ToString();
                        gebruiker.Vak = reader["Vak"].ToString();

                    }
                }
                else
                {
                    Console.WriteLine("Uw email en/of wachtwoord zijn onjuist!");
                }

                this.Disconnect();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
