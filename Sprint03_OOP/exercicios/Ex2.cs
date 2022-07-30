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





        }

        private void btnChecar_Click(object sender, EventArgs e)
        {

            /*
            EX2
            Faça um Programa que peça um valor e mostre na tela se o valor é positivo 
            ou negativo e verifique se o número é par ou ímpar.
            */
            try
            {
            int number = Convert.ToInt16(txbNumero1.Text);

            string positivoOuNegativo = (number >= 0) ? "positivo" : "negativo";
            string parOuImpar = (number % 2 == 0) ? "Par" : "Impar";
            MessageBox.Show($"O número é {parOuImpar} e {positivoOuNegativo}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong!!\n\n{ex.Message.ToUpper()}\n\nTry again.");
                txbNumero1.Text = "";
            }
        }
    }
}
