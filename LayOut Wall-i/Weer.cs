using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Net;
using System.Xml;

namespace HetWeer
{
    public class Weer
    {
        private double temperatuur;
        private double voeltAls;
        private double windsnelheid;
        private double humiditeit;
        private string url;
        private string weersverwachting;

        public Weer(double temperatuur, double voeltAls, double windsnelheid, double humiditeit, string weersverwachting)
        {
            this.temperatuur = temperatuur;
            this.voeltAls = voeltAls;
            this.windsnelheid = windsnelheid;
            this.humiditeit = humiditeit;
            this.weersverwachting = weersverwachting;
        }

        public Weer(string url)
        {
            this.url = url;
        }

        public string WeersVerwachting
        {
            get { return this.weersverwachting; }
        }

        public string Url
        {
            get { return this.url; }
        }

        public double Temperatuur
        {
            get { return this.temperatuur; }
        }
        
        public double VoeltAls
        {
            get { return this.voeltAls; }
        }

        public double Windsnelheid
        {
            get { return this.windsnelheid; }
        }

        public double Humiditeit
        {
            get { return this.humiditeit; }
        }
    }
}

