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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void F_menu_Load(object sender, EventArgs e)
        {

        }

        private void Glavno_jelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new potvrda(this).Show();
    
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_jela_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }  

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*listBox1.Items.Clear();
            foreach(string s in 
            {
                listBox1.Items.Add(s);
            }*/
        }

        private void b_ponuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.scpu.hr/hr/prehrana/");
        }
    }
}
