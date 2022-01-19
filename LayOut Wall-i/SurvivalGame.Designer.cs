
namespace LayOut_Wall_i
{
    partial class SurvivalGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurvivalGame));
            this.lbxLeaderBoard = new System.Windows.Forms.ListBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lbBullets = new System.Windows.Forms.Label();
            this.lbMovement = new System.Windows.Forms.Label();
            this.lbDamage = new System.Windows.Forms.Label();
            this.lbLeven = new System.Windows.Forms.Label();
            this.btnSaveName = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCharacters = new System.Windows.Forms.GroupBox();
            this.rbtnCatWoman = new System.Windows.Forms.RadioButton();
            this.rbtnSuperman = new System.Windows.Forms.RadioButton();
            this.rbtnMonkey = new System.Windows.Forms.RadioButton();
            this.rbtnGorilla = new System.Windows.Forms.RadioButton();
            this.lbPlayernaam = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbCharacters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxLeaderBoard
            // 
            this.lbxLeaderBoard.BackColor = System.Drawing.Color.Black;
            this.lbxLeaderBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxLeaderBoard.ForeColor = System.Drawing.Color.White;
            this.lbxLeaderBoard.FormattingEnabled = true;
            this.lbxLeaderBoard.ItemHeight = 25;
            this.lbxLeaderBoard.Location = new System.Drawing.Point(673, 100);
            this.lbxLeaderBoard.Name = "lbxLeaderBoard";
            this.lbxLeaderBoard.Size = new System.Drawing.Size(396, 454);
            this.lbxLeaderBoard.TabIndex = 22;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Moccasin;
            this.btnSignIn.Enabled = false;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.Black;
            this.btnSignIn.Location = new System.Drawing.Point(54, 502);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(230, 62);
            this.btnSignIn.TabIndex = 20;
            this.btnSignIn.Text = "Play";
            this.btnSignIn.UseVisualStyleBackColor = false;
            // 
            // lbBullets
            // 
            this.lbBullets.AutoSize = true;
            this.lbBullets.Location = new System.Drawing.Point(6, 165);
            this.lbBullets.Name = "lbBullets";
            this.lbBullets.Size = new System.Drawing.Size(77, 25);
            this.lbBullets.TabIndex = 3;
            this.lbBullets.Text = "Bullets";
            // 
            // lbMovement
            // 
            this.lbMovement.AutoSize = true;
            this.lbMovement.Location = new System.Drawing.Point(6, 125);
            this.lbMovement.Name = "lbMovement";
            this.lbMovement.Size = new System.Drawing.Size(119, 25);
            this.lbMovement.TabIndex = 2;
            this.lbMovement.Text = "Movement:";
            // 
            // lbDamage
            // 
            this.lbDamage.AutoSize = true;
            this.lbDamage.Location = new System.Drawing.Point(6, 85);
            this.lbDamage.Name = "lbDamage";
            this.lbDamage.Size = new System.Drawing.Size(92, 25);
            this.lbDamage.TabIndex = 1;
            this.lbDamage.Text = "Damage";
            // 
            // lbLeven
            // 
            this.lbLeven.AutoSize = true;
            this.lbLeven.Location = new System.Drawing.Point(6, 44);
            this.lbLeven.Name = "lbLeven";
            this.lbLeven.Size = new System.Drawing.Size(71, 25);
            this.lbLeven.TabIndex = 0;
            this.lbLeven.Text = "Leven";
            // 
            // btnSaveName
            // 
            this.btnSaveName.BackColor = System.Drawing.Color.Moccasin;
            this.btnSaveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveName.ForeColor = System.Drawing.Color.Black;
            this.btnSaveName.Location = new System.Drawing.Point(60, 412);
            this.btnSaveName.Name = "btnSaveName";
            this.btnSaveName.Size = new System.Drawing.Size(211, 61);
            this.btnSaveName.TabIndex = 21;
            this.btnSaveName.Text = "Save Name";
            this.btnSaveName.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.lbBullets);
            this.groupBox1.Controls.Add(this.lbMovement);
            this.groupBox1.Controls.Add(this.lbDamage);
            this.groupBox1.Controls.Add(this.lbLeven);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(326, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 217);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Character";
            // 
            // gbCharacters
            // 
            this.gbCharacters.BackColor = System.Drawing.Color.Transparent;
            this.gbCharacters.Controls.Add(this.rbtnCatWoman);
            this.gbCharacters.Controls.Add(this.rbtnSuperman);
            this.gbCharacters.Controls.Add(this.rbtnMonkey);
            this.gbCharacters.Controls.Add(this.rbtnGorilla);
            this.gbCharacters.Enabled = false;
            this.gbCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCharacters.Location = new System.Drawing.Point(54, 83);
            this.gbCharacters.Name = "gbCharacters";
            this.gbCharacters.Size = new System.Drawing.Size(219, 201);
            this.gbCharacters.TabIndex = 16;
            this.gbCharacters.TabStop = false;
            this.gbCharacters.Text = "Pick a Character";
            // 
            // rbtnCatWoman
            // 
            this.rbtnCatWoman.AutoSize = true;
            this.rbtnCatWoman.Location = new System.Drawing.Point(8, 123);
            this.rbtnCatWoman.Name = "rbtnCatWoman";
            this.rbtnCatWoman.Size = new System.Drawing.Size(147, 29);
            this.rbtnCatWoman.TabIndex = 6;
            this.rbtnCatWoman.TabStop = true;
            this.rbtnCatWoman.Text = "Cat Woman";
            this.rbtnCatWoman.UseVisualStyleBackColor = true;
            // 
            // rbtnSuperman
            // 
            this.rbtnSuperman.AutoSize = true;
            this.rbtnSuperman.Location = new System.Drawing.Point(8, 158);
            this.rbtnSuperman.Name = "rbtnSuperman";
            this.rbtnSuperman.Size = new System.Drawing.Size(132, 29);
            this.rbtnSuperman.TabIndex = 7;
            this.rbtnSuperman.TabStop = true;
            this.rbtnSuperman.Text = "Superman";
            this.rbtnSuperman.UseVisualStyleBackColor = true;
            // 
            // rbtnMonkey
            // 
            this.rbtnMonkey.AutoSize = true;
            this.rbtnMonkey.Location = new System.Drawing.Point(6, 53);
            this.rbtnMonkey.Name = "rbtnMonkey";
            this.rbtnMonkey.Size = new System.Drawing.Size(109, 29);
            this.rbtnMonkey.TabIndex = 4;
            this.rbtnMonkey.TabStop = true;
            this.rbtnMonkey.Text = "Monkey";
            this.rbtnMonkey.UseVisualStyleBackColor = true;
            // 
            // rbtnGorilla
            // 
            this.rbtnGorilla.AutoSize = true;
            this.rbtnGorilla.Location = new System.Drawing.Point(6, 88);
            this.rbtnGorilla.Name = "rbtnGorilla";
            this.rbtnGorilla.Size = new System.Drawing.Size(95, 29);
            this.rbtnGorilla.TabIndex = 5;
            this.rbtnGorilla.TabStop = true;
            this.rbtnGorilla.Text = "Gorilla";
            this.rbtnGorilla.UseVisualStyleBackColor = true;
            // 
            // lbPlayernaam
            // 
            this.lbPlayernaam.AutoSize = true;
            this.lbPlayernaam.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayernaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayernaam.Location = new System.Drawing.Point(57, 323);
            this.lbPlayernaam.Name = "lbPlayernaam";
            this.lbPlayernaam.Size = new System.Drawing.Size(126, 25);
            this.lbPlayernaam.TabIndex = 15;
            this.lbPlayernaam.Text = "Playernaam";
            // 
            // tbNaam
            // 
            this.tbNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNaam.Location = new System.Drawing.Point(62, 363);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(163, 30);
            this.tbNaam.TabIndex = 14;
            // 
            // pbCharacter
            // 
            this.pbCharacter.BackColor = System.Drawing.Color.Transparent;
            this.pbCharacter.Location = new System.Drawing.Point(341, 111);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(210, 187);
            this.pbCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCharacter.TabIndex = 17;
            this.pbCharacter.TabStop = false;
            // 
            // btnTerug
            // 
            this.btnTerug.BackColor = System.Drawing.Color.Moccasin;
            this.btnTerug.Enabled = false;
            this.btnTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.ForeColor = System.Drawing.Color.Black;
            this.btnTerug.Location = new System.Drawing.Point(16, 12);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(153, 47);
            this.btnTerug.TabIndex = 23;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = false;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // SurvivalGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 602);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.lbxLeaderBoard);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnSaveName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCharacters);
            this.Controls.Add(this.pbCharacter);
            this.Controls.Add(this.lbPlayernaam);
            this.Controls.Add(this.tbNaam);
            this.Name = "SurvivalGame";
            this.Text = "SurvivalGame";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCharacters.ResumeLayout(false);
            this.gbCharacters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxLeaderBoard;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lbBullets;
        private System.Windows.Forms.Label lbMovement;
        private System.Windows.Forms.Label lbDamage;
        private System.Windows.Forms.Label lbLeven;
        private System.Windows.Forms.Button btnSaveName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCharacters;
        private System.Windows.Forms.RadioButton rbtnCatWoman;
        private System.Windows.Forms.RadioButton rbtnSuperman;
        private System.Windows.Forms.RadioButton rbtnMonkey;
        private System.Windows.Forms.RadioButton rbtnGorilla;
        private System.Windows.Forms.PictureBox pbCharacter;
        private System.Windows.Forms.Label lbPlayernaam;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Button btnTerug;
    }
}