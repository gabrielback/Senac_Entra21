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
            int celsius = Convert.ToInt16(txbCelsius.Text);
            int kelvin = Convert.ToInt16(txbKelvin.Text);
            int fahrenheit = Convert.ToInt16(txbFahrenheit.Text);



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

        }

        private void txbKelvin_TextChanged(object sender, EventArgs e)
        {

            txbCelsius.ReadOnly = true;
            txbFahrenheit.ReadOnly = true;

                
        }
    }
}
