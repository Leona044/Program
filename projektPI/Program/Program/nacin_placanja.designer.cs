namespace WindowsFormsApp1
{
    partial class nacinplacanja
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nacinplacanja));
            this.p_goto = new System.Windows.Forms.Panel();
            this.b_gotovinsko = new System.Windows.Forms.Button();
            this.p_online = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.b_online = new System.Windows.Forms.Button();
            this.mp_nacinpl = new MetroFramework.Controls.MetroPanel();
            this.lbl_odabir = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p_goto.SuspendLayout();
            this.p_online.SuspendLayout();
            this.mp_nacinpl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // p_goto
            // 
            this.p_goto.BackColor = System.Drawing.Color.Transparent;
            this.p_goto.Controls.Add(this.b_gotovinsko);
            this.p_goto.Location = new System.Drawing.Point(136, 152);
            this.p_goto.Name = "p_goto";
            this.p_goto.Size = new System.Drawing.Size(164, 49);
            this.p_goto.TabIndex = 0;
            // 
            // b_gotovinsko
            // 
            this.b_gotovinsko.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_gotovinsko.Location = new System.Drawing.Point(5, 3);
            this.b_gotovinsko.Name = "b_gotovinsko";
            this.b_gotovinsko.Size = new System.Drawing.Size(158, 49);
            this.b_gotovinsko.TabIndex = 0;
            this.b_gotovinsko.Text = "GOTOVINSKO";
            this.b_gotovinsko.UseVisualStyleBackColor = true;
            this.b_gotovinsko.Click += new System.EventHandler(this.b_gotovinsko_Click);
            // 
            // p_online
            // 
            this.p_online.BackColor = System.Drawing.Color.Transparent;
            this.p_online.Controls.Add(this.button5);
            this.p_online.Controls.Add(this.button4);
            this.p_online.Controls.Add(this.b_online);
            this.p_online.Location = new System.Drawing.Point(370, 152);
            this.p_online.Name = "p_online";
            this.p_online.Size = new System.Drawing.Size(164, 139);
            this.p_online.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(3, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "PayPal";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Kartično plaćanje";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // b_online
            // 
            this.b_online.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_online.Location = new System.Drawing.Point(3, 4);
            this.b_online.Name = "b_online";
            this.b_online.Size = new System.Drawing.Size(158, 46);
            this.b_online.TabIndex = 1;
            this.b_online.Text = "ONLINE";
            this.b_online.UseVisualStyleBackColor = true;
            this.b_online.Click += new System.EventHandler(this.b_online_Click);
            this.b_online.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.b_online.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // mp_nacinpl
            // 
            this.mp_nacinpl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mp_nacinpl.BackgroundImage")));
            this.mp_nacinpl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mp_nacinpl.Controls.Add(this.lbl_odabir);
            this.mp_nacinpl.HorizontalScrollbarBarColor = true;
            this.mp_nacinpl.HorizontalScrollbarHighlightOnWheel = false;
            this.mp_nacinpl.HorizontalScrollbarSize = 10;
            this.mp_nacinpl.Location = new System.Drawing.Point(-1, 24);
            this.mp_nacinpl.Name = "mp_nacinpl";
            this.mp_nacinpl.Size = new System.Drawing.Size(683, 72);
            this.mp_nacinpl.TabIndex = 2;
            this.mp_nacinpl.VerticalScrollbarBarColor = true;
            this.mp_nacinpl.VerticalScrollbarHighlightOnWheel = false;
            this.mp_nacinpl.VerticalScrollbarSize = 10;
            // 
            // lbl_odabir
            // 
            this.lbl_odabir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_odabir.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl_odabir.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_odabir.Location = new System.Drawing.Point(49, 15);
            this.lbl_odabir.Name = "lbl_odabir";
            this.lbl_odabir.Size = new System.Drawing.Size(586, 45);
            this.lbl_odabir.TabIndex = 2;
            this.lbl_odabir.Text = "Odaberite način plaćanja:";
            this.lbl_odabir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(26, 363);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nacinplacanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(682, 418);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.p_online);
            this.Controls.Add(this.mp_nacinpl);
            this.Controls.Add(this.p_goto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "nacinplacanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menza TO GO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p_goto.ResumeLayout(false);
            this.p_online.ResumeLayout(false);
            this.mp_nacinpl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_goto;
        private System.Windows.Forms.Button b_gotovinsko;
        private System.Windows.Forms.Panel p_online;
        private System.Windows.Forms.Button b_online;
        private MetroFramework.Controls.MetroPanel mp_nacinpl;
        private System.Windows.Forms.Label lbl_odabir;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

