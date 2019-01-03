using Program;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class nacinplacanja : Form
    {
        public nacinplacanja()
        {
            InitializeComponent();
        }

        int t1 = 46;
        int t2 = 46;
        int t3 = 46;
        int t4 = 46;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.p_online.Size = new Size(this.p_online.Size.Width, t4);
            this.p_online.Size = new Size(this.p_online.Size.Width, t2);
            this.p_online.Size = new Size(this.p_online.Size.Width, t3);
            timer1.Start();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
            t1 = 46;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t1 > 255)
            {
                timer1.Stop();
                t1 += 5;
            }
            else
            {
                this.p_online.Size = new Size(this.p_online.Size.Width, t1);
                t1 += 5;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new karticno_placanje().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new paypal().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new menu().Show();
            this.Hide();
        }

        private void b_gotovinsko_Click(object sender, EventArgs e)
        {
            b_gotovinsko.BackColor = Color.Yellow;
            if (b_online.BackColor.Equals(Color.Yellow))
            {
                b_online.BackColor = Color.WhiteSmoke;
            }

            new placanje_uspjesno().Show();
            this.Hide();
        }


        private void b_online_Click(object sender, EventArgs e)
        {
            b_online.BackColor = Color.Yellow;
            if (b_gotovinsko.BackColor.Equals(Color.Yellow))
            {
                b_gotovinsko.BackColor =Color.WhiteSmoke;
            }
  
        }
    }
}
