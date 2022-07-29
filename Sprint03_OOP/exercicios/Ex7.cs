using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaDeExercicios
{
    public partial class Ex7 : Form
    {
        public Ex7()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int celsius, kelvin, fahrenheit;
            try
            {
                if (txbCelsius.Text.Length > 0)
                {
                    celsius = Convert.ToInt32(txbCelsius.Text);
                    double celsiusToFahrenheit = 9 * celsius / 5 + 32;
                    double celsiusToKelvin = celsius + 273;

                    txbFahrenheit.Text = celsiusToFahrenheit.ToString();
                    txbKelvin.Text = celsiusToKelvin.ToString();
                    txbCelsius.ReadOnly = true;
                }
                else if (txbKelvin.Text.Length > 0)
                {
                    kelvin = Convert.ToInt32(txbKelvin.Text);
                    double kelvinToCelsius = kelvin - 273;
                    double kelvinToFahrenheit = 9 * (kelvin - 273) / 5 + 32;

                    txbCelsius.Text = kelvinToCelsius.ToString();
                    txbFahrenheit.Text = kelvinToFahrenheit.ToString();
                }
                else if (txbFahrenheit.Text.Length > 0)
                {

                    fahrenheit = Convert.ToInt32(txbFahrenheit.Text);
                    double fahrenheitToKelvin = 5 * (fahrenheit - 32) / 9 + 273;
                    double fahrenheitToCelsius = 5 * (fahrenheit - 32) / 9;

                    txbCelsius.Text = fahrenheitToCelsius.ToString();
                    txbKelvin.Text = fahrenheitToKelvin.ToString();
                }
                btnConverter.Enabled = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong!!\n\n{ex.Message.ToUpper()}\n\nTry again.");
                btnLimpar.PerformClick();
            }
           


        }


        
        public void setInputVisibility()
        {
            if (txbCelsius.Text.Length > 0)
            {
                txbKelvin.ReadOnly = true;
                txbFahrenheit.ReadOnly = true;


            }
            else if (txbFahrenheit.Text.Length > 0)
            {
                txbKelvin.ReadOnly = true;
                txbCelsius.ReadOnly = true;

            }
            else if (txbKelvin.Text.Length > 0)
            {
                txbCelsius.ReadOnly = true;
                txbFahrenheit.ReadOnly = true;

            }
            else
            {
                txbKelvin.ReadOnly = false;
                txbCelsius.ReadOnly = false;
                txbFahrenheit.ReadOnly = false;

            }
        }

        private void txbKelvin_TextChanged(object sender, EventArgs e)
        {
            setInputVisibility();
        }

        private void txbCelsius_TextChanged(object sender, EventArgs e)
        {
            setInputVisibility();
        }

        private void txbFahrenheit_TextChanged(object sender, EventArgs e)
        {
            setInputVisibility();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbCelsius.Text = "";
            txbKelvin.Text = "";
            txbFahrenheit.Text = "";
            btnConverter.Enabled = true;
        }
    }
}
