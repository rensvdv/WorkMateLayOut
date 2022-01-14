
namespace LayOut_Wall_i
{
    partial class AgendaForm
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
            this.lbKlas = new System.Windows.Forms.Label();
            this.lbLokaal1 = new System.Windows.Forms.Label();
            this.lbVak1 = new System.Windows.Forms.Label();
            this.lbVak2 = new System.Windows.Forms.Label();
            this.lbDocent1 = new System.Windows.Forms.Label();
            this.lbAgenda = new System.Windows.Forms.Label();
            this.lbDocent2 = new System.Windows.Forms.Label();
            this.lbLokaal2 = new System.Windows.Forms.Label();
            this.lbAfspraken = new System.Windows.Forms.ListBox();
            this.lbAfspraak = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbNaamOntvanger = new System.Windows.Forms.Label();
            this.lbTitel = new System.Windows.Forms.Label();
            this.lbKorteBeschrijving = new System.Windows.Forms.Label();
            this.lbTitel2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbMailOntvanger = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbBeschrijving = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbAfspraaksduur = new System.Windows.Forms.Label();
            this.lbDatum2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbDatum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pbAchtergrond = new System.Windows.Forms.PictureBox();
            this.grpbxKleineAfspraak = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAchtergrond)).BeginInit();
            this.grpbxKleineAfspraak.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbKlas
            // 
            this.lbKlas.AutoSize = true;
            this.lbKlas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKlas.ForeColor = System.Drawing.Color.Black;
            this.lbKlas.Location = new System.Drawing.Point(320, 133);
            this.lbKlas.Name = "lbKlas";
            this.lbKlas.Size = new System.Drawing.Size(35, 17);
            this.lbKlas.TabIndex = 1;
            this.lbKlas.Text = "Klas";
            // 
            // lbLokaal1
            // 
            this.lbLokaal1.AutoSize = true;
            this.lbLokaal1.Location = new System.Drawing.Point(321, 232);
            this.lbLokaal1.Name = "lbLokaal1";
            this.lbLokaal1.Size = new System.Drawing.Size(62, 17);
            this.lbLokaal1.TabIndex = 4;
            this.lbLokaal1.Text = "Lokaal : ";
            this.lbLokaal1.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbVak1
            // 
            this.lbVak1.AutoSize = true;
            this.lbVak1.Location = new System.Drawing.Point(322, 184);
            this.lbVak1.Name = "lbVak1";
            this.lbVak1.Size = new System.Drawing.Size(40, 17);
            this.lbVak1.TabIndex = 5;
            this.lbVak1.Text = "Vak :";
            this.lbVak1.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbVak2
            // 
            this.lbVak2.AutoSize = true;
            this.lbVak2.BackColor = System.Drawing.SystemColors.Control;
            this.lbVak2.Font = new System.Drawing.Font("Papyrus", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVak2.ForeColor = System.Drawing.Color.Indigo;
            this.lbVak2.Location = new System.Drawing.Point(398, 133);
            this.lbVak2.Name = "lbVak2";
            this.lbVak2.Size = new System.Drawing.Size(34, 24);
            this.lbVak2.TabIndex = 6;
            this.lbVak2.Text = "......";
            this.lbVak2.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbDocent1
            // 
            this.lbDocent1.AutoSize = true;
            this.lbDocent1.Location = new System.Drawing.Point(321, 284);
            this.lbDocent1.Name = "lbDocent1";
            this.lbDocent1.Size = new System.Drawing.Size(61, 17);
            this.lbDocent1.TabIndex = 7;
            this.lbDocent1.Text = "Docent :";
            // 
            // lbAgenda
            // 
            this.lbAgenda.AutoSize = true;
            this.lbAgenda.Font = new System.Drawing.Font("Ravie", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgenda.ForeColor = System.Drawing.Color.Crimson;
            this.lbAgenda.Location = new System.Drawing.Point(281, 25);
            this.lbAgenda.Name = "lbAgenda";
            this.lbAgenda.Size = new System.Drawing.Size(204, 52);
            this.lbAgenda.TabIndex = 8;
            this.lbAgenda.Text = "Agenda";
            // 
            // lbDocent2
            // 
            this.lbDocent2.AutoSize = true;
            this.lbDocent2.Font = new System.Drawing.Font("Papyrus", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocent2.ForeColor = System.Drawing.Color.Indigo;
            this.lbDocent2.Location = new System.Drawing.Point(399, 284);
            this.lbDocent2.Name = "lbDocent2";
            this.lbDocent2.Size = new System.Drawing.Size(34, 24);
            this.lbDocent2.TabIndex = 10;
            this.lbDocent2.Text = "......";
            // 
            // lbLokaal2
            // 
            this.lbLokaal2.AutoSize = true;
            this.lbLokaal2.Font = new System.Drawing.Font("Papyrus", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLokaal2.ForeColor = System.Drawing.Color.Indigo;
            this.lbLokaal2.Location = new System.Drawing.Point(399, 232);
            this.lbLokaal2.Name = "lbLokaal2";
            this.lbLokaal2.Size = new System.Drawing.Size(34, 24);
            this.lbLokaal2.TabIndex = 11;
            this.lbLokaal2.Text = "......";
            // 
            // lbAfspraken
            // 
            this.lbAfspraken.FormattingEnabled = true;
            this.lbAfspraken.ItemHeight = 16;
            this.lbAfspraken.Location = new System.Drawing.Point(24, 89);
            this.lbAfspraken.Name = "lbAfspraken";
            this.lbAfspraken.Size = new System.Drawing.Size(242, 212);
            this.lbAfspraken.TabIndex = 12;
            // 
            // lbAfspraak
            // 
            this.lbAfspraak.AutoSize = true;
            this.lbAfspraak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAfspraak.Location = new System.Drawing.Point(21, 60);
            this.lbAfspraak.Name = "lbAfspraak";
            this.lbAfspraak.Size = new System.Drawing.Size(93, 20);
            this.lbAfspraak.TabIndex = 13;
            this.lbAfspraak.Text = "Afspraken";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 179);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 90);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 122);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(831, 94);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 20);
            this.textBox3.TabIndex = 17;
            // 
            // lbNaamOntvanger
            // 
            this.lbNaamOntvanger.AutoSize = true;
            this.lbNaamOntvanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNaamOntvanger.Location = new System.Drawing.Point(34, 42);
            this.lbNaamOntvanger.Name = "lbNaamOntvanger";
            this.lbNaamOntvanger.Size = new System.Drawing.Size(127, 17);
            this.lbNaamOntvanger.TabIndex = 18;
            this.lbNaamOntvanger.Text = "Naam ontvanger";
            // 
            // lbTitel
            // 
            this.lbTitel.AutoSize = true;
            this.lbTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitel.Location = new System.Drawing.Point(34, 101);
            this.lbTitel.Name = "lbTitel";
            this.lbTitel.Size = new System.Drawing.Size(40, 17);
            this.lbTitel.TabIndex = 19;
            this.lbTitel.Text = "Titel";
            this.lbTitel.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbKorteBeschrijving
            // 
            this.lbKorteBeschrijving.AutoSize = true;
            this.lbKorteBeschrijving.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKorteBeschrijving.Location = new System.Drawing.Point(34, 159);
            this.lbKorteBeschrijving.Name = "lbKorteBeschrijving";
            this.lbKorteBeschrijving.Size = new System.Drawing.Size(139, 17);
            this.lbKorteBeschrijving.TabIndex = 20;
            this.lbKorteBeschrijving.Text = "Korte beschrijving";
            this.lbKorteBeschrijving.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbTitel2
            // 
            this.lbTitel2.AutoSize = true;
            this.lbTitel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitel2.Location = new System.Drawing.Point(828, 133);
            this.lbTitel2.Name = "lbTitel2";
            this.lbTitel2.Size = new System.Drawing.Size(40, 17);
            this.lbTitel2.TabIndex = 22;
            this.lbTitel2.Text = "Titel";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(831, 154);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(111, 20);
            this.textBox4.TabIndex = 21;
            // 
            // lbMailOntvanger
            // 
            this.lbMailOntvanger.AutoSize = true;
            this.lbMailOntvanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMailOntvanger.Location = new System.Drawing.Point(828, 74);
            this.lbMailOntvanger.Name = "lbMailOntvanger";
            this.lbMailOntvanger.Size = new System.Drawing.Size(115, 17);
            this.lbMailOntvanger.TabIndex = 25;
            this.lbMailOntvanger.Text = "Mail ontvanger";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(37, 62);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 20);
            this.textBox5.TabIndex = 24;
            // 
            // lbBeschrijving
            // 
            this.lbBeschrijving.AutoSize = true;
            this.lbBeschrijving.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBeschrijving.Location = new System.Drawing.Point(828, 191);
            this.lbBeschrijving.Name = "lbBeschrijving";
            this.lbBeschrijving.Size = new System.Drawing.Size(96, 17);
            this.lbBeschrijving.TabIndex = 27;
            this.lbBeschrijving.Text = "Beschrijving";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 292);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 24);
            this.comboBox1.TabIndex = 28;
            // 
            // lbAfspraaksduur
            // 
            this.lbAfspraaksduur.AutoSize = true;
            this.lbAfspraaksduur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAfspraaksduur.ForeColor = System.Drawing.Color.Blue;
            this.lbAfspraaksduur.Location = new System.Drawing.Point(34, 272);
            this.lbAfspraaksduur.Name = "lbAfspraaksduur";
            this.lbAfspraaksduur.Size = new System.Drawing.Size(100, 17);
            this.lbAfspraaksduur.TabIndex = 29;
            this.lbAfspraaksduur.Text = "Afspraaksduur";
            // 
            // lbDatum2
            // 
            this.lbDatum2.AutoSize = true;
            this.lbDatum2.ForeColor = System.Drawing.Color.Blue;
            this.lbDatum2.Location = new System.Drawing.Point(33, 279);
            this.lbDatum2.Name = "lbDatum2";
            this.lbDatum2.Size = new System.Drawing.Size(49, 17);
            this.lbDatum2.TabIndex = 31;
            this.lbDatum2.Text = "Datum";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(36, 299);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(136, 24);
            this.comboBox2.TabIndex = 30;
            // 
            // lbDatum
            // 
            this.lbDatum.AutoSize = true;
            this.lbDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatum.Location = new System.Drawing.Point(320, 331);
            this.lbDatum.Name = "lbDatum";
            this.lbDatum.Size = new System.Drawing.Size(49, 17);
            this.lbDatum.TabIndex = 32;
            this.lbDatum.Text = "Datum";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightPink;
            this.button1.Location = new System.Drawing.Point(24, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 38);
            this.button1.TabIndex = 33;
            this.button1.Text = "Zie afspraken";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightPink;
            this.button2.Location = new System.Drawing.Point(37, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 32);
            this.button2.TabIndex = 34;
            this.button2.Text = "Maak afspraak";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightPink;
            this.button3.Location = new System.Drawing.Point(149, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 38);
            this.button3.TabIndex = 35;
            this.button3.Text = "Dagplanning";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightPink;
            this.button4.Location = new System.Drawing.Point(36, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 25);
            this.button4.TabIndex = 36;
            this.button4.Text = "Stuur E-mail";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pbAchtergrond
            // 
            this.pbAchtergrond.Image = global::LayOut_Wall_i.Properties.Resources.agenda2;
            this.pbAchtergrond.Location = new System.Drawing.Point(-2, -16);
            this.pbAchtergrond.Name = "pbAchtergrond";
            this.pbAchtergrond.Size = new System.Drawing.Size(1157, 467);
            this.pbAchtergrond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAchtergrond.TabIndex = 37;
            this.pbAchtergrond.TabStop = false;
            // 
            // grpbxKleineAfspraak
            // 
            this.grpbxKleineAfspraak.Controls.Add(this.lbKorteBeschrijving);
            this.grpbxKleineAfspraak.Controls.Add(this.textBox1);
            this.grpbxKleineAfspraak.Controls.Add(this.textBox2);
            this.grpbxKleineAfspraak.Controls.Add(this.button2);
            this.grpbxKleineAfspraak.Controls.Add(this.lbNaamOntvanger);
            this.grpbxKleineAfspraak.Controls.Add(this.lbTitel);
            this.grpbxKleineAfspraak.Controls.Add(this.textBox5);
            this.grpbxKleineAfspraak.Controls.Add(this.lbAfspraaksduur);
            this.grpbxKleineAfspraak.Controls.Add(this.comboBox1);
            this.grpbxKleineAfspraak.Location = new System.Drawing.Point(524, 25);
            this.grpbxKleineAfspraak.Name = "grpbxKleineAfspraak";
            this.grpbxKleineAfspraak.Size = new System.Drawing.Size(208, 370);
            this.grpbxKleineAfspraak.TabIndex = 38;
            this.grpbxKleineAfspraak.TabStop = false;
            this.grpbxKleineAfspraak.Text = "KleineAfspraak";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(831, 211);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(186, 90);
            this.textBox7.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDatum2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Location = new System.Drawing.Point(795, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 370);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GroteAfspraak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(399, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "......";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(399, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "......";
            // 
            // AgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDatum);
            this.Controls.Add(this.lbBeschrijving);
            this.Controls.Add(this.lbMailOntvanger);
            this.Controls.Add(this.lbTitel2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbAfspraak);
            this.Controls.Add(this.lbAfspraken);
            this.Controls.Add(this.lbLokaal2);
            this.Controls.Add(this.lbDocent2);
            this.Controls.Add(this.lbAgenda);
            this.Controls.Add(this.lbDocent1);
            this.Controls.Add(this.lbVak2);
            this.Controls.Add(this.lbVak1);
            this.Controls.Add(this.lbLokaal1);
            this.Controls.Add(this.lbKlas);
            this.Controls.Add(this.grpbxKleineAfspraak);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbAchtergrond);
            this.Name = "AgendaForm";
            this.Text = "AgendaForm";
            this.Load += new System.EventHandler(this.AgendaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAchtergrond)).EndInit();
            this.grpbxKleineAfspraak.ResumeLayout(false);
            this.grpbxKleineAfspraak.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbKlas;
        private System.Windows.Forms.Label lbLokaal1;
        private System.Windows.Forms.Label lbVak1;
        private System.Windows.Forms.Label lbVak2;
        private System.Windows.Forms.Label lbDocent1;
        private System.Windows.Forms.Label lbAgenda;
        private System.Windows.Forms.Label lbDocent2;
        private System.Windows.Forms.Label lbLokaal2;
        private System.Windows.Forms.ListBox lbAfspraken;
        private System.Windows.Forms.Label lbAfspraak;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbNaamOntvanger;
        private System.Windows.Forms.Label lbTitel;
        private System.Windows.Forms.Label lbKorteBeschrijving;
        private System.Windows.Forms.Label lbTitel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbMailOntvanger;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbBeschrijving;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbAfspraaksduur;
        private System.Windows.Forms.Label lbDatum2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbDatum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pbAchtergrond;
        private System.Windows.Forms.GroupBox grpbxKleineAfspraak;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}