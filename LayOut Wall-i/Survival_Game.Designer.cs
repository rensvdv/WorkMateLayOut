
namespace LayOut_Wall_i
{
    partial class Survival_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbLeven = new System.Windows.Forms.Label();
            this.lbKogels = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.prBarPlayer = new System.Windows.Forms.ProgressBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lbTijd = new System.Windows.Forms.Label();
            this.pbSpeler = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbEnemyKills = new System.Windows.Forms.Label();
            this.lbEnemy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeler)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLeven
            // 
            this.lbLeven.AutoSize = true;
            this.lbLeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeven.ForeColor = System.Drawing.Color.Red;
            this.lbLeven.Location = new System.Drawing.Point(1679, 36);
            this.lbLeven.Name = "lbLeven";
            this.lbLeven.Size = new System.Drawing.Size(132, 32);
            this.lbLeven.TabIndex = 13;
            this.lbLeven.Text = "Leven: 0";
            // 
            // lbKogels
            // 
            this.lbKogels.AutoSize = true;
            this.lbKogels.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKogels.ForeColor = System.Drawing.Color.Red;
            this.lbKogels.Location = new System.Drawing.Point(12, 81);
            this.lbKogels.Name = "lbKogels";
            this.lbKogels.Size = new System.Drawing.Size(143, 32);
            this.lbKogels.TabIndex = 12;
            this.lbKogels.Text = "Kogels: 0";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.Red;
            this.lbScore.Location = new System.Drawing.Point(12, 36);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(128, 32);
            this.lbScore.TabIndex = 11;
            this.lbScore.Text = "Score: 0";
            // 
            // tbNaam
            // 
            this.tbNaam.Enabled = false;
            this.tbNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNaam.Location = new System.Drawing.Point(875, 84);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(144, 30);
            this.tbNaam.TabIndex = 10;
            // 
            // prBarPlayer
            // 
            this.prBarPlayer.BackColor = System.Drawing.Color.Lime;
            this.prBarPlayer.ForeColor = System.Drawing.Color.Red;
            this.prBarPlayer.Location = new System.Drawing.Point(1685, 91);
            this.prBarPlayer.Name = "prBarPlayer";
            this.prBarPlayer.Size = new System.Drawing.Size(209, 35);
            this.prBarPlayer.TabIndex = 9;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick_1);
            // 
            // lbTijd
            // 
            this.lbTijd.AutoSize = true;
            this.lbTijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTijd.ForeColor = System.Drawing.Color.Red;
            this.lbTijd.Location = new System.Drawing.Point(15, 904);
            this.lbTijd.Name = "lbTijd";
            this.lbTijd.Size = new System.Drawing.Size(100, 32);
            this.lbTijd.TabIndex = 15;
            this.lbTijd.Text = "Tijd: 0";
            // 
            // pbSpeler
            // 
            this.pbSpeler.Location = new System.Drawing.Point(888, 477);
            this.pbSpeler.Name = "pbSpeler";
            this.pbSpeler.Size = new System.Drawing.Size(164, 167);
            this.pbSpeler.TabIndex = 14;
            this.pbSpeler.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lbEnemyKills
            // 
            this.lbEnemyKills.AutoSize = true;
            this.lbEnemyKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnemyKills.ForeColor = System.Drawing.Color.Red;
            this.lbEnemyKills.Location = new System.Drawing.Point(166, 904);
            this.lbEnemyKills.Name = "lbEnemyKills";
            this.lbEnemyKills.Size = new System.Drawing.Size(201, 32);
            this.lbEnemyKills.TabIndex = 17;
            this.lbEnemyKills.Text = "EnemyKills: 0";
            // 
            // lbEnemy
            // 
            this.lbEnemy.AutoSize = true;
            this.lbEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnemy.ForeColor = System.Drawing.Color.Red;
            this.lbEnemy.Location = new System.Drawing.Point(1669, 904);
            this.lbEnemy.Name = "lbEnemy";
            this.lbEnemy.Size = new System.Drawing.Size(225, 32);
            this.lbEnemy.TabIndex = 16;
            this.lbEnemy.Text = "LevenEnemy: 0";
            // 
            // Survival_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.lbLeven);
            this.Controls.Add(this.lbKogels);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.prBarPlayer);
            this.Controls.Add(this.lbTijd);
            this.Controls.Add(this.pbSpeler);
            this.Controls.Add(this.lbEnemyKills);
            this.Controls.Add(this.lbEnemy);
            this.Name = "Survival_Game";
            this.Text = "Survival_Game";
            this.Load += new System.EventHandler(this.Survival_Game_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Survival_Game_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLeven;
        private System.Windows.Forms.Label lbKogels;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.ProgressBar prBarPlayer;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lbTijd;
        private System.Windows.Forms.PictureBox pbSpeler;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbEnemyKills;
        private System.Windows.Forms.Label lbEnemy;
    }
}