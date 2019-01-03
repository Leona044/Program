namespace Program
{
    partial class paypal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paypal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l_paypal = new System.Windows.Forms.Label();
            this.tbInputPass = new System.Windows.Forms.TextBox();
            this.tbInputEm = new System.Windows.Forms.TextBox();
            this.l_or = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(34, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 51);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // l_paypal
            // 
            this.l_paypal.BackColor = System.Drawing.Color.Transparent;
            this.l_paypal.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_paypal.ForeColor = System.Drawing.Color.White;
            this.l_paypal.Location = new System.Drawing.Point(220, 117);
            this.l_paypal.Name = "l_paypal";
            this.l_paypal.Size = new System.Drawing.Size(234, 41);
            this.l_paypal.TabIndex = 6;
            this.l_paypal.Text = "Pay with PayPal";
            // 
            // tbInputPass
            // 
            this.tbInputPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputPass.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbInputPass.Location = new System.Drawing.Point(226, 209);
            this.tbInputPass.Margin = new System.Windows.Forms.Padding(5);
            this.tbInputPass.Name = "tbInputPass";
            this.tbInputPass.Size = new System.Drawing.Size(212, 26);
            this.tbInputPass.TabIndex = 10;
            this.tbInputPass.Text = " Password";
            this.tbInputPass.UseSystemPasswordChar = true;
            this.tbInputPass.Click += new System.EventHandler(this.tbInputPass_Click);
            // 
            // tbInputEm
            // 
            this.tbInputEm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputEm.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbInputEm.Location = new System.Drawing.Point(226, 167);
            this.tbInputEm.Name = "tbInputEm";
            this.tbInputEm.Size = new System.Drawing.Size(212, 26);
            this.tbInputEm.TabIndex = 9;
            this.tbInputEm.Text = "Ex. lestruc123@gmail.com";
            this.tbInputEm.Click += new System.EventHandler(this.tbInputEm_Click);
            // 
            // l_or
            // 
            this.l_or.AutoSize = true;
            this.l_or.BackColor = System.Drawing.Color.Transparent;
            this.l_or.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_or.ForeColor = System.Drawing.Color.White;
            this.l_or.Location = new System.Drawing.Point(317, 296);
            this.l_or.Name = "l_or";
            this.l_or.Size = new System.Drawing.Size(25, 19);
            this.l_or.TabIndex = 13;
            this.l_or.Text = "or";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(34, 354);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 43);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(222, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Pay with Debit or Credit Card";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(245, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "Log in to PayPal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // paypal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Program.Properties.Resources.images3;
            this.ClientSize = new System.Drawing.Size(682, 418);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.l_or);
            this.Controls.Add(this.tbInputPass);
            this.Controls.Add(this.tbInputEm);
            this.Controls.Add(this.l_paypal);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "paypal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menza TO GO";
            this.Load += new System.EventHandler(this.paypal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_paypal;
        private System.Windows.Forms.TextBox tbInputPass;
        private System.Windows.Forms.TextBox tbInputEm;
        private System.Windows.Forms.Label l_or;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}