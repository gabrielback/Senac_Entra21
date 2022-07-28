using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeExercicios
{
    internal class ChangeVisibility
    {
        public string Kelvin { get; set; }
        public string Fahrenheit { get; set; }
        public bool Celsius { get; set; }
        

        private void Carro(int name, int description, int isVisibel)
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
    }
}
