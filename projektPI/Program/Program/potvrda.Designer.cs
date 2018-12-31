namespace Program
{
    partial class potvrda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(potvrda));
            this.lblPotvrdujete = new System.Windows.Forms.Label();
            this.btnPotvrda = new System.Windows.Forms.Button();
            this.btnNePotrvda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPotvrdujete
            // 
            this.lblPotvrdujete.AutoSize = true;
            this.lblPotvrdujete.BackColor = System.Drawing.Color.Transparent;
            this.lblPotvrdujete.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotvrdujete.Location = new System.Drawing.Point(39, 52);
            this.lblPotvrdujete.Name = "lblPotvrdujete";
            this.lblPotvrdujete.Size = new System.Drawing.Size(198, 18);
            this.lblPotvrdujete.TabIndex = 0;
            this.lblPotvrdujete.Text = "Potvrđujete li svoj odabir?";
            // 
            // btnPotvrda
            // 
            this.btnPotvrda.Location = new System.Drawing.Point(42, 98);
            this.btnPotvrda.Name = "btnPotvrda";
            this.btnPotvrda.Size = new System.Drawing.Size(88, 33);
            this.btnPotvrda.TabIndex = 1;
            this.btnPotvrda.Text = "DA";
            this.btnPotvrda.UseVisualStyleBackColor = true;
            this.btnPotvrda.Click += new System.EventHandler(this.btnPotvrda_Click);
            // 
            // btnNePotrvda
            // 
            this.btnNePotrvda.Location = new System.Drawing.Point(140, 98);
            this.btnNePotrvda.Name = "btnNePotrvda";
            this.btnNePotrvda.Size = new System.Drawing.Size(93, 33);
            this.btnNePotrvda.TabIndex = 2;
            this.btnNePotrvda.Text = "NE";
            this.btnNePotrvda.UseVisualStyleBackColor = true;
            this.btnNePotrvda.Click += new System.EventHandler(this.btnNePotvrda_Click);
            // 
            // potvrda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(283, 165);
            this.Controls.Add(this.btnNePotrvda);
            this.Controls.Add(this.btnPotvrda);
            this.Controls.Add(this.lblPotvrdujete);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "potvrda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POZOR!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPotvrdujete;
        private System.Windows.Forms.Button btnPotvrda;
        private System.Windows.Forms.Button btnNePotrvda;
    }
}