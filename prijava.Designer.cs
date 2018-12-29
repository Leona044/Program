namespace Program
{
    partial class prijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prijava));
            this.tB_username = new System.Windows.Forms.TextBox();
            this.tB_password = new System.Windows.Forms.TextBox();
            this.l_username = new System.Windows.Forms.Label();
            this.l_password = new System.Windows.Forms.Label();
            this.b_prijava = new System.Windows.Forms.Button();
            this.video = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.video)).BeginInit();
            this.SuspendLayout();
            // 
            // tB_username
            // 
            this.tB_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_username.Location = new System.Drawing.Point(461, 173);
            this.tB_username.Name = "tB_username";
            this.tB_username.Size = new System.Drawing.Size(189, 26);
            this.tB_username.TabIndex = 0;
            // 
            // tB_password
            // 
            this.tB_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_password.Location = new System.Drawing.Point(461, 218);
            this.tB_password.Name = "tB_password";
            this.tB_password.Size = new System.Drawing.Size(189, 26);
            this.tB_password.TabIndex = 1;
            this.tB_password.UseSystemPasswordChar = true;
            // 
            // l_username
            // 
            this.l_username.AutoSize = true;
            this.l_username.BackColor = System.Drawing.Color.Transparent;
            this.l_username.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_username.ForeColor = System.Drawing.Color.White;
            this.l_username.Location = new System.Drawing.Point(351, 177);
            this.l_username.Name = "l_username";
            this.l_username.Size = new System.Drawing.Size(104, 19);
            this.l_username.TabIndex = 2;
            this.l_username.Text = "USERNAME";
            this.l_username.Click += new System.EventHandler(this.l_username_Click);
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.BackColor = System.Drawing.Color.Transparent;
            this.l_password.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_password.ForeColor = System.Drawing.Color.White;
            this.l_password.Location = new System.Drawing.Point(351, 222);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(104, 19);
            this.l_password.TabIndex = 3;
            this.l_password.Text = "PASSWORD";
            // 
            // b_prijava
            // 
            this.b_prijava.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_prijava.Location = new System.Drawing.Point(515, 262);
            this.b_prijava.Name = "b_prijava";
            this.b_prijava.Size = new System.Drawing.Size(75, 23);
            this.b_prijava.TabIndex = 4;
            this.b_prijava.Text = "Log in";
            this.b_prijava.UseVisualStyleBackColor = true;
            this.b_prijava.Click += new System.EventHandler(this.b_prijava_Click);
            // 
            // video
            // 
            this.video.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.video.Enabled = true;
            this.video.Location = new System.Drawing.Point(12, 97);
            this.video.Name = "video";
            this.video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video.OcxState")));
            this.video.Size = new System.Drawing.Size(315, 230);
            this.video.TabIndex = 5;
            this.video.Enter += new System.EventHandler(this.video_Enter);
            this.video.Leave += new System.EventHandler(this.b_prijava_Click);
            // 
            // prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Program.Properties.Resources.images3;
            this.ClientSize = new System.Drawing.Size(682, 418);
            this.Controls.Add(this.video);
            this.Controls.Add(this.b_prijava);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.l_username);
            this.Controls.Add(this.tB_password);
            this.Controls.Add(this.tB_username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menza TO GO";
            ((System.ComponentModel.ISupportInitialize)(this.video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_username;
        private System.Windows.Forms.TextBox tB_password;
        private System.Windows.Forms.Label l_username;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.Button b_prijava;
        private AxWMPLib.AxWindowsMediaPlayer video;
    }
}

