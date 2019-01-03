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
    public partial class prijava : Form
    {
        public prijava()
        {
            InitializeComponent();
        }

        private void L_username_Click(object sender, EventArgs e)
        { 
        }

        private void B_prijava_Click(object sender, EventArgs e)
        {
        
            prijava prijava = new prijava();
            string email = inputEmail.Text;
            string lozinka = inputLozinka.Text;

            if(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(lozinka))
            {
                MessageBox.Show("Korisničko ime i/ili lozinka nisu uneseni. Pokušajte ponovno.", "Greška kod prijave!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputEmail.Clear();
                inputLozinka.Clear();
            }
            else
            {
                List<Korisnik> upisano = BPkorisnik.DohvatiPrijava(email, lozinka);
                if (upisano.Count > 0)
                {
                   
                    new menu().Show(); 
                    this.Hide();
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                }
                else
                {
                    MessageBox.Show("Krivo korisničko ime i/ili lozinka. Pokušajte ponovno.", "Greška kod prijave!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }

        }

        private void Video_Enter(object sender, EventArgs e)
        {
           
        }

        private void inputEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputLozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLozinka_Click(object sender, EventArgs e)
        {

        }
    }
}
