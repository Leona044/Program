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
    public partial class potvrda : Form
    {
        menu menu = null;
        public potvrda(menu menu)
        {
            InitializeComponent();
            this.menu = menu;

        }

        private void mlbl_potvrda_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new nacinplacanja().Show();
            this.Hide();
            menu.Hide();



           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
