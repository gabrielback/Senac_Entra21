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
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {




            /*
            EX3 / EX4
            */
            try
            {
                int limiteInicial = Convert.ToInt32(txbNumero1.Text);
                int limiteFinal = Convert.ToInt32(txbNumero2.Text);
                int qntNumeros = limiteFinal - limiteInicial, numeroAtual = limiteInicial;
                int positivos = 0, multiplosDeSete = 0;
                for (int i = numeroAtual; i <= limiteFinal; i++)
                {
                    ltbIntervalo.Items.Add(numeroAtual);
                    if (numeroAtual >= 0)
                    {
                        positivos++;
                    }
                    if (numeroAtual % 7 == 0)
                    {
                        multiplosDeSete++;
                    }
                    numeroAtual++;
                }
                    MessageBox.Show($"Positivo: {positivos}\nNegativo: {qntNumeros+1 - (positivos)}\nMultiplos de 7: {multiplosDeSete}");


            }
            catch (Exception error)
            {
                MessageBox.Show($"Houve um erro:\n" + error.Message);
            }

            /*
                5.FUP utilizando a estrutura for para imprimir a seguinte torre de caracteres: 
            */

            /*
                         int quantidadeImpressoes = 50;
                        string caracter = "7";
                        string imprimir = "";
                        for (int i = 0; i < quantidadeImpressoes; i++)
                        {
                            imprimir += caracter;
                            Console.WriteLine(imprimir);
                        }
             */


        }
    }
}
