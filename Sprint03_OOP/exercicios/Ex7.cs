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
          
            if(txbCelsius.Text.Length > 0)
            {
                celsius = Convert.ToInt32(txbCelsius.Text);
                int celsiusToFahrenheit = 9 * celsius / 5 + 32;
                int celsiusToKelvin = celsius + 273;

                txbFahrenheit.Text = celsiusToFahrenheit.ToString();
                txbKelvin.Text = celsiusToKelvin.ToString();
            }
            else if (txbKelvin.Text.Length > 0)
            {
                kelvin = Convert.ToInt32(txbKelvin.Text);
                int kelvinToCelsius = kelvin - 273;
                int kelvinToFahrenheit = 9 * (kelvin - 273) / 5 + 32;
                
                txbCelsius.Text = kelvinToCelsius.ToString();
                txbFahrenheit.Text = kelvinToFahrenheit.ToString();
            }
            else if (txbFahrenheit.Text.Length > 0)
            {

                fahrenheit = Convert.ToInt32(txbFahrenheit.Text);
                int fahrenheitToKelvin = 5 * (fahrenheit - 32) / 9 + 273;
                int fahrenheitToCelsius = 5 * (fahrenheit - 32) / 9;

                txbFahrenheit.Text = fahrenheitToKelvin.ToString();
                txbKelvin.Text = fahrenheitToCelsius.ToString();
            }

        }

        private void txbKelvin_TextChanged(object sender, EventArgs e)
        {
            if (txbKelvin.Text.Length > 0)
            {
                txbCelsius.ReadOnly = true;
                txbFahrenheit.ReadOnly = true;
                
            }
            else
            {
                txbCelsius.ReadOnly = false;
                txbFahrenheit.ReadOnly = false;

            }
        }

        private void txbCelsius_TextChanged(object sender, EventArgs e)
        {
            bool v = txbCelsius.Text.Length >= 0 ? txbKelvin.ReadOnly = true: txbKelvin.ReadOnly = false;
            MessageBox.Show(v.ToString());
            if (txbCelsius.Text.Length > 0)
            {

        //    txbKelvin.ReadOnly = true;
         //   txbFahrenheit.ReadOnly = true;

            }
            else
            {
         //       txbKelvin.ReadOnly = false;
         //       txbFahrenheit.ReadOnly = false;
            }

        }

        private void txbFahrenheit_TextChanged(object sender, EventArgs e)
        {
            if (txbFahrenheit.Text.Length > 0)
            {   
                
                txbCelsius.ReadOnly = true;
                txbKelvin.ReadOnly = true;

            }
            else
            {
                txbCelsius.ReadOnly = false;
                txbKelvin.ReadOnly = false;

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbCelsius.Text = "";
            txbKelvin.Text = "";
            txbFahrenheit.Text = "";
        }
    }
}
