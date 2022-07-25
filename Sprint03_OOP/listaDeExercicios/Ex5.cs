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
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            /*
                 5.FUP utilizando a estrutura for para imprimir a seguinte torre de caracteres: 
            */
            try
            {

                        int quantidadeImpressoes = Convert.ToInt32(txbQuantidade.Text);
                        string caracter = txbCaracteres.Text;
                        string imprimir = "";

                        for (int i = 0; i < quantidadeImpressoes; i++)
                        {
                            imprimir += caracter;
                            ltbPrint.Items.Add(imprimir);
                        }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Houve um erro:\n" + error.Message);

            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ltbPrint.Items.Clear();
            txbCaracteres.Text = "";
            txbQuantidade.Text = "";

        }
    }
}
