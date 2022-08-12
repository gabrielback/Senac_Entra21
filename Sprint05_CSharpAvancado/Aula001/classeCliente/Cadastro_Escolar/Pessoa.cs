using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Escolar
{
    internal class Pessoa
    {
<<<<<<< HEAD
        private int matricula;
        private string nome;
        private string cpf;

        public void ValidarCpf()
        {
            Console.WriteLine("Cpf");
        }

        public int Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
=======
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


>>>>>>> 4542b3e8006fd1150c18ed1a10352d2ef20c58cb
    }
}
