namespace Program
{
    partial class narudzbezaposlenik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(narudzbezaposlenik));
            this.d1zap = new System.Windows.Forms.DataGridView();
            this.lblMyNarudzbezap = new System.Windows.Forms.Label();
            this.btnOdjavazap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.d1zap)).BeginInit();
            this.SuspendLayout();
            // 
            // d1zap
            // 
            this.d1zap.BackgroundColor = System.Drawing.Color.Beige;
            this.d1zap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.d1zap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d1zap.Location = new System.Drawing.Point(12, 63);
            this.d1zap.Name = "d1zap";
            this.d1zap.Size = new System.Drawing.Size(658, 277);
            this.d1zap.TabIndex = 1;
            // 
            // lblMyNarudzbezap
            // 
            this.lblMyNarudzbezap.AutoSize = true;
            this.lblMyNarudzbezap.BackColor = System.Drawing.Color.Transparent;
            this.lblMyNarudzbezap.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyNarudzbezap.ForeColor = System.Drawing.Color.White;
            this.lblMyNarudzbezap.Location = new System.Drawing.Point(22, 23);
            this.lblMyNarudzbezap.Name = "lblMyNarudzbezap";
            this.lblMyNarudzbezap.Size = new System.Drawing.Size(144, 27);
            this.lblMyNarudzbezap.TabIndex = 2;
            this.lblMyNarudzbezap.Text = "Sve narudžbe:";
            this.lblMyNarudzbezap.Click += new System.EventHandler(this.lblMyNarudzbe_Click);
            // 
            // btnOdjavazap
            // 
            this.btnOdjavazap.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjavazap.Location = new System.Drawing.Point(523, 356);
            this.btnOdjavazap.Name = "btnOdjavazap";
            this.btnOdjavazap.Size = new System.Drawing.Size(106, 40);
            this.btnOdjavazap.TabIndex = 5;
            this.btnOdjavazap.Text = "Odjava";
            this.btnOdjavazap.UseVisualStyleBackColor = true;
            this.btnOdjavazap.Click += new System.EventHandler(this.btnOdjavazap_Click);
            // 
            // narudzbezaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Program.Properties.Resources.images3;
            this.ClientSize = new System.Drawing.Size(682, 418);
            this.Controls.Add(this.btnOdjavazap);
            this.Controls.Add(this.lblMyNarudzbezap);
            this.Controls.Add(this.d1zap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "narudzbezaposlenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menza TO GO";
            this.Load += new System.EventHandler(this.narudzbezaposlenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.d1zap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView d1zap;
        private System.Windows.Forms.Label lblMyNarudzbezap;
        private System.Windows.Forms.Button btnOdjavazap;
    }
}