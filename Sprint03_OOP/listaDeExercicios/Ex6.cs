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
            int acumulador = 0;
            int fatorial = 5;

            for (int i = 0; i < fatorial; i++)
            {
                acumulador *= fatorial;
                fatorial--;
            MessageBox.Show(fatorial.ToString());

            }
            MessageBox.Show(acumulador.ToString());
            /*
            
            const fatorial = (n, p) => {
                if (n > 1 && p == undefined)
                {
                    return n * fatorial(n - 1)
                }
                return n
                }
            */
        }
    }
}
