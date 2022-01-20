
namespace TurnBasedGame
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSpeler1Assassin = new System.Windows.Forms.RadioButton();
            this.rbSpeler1Medic = new System.Windows.Forms.RadioButton();
            this.rbSpeler1Tank = new System.Windows.Forms.RadioButton();
            this.rbSpeler1Swordsman = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSpeler2Assassin = new System.Windows.Forms.RadioButton();
            this.rbSpeler2Medic = new System.Windows.Forms.RadioButton();
            this.rbSpeler2Tank = new System.Windows.Forms.RadioButton();
            this.rbSpeler2Swordsman = new System.Windows.Forms.RadioButton();
            this.btnSurvivalBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speler 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speler 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selecteer je karakter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selecteer je karakter";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(330, 323);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 71);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSpeler1Assassin);
            this.groupBox1.Controls.Add(this.rbSpeler1Medic);
            this.groupBox1.Controls.Add(this.rbSpeler1Tank);
            this.groupBox1.Controls.Add(this.rbSpeler1Swordsman);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(49, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 285);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // rbSpeler1Assassin
            // 
            this.rbSpeler1Assassin.AutoSize = true;
            this.rbSpeler1Assassin.Location = new System.Drawing.Point(51, 205);
            this.rbSpeler1Assassin.Name = "rbSpeler1Assassin";
            this.rbSpeler1Assassin.Size = new System.Drawing.Size(85, 21);
            this.rbSpeler1Assassin.TabIndex = 8;
            this.rbSpeler1Assassin.TabStop = true;
            this.rbSpeler1Assassin.Text = "Assassin";
            this.rbSpeler1Assassin.UseVisualStyleBackColor = true;
            // 
            // rbSpeler1Medic
            // 
            this.rbSpeler1Medic.AutoSize = true;
            this.rbSpeler1Medic.Location = new System.Drawing.Point(51, 166);
            this.rbSpeler1Medic.Name = "rbSpeler1Medic";
            this.rbSpeler1Medic.Size = new System.Drawing.Size(66, 21);
            this.rbSpeler1Medic.TabIndex = 7;
            this.rbSpeler1Medic.TabStop = true;
            this.rbSpeler1Medic.Text = "Medic";
            this.rbSpeler1Medic.UseVisualStyleBackColor = true;
            // 
            // rbSpeler1Tank
            // 
            this.rbSpeler1Tank.AutoSize = true;
            this.rbSpeler1Tank.Location = new System.Drawing.Point(51, 128);
            this.rbSpeler1Tank.Name = "rbSpeler1Tank";
            this.rbSpeler1Tank.Size = new System.Drawing.Size(61, 21);
            this.rbSpeler1Tank.TabIndex = 6;
            this.rbSpeler1Tank.TabStop = true;
            this.rbSpeler1Tank.Text = "Tank";
            this.rbSpeler1Tank.UseVisualStyleBackColor = true;
            // 
            // rbSpeler1Swordsman
            // 
            this.rbSpeler1Swordsman.AutoSize = true;
            this.rbSpeler1Swordsman.Location = new System.Drawing.Point(51, 89);
            this.rbSpeler1Swordsman.Name = "rbSpeler1Swordsman";
            this.rbSpeler1Swordsman.Size = new System.Drawing.Size(102, 21);
            this.rbSpeler1Swordsman.TabIndex = 5;
            this.rbSpeler1Swordsman.TabStop = true;
            this.rbSpeler1Swordsman.Text = "Swordsman";
            this.rbSpeler1Swordsman.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSpeler2Assassin);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rbSpeler2Medic);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rbSpeler2Tank);
            this.groupBox2.Controls.Add(this.rbSpeler2Swordsman);
            this.groupBox2.Location = new System.Drawing.Point(452, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 285);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // rbSpeler2Assassin
            // 
            this.rbSpeler2Assassin.AutoSize = true;
            this.rbSpeler2Assassin.Location = new System.Drawing.Point(49, 205);
            this.rbSpeler2Assassin.Name = "rbSpeler2Assassin";
            this.rbSpeler2Assassin.Size = new System.Drawing.Size(85, 21);
            this.rbSpeler2Assassin.TabIndex = 12;
            this.rbSpeler2Assassin.TabStop = true;
            this.rbSpeler2Assassin.Text = "Assassin";
            this.rbSpeler2Assassin.UseVisualStyleBackColor = true;
            // 
            // rbSpeler2Medic
            // 
            this.rbSpeler2Medic.AutoSize = true;
            this.rbSpeler2Medic.Location = new System.Drawing.Point(49, 166);
            this.rbSpeler2Medic.Name = "rbSpeler2Medic";
            this.rbSpeler2Medic.Size = new System.Drawing.Size(66, 21);
            this.rbSpeler2Medic.TabIndex = 11;
            this.rbSpeler2Medic.TabStop = true;
            this.rbSpeler2Medic.Text = "Medic";
            this.rbSpeler2Medic.UseVisualStyleBackColor = true;
            // 
            // rbSpeler2Tank
            // 
            this.rbSpeler2Tank.AutoSize = true;
            this.rbSpeler2Tank.Location = new System.Drawing.Point(49, 128);
            this.rbSpeler2Tank.Name = "rbSpeler2Tank";
            this.rbSpeler2Tank.Size = new System.Drawing.Size(61, 21);
            this.rbSpeler2Tank.TabIndex = 10;
            this.rbSpeler2Tank.TabStop = true;
            this.rbSpeler2Tank.Text = "Tank";
            this.rbSpeler2Tank.UseVisualStyleBackColor = true;
            // 
            // rbSpeler2Swordsman
            // 
            this.rbSpeler2Swordsman.AutoSize = true;
            this.rbSpeler2Swordsman.Location = new System.Drawing.Point(49, 89);
            this.rbSpeler2Swordsman.Name = "rbSpeler2Swordsman";
            this.rbSpeler2Swordsman.Size = new System.Drawing.Size(102, 21);
            this.rbSpeler2Swordsman.TabIndex = 9;
            this.rbSpeler2Swordsman.TabStop = true;
            this.rbSpeler2Swordsman.Text = "Swordsman";
            this.rbSpeler2Swordsman.UseVisualStyleBackColor = true;
            // 
            // btnSurvivalBack
            // 
            this.btnSurvivalBack.BackColor = System.Drawing.Color.Black;
            this.btnSurvivalBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurvivalBack.ForeColor = System.Drawing.Color.Red;
            this.btnSurvivalBack.Location = new System.Drawing.Point(54, 357);
            this.btnSurvivalBack.Name = "btnSurvivalBack";
            this.btnSurvivalBack.Size = new System.Drawing.Size(112, 67);
            this.btnSurvivalBack.TabIndex = 9;
            this.btnSurvivalBack.Text = "🠔";
            this.btnSurvivalBack.UseVisualStyleBackColor = false;
            this.btnSurvivalBack.Click += new System.EventHandler(this.btnSurvivalBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSurvivalBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSpeler1Assassin;
        private System.Windows.Forms.RadioButton rbSpeler1Medic;
        private System.Windows.Forms.RadioButton rbSpeler1Tank;
        private System.Windows.Forms.RadioButton rbSpeler1Swordsman;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSpeler2Assassin;
        private System.Windows.Forms.RadioButton rbSpeler2Medic;
        private System.Windows.Forms.RadioButton rbSpeler2Tank;
        private System.Windows.Forms.RadioButton rbSpeler2Swordsman;
        private System.Windows.Forms.Button btnSurvivalBack;
    }
}

