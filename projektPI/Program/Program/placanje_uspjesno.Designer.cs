namespace Program
{
    partial class placanje_uspjesno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(placanje_uspjesno));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInputVrijeme = new System.Windows.Forms.Label();
            this.lblInputOpis = new System.Windows.Forms.Label();
            this.lblInputIznos = new System.Windows.Forms.Label();
            this.lblInputStatus = new System.Windows.Forms.Label();
            this.lblInputBr = new System.Windows.Forms.Label();
            this.lblInputNacin = new System.Windows.Forms.Label();
            this.lblNacPl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(197, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 63);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.Transparent;
            this.lblDatum.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(48, 122);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(63, 19);
            this.lblDatum.TabIndex = 3;
            this.lblDatum.Text = "Vrijeme:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.BackColor = System.Drawing.Color.Transparent;
            this.lblOpis.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.Location = new System.Drawing.Point(48, 153);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(48, 19);
            this.lblOpis.TabIndex = 4;
            this.lblOpis.Text = "Opis: ";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.BackColor = System.Drawing.Color.Transparent;
            this.lblIznos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIznos.Location = new System.Drawing.Point(48, 183);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(55, 19);
            this.lblIznos.TabIndex = 5;
            this.lblIznos.Text = "Iznos: ";
            this.lblIznos.Click += new System.EventHandler(this.lblIznos_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(48, 241);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 19);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Broj narudžbe: ";
            // 
            // lblInputVrijeme
            // 
            this.lblInputVrijeme.AutoSize = true;
            this.lblInputVrijeme.BackColor = System.Drawing.Color.Transparent;
            this.lblInputVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputVrijeme.Location = new System.Drawing.Point(108, 124);
            this.lblInputVrijeme.Name = "lblInputVrijeme";
            this.lblInputVrijeme.Size = new System.Drawing.Size(19, 16);
            this.lblInputVrijeme.TabIndex = 8;
            this.lblInputVrijeme.Text = "vr";
            // 
            // lblInputOpis
            // 
            this.lblInputOpis.AutoSize = true;
            this.lblInputOpis.BackColor = System.Drawing.Color.Transparent;
            this.lblInputOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputOpis.Location = new System.Drawing.Point(88, 155);
            this.lblInputOpis.Name = "lblInputOpis";
            this.lblInputOpis.Size = new System.Drawing.Size(24, 16);
            this.lblInputOpis.TabIndex = 9;
            this.lblInputOpis.Text = "op";
            // 
            // lblInputIznos
            // 
            this.lblInputIznos.AutoSize = true;
            this.lblInputIznos.BackColor = System.Drawing.Color.Transparent;
            this.lblInputIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputIznos.Location = new System.Drawing.Point(94, 185);
            this.lblInputIznos.Name = "lblInputIznos";
            this.lblInputIznos.Size = new System.Drawing.Size(17, 16);
            this.lblInputIznos.TabIndex = 10;
            this.lblInputIznos.Text = "iz";
            // 
            // lblInputStatus
            // 
            this.lblInputStatus.AutoSize = true;
            this.lblInputStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblInputStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputStatus.Location = new System.Drawing.Point(103, 243);
            this.lblInputStatus.Name = "lblInputStatus";
            this.lblInputStatus.Size = new System.Drawing.Size(18, 16);
            this.lblInputStatus.TabIndex = 11;
            this.lblInputStatus.Text = "st";
            // 
            // lblInputBr
            // 
            this.lblInputBr.AutoSize = true;
            this.lblInputBr.BackColor = System.Drawing.Color.Transparent;
            this.lblInputBr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputBr.Location = new System.Drawing.Point(149, 95);
            this.lblInputBr.Name = "lblInputBr";
            this.lblInputBr.Size = new System.Drawing.Size(23, 16);
            this.lblInputBr.TabIndex = 12;
            this.lblInputBr.Text = "bn";
            // 
            // lblInputNacin
            // 
            this.lblInputNacin.AutoSize = true;
            this.lblInputNacin.BackColor = System.Drawing.Color.Transparent;
            this.lblInputNacin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputNacin.Location = new System.Drawing.Point(154, 215);
            this.lblInputNacin.Name = "lblInputNacin";
            this.lblInputNacin.Size = new System.Drawing.Size(23, 16);
            this.lblInputNacin.TabIndex = 14;
            this.lblInputNacin.Text = "na";
            // 
            // lblNacPl
            // 
            this.lblNacPl.AutoSize = true;
            this.lblNacPl.BackColor = System.Drawing.Color.Transparent;
            this.lblNacPl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacPl.Location = new System.Drawing.Point(48, 213);
            this.lblNacPl.Name = "lblNacPl";
            this.lblNacPl.Size = new System.Drawing.Size(114, 19);
            this.lblNacPl.TabIndex = 13;
            this.lblNacPl.Text = "Način plaćanja: ";
            // 
            // placanje_uspjesno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(468, 294);
            this.Controls.Add(this.lblInputNacin);
            this.Controls.Add(this.lblNacPl);
            this.Controls.Add(this.lblInputBr);
            this.Controls.Add(this.lblInputStatus);
            this.Controls.Add(this.lblInputIznos);
            this.Controls.Add(this.lblInputOpis);
            this.Controls.Add(this.lblInputVrijeme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "placanje_uspjesno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USPJEŠNO!";
            this.Load += new System.EventHandler(this.placanje_uspjesno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInputVrijeme;
        private System.Windows.Forms.Label lblInputOpis;
        private System.Windows.Forms.Label lblInputIznos;
        private System.Windows.Forms.Label lblInputStatus;
        private System.Windows.Forms.Label lblInputBr;
        private System.Windows.Forms.Label lblInputNacin;
        private System.Windows.Forms.Label lblNacPl;
    }
}