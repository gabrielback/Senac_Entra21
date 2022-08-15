using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarCPF
{
    internal class ValidarCpf
    {
        private string cpf = "063.169.969-42";
        private int primeiroDigitoVerificador;
        private int segundoDigitoVerificador;

        public string limparCpf( string cpf)
        {
            return cpf.Substring(6,7);
        }
    }
}
