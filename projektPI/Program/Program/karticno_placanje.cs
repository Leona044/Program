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
using System.Text.RegularExpressions;

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

        private void tb_cardnumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbInputCNumb.Text) || string.IsNullOrWhiteSpace(tbInputName.Text) || string.IsNullOrWhiteSpace(tbInputExDate.Text) || string.IsNullOrWhiteSpace(tbInputSeCode.Text))
            {
              //  MessageBox.Show("Nisu popunjena sva polja!", "Greška kod plaćanja!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Regex r = new Regex("^([0-9]{4}\\s){3}[0-9]{4}");
                Regex r2 = new Regex("^[0-9]{16}$");
                String provjeriText = tbInputCNumb.Text;
                if (provjeriText != ""){
                    Boolean provjera = r.IsMatch(provjeriText);
                    Boolean provjera2 = r2.IsMatch(provjeriText);
                    if (provjera || provjera2)
                    {
                        //točno upisano
                        label4.Text="Tocno!";
                    }
                    else
                    {
                        //netočno upisano
                        label4.Text = "Netocno!";
                    }
                    //tbInputCNumb.Text.Remove(tbInputCNumb.Text.Length - 1);
                }
               



            }

        }        

        private void tbInputCNumb_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tbInputCNumb_Click(object sender, EventArgs e)
        {
            tbInputCNumb.Text = "";
            tbInputCNumb.ForeColor = Color.Black;

            Regex r = new Regex("^([0-9]{4}\\s){3}[0-9]{4}");
            Regex r2 = new Regex("^[0-9]{16}$");
            String provjeriText = tbInputCNumb.Text;
            if (provjeriText != "")
            {
                Boolean provjera = r.IsMatch(provjeriText);
                Boolean provjera2 = r2.IsMatch(provjeriText);
                if (provjera || provjera2)
                {
                    //točno upisano
                    label4.Text = "Tocno!";
                }
                else
                {
                    //netočno upisano
                    label4.Text = "Netocno!";
                }
            }
        }

        private void tbInputName_Click(object sender, EventArgs e)
        {
            tbInputName.Text = "";
            tbInputName.ForeColor = Color.Black;
        }

        private void tbInputExDate_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbInputExDate_Click(object sender, EventArgs e)
        {
            tbInputExDate.Text = "";
            tbInputExDate.ForeColor = Color.Black;

            Regex r = new Regex("^[0-9]{2}\\/[0-9]{2}");
            String provjeriText = tbInputExDate.Text;
            if (provjeriText != "")
            {
                Boolean provjera = r.IsMatch(provjeriText);
                if (provjera)
                {
                    //točno upisano
                    label5.Text = "Tocno!";
                }
                else
                {
                    //netočno upisano
                    label5.Text = "Netocno!";
                }
                //tbInputCNumb.Text.Remove(tbInputCNumb.Text.Length - 1);
            }
        }

        private void tbInputSeCode_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex("^[0-9]{3}$");
            String provjeriText = tbInputSeCode.Text;
            if (provjeriText != "")
            {
                Boolean provjera = r.IsMatch(provjeriText);
                if (provjera)
                {
                    //točno upisano
                    label5.Text = "Tocno!";
                }
                else
                {
                    //netočno upisano
                    label5.Text = "Netocno!";
                }
                //tbInputCNumb.Text.Remove(tbInputCNumb.Text.Length - 1);
            }
        }

        private void tbInputSeCode_Click(object sender, EventArgs e)
        {
            tbInputSeCode.Text = "";
            tbInputSeCode.ForeColor = Color.Black;
        }
    }
}

