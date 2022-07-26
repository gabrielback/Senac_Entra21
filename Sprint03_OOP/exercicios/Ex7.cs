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
            celsius = Convert.ToInt16(txbCelsius.Text);
            kelvin = Convert.ToInt16(txbKelvin.Text);
            fahrenheit = Convert.ToInt16(txbFahrenheit.Text);
            if(celsius.ToString().Length > 0) 
                    MessageBox.Show(celsius.ToString());
            if(kelvin.ToString().Length > 0) 
                    MessageBox.Show(kelvin.ToString());
            if(fahrenheit.ToString().Length > 0) 
                    MessageBox.Show(fahrenheit.ToString());

            }
            catch
            {
            }
            

            /*

            int CelsiusToFahrenheit = 9 * celsius / 5 + 32;
            int celsiusToKelvin = celsius + 273;

            int kelvinToCelsius = kelvin - 273;
            int kelvinToFahrenheit = 9 * (kelvin - 273) / 5 + 32;

            int fahrenheitToKelvin = 5 * (fahrenheit - 32) / 9 + 273;
            int fahrenheitToCelsius = 5 * (fahrenheit - 32) / 9;

            txbCelsius.Text = kelvinToCelsius.ToString();
            txbFahrenheit.Text = kelvinToFahrenheit.ToString();

 




            Console.WriteLine($"CelsiusToFahrenheit: {CelsiusToFahrenheit}");
            Console.WriteLine($"celsiusToKelvin: {celsiusToKelvin}");

            Console.WriteLine("kelvinToFahrenheit: " + kelvinToFahrenheit);
            Console.WriteLine("kelvinToCelsius: " + kelvinToCelsius);


            Console.WriteLine("fahrenheitToKelvin: " + fahrenheitToKelvin);
            Console.WriteLine("fahrenheitToCelsius: " + fahrenheitToCelsius);
             
             */
        }

        private void txbKelvin_TextChanged(object sender, EventArgs e)
        {
            if (txbKelvin.Text.Length > 0)
            {
                txbCelsius.ReadOnly = true;
                txbFahrenheit.ReadOnly = true;
                txbCelsius.Text = "";
                txbFahrenheit.Text = "";

            }
            else
            {
                txbCelsius.ReadOnly = false;
                txbFahrenheit.ReadOnly = false;
                txbCelsius.Text = "";
                txbFahrenheit.Text = "";

            }
        }

        private void txbCelsius_TextChanged(object sender, EventArgs e)
        {
            if(txbCelsius.Text.Length > 0)
            {

            txbKelvin.ReadOnly = true;
            txbFahrenheit.ReadOnly = true;

            }
            else
            {
                txbKelvin.ReadOnly = false;
                txbFahrenheit.ReadOnly = false;
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
    }
}
