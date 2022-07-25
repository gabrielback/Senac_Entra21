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
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int fatorial = Convert.ToInt16(txbFatorial.Text);
            int soma = fatorial;

            for (int i = 1; i < fatorial; i++)
            {
                soma = soma * i;

            }
            
            lblResult.Text = $"Fatorial de {fatorial} é : {soma.ToString()}";
            lblResult.Visible = true;
        }
    }
}
