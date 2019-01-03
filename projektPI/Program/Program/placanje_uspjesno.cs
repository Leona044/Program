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
        public placanje_uspjesno()
        {
            InitializeComponent();
        }

        
        private void placanje_uspjesno_Load(object sender, EventArgs e)
        {
            DateTime datum = DateTime.Now;
            string datumVracanja = datum.ToString("dd.MM.yyyy, HH:mm");
            lblInputVrijeme.Text = datumVracanja;

        }

        private void lblIznos_Click(object sender, EventArgs e)
        {

        }
    }
}
