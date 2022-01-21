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
    public partial class Survival_Game : Form
    {
        private Speler speler;
        private Enemy enemy;
        private PictureBox playerPic;
        private List<PictureBox> enemies = new List<PictureBox>();
        private LeaderBoard lb = new LeaderBoard();
        int tijd = 0;
        bool dropped = false;
        public Survival_Game(Speler speler, PictureBox pic)
        {
            this.speler = speler;
            this.playerPic = pic;
            InitializeComponent();
            Timer.Start();
            timer1.Start();
        }

        private void PrBarChange(Speler player)
        {
            if (player.Leven > 0)
            {
                prBarPlayer.Maximum = player.Leven;
                prBarPlayer.Value = player.Leven;
            }
            else
            {
                prBarPlayer.Value = 0;
                pbSpeler.Dispose();
                lb.VoegSpelerToe(speler);
                MessageBox.Show("Game Over");
                KeerTerugNaarHome();
            }
        }
        private void KeerTerugNaarHome()
        {
            SurvivalGame sur = new SurvivalGame();
            this.Hide();
            sur.ShowDialog();
        }

        private bool EnemyHit(PictureBox pic)
        {
            bool check = false;
            foreach (var pb in enemies)
            {
                if (pic.Bounds.IntersectsWith(pb.Bounds))
                {
                    check = true;
                }
            }
            return check;
        }
        private void MunitieBijvullen()
        {
            if (!dropped && speler.Kogels == 0)
            {
                DropBullets();
                dropped = true;
            }
            foreach (Control control in Controls)
            {
                if (control is PictureBox && (string)control.Tag == "kogels")
                {
                    if (pbSpeler.Bounds.IntersectsWith(control.Bounds))
                    {
                        this.Controls.Remove(control);
                        (control as PictureBox).Dispose();
                        speler.Kogels += 6;
                        dropped = false;
                    }
                }
            }
        }
        private void DropBullets()
        {
            if (speler.Kogels <= 0)
            {
                PictureBox kogels = new PictureBox();
                kogels.Image = Properties.Resources.Bullets;
                kogels.SizeMode = PictureBoxSizeMode.Zoom;
                kogels.Left = enemy.RandomLocation(10, this.ClientSize.Width);
                kogels.Top = enemy.RandomLocation(10, this.ClientSize.Height);
                kogels.Tag = "kogels";
                this.Controls.Add(kogels);
                kogels.BringToFront();
            }
        }
        private void AttackEnemy()
        {
            if (enemies.Count > 0)
            {
                speler.Attack(enemy);
                if (enemy.Leven <= 0)
                {
                    enemies[0].Dispose();
                    enemies.Remove(enemies[0]);
                    speler.EnemyCount++;
                }
                lbEnemy.Text = enemy.ToString();
            }
        }
        private void ValSpelerAan()
        {
            foreach (var pb in enemies)
            {
                if (pb.Left > pbSpeler.Left)
                {
                    pb.Left -= enemy.BewegingSnelheid;
                }
                if (pb.Left < pbSpeler.Left)
                {
                    pb.Left += enemy.BewegingSnelheid;
                }
                if (pb.Top > pbSpeler.Top)
                {
                    pb.Top -= enemy.BewegingSnelheid;
                }
                if (pb.Top < pbSpeler.Top)
                {
                    pb.Top += enemy.BewegingSnelheid;
                }
            }
        }
        private void MakeEnemy(int leven, int damage, int snelheid)
        {
            enemy = new Enemy(leven, damage, snelheid);
            PictureBox pic = new PictureBox();
            pic.Image = Properties.Resources.Enemy;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Left = enemy.RandomLocation(10, this.ClientSize.Width - pic.Width);
            pic.Top = enemy.RandomLocation(10, this.ClientSize.Height - pic.Height);
            enemies.Add(pic);
            foreach (var pb in enemies)
            {
                this.Controls.Add(pb);
            }
            pbSpeler.BringToFront();
        }

        private void Survival_Game_Load_1(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.WindowState = FormWindowState.Maximized;

            prBarPlayer.Maximum = speler.Leven;
            prBarPlayer.Value = speler.Leven;
            tbNaam.Text = speler.PlayerNaam;
            lbKogels.Text = $"Kogels: {speler.Kogels}";
            lbLeven.Text = $"Leven: {speler.Leven}";
            pbSpeler.Image = playerPic.Image;
            pbSpeler.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Timer_Tick_1(object sender, EventArgs e)
        {
            tijd++;
            lbTijd.Text = $"Tijd: {tijd}";
            if (tijd % 7 == 0)
            {
                MakeEnemy(30, 15, 5);
            }
            if (tijd >= 40)
            {
                if (tijd % 7 == 0)
                {
                    MakeEnemy(40, 20, 10);
                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (enemy != null)
            {
                ValSpelerAan();
                enemy.BeastMode(tijd);
                speler.Genees(tijd);
                lbLeven.Text = $"Leven: {speler.Leven}";
                lbEnemy.Text = enemy.ToString();
            }
        }

        private void Survival_Game_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    pbSpeler.Left -= speler.BewegingSnelheid;
                    break;
                case Keys.Right:
                    pbSpeler.Left += speler.BewegingSnelheid;
                    break;
                case Keys.Up:
                    pbSpeler.Top -= speler.BewegingSnelheid;
                    break;
                case Keys.Down:
                    pbSpeler.Top += speler.BewegingSnelheid;
                    break;
                case Keys.Space:
                    AttackEnemy();
                    break;
            }
            MunitieBijvullen();
            if (EnemyHit(pbSpeler))
            {
                enemy.GiveDamage(speler);
                PrBarChange(speler);
            }
            lbScore.Text = $"Score: {speler.Score}";
            lbKogels.Text = $"Kogels: {speler.Kogels}";
            lbEnemyKills.Text = $"EnemyKills: {speler.EnemyCount}";
        }
    }
}
