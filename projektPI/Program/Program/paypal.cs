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
    public partial class paypal : Form
    {
        public paypal()
        {
            InitializeComponent();
        }

        private void tb_loginpaypal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void paypal_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new nacinplacanja().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new karticno_placanje().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new placanje_uspjesno().Show();
            
        }
    }
}
