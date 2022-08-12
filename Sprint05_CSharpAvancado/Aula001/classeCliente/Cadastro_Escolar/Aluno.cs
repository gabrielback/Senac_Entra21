using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using System.Globalization;
=======
>>>>>>> 4542b3e8006fd1150c18ed1a10352d2ef20c58cb

namespace Cadastro_Escolar
{
    internal class Aluno:Pessoa
    {
<<<<<<< HEAD
        private double media;

        public double Media { get => media; set => media = value; }


        public override string ToString()
        {
            return $"\n\nAluno: {Nome}" +
                $"\nMédia: {Media.ToString("F", CultureInfo.InvariantCulture)}" +
                $"\nMatrícula do Aluno: {Matricula}";
=======
        private int Matricula;
        private double Media;



        public int Matricula2 { get => Matricula; set => Matricula = value; }
        public double Media1 { get => Media; set => Media = value; }

        public override string ToString()
        {
            return $"\n\nAluno: {getNome()}" +
                $"\nMédia: ${Media1.ToString("F")}" +
                $"\nMatrícula do Aluno: {getMatricula()}";
>>>>>>> 4542b3e8006fd1150c18ed1a10352d2ef20c58cb
        }
    }
}
