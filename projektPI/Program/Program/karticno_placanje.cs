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
            if(label4.Visible == true && label7.Visible == true && label9.Visible == true && label8.Visible == true)
            {
                if(bVisaOkvir.BackColor.Equals(Color.Yellow) || bMaestroOkvir.BackColor.Equals(Color.Yellow) || bMasterOkvir.BackColor.Equals(Color.Yellow) || bAmexOkvir.BackColor.Equals(Color.Yellow))
                {
                    new placanje_uspjesno().Show();
                }
                else
                {
                    MessageBox.Show("Odaberite vrstu kartice. Pokušajte ponovno.", "Greška kod plaćanja!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Neispravni unos podataka. Pokušajte ponovno.", "Greška kod plaćanja!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
          }
        
        

        private void tbInputCNumb_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tbInputCNumb_Click(object sender, EventArgs e)
        {
            tbInputCNumb.Text = "";
            tbInputCNumb.ForeColor = Color.Black;

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
        }

        private void tbInputSeCode_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbInputSeCode_Click(object sender, EventArgs e)
        {
            tbInputSeCode.Text = "";
            tbInputSeCode.ForeColor = Color.Black;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void karticno_placanje_Click(object sender, EventArgs e)
        {

        }

        private void tbInputCNumb_Leave(object sender, EventArgs e)
        {
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
                    label5.Visible = false;
                    label4.Visible = true;
                }
                else
                {
                    //netočno upisano
                    label4.Visible = false;
                    label5.Visible = true;
                }

            }
            if (provjeriText == "")
            {
                label4.Visible = false;
                label5.Visible = true;
            }
           
        }

        private void tbInputName_Leave(object sender, EventArgs e)
        {
            String provjeriText = tbInputName.Text;

            if (provjeriText != "")
            {
                if (provjeriText.Contains(" "))
                {
                    //točno upisano
                    label6.Visible = false;
                    label7.Visible = true;
                }
                else
                {
                    //netočno upisano
                    label7.Visible = false;
                    label6.Visible = true;
                }

            }
            if (provjeriText == "")
            {
                label7.Visible = false;
                label6.Visible = true;
            }
        }

        private void tbInputExDate_Leave(object sender, EventArgs e)
        {

            Regex r = new Regex("^[0-9]{2}\\/[0-9]{2}");
            String provjeriText = tbInputExDate.Text;
            string[] polje;
            if (provjeriText != "")
            {
                Boolean provjera = r.IsMatch(provjeriText);
                if (provjera)
                {
                    //točno upisano
                    polje = provjeriText.Split('/');
                    int mjesec = Convert.ToInt32(polje[0]);
                    int godina = Convert.ToInt32(polje[1]);
                    if (mjesec < 13)
                    {
                        if(godina > 18 && godina < 30)
                        {
                            label11.Visible = false;
                            label9.Visible = true;
                        }
                        else
                        {
                            label9.Visible = false;
                            label11.Visible = true;
                        }
                    }
                    else
                    {
                        label9.Visible = false;
                        label11.Visible = true;
                    }
                }
                else
                {
                    //netočno upisano
                    label9.Visible = false;
                    label11.Visible = true;
                }
            }
            if (provjeriText == "")
            {
                label9.Visible = false;
                label11.Visible = true;
            }
        }

        private void tbInputSeCode_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex("^[0-9]{3}$");
            String provjeriText = tbInputSeCode.Text;
            if (provjeriText != "")
            {
                Boolean provjera = r.IsMatch(provjeriText);
                if (provjera)
                {
                    //točno upisano
                    label10.Visible = false;
                    label8.Visible = true;
                }
                else
                {
                    //netočno upisano
                    label8.Visible = false;
                    label10.Visible = true;
                }

            }
            if (provjeriText == "")
            {
                label8.Visible = false;
                label10.Visible = true;
            }
        }
    }
}

