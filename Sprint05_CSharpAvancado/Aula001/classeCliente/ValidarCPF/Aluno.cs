﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarCPF
{
    internal class Aluno
    {
        private double nota1;
        private double nota2;
        private double nota3;

        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }

        public double CalcularMedia()
        {
            return (Nota1 + Nota2 + Nota3);
        }
    }
}
