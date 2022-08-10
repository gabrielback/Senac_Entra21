using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarCPF
{
    internal class Professor
    {
        private double salario;
        private int qntFilhos;

        public void AumentarSalario(double qte)
        {
            salario += qte;
        }
        public void AumentarFilhos(int qte)
        {
            qntFilhos += qte;
        }

    }
}
