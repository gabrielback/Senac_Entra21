using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Escolar
{
    internal class Professor:Pessoa
    {

        private double salario;


        public double Salario { get => salario; set => salario = value; }

        public override string ToString()
        {
<<<<<<< HEAD
            return $"\n\nProfessor: {Nome}" +
                $"\nSalário: ${salario.ToString("F")}" +
                $"\nMatrícula do Professor: {Matricula}";
=======
            return $"\n\nProfessor: {getNome()}" +
                $"\nSalário: ${salario.ToString("F")}" +
                $"\nMatrícula do Professor: {getMatricula()}";
>>>>>>> 4542b3e8006fd1150c18ed1a10352d2ef20c58cb
        }
    }
}
