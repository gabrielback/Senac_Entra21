using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Escolar
{
    internal class Aluno:Pessoa
    {
        private int Matricula;
        private double Media;



        public int Matricula2 { get => Matricula; set => Matricula = value; }
        public double Media1 { get => Media; set => Media = value; }

        public override string ToString()
        {
            return $"\n\nAluno: {getNome()}" +
                $"\nMédia: ${Media1.ToString("F")}" +
                $"\nMatrícula do Aluno: {getMatricula()}";
        }
    }
}
