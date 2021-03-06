﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class menu : Form
    {
        Korisnik prijavljeniKorisnik = new Korisnik();
        Narudzba novaNarudzba = new Narudzba();
        string opis = "";

        public menu(Korisnik korisnikLogin)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnikLogin;
        }

        decimal iznosKucica = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void F_menu_Load(object sender, EventArgs e)
        {

        }

        private void Glavno_jelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
            if (listBox1.Items.Count == 0)
            {
                lblObavezanOdabir.Text = "Obavezno popuniti polje!";
                lblObavezanOdabir.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(textBox1.Text))
            { 
                lblUpisObavezan.Text = "Obavezno popuniti polje!";
                lblUpisObavezan.ForeColor = Color.Red; 
            }
            else if (string.IsNullOrWhiteSpace(tbInputBrmob.Text))
            {
                lblUpisObavezan.Text = "Obavezno popuniti polje!";
                lblUpisObavezan.ForeColor = Color.Red;
            }
            else if (!(b_menu1.BackColor.Equals(Color.Yellow) || b_menu2.BackColor.Equals(Color.Yellow) || b_vege.BackColor.Equals(Color.Yellow)))
            {
                MessageBox.Show("Odaberite vrstu menu-a. Pokušajte ponovno.", "Greška kod odabira!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                foreach (object j in listBox1.Items)
                {
                    novaNarudzba.Sadrzaj += j.ToString();
                    novaNarudzba.Sadrzaj += " | ";
                }
                novaNarudzba.Kolicina = Convert.ToInt32(NUD_kolicina.Value.ToString());
                string iznosKn = metroTextBox1.Text.ToString();
                string iznosBezKn = iznosKn.Replace("kn", "");
                novaNarudzba.Iznos = Convert.ToDouble(iznosBezKn);
                novaNarudzba.Adresa = textBox1.Text.ToString();
                novaNarudzba.Jmbag_k = prijavljeniKorisnik.Jmbag;
                novaNarudzba.Broj_mobitela = tbInputBrmob.Text.ToString();
                new potvrda(this, novaNarudzba, prijavljeniKorisnik).Show();
            }
                
    
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClbOdabir_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void LbOdabrano_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void b_ponuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.scpu.hr/hr/prehrana/");
        }

        private void btnMenu1_Click(object sender, EventArgs e)
        {
            foreach(Control c in metroPanel1.Controls)
            {
                c.BackColor = Color.WhiteSmoke;
            }
            Control o = (Control)sender;
            o.BackColor = Color.Yellow;
            novaNarudzba.Menu = "Menu 1";

        }  

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            foreach (Control c in metroPanel1.Controls)
            {
                c.BackColor = Color.WhiteSmoke;
            }
            Control o = (Control)sender;
            o.BackColor = Color.Yellow;
            novaNarudzba.Menu = "Menu 2";

        }

        private void BtnVege_Click(object sender, EventArgs e)
        {
            foreach (Control c in metroPanel1.Controls)
            {
                c.BackColor = Color.WhiteSmoke;
            }
            Control o = (Control)sender;
            o.BackColor = Color.Yellow;
            novaNarudzba.Menu = "Vege";
        }

        private void NUD_kolicina_ValueChanged(object sender, EventArgs e)
        {
           izracunaj();

        }

        public void izracunaj()
        {
            decimal konacno = (NUD_kolicina.Value * iznosKucica) + 10;
            string str = konacno.ToString();
            metroTextBox1.Text = konacno + "kn";
        }

        private void clb_jela_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;

            int brojOznacenih = clb.SelectedItems.Count;
            for (int i = 0; i < brojOznacenih; i++)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    listBox1.Items.Add(clb.SelectedItem);
                }
                else
                {
                    listBox1.Items.Remove(clb.SelectedItem);
                }
            }

            double iznos = 0;
            foreach (object j in listBox1.Items)
            {
                    if (j.Equals("Glavno jelo"))
                    {
                        iznos += 2.50;
                    }
                    else if (j.Equals("Juha"))
                    {
                        iznos += 1.00;
                    }
                    else if (j.Equals("Salata"))
                    {
                        iznos += 1.00;
                    }
                    else if (j.Equals("Desert"))
                    {
                        iznos += 2.00;
                    }
            }

            iznosKucica = (decimal)iznos;
            metroTextBox1.Text = iznos + "kn";
            izracunaj();

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
          
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblUpisObavezan.Text = "";
            
        }

        private void clb_jela_Click(object sender, EventArgs e)
        {
            lblObavezanOdabir.Text = "";
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
            
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMojeNaru_Click(object sender, EventArgs e)
        {
            new proba(prijavljeniKorisnik).Show();
            this.Hide();
        }

        private void tbInputBrmob_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblUpisObavezan.Text = "";
        }
    }
}
