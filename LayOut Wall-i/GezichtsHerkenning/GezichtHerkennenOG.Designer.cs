
namespace LayOut_Wall_i
{
    partial class GezichtHerkennenOG
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
            this.lblScan = new System.Windows.Forms.Label();
            this.btnScannen = new System.Windows.Forms.Button();
            this.pbScan = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.pbScreenshot = new System.Windows.Forms.PictureBox();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.lblScanPopUp1 = new System.Windows.Forms.Label();
            this.lblScanPopUp2 = new System.Windows.Forms.Label();
            this.btnHandmatigeLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenshot)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScan
            // 
            this.lblScan.AutoSize = true;
            this.lblScan.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScan.ForeColor = System.Drawing.Color.Aqua;
            this.lblScan.Location = new System.Drawing.Point(12, 9);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(318, 64);
            this.lblScan.TabIndex = 0;
            this.lblScan.Text = "Scan uw gezicht!";
            // 
            // btnScannen
            // 
            this.btnScannen.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnScannen.Location = new System.Drawing.Point(580, 389);
            this.btnScannen.Name = "btnScannen";
            this.btnScannen.Size = new System.Drawing.Size(110, 49);
            this.btnScannen.TabIndex = 1;
            this.btnScannen.Text = "Scannen";
            this.btnScannen.UseVisualStyleBackColor = false;
            this.btnScannen.Click += new System.EventHandler(this.btnScannen_Click);
            // 
            // pbScan
            // 
            this.pbScan.Image = global::LayOut_Wall_i.Properties.Resources.Gezcihtscan;
            this.pbScan.Location = new System.Drawing.Point(121, -4);
            this.pbScan.Name = "pbScan";
            this.pbScan.Size = new System.Drawing.Size(569, 454);
            this.pbScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScan.TabIndex = 2;
            this.pbScan.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(464, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Data Gezicht";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbCamera
            // 
            this.pbCamera.Location = new System.Drawing.Point(189, 76);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(440, 278);
            this.pbCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCamera.TabIndex = 19;
            this.pbCamera.TabStop = false;
            // 
            // pbScreenshot
            // 
            this.pbScreenshot.Location = new System.Drawing.Point(189, 76);
            this.pbScreenshot.Name = "pbScreenshot";
            this.pbScreenshot.Size = new System.Drawing.Size(440, 278);
            this.pbScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScreenshot.TabIndex = 20;
            this.pbScreenshot.TabStop = false;
            this.pbScreenshot.Visible = false;
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(135, 426);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(47, 24);
            this.cboCamera.TabIndex = 21;
            this.cboCamera.Visible = false;
            // 
            // lblScanPopUp1
            // 
            this.lblScanPopUp1.AutoSize = true;
            this.lblScanPopUp1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanPopUp1.ForeColor = System.Drawing.Color.Aqua;
            this.lblScanPopUp1.Location = new System.Drawing.Point(45, 76);
            this.lblScanPopUp1.Name = "lblScanPopUp1";
            this.lblScanPopUp1.Size = new System.Drawing.Size(224, 31);
            this.lblScanPopUp1.TabIndex = 22;
            this.lblScanPopUp1.Text = "Gezicht wordt gescand...";
            this.lblScanPopUp1.Visible = false;
            // 
            // lblScanPopUp2
            // 
            this.lblScanPopUp2.AutoSize = true;
            this.lblScanPopUp2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanPopUp2.ForeColor = System.Drawing.Color.Aqua;
            this.lblScanPopUp2.Location = new System.Drawing.Point(55, 119);
            this.lblScanPopUp2.Name = "lblScanPopUp2";
            this.lblScanPopUp2.Size = new System.Drawing.Size(191, 31);
            this.lblScanPopUp2.TabIndex = 23;
            this.lblScanPopUp2.Text = "Dit kan even duren...";
            this.lblScanPopUp2.Visible = false;
            // 
            // btnHandmatigeLogin
            // 
            this.btnHandmatigeLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHandmatigeLogin.Location = new System.Drawing.Point(121, 389);
            this.btnHandmatigeLogin.Name = "btnHandmatigeLogin";
            this.btnHandmatigeLogin.Size = new System.Drawing.Size(110, 49);
            this.btnHandmatigeLogin.TabIndex = 24;
            this.btnHandmatigeLogin.Text = "Login";
            this.btnHandmatigeLogin.UseVisualStyleBackColor = false;
            this.btnHandmatigeLogin.Visible = false;
            this.btnHandmatigeLogin.Click += new System.EventHandler(this.btnHandmatigeLogin_Click);
            // 
            // GezichtHerkennenOG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHandmatigeLogin);
            this.Controls.Add(this.lblScanPopUp2);
            this.Controls.Add(this.lblScanPopUp1);
            this.Controls.Add(this.btnScannen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblScan);
            this.Controls.Add(this.pbScan);
            this.Controls.Add(this.pbScreenshot);
            this.Controls.Add(this.pbCamera);
            this.Controls.Add(this.cboCamera);
            this.Name = "GezichtHerkennenOG";
            this.Text = "GezichtHerkennenOG";
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenshot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.Button btnScannen;
        private System.Windows.Forms.PictureBox pbScan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.PictureBox pbScreenshot;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Label lblScanPopUp1;
        private System.Windows.Forms.Label lblScanPopUp2;
        private System.Windows.Forms.Button btnHandmatigeLogin;
    }
}