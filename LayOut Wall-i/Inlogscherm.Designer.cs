
namespace LayOut_Wall_i
{
    partial class Inlogscherm
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
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblGebr = new System.Windows.Forms.Label();
            this.lblWw = new System.Windows.Forms.Label();
            this.tbxWachtwoord = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblVulGegevensIn = new System.Windows.Forms.Label();
            this.pbAchtergrondInlog = new System.Windows.Forms.PictureBox();
            this.btnBackGameMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAchtergrondInlog)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(140, 157);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(176, 20);
            this.tbxEmail.TabIndex = 0;
            // 
            // lblGebr
            // 
            this.lblGebr.AutoSize = true;
            this.lblGebr.ForeColor = System.Drawing.Color.White;
            this.lblGebr.Location = new System.Drawing.Point(101, 201);
            this.lblGebr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGebr.Name = "lblGebr";
            this.lblGebr.Size = new System.Drawing.Size(35, 13);
            this.lblGebr.TabIndex = 1;
            this.lblGebr.Text = "Email:";
            // 
            // lblWw
            // 
            this.lblWw.AutoSize = true;
            this.lblWw.ForeColor = System.Drawing.Color.White;
            this.lblWw.Location = new System.Drawing.Point(62, 245);
            this.lblWw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWw.Name = "lblWw";
            this.lblWw.Size = new System.Drawing.Size(77, 13);
            this.lblWw.TabIndex = 2;
            this.lblWw.Text = "Wachtwoord : ";
            // 
            // tbxWachtwoord
            // 
            this.tbxWachtwoord.Location = new System.Drawing.Point(140, 194);
            this.tbxWachtwoord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxWachtwoord.Name = "tbxWachtwoord";
            this.tbxWachtwoord.PasswordChar = '*';
            this.tbxWachtwoord.Size = new System.Drawing.Size(176, 20);
            this.tbxWachtwoord.TabIndex = 3;
            this.tbxWachtwoord.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(244, 238);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(71, 33);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Inloggen";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblVulGegevensIn
            // 
            this.lblVulGegevensIn.AutoSize = true;
            this.lblVulGegevensIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVulGegevensIn.ForeColor = System.Drawing.Color.Gray;
            this.lblVulGegevensIn.Location = new System.Drawing.Point(44, 116);
            this.lblVulGegevensIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVulGegevensIn.Name = "lblVulGegevensIn";
            this.lblVulGegevensIn.Size = new System.Drawing.Size(201, 26);
            this.lblVulGegevensIn.TabIndex = 7;
            this.lblVulGegevensIn.Text = "Vul uw gegevens in";
            // 
            // pbAchtergrondInlog
            // 
            this.pbAchtergrondInlog.Image = global::LayOut_Wall_i.Resources.cyber_unlock_security_concept__lock_symbol_form_lines;
            this.pbAchtergrondInlog.Location = new System.Drawing.Point(1, -47);
            this.pbAchtergrondInlog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbAchtergrondInlog.Name = "pbAchtergrondInlog";
            this.pbAchtergrondInlog.Size = new System.Drawing.Size(603, 369);
            this.pbAchtergrondInlog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAchtergrondInlog.TabIndex = 6;
            this.pbAchtergrondInlog.TabStop = false;
            // 
            // btnBackGameMenu
            // 
            this.btnBackGameMenu.BackColor = System.Drawing.Color.Black;
            this.btnBackGameMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackGameMenu.ForeColor = System.Drawing.Color.Red;
            this.btnBackGameMenu.Location = new System.Drawing.Point(9, 262);
            this.btnBackGameMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackGameMenu.Name = "btnBackGameMenu";
            this.btnBackGameMenu.Size = new System.Drawing.Size(64, 48);
            this.btnBackGameMenu.TabIndex = 8;
            this.btnBackGameMenu.Text = "🠔";
            this.btnBackGameMenu.UseVisualStyleBackColor = false;
            this.btnBackGameMenu.Click += new System.EventHandler(this.btnBackGameMenu_Click);
            // 
            // Inlogscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 320);
            this.Controls.Add(this.btnBackGameMenu);
            this.Controls.Add(this.lblVulGegevensIn);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.tbxWachtwoord);
            this.Controls.Add(this.lblWw);
            this.Controls.Add(this.lblGebr);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.pbAchtergrondInlog);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Inlogscherm";
            this.Text = "Inlogscherm";
            ((System.ComponentModel.ISupportInitialize)(this.pbAchtergrondInlog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblGebr;
        private System.Windows.Forms.Label lblWw;
        private System.Windows.Forms.TextBox tbxWachtwoord;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.PictureBox pbAchtergrondInlog;
        private System.Windows.Forms.Label lblVulGegevensIn;
        private System.Windows.Forms.Button btnBackGameMenu;
    }
}