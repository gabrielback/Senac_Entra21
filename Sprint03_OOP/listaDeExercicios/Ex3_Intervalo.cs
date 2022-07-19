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
    public partial class Ex3_Intervalo : Form
    {
        public Ex3_Intervalo()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {


            try { 
            int numero1 = Convert.ToInt16(txbNumero1.Text);
            int numero2 = Convert.ToInt16(txbNumero2.Text);
            for(int i = numero1; i <= numero2; i++)
            {
                ltbIntervalo.Items.Add(numero1);
                numero1++;
            }
            
            }
            catch (Exception error)
            {
                MessageBox.Show($"Houve um erro:\n" + error.Message);
            }
        }
    }
}
