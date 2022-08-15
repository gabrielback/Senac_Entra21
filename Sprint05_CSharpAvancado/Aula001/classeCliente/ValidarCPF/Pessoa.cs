using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Escolar
{
    internal class Pessoa
    {
        private int matricula;
        private string nome;
        private string cpf = "082.125.496-14";

        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Matricula { get => matricula; set => matricula = value; }

        public string imprimirCpf(string cpf)
        {
            return cpf.Substring(6, 7);
        }

    }
}
