
namespace HetWeer
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
            this.lblTilburg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerwachting = new System.Windows.Forms.Button();
            this.lbWolken = new System.Windows.Forms.Label();
            this.btnWolken = new System.Windows.Forms.Button();
            this.lblNederland = new System.Windows.Forms.Label();
            this.lbTemperatuur = new System.Windows.Forms.Label();
            this.lbVoeltAls = new System.Windows.Forms.Label();
            this.lbWindSnelheid = new System.Windows.Forms.Label();
            this.lbHumiditeit = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pbWolk = new System.Windows.Forms.PictureBox();
            this.pbAchtergrondWeer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWolk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAchtergrondWeer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTilburg
            // 
            this.lblTilburg.AutoSize = true;
            this.lblTilburg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilburg.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTilburg.Location = new System.Drawing.Point(31, 76);
            this.lblTilburg.Name = "lblTilburg";
            this.lblTilburg.Size = new System.Drawing.Size(97, 29);
            this.lblTilburg.TabIndex = 0;
            this.lblTilburg.Text = "Tilburg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatuur:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Voelt als:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Windsnelheid:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(522, 171);
            this.dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(295, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Humiditeit:";
            // 
            // btnVerwachting
            // 
            this.btnVerwachting.Location = new System.Drawing.Point(648, 389);
            this.btnVerwachting.Name = "btnVerwachting";
            this.btnVerwachting.Size = new System.Drawing.Size(120, 49);
            this.btnVerwachting.TabIndex = 13;
            this.btnVerwachting.Text = "Verwachting";
            this.btnVerwachting.UseVisualStyleBackColor = true;
            this.btnVerwachting.Click += new System.EventHandler(this.btnVerwachting_Click);
            // 
            // lbWolken
            // 
            this.lbWolken.AutoSize = true;
            this.lbWolken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWolken.ForeColor = System.Drawing.Color.Red;
            this.lbWolken.Location = new System.Drawing.Point(584, 22);
            this.lbWolken.Name = "lbWolken";
            this.lbWolken.Size = new System.Drawing.Size(79, 25);
            this.lbWolken.TabIndex = 15;
            this.lbWolken.Text = "Wolken";
            // 
            // btnWolken
            // 
            this.btnWolken.Location = new System.Drawing.Point(659, 201);
            this.btnWolken.Name = "btnWolken";
            this.btnWolken.Size = new System.Drawing.Size(109, 51);
            this.btnWolken.TabIndex = 17;
            this.btnWolken.Text = "Tonen";
            this.btnWolken.UseVisualStyleBackColor = true;
            this.btnWolken.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNederland
            // 
            this.lblNederland.AutoSize = true;
            this.lblNederland.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNederland.Location = new System.Drawing.Point(28, 22);
            this.lblNederland.Name = "lblNederland";
            this.lblNederland.Size = new System.Drawing.Size(204, 44);
            this.lblNederland.TabIndex = 18;
            this.lblNederland.Text = "Nederland";
            // 
            // lbTemperatuur
            // 
            this.lbTemperatuur.AutoSize = true;
            this.lbTemperatuur.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemperatuur.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTemperatuur.Location = new System.Drawing.Point(153, 155);
            this.lbTemperatuur.Name = "lbTemperatuur";
            this.lbTemperatuur.Size = new System.Drawing.Size(0, 35);
            this.lbTemperatuur.TabIndex = 20;
            // 
            // lbVoeltAls
            // 
            this.lbVoeltAls.AutoSize = true;
            this.lbVoeltAls.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVoeltAls.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbVoeltAls.Location = new System.Drawing.Point(153, 211);
            this.lbVoeltAls.Name = "lbVoeltAls";
            this.lbVoeltAls.Size = new System.Drawing.Size(0, 35);
            this.lbVoeltAls.TabIndex = 21;
            // 
            // lbWindSnelheid
            // 
            this.lbWindSnelheid.AutoSize = true;
            this.lbWindSnelheid.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWindSnelheid.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbWindSnelheid.Location = new System.Drawing.Point(432, 155);
            this.lbWindSnelheid.Name = "lbWindSnelheid";
            this.lbWindSnelheid.Size = new System.Drawing.Size(0, 35);
            this.lbWindSnelheid.TabIndex = 22;
            // 
            // lbHumiditeit
            // 
            this.lbHumiditeit.AutoSize = true;
            this.lbHumiditeit.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHumiditeit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbHumiditeit.Location = new System.Drawing.Point(431, 213);
            this.lbHumiditeit.Name = "lbHumiditeit";
            this.lbHumiditeit.Size = new System.Drawing.Size(0, 35);
            this.lbHumiditeit.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 55);
            this.button1.TabIndex = 26;
            this.button1.Text = "🠔";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbWolk
            // 
            this.pbWolk.Location = new System.Drawing.Point(589, 59);
            this.pbWolk.Name = "pbWolk";
            this.pbWolk.Size = new System.Drawing.Size(179, 131);
            this.pbWolk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWolk.TabIndex = 16;
            this.pbWolk.TabStop = false;
            // 
            // pbAchtergrondWeer
            // 
            this.pbAchtergrondWeer.Image = global::LayOut_Wall_i.Properties.Resources.WeerAchtergrond;
            this.pbAchtergrondWeer.Location = new System.Drawing.Point(-2, -4);
            this.pbAchtergrondWeer.Name = "pbAchtergrondWeer";
            this.pbAchtergrondWeer.Size = new System.Drawing.Size(803, 482);
            this.pbAchtergrondWeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAchtergrondWeer.TabIndex = 25;
            this.pbAchtergrondWeer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbHumiditeit);
            this.Controls.Add(this.lbWindSnelheid);
            this.Controls.Add(this.lbVoeltAls);
            this.Controls.Add(this.lbTemperatuur);
            this.Controls.Add(this.lblNederland);
            this.Controls.Add(this.btnWolken);
            this.Controls.Add(this.pbWolk);
            this.Controls.Add(this.lbWolken);
            this.Controls.Add(this.btnVerwachting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTilburg);
            this.Controls.Add(this.pbAchtergrondWeer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWolk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAchtergrondWeer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTilburg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerwachting;
        private System.Windows.Forms.Label lbWolken;
        private System.Windows.Forms.PictureBox pbWolk;
        private System.Windows.Forms.Button btnWolken;
        private System.Windows.Forms.Label lblNederland;
        private System.Windows.Forms.Label lbTemperatuur;
        private System.Windows.Forms.Label lbVoeltAls;
        private System.Windows.Forms.Label lbWindSnelheid;
        private System.Windows.Forms.Label lbHumiditeit;
        private System.Windows.Forms.PictureBox pbAchtergrondWeer;
        private System.Windows.Forms.Button button1;
    }
}

