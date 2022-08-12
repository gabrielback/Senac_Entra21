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
            return $"\n\nProfessor: {Nome}" +
                $"\nSalário: ${salario.ToString("F")}" +
                $"\nMatrícula do Professor: {Matricula}";
        }
    }
}
