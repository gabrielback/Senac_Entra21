using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cadastro_Escolar
{
    internal class Aluno:Pessoa
    {
        private double media;

        public double Media { get => media; set => media = value; }


        public override string ToString()
        {
            return $"\n\nAluno: {Nome}" +
                $"\nMédia: {Media.ToString("F", CultureInfo.InvariantCulture)}" +
                $"\nMatrícula do Aluno: {Matricula}";
        }
    }
}
