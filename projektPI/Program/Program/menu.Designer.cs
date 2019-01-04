namespace Program
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.B_kolicina = new System.Windows.Forms.Button();
            this.NUD_kolicina = new System.Windows.Forms.NumericUpDown();
            this.B_odabir = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.b_vege = new System.Windows.Forms.Button();
            this.b_menu2 = new System.Windows.Forms.Button();
            this.b_menu1 = new System.Windows.Forms.Button();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblObavezanOdabir = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clb_jela = new System.Windows.Forms.CheckedListBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.b_ponuda = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mp_adresaupis = new MetroFramework.Controls.MetroPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBrojmob = new System.Windows.Forms.Label();
            this.tbInputBrmob = new System.Windows.Forms.TextBox();
            this.lblUpisObavezan = new System.Windows.Forms.Label();
            this.lbl_upisiadresu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_kolicina)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.mp_adresaupis.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_kolicina
            // 
            this.B_kolicina.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_kolicina.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.B_kolicina.Location = new System.Drawing.Point(23, 202);
            this.B_kolicina.Name = "B_kolicina";
            this.B_kolicina.Size = new System.Drawing.Size(130, 24);
            this.B_kolicina.TabIndex = 3;
            this.B_kolicina.Text = "Količina";
            this.B_kolicina.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.B_kolicina.UseVisualStyleBackColor = false;
            // 
            // NUD_kolicina
            // 
            this.NUD_kolicina.BackColor = System.Drawing.Color.Beige;
            this.NUD_kolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_kolicina.Location = new System.Drawing.Point(147, 202);
            this.NUD_kolicina.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUD_kolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_kolicina.Name = "NUD_kolicina";
            this.NUD_kolicina.Size = new System.Drawing.Size(44, 24);
            this.NUD_kolicina.TabIndex = 4;
            this.NUD_kolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_kolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_kolicina.ValueChanged += new System.EventHandler(this.NUD_kolicina_ValueChanged);
            // 
            // B_odabir
            // 
            this.B_odabir.BackColor = System.Drawing.Color.Beige;
            this.B_odabir.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_odabir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.B_odabir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.B_odabir.Location = new System.Drawing.Point(3, 1);
            this.B_odabir.Name = "B_odabir";
            this.B_odabir.Size = new System.Drawing.Size(357, 40);
            this.B_odabir.TabIndex = 5;
            this.B_odabir.Text = "Vaš odabir:";
            this.B_odabir.UseVisualStyleBackColor = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.b_vege);
            this.metroPanel1.Controls.Add(this.b_menu2);
            this.metroPanel1.Controls.Add(this.b_menu1);
            this.metroPanel1.ForeColor = System.Drawing.Color.Black;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 25);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(365, 70);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // b_vege
            // 
            this.b_vege.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_vege.Location = new System.Drawing.Point(235, 3);
            this.b_vege.Name = "b_vege";
            this.b_vege.Size = new System.Drawing.Size(100, 62);
            this.b_vege.TabIndex = 4;
            this.b_vege.Text = "VEGE";
            this.b_vege.UseVisualStyleBackColor = true;
            this.b_vege.Click += new System.EventHandler(this.BtnVege_Click);
            // 
            // b_menu2
            // 
            this.b_menu2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_menu2.Location = new System.Drawing.Point(129, 3);
            this.b_menu2.Name = "b_menu2";
            this.b_menu2.Size = new System.Drawing.Size(100, 62);
            this.b_menu2.TabIndex = 3;
            this.b_menu2.Text = "MENU 2";
            this.b_menu2.UseVisualStyleBackColor = true;
            this.b_menu2.Click += new System.EventHandler(this.btnMenu2_Click);
            // 
            // b_menu1
            // 
            this.b_menu1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_menu1.Location = new System.Drawing.Point(23, 3);
            this.b_menu1.Name = "b_menu1";
            this.b_menu1.Size = new System.Drawing.Size(100, 62);
            this.b_menu1.TabIndex = 2;
            this.b_menu1.Text = "MENU 1";
            this.b_menu1.UseVisualStyleBackColor = true;
            this.b_menu1.Click += new System.EventHandler(this.btnMenu1_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel2.BackgroundImage")));
            this.metroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.pictureBox2);
            this.metroPanel2.Controls.Add(this.lblObavezanOdabir);
            this.metroPanel2.Controls.Add(this.pictureBox1);
            this.metroPanel2.Controls.Add(this.listBox1);
            this.metroPanel2.Controls.Add(this.metroTextBox1);
            this.metroPanel2.Controls.Add(this.label1);
            this.metroPanel2.Controls.Add(this.clb_jela);
            this.metroPanel2.Controls.Add(this.NUD_kolicina);
            this.metroPanel2.Controls.Add(this.B_kolicina);
            this.metroPanel2.Controls.Add(this.B_odabir);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 108);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(365, 253);
            this.metroPanel2.TabIndex = 11;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            this.metroPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(342, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 16);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // lblObavezanOdabir
            // 
            this.lblObavezanOdabir.AutoSize = true;
            this.lblObavezanOdabir.Location = new System.Drawing.Point(35, 48);
            this.lblObavezanOdabir.Name = "lblObavezanOdabir";
            this.lblObavezanOdabir.Size = new System.Drawing.Size(0, 13);
            this.lblObavezanOdabir.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(250, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(205, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 72);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.LbOdabrano_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "UKUPNO:";
            // 
            // clb_jela
            // 
            this.clb_jela.BackColor = System.Drawing.Color.Beige;
            this.clb_jela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clb_jela.CheckOnClick = true;
            this.clb_jela.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_jela.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clb_jela.FormattingEnabled = true;
            this.clb_jela.Items.AddRange(new object[] {
            "Juha",
            "Glavno jelo",
            "Salata",
            "Desert"});
            this.clb_jela.Location = new System.Drawing.Point(38, 66);
            this.clb_jela.Name = "clb_jela";
            this.clb_jela.Size = new System.Drawing.Size(125, 86);
            this.clb_jela.TabIndex = 11;
            this.clb_jela.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_jela_ItemCheck);
            this.clb_jela.Click += new System.EventHandler(this.clb_jela_Click);
            this.clb_jela.SelectedIndexChanged += new System.EventHandler(this.ClbOdabir_SelectedIndexChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(595, 363);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // b_ponuda
            // 
            this.b_ponuda.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ponuda.Location = new System.Drawing.Point(476, 26);
            this.b_ponuda.Name = "b_ponuda";
            this.b_ponuda.Size = new System.Drawing.Size(180, 27);
            this.b_ponuda.TabIndex = 16;
            this.b_ponuda.Text = "Pogledaj današnju ponudu";
            this.b_ponuda.UseVisualStyleBackColor = true;
            this.b_ponuda.Click += new System.EventHandler(this.b_ponuda_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(150, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // mp_adresaupis
            // 
            this.mp_adresaupis.BackColor = System.Drawing.Color.DarkGray;
            this.mp_adresaupis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mp_adresaupis.BackgroundImage")));
            this.mp_adresaupis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mp_adresaupis.Controls.Add(this.label3);
            this.mp_adresaupis.Controls.Add(this.lblBrojmob);
            this.mp_adresaupis.Controls.Add(this.tbInputBrmob);
            this.mp_adresaupis.Controls.Add(this.lblUpisObavezan);
            this.mp_adresaupis.Controls.Add(this.lbl_upisiadresu);
            this.mp_adresaupis.Controls.Add(this.textBox1);
            this.mp_adresaupis.Cursor = System.Windows.Forms.Cursors.Default;
            this.mp_adresaupis.HorizontalScrollbarBarColor = true;
            this.mp_adresaupis.HorizontalScrollbarHighlightOnWheel = false;
            this.mp_adresaupis.HorizontalScrollbarSize = 10;
            this.mp_adresaupis.Location = new System.Drawing.Point(0, 351);
            this.mp_adresaupis.Name = "mp_adresaupis";
            this.mp_adresaupis.Size = new System.Drawing.Size(365, 67);
            this.mp_adresaupis.TabIndex = 18;
            this.mp_adresaupis.VerticalScrollbarBarColor = true;
            this.mp_adresaupis.VerticalScrollbarHighlightOnWheel = false;
            this.mp_adresaupis.VerticalScrollbarSize = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(177, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 22;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblBrojmob
            // 
            this.lblBrojmob.AutoSize = true;
            this.lblBrojmob.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojmob.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojmob.Location = new System.Drawing.Point(10, 41);
            this.lblBrojmob.Name = "lblBrojmob";
            this.lblBrojmob.Size = new System.Drawing.Size(124, 14);
            this.lblBrojmob.TabIndex = 21;
            this.lblBrojmob.Text = "Upiši broj mobitela:";
            this.lblBrojmob.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbInputBrmob
            // 
            this.tbInputBrmob.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbInputBrmob.Location = new System.Drawing.Point(150, 38);
            this.tbInputBrmob.Name = "tbInputBrmob";
            this.tbInputBrmob.Size = new System.Drawing.Size(192, 20);
            this.tbInputBrmob.TabIndex = 20;
            this.tbInputBrmob.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbInputBrmob.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblUpisObavezan
            // 
            this.lblUpisObavezan.AutoSize = true;
            this.lblUpisObavezan.BackColor = System.Drawing.Color.Transparent;
            this.lblUpisObavezan.Location = new System.Drawing.Point(177, -6);
            this.lblUpisObavezan.Name = "lblUpisObavezan";
            this.lblUpisObavezan.Size = new System.Drawing.Size(0, 13);
            this.lblUpisObavezan.TabIndex = 19;
            // 
            // lbl_upisiadresu
            // 
            this.lbl_upisiadresu.AutoSize = true;
            this.lbl_upisiadresu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_upisiadresu.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_upisiadresu.Location = new System.Drawing.Point(10, 14);
            this.lbl_upisiadresu.Name = "lbl_upisiadresu";
            this.lbl_upisiadresu.Size = new System.Drawing.Size(134, 14);
            this.lbl_upisiadresu.TabIndex = 18;
            this.lbl_upisiadresu.Text = "Upiši adresu dostave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(368, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Dostava uključena u cijenu!";
            this.label2.Visible = false;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "10,00kn"};
            this.metroTextBox1.Location = new System.Drawing.Point(232, 203);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(107, 23);
            this.metroTextBox1.TabIndex = 14;
            this.metroTextBox1.Text = "10,00kn";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Program.Properties.Resources.images3;
            this.ClientSize = new System.Drawing.Size(682, 418);
            this.Controls.Add(this.mp_adresaupis);
            this.Controls.Add(this.b_ponuda);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menza TO GO";
            this.Load += new System.EventHandler(this.F_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_kolicina)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.mp_adresaupis.ResumeLayout(false);
            this.mp_adresaupis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button B_kolicina;
        private System.Windows.Forms.NumericUpDown NUD_kolicina;
        private System.Windows.Forms.Button B_odabir;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.CheckedListBox clb_jela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button b_vege;
        private System.Windows.Forms.Button b_menu2;
        private System.Windows.Forms.Button b_menu1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button b_ponuda;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroPanel mp_adresaupis;
        private System.Windows.Forms.Label lbl_upisiadresu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUpisObavezan;
        private System.Windows.Forms.Label lblObavezanOdabir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBrojmob;
        private System.Windows.Forms.TextBox tbInputBrmob;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}