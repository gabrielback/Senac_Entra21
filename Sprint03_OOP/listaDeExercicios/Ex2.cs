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
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {


            /*
EX2

Faça um Programa que peça um valor e mostre na tela se o valor é positivo 
ou negativo e verifique se o número é par ou ímpar.

*/

            int number = -0;


            if (number >= 0)
            {
                Console.WriteLine("Positivo");
            }
            else
            {
                Console.WriteLine("Negativo");

            }
            if (number % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("impar");

            }
            MessageBox.Show("teste");
            string positivoOuNegativo = (number >= 0) ? "positivo" : "negativo";
            string parOuImpar = (number % 2 == 0) ? "Par" : "Impar";
            Console.WriteLine($"O número é {parOuImpar} e {positivoOuNegativo}");

        }
    }
}
