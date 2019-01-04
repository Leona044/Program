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
    public partial class placanje_uspjesno : Form
    {
        Korisnik prijavljeniKorisnik = null;
        Narudzba novaNarudzba = null;
        public placanje_uspjesno(Narudzba novaNarudzba, Korisnik prijavljeniKorisnik)
        {
            InitializeComponent();
            this.novaNarudzba = novaNarudzba;
            this.prijavljeniKorisnik = prijavljeniKorisnik;
        }

        
        private void placanje_uspjesno_Load(object sender, EventArgs e)
        {
            DateTime datum = DateTime.Now;
            string datumVracanja = datum.ToString("dd.MM.yyyy, HH:mm");
            lblInputVrijeme.Text = datumVracanja;
            lblInputIznos.Text = novaNarudzba.Iznos.ToString();
            lblInputNacin.Text = novaNarudzba.Nacin_placanja.ToString();
            lblInputStatus.Text = novaNarudzba.Status.ToString();
            lblMobi.Text = novaNarudzba.Broj_mobitela.ToString();
            label2.Text = novaNarudzba.Menu.ToString();
            lblInputOpis.Text = novaNarudzba.Sadrzaj.ToString();
            lblInputKol.Text = novaNarudzba.Kolicina.ToString();
            lblInputBr.Text = BPnarudzba.DohvatiBroj().ToString();
           // BPnarudzba.Spremi(novaNarudzba);

        }

        private void lblIznos_Click(object sender, EventArgs e)
        {

        }
    }
}
