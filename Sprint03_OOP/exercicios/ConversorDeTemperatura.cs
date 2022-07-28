using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercicios
{
    internal class ConversorDeTemperatura
    {
        int Celsius, Kelvin, Fahrenheit;
          
        public void ConverterTemperatura(int celsius, int fahrenheit, int kelvin)
        {
            if (celsius > 0)
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

    }
}
