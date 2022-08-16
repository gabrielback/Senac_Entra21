using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstruturaDeHeranca
{
    public class Aluno:Pessoa
    {
        private double media1;
        private double media2;
        private double media3;
        private double media4;


        public double CalcularMedia()
        {
            return (Media1 + Media2 + Media3 + Media4) / 4;
        }

        public bool StatusDeAprovacao()
        {
            return false;
        }

        public double Media1 { get => media1; set => media1 = value; }
        public double Media2 { get => media2; set => media2 = value; }
        public double Media3 { get => media3; set => media3 = value; }
        public double Media4 { get => media4; set => media4 = value; }

    }
}