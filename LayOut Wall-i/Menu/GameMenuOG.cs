using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurnBasedGame;

namespace LayOut_Wall_i
{
    public partial class GameMenuOG : Form
    {
        public GameMenuOG()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ver = new Form1();
            this.Hide();
            ver.ShowDialog();
        }

        private void btnBackGameMenu_Click(object sender, EventArgs e)
        {
            BeginschermWalli form = new BeginschermWalli();
            this.Hide();
            form.ShowDialog();
        }
    }
}
