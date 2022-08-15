using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarCPF
{
    internal class ValidarCpf
    {
        private string cpf = "082.125.496-14";
        private int primeiroDigitoVerificador;
        private int segundoDigitoVerificador;

        public string limparCpf( string cpf)
        {
            return cpf.Substring(6,7);
        }
    }
}
