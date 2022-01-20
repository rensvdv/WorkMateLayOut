using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Net;
using LayOut_Wall_i;

namespace HetWeer
{
    public partial class Form1 : Form
    {
        Gebruiker gebruiker;
        Spraak spraak = new Spraak();

        Weer api = new Weer("http://api.weatherapi.com/v1/current.xml?key=8fee798205ff4b0e965154533212311&q=Tilburg&aqi=yes");
        
        public Form1()
        {
            InitializeComponent();

            lbTemperatuur.Parent = pbAchtergrondWeer;
            lbTemperatuur.BackColor = Color.Transparent;

            lbVoeltAls.Parent = pbAchtergrondWeer;
            lbVoeltAls.BackColor = Color.Transparent;

            lbWindSnelheid.Parent = pbAchtergrondWeer;
            lbWindSnelheid.BackColor = Color.Transparent;

            lbHumiditeit.Parent = pbAchtergrondWeer;
            lbHumiditeit.BackColor = Color.Transparent;

            lbWolken.Parent = pbAchtergrondWeer;
            lbWolken.BackColor = Color.Transparent;


            lblNederland.Parent = pbAchtergrondWeer;
            lblNederland.BackColor = Color.Transparent;


            lblTilburg.Parent = pbAchtergrondWeer;
            lblTilburg.BackColor = Color.Transparent;
        }

        //2e constructor om gebruiker mee te geven na inloggen
        public Form1(Gebruiker gebruiker)
        {
            InitializeComponent();

            this.gebruiker = gebruiker;

            lbTemperatuur.Parent = pbAchtergrondWeer;
            lbTemperatuur.BackColor = Color.Transparent;

            lbVoeltAls.Parent = pbAchtergrondWeer;
            lbVoeltAls.BackColor = Color.Transparent;

            lbWindSnelheid.Parent = pbAchtergrondWeer;
            lbWindSnelheid.BackColor = Color.Transparent;

            lbHumiditeit.Parent = pbAchtergrondWeer;
            lbHumiditeit.BackColor = Color.Transparent;

            lbWolken.Parent = pbAchtergrondWeer;
            lbWolken.BackColor = Color.Transparent;


            lblNederland.Parent = pbAchtergrondWeer;
            lblNederland.BackColor = Color.Transparent;


            lblTilburg.Parent = pbAchtergrondWeer;
            lblTilburg.BackColor = Color.Transparent;
        }
        private void WeerTonen()
        {
            XDocument bestand = XDocument.Load(api.Url);
            Weer weer = new Weer((double)bestand.Descendants("temp_c").FirstOrDefault(), (double)bestand.Descendants("feelslike_c").FirstOrDefault(), (double)bestand.Descendants("wind_kph").FirstOrDefault(), (double)bestand.Descendants("humidity").FirstOrDefault(), (string)bestand.Descendants("text").FirstOrDefault());
            string icoon = (string)bestand.Descendants("icon").FirstOrDefault();
            WebClient client = new WebClient();
            byte[] afbeelding = client.DownloadData("http:" + icoon);
            MemoryStream stream = new MemoryStream(afbeelding);
            Bitmap nieuwebitmap = new Bitmap(stream);
            Bitmap icoon2 = nieuwebitmap;

            lbTemperatuur.Text = $"{weer.Temperatuur} ℃";
            lbVoeltAls.Text = $"{weer.VoeltAls} ℃";
            lbWindSnelheid.Text = $"{weer.Windsnelheid} km/h";
            lbHumiditeit.Text = $"{weer.Humiditeit} %";
            lbWolken.Text = weer.WeersVerwachting;

            pbWolk.Image = icoon2;

            Output();
        }

        private void Output()
        {
            spraak.Zeg("temperature = " + lbTemperatuur.Text);
            spraak.Zeg("feels as " + lbVoeltAls.Text);
            spraak.Zeg("wind speed " + lbWindSnelheid.Text);
            spraak.Zeg("humidity " + lbHumiditeit.Text);
            spraak.Zeg("expectancy " + lbWolken.Text);
        }

        private void btnVerwachting_Click(object sender, EventArgs e)
        {
            DataTable verwachting = new DataTable();
            verwachting.Columns.Add("Datum", typeof(string));
            verwachting.Columns.Add("Temperatuur (℃)", typeof(double));
            verwachting.Columns.Add("Voelt als (℃)", typeof(double));
            verwachting.Columns.Add("Windsnelheid (KM/h)", typeof(double));
            verwachting.Columns.Add("Humididteit (%)", typeof(double));
            verwachting.Columns.Add("Het weer is", typeof(string));
          
            dataGridView1.Visible = true;
            string url2 = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=8fee798205ff4b0e965154533212311&q=Tilburg&days=4&aqi=yes&alerts=no");
            XDocument Doc2 = XDocument.Load(url2);
            foreach (var doc2 in Doc2.Descendants("forecastday"))
            {
                string icoon = (string)doc2.Descendants("icon").FirstOrDefault();
                WebClient client = new WebClient();
                byte[] afbeelding = client.DownloadData("http:" + icoon);
                MemoryStream stream = new MemoryStream(afbeelding);
                Bitmap bitmap2 = new Bitmap(stream);
                verwachting.Rows.Add(new object[]
                {
                (string)doc2.Descendants("date").FirstOrDefault(),
                (double)doc2.Descendants("temp_c").FirstOrDefault(),
                (double)doc2.Descendants("feelslike_c").FirstOrDefault(),
                (double)doc2.Descendants("wind_kph").FirstOrDefault(),
                (double)doc2.Descendants("humidity").FirstOrDefault(),
                (string)doc2.Descendants("text").FirstOrDefault()
                });
            }
            dataGridView1.DataSource = verwachting;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BeginschermWalli ver = new BeginschermWalli();
            this.Hide();
            ver.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.WindowState = FormWindowState.Maximized;
            WeerTonen();
        }
    }
}
