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

        private void l_username_Click(object sender, EventArgs e)
        {

        }

        private void b_prijava_Click(object sender, EventArgs e)
        {
            new menu().Show();
            this.Hide();
            video.Ctlcontrols.stop();

        }

        private void video_Enter(object sender, EventArgs e)
        {

        }
    }
}
