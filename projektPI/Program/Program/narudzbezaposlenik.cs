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
    public partial class narudzbezaposlenik : Form
    {
       
        public narudzbezaposlenik()
        {
            InitializeComponent();
        }

        private void OsvjeziNarudzbe()
        {
            List<Narudzba> listaNarudzba = BPnarudzba.DohvatiSve();
            d1zap.DataSource = listaNarudzba;
        }

        private void lblMyNarudzbe_Click(object sender, EventArgs e)
        {

        }

        private void narudzbezaposlenik_Load(object sender, EventArgs e)
        {
            OsvjeziNarudzbe();
        }

        private void btnOdjavazap_Click(object sender, EventArgs e)
        {
            prijava prijava = new prijava();
            prijava.Show();
            this.Hide();
        }
    }
}
