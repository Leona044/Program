﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Program
{
    public partial class paypal : Form
    {
        public paypal()
        {
            InitializeComponent();
        }

        private void tb_loginpaypal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void paypal_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new nacinplacanja().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new karticno_placanje().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prijava prijava = new prijava();
            string email = tbInputEm.Text;
            string lozinka = tbInputPass.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(lozinka))
            {
                MessageBox.Show("Email i/ili lozinka nisu uneseni. Pokušajte ponovno.", "Greška kod prijave!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbInputEm.Clear();
                tbInputPass.Clear();
            }
            else
            {
                 new placanje_uspjesno().Show();   
            }

            
        }

        private void tbInputEm_Click(object sender, EventArgs e)
        {
            tbInputEm.Text = "";
            tbInputEm.ForeColor = Color.Black;
        }

        private void tbInputPass_Click(object sender, EventArgs e)
        {
            tbInputPass.Text = "";
            tbInputPass.ForeColor = Color.Black;
        }
    }
}
