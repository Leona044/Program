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

        private void OsvjeziNarudzbe() {
            List<Narudzba> listaNarudzba = BPnarudzba.DohvatiSve();
            d1.DataSource = listaNarudzba;
        }

        private void proba_Load(object sender, EventArgs e)
        {
            OsvjeziNarudzbe();
        }
    }
}
