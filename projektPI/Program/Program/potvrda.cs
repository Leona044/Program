using System;
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
    public partial class potvrda : Form
    {
        menu menu = null;
        Narudzba novaNarudzba = null;
        Korisnik prijavljeniKorisnik = null;
        public potvrda(menu menu, Narudzba novaNarudzba, Korisnik prijavljeniKorisnik)
        {
            InitializeComponent();
            this.menu = menu;
            this.novaNarudzba = novaNarudzba;
            this.prijavljeniKorisnik = prijavljeniKorisnik;

        }

        private void LblPotvrdivanje_Click(object sender, EventArgs e)
        {

        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            new nacinplacanja(novaNarudzba, prijavljeniKorisnik).Show();
            this.Hide();
            menu.Hide();



           
        }

        private void btnNePotvrda_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
