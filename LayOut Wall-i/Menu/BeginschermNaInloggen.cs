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
    public partial class BeginschermNaInloggen : Form
    {
        public BeginschermNaInloggen()
        {
            InitializeComponent();
        }

        private void btnGames_Click_1(object sender, EventArgs e)
        {
            GameMenuOG ver = new GameMenuOG();
            this.Hide();
            ver.ShowDialog();
        }

        private void btnWeer_Click_1(object sender, EventArgs e)
        {
            HetWeer.Form1 ver = new HetWeer.Form1();
            this.Hide();
            ver.ShowDialog();
        }

        private void btnNaarAgenda_Click(object sender, EventArgs e)
        {

        }
    }
}
