using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Escolar
{
    internal class Pessoa
    {
        private int Matricula;
        private string Nome;

        public string getNome()
        {
            return Nome;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }
        public int getMatricula()
        {
            return Matricula;
        }

        public void setMatricula(int matricula)
        {
            this.Matricula = matricula;
        }


    }
}
