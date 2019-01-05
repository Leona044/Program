using System;
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
    public partial class proba : Form
    {
        Korisnik prijavljeniKorisnik = null;
        public proba(Korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        private void OsvjeziNarudzbe() {
            List<Narudzba> listaNarudzba = BPnarudzba.Dohvati(prijavljeniKorisnik.Jmbag);
            d1.DataSource = listaNarudzba;
        }

        private void proba_Load(object sender, EventArgs e)
        {
            OsvjeziNarudzbe();
        }

        private void lblMyNarudzbe_Click(object sender, EventArgs e)
        {

        }

        private void btnPočetna_Click(object sender, EventArgs e)
        {
            new menu(prijavljeniKorisnik).Show();
            this.Hide();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            prijavljeniKorisnik = null;
            prijava prijava = new prijava();
            prijava.Show();
            this.Hide();
            
        }
    }
}
