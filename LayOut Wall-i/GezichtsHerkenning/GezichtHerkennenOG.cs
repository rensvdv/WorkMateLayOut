using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using AForge.Video;
using AForge.Video.DirectShow;

namespace LayOut_Wall_i
{
    public partial class GezichtHerkennenOG : Form
    {
        GezichtsHerkenner gezichtsHerkenner = new GezichtsHerkenner();
        public IFaceClient Client;
        const string SubscriptionKey = "27dd6d32ac02424081821ce2bfd921d6";
        const string EndPoint = "https://workmatefaceapi.cognitiveservices.azure.com/";
        const string recognitionModel = RecognitionModel.Recognition04;
        FileStream file;

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        int count = 1;
        string personPicPath;

        //string array van foto's waar personen instaan voor de verificatie
        String[] picsPath = { Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Fotos", "Rens1.png"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Fotos", "Rens2.jpg"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Fotos", "Rowy1.png"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Fotos", "Rowy2.png"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Fotos", "Thor1.png"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Fotos", "Thor2.png"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Fotos", "Cezar1.png"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Fotos", "Cezar2.png"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Fotos", "Zaka1.png"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Fotos", "Zaka2.png")
            };

        public GezichtHerkennenOG()
        {
            InitializeComponent();
            gezichtsHerkenner.Connect();
            Client = new FaceClient(new ApiKeyServiceClientCredentials(SubscriptionKey)) { Endpoint = EndPoint };

            //laadt webcam in als form opstart
            LoadDevice();
            cboCamera.SelectedIndex = 0;
            StartVideo();

            lblScan.Parent = pbScan;
            lblScan.BackColor = Color.Transparent;
        }

        private async void btnScannen_Click(object sender, EventArgs e)
        {
            Opslaan();
            //string van de foto die gemaakt is met de webcam
            personPicPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Fotos", "Foto" + count.ToString()+".png");
            string naam = "a";
            count++;
            try
            {
                lblScanPopUp1.Visible = true;
                lblScanPopUp2.Visible = true;

                bool result = await GezichtsHerkenner.VergelijkGroep(Client, personPicPath, picsPath, naam);
                if (result)
                {
                    //als gezicht succesvol is herkent, door naar menu form
                    MessageBox.Show("Gezicht geïdentificeerd!");
                    BeginschermWalli beginscherm = new BeginschermWalli();
                    this.Hide();
                    beginscherm.ShowDialog();
                }
                else
                {
                    //gezicht wel herkent, maar komt niet overeen met foto's
                    MessageBox.Show("Niemand herkend, probeer het nog eens of log in!");

                    //na foute inlog via gezichtsherkenning kan je naar de handmatige inlog form
                    btnHandmatigeLogin.Visible = true;
                    lblScanPopUp1.Visible = false;
                    lblScanPopUp2.Visible = false;
                }
            }
            catch(Exception ex)
            {
                //geen gezicht herkent in webcam foto
                MessageBox.Show("Geen gezicht herkent! probeer het nog eens.");

                //na foute inlog via gezichtsherkenning kan je naar de handmatige inlog form
                btnHandmatigeLogin.Visible = true;
                lblScanPopUp1.Visible = false;
                lblScanPopUp2.Visible = false;
            }
            
        }
        private void LoadDevice()
        {
            //input devices ophalen
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterinfo in filterInfoCollection)
            {
                //input devices in de combo box zetten
                cboCamera.Items.Add(filterinfo.Name);
            }
            captureDevice = new VideoCaptureDevice();
        }

        private void StartVideo()
        {
            //input van capturedevice instellen en starten
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            captureDevice.Start();

        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //na iedere frame wordt de picturebox image aangepast
            pbCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void Opslaan()
        {
            pbScreenshot.Image = (Bitmap)pbCamera.Image.Clone();
            //foto uit picturebox halen en opslaan naar interne opslag
            Bitmap varBmp = new Bitmap(pbScreenshot.Image);
            varBmp.Save(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Fotos", "Foto" + count.ToString() + ".png"));

            //foto disposen voor minder geheugen verbruik
            varBmp.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Opslaan();
            //foto inladen en herkennen met face api
            file = new FileStream(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Workmate", "Fotos", "Foto" + count.ToString() + ".png"), FileMode.Open);

            try
            {
                //haalt eigenschappen op van de foto uit de webcam
                GezichtsHerkenner.DetectFaceExtractFile(Client, file, recognitionModel);
                count++;
            }
            catch(Exception exc)
            {
                MessageBox.Show("Gezicht niet herkent!, probeer het nog eens.");
            }
        }

        private void btnHandmatigeLogin_Click(object sender, EventArgs e)
        {
            Inlogscherm inloggen = new Inlogscherm();
            this.Hide();
            inloggen.ShowDialog();
        }

        private void GezichtHerkennenOG_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
