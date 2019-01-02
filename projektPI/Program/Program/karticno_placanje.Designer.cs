namespace Program
{
    partial class karticno_placanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(karticno_placanje));
            this.b_visa = new System.Windows.Forms.Button();
            this.b_mastercard = new System.Windows.Forms.Button();
            this.b_amex = new System.Windows.Forms.Button();
            this.b_maestro = new System.Windows.Forms.Button();
            this.l_cnumber = new System.Windows.Forms.Label();
            this.tbInputCNumb = new System.Windows.Forms.TextBox();
            this.tbInputName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInputExDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInputSeCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bVisaOkvir = new System.Windows.Forms.Button();
            this.bMasterOkvir = new System.Windows.Forms.Button();
            this.bAmexOkvir = new System.Windows.Forms.Button();
            this.bMaestroOkvir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_visa
            // 
            this.b_visa.BackColor = System.Drawing.Color.Transparent;
            this.b_visa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_visa.BackgroundImage")));
            this.b_visa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_visa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.b_visa.Location = new System.Drawing.Point(103, 39);
            this.b_visa.Name = "b_visa";
            this.b_visa.Size = new System.Drawing.Size(98, 57);
            this.b_visa.TabIndex = 0;
            this.b_visa.UseVisualStyleBackColor = false;
            this.b_visa.Click += new System.EventHandler(this.b_visa_Click);
            // 
            // b_mastercard
            // 
            this.b_mastercard.BackColor = System.Drawing.Color.Transparent;
            this.b_mastercard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_mastercard.BackgroundImage")));
            this.b_mastercard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_mastercard.Location = new System.Drawing.Point(222, 39);
            this.b_mastercard.Name = "b_mastercard";
            this.b_mastercard.Size = new System.Drawing.Size(98, 57);
            this.b_mastercard.TabIndex = 1;
            this.b_mastercard.UseVisualStyleBackColor = false;
            this.b_mastercard.Click += new System.EventHandler(this.b_mastercard_Click);
            // 
            // b_amex
            // 
            this.b_amex.BackColor = System.Drawing.Color.Transparent;
            this.b_amex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_amex.BackgroundImage")));
            this.b_amex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_amex.Location = new System.Drawing.Point(339, 39);
            this.b_amex.Name = "b_amex";
            this.b_amex.Size = new System.Drawing.Size(98, 57);
            this.b_amex.TabIndex = 2;
            this.b_amex.UseVisualStyleBackColor = false;
            this.b_amex.Click += new System.EventHandler(this.b_amex_Click);
            // 
            // b_maestro
            // 
            this.b_maestro.BackColor = System.Drawing.Color.Transparent;
            this.b_maestro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_maestro.BackgroundImage")));
            this.b_maestro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_maestro.Location = new System.Drawing.Point(459, 39);
            this.b_maestro.Name = "b_maestro";
            this.b_maestro.Size = new System.Drawing.Size(98, 57);
            this.b_maestro.TabIndex = 3;
            this.b_maestro.UseVisualStyleBackColor = false;
            this.b_maestro.Click += new System.EventHandler(this.b_maestro_Click);
            // 
            // l_cnumber
            // 
            this.l_cnumber.AutoSize = true;
            this.l_cnumber.BackColor = System.Drawing.Color.Transparent;
            this.l_cnumber.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_cnumber.ForeColor = System.Drawing.Color.White;
            this.l_cnumber.Location = new System.Drawing.Point(101, 157);
            this.l_cnumber.Name = "l_cnumber";
            this.l_cnumber.Size = new System.Drawing.Size(114, 19);
            this.l_cnumber.TabIndex = 5;
            this.l_cnumber.Text = "Card number";
            // 
            // tbInputCNumb
            // 
            this.tbInputCNumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputCNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputCNumb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbInputCNumb.Location = new System.Drawing.Point(105, 180);
            this.tbInputCNumb.Name = "tbInputCNumb";
            this.tbInputCNumb.Size = new System.Drawing.Size(255, 22);
            this.tbInputCNumb.TabIndex = 6;
            this.tbInputCNumb.Text = " 1234 5678 9102 3456";
            this.tbInputCNumb.Click += new System.EventHandler(this.tbInputCNumb_Click);
            this.tbInputCNumb.TextChanged += new System.EventHandler(this.tb_cardnumber_TextChanged);
            this.tbInputCNumb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInputCNumb_KeyPress);
            // 
            // tbInputName
            // 
            this.tbInputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbInputName.Location = new System.Drawing.Point(105, 233);
            this.tbInputName.Name = "tbInputName";
            this.tbInputName.Size = new System.Drawing.Size(255, 22);
            this.tbInputName.TabIndex = 8;
            this.tbInputName.Text = " Ex. Leona Štrucelj";
            this.tbInputName.Click += new System.EventHandler(this.tbInputName_Click);
            this.tbInputName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name on card";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbInputExDate
            // 
            this.tbInputExDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputExDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputExDate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbInputExDate.Location = new System.Drawing.Point(105, 289);
            this.tbInputExDate.Name = "tbInputExDate";
            this.tbInputExDate.Size = new System.Drawing.Size(110, 22);
            this.tbInputExDate.TabIndex = 10;
            this.tbInputExDate.Text = " 01/19";
            this.tbInputExDate.Click += new System.EventHandler(this.tbInputExDate_Click);
            this.tbInputExDate.TextChanged += new System.EventHandler(this.tbInputExDate_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Expiry date";
            // 
            // tbInputSeCode
            // 
            this.tbInputSeCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputSeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputSeCode.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbInputSeCode.Location = new System.Drawing.Point(250, 289);
            this.tbInputSeCode.Name = "tbInputSeCode";
            this.tbInputSeCode.Size = new System.Drawing.Size(110, 22);
            this.tbInputSeCode.TabIndex = 12;
            this.tbInputSeCode.Text = "012";
            this.tbInputSeCode.UseSystemPasswordChar = true;
            this.tbInputSeCode.Click += new System.EventHandler(this.tbInputSeCode_Click);
            this.tbInputSeCode.TextChanged += new System.EventHandler(this.tbInputSeCode_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(246, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Security code";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(538, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Potvrdi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(40, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bVisaOkvir
            // 
            this.bVisaOkvir.BackColor = System.Drawing.Color.Transparent;
            this.bVisaOkvir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bVisaOkvir.Location = new System.Drawing.Point(99, 34);
            this.bVisaOkvir.Name = "bVisaOkvir";
            this.bVisaOkvir.Size = new System.Drawing.Size(106, 67);
            this.bVisaOkvir.TabIndex = 16;
            this.bVisaOkvir.Text = "button1";
            this.bVisaOkvir.UseVisualStyleBackColor = false;
            // 
            // bMasterOkvir
            // 
            this.bMasterOkvir.BackColor = System.Drawing.Color.Transparent;
            this.bMasterOkvir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bMasterOkvir.Location = new System.Drawing.Point(218, 34);
            this.bMasterOkvir.Name = "bMasterOkvir";
            this.bMasterOkvir.Size = new System.Drawing.Size(106, 67);
            this.bMasterOkvir.TabIndex = 17;
            this.bMasterOkvir.Text = "button3";
            this.bMasterOkvir.UseVisualStyleBackColor = false;
            // 
            // bAmexOkvir
            // 
            this.bAmexOkvir.BackColor = System.Drawing.Color.Transparent;
            this.bAmexOkvir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAmexOkvir.ForeColor = System.Drawing.Color.Black;
            this.bAmexOkvir.Location = new System.Drawing.Point(335, 34);
            this.bAmexOkvir.Name = "bAmexOkvir";
            this.bAmexOkvir.Size = new System.Drawing.Size(106, 67);
            this.bAmexOkvir.TabIndex = 18;
            this.bAmexOkvir.Text = "button4";
            this.bAmexOkvir.UseVisualStyleBackColor = false;
            // 
            // bMaestroOkvir
            // 
            this.bMaestroOkvir.BackColor = System.Drawing.Color.Transparent;
            this.bMaestroOkvir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bMaestroOkvir.Location = new System.Drawing.Point(455, 34);
            this.bMaestroOkvir.Name = "bMaestroOkvir";
            this.bMaestroOkvir.Size = new System.Drawing.Size(106, 67);
            this.bMaestroOkvir.TabIndex = 19;
            this.bMaestroOkvir.Text = "button5";
            this.bMaestroOkvir.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // karticno_placanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Program.Properties.Resources.images3;
            this.ClientSize = new System.Drawing.Size(682, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_visa);
            this.Controls.Add(this.bVisaOkvir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbInputSeCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbInputExDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInputName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInputCNumb);
            this.Controls.Add(this.l_cnumber);
            this.Controls.Add(this.b_maestro);
            this.Controls.Add(this.b_amex);
            this.Controls.Add(this.b_mastercard);
            this.Controls.Add(this.bMasterOkvir);
            this.Controls.Add(this.bAmexOkvir);
            this.Controls.Add(this.bMaestroOkvir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "karticno_placanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menza TO GO";
            this.Load += new System.EventHandler(this.karticno_placanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_visa;
        private System.Windows.Forms.Button b_mastercard;
        private System.Windows.Forms.Button b_amex;
        private System.Windows.Forms.Button b_maestro;
        private System.Windows.Forms.Label l_cnumber;
        private System.Windows.Forms.TextBox tbInputCNumb;
        private System.Windows.Forms.TextBox tbInputName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInputExDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInputSeCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bVisaOkvir;
        private System.Windows.Forms.Button bMasterOkvir;
        private System.Windows.Forms.Button bAmexOkvir;
        private System.Windows.Forms.Button bMaestroOkvir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}