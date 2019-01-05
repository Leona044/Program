namespace Program
{
    partial class proba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(proba));
            this.d1 = new System.Windows.Forms.DataGridView();
            this.lblMyNarudzbe = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnPočetna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.d1)).BeginInit();
            this.SuspendLayout();
            // 
            // d1
            // 
            this.d1.BackgroundColor = System.Drawing.Color.Beige;
            this.d1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.d1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d1.Location = new System.Drawing.Point(12, 71);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(658, 258);
            this.d1.TabIndex = 0;
            // 
            // lblMyNarudzbe
            // 
            this.lblMyNarudzbe.AutoSize = true;
            this.lblMyNarudzbe.BackColor = System.Drawing.Color.Transparent;
            this.lblMyNarudzbe.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyNarudzbe.ForeColor = System.Drawing.Color.White;
            this.lblMyNarudzbe.Location = new System.Drawing.Point(13, 32);
            this.lblMyNarudzbe.Name = "lblMyNarudzbe";
            this.lblMyNarudzbe.Size = new System.Drawing.Size(157, 27);
            this.lblMyNarudzbe.TabIndex = 1;
            this.lblMyNarudzbe.Text = "Moje narudžbe:";
            this.lblMyNarudzbe.Click += new System.EventHandler(this.lblMyNarudzbe_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Location = new System.Drawing.Point(533, 354);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(106, 40);
            this.btnOdjava.TabIndex = 2;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnPočetna
            // 
            this.btnPočetna.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPočetna.Location = new System.Drawing.Point(44, 354);
            this.btnPočetna.Name = "btnPočetna";
            this.btnPočetna.Size = new System.Drawing.Size(144, 40);
            this.btnPočetna.TabIndex = 3;
            this.btnPočetna.Text = "Početna stranica";
            this.btnPočetna.UseVisualStyleBackColor = true;
            this.btnPočetna.Click += new System.EventHandler(this.btnPočetna_Click);
            // 
            // proba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Program.Properties.Resources.images3;
            this.ClientSize = new System.Drawing.Size(682, 418);
            this.Controls.Add(this.btnPočetna);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.lblMyNarudzbe);
            this.Controls.Add(this.d1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "proba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menza TO GO";
            this.Load += new System.EventHandler(this.proba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.d1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView d1;
        private System.Windows.Forms.Label lblMyNarudzbe;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnPočetna;
    }
}