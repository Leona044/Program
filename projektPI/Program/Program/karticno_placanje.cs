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
    public partial class karticno_placanje : Form
    {
        public karticno_placanje()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void karticno_placanje_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new nacinplacanja().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new placanje_uspjesno().Show();
        }

        private void b_visa_Click(object sender, EventArgs e)
        {
            bVisaOkvir.BackColor = Color.Yellow;
            if (bMasterOkvir.BackColor.Equals(Color.Yellow))
            {
                bMasterOkvir.BackColor = Color.Transparent;
            }
            else if (bMaestroOkvir.BackColor.Equals(Color.Yellow))
            {
                bMaestroOkvir.BackColor = Color.Transparent;
            }
            else if (bAmexOkvir.BackColor.Equals(Color.Yellow))
            {
                bAmexOkvir.BackColor = Color.Transparent;
            }
        }

        private void b_mastercard_Click(object sender, EventArgs e)
        {
            bMasterOkvir.BackColor = Color.Yellow;
            if (bVisaOkvir.BackColor.Equals(Color.Yellow))
            {
                bVisaOkvir.BackColor = Color.Transparent;
            }
            else if (bMaestroOkvir.BackColor.Equals(Color.Yellow))
            {
                bMaestroOkvir.BackColor = Color.Transparent;
            }
            else if (bAmexOkvir.BackColor.Equals(Color.Yellow))
            {
                bAmexOkvir.BackColor = Color.Transparent;
            }
        }

        private void b_amex_Click(object sender, EventArgs e)
        {
            bAmexOkvir.BackColor = Color.Yellow;
            if (bMasterOkvir.BackColor.Equals(Color.Yellow))
            {
                bMasterOkvir.BackColor = Color.Transparent;
            }
            else if (bMaestroOkvir.BackColor.Equals(Color.Yellow))
            {
                bMaestroOkvir.BackColor = Color.Transparent;
            }
            else if (bVisaOkvir.BackColor.Equals(Color.Yellow))
            {
                bVisaOkvir.BackColor = Color.Transparent;
            }
        }

        private void b_maestro_Click(object sender, EventArgs e)
        {
            bMaestroOkvir.BackColor = Color.Yellow;
            if (bMasterOkvir.BackColor.Equals(Color.Yellow))
            {
                bMasterOkvir.BackColor = Color.Transparent;
            }
            else if (bVisaOkvir.BackColor.Equals(Color.Yellow))
            {
                bVisaOkvir.BackColor = Color.Transparent;
            }
            else if (bAmexOkvir.BackColor.Equals(Color.Yellow))
            {
                bAmexOkvir.BackColor = Color.Transparent;
            }
        }
    }
}
