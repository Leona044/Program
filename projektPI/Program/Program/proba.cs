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
        public proba()
        {
            InitializeComponent();
        }

        private void OsvjeziKorisnike() {
            List<Korisnik> listaKorisnika = BPkorisnik.DohvatiSve();
            d1.DataSource = listaKorisnika;
        }

        private void proba_Load(object sender, EventArgs e)
        {
            OsvjeziKorisnike();
        }
    }
}
