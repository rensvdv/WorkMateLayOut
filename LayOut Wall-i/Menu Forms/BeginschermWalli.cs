﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayOut_Wall_i
{
    public partial class BeginschermWalli : Form
    {
        Gebruiker gebruiker;
        public BeginschermWalli()
        {
            InitializeComponent();
        }
        //2 constructors om gebruiker mee te geven als er ingelogd is
        public BeginschermWalli(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;
        }

        private void BeginschermWalli_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void btnGames_Click_1(object sender, EventArgs e)
        {
            GameMenuOG games = new GameMenuOG(gebruiker);
            this.Hide();
            games.ShowDialog();
        }

        private void btnWeer_Click_1(object sender, EventArgs e)
        {
            HetWeer.Form1 weer = new HetWeer.Form1(gebruiker);
            this.Hide();
            weer.ShowDialog();
        }

        private void btnInlog_Click(object sender, EventArgs e)
        {
            Inlogscherm inlog = new Inlogscherm();
            this.Hide();
            inlog.ShowDialog();
        }
    }
}
