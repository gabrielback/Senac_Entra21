using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstruturaDeHeranca
{
    public class Instrutor:Funcionario
    {
        private DateTime primeiraEmissaoCnh;
        private string cnh;
        public DateTime PrimeiraEmissaoCnh { get => primeiraEmissaoCnh; set => primeiraEmissaoCnh = value; }

        public bool StatusCarteira()
        {
            return false;
        }

        public bool StatusInstrutor()
        {
            if( PrimeiraEmissaoCnh.Year < 2 &&  StatusCarteira() == false )
            {
                return false;
            }
            return true;

        }
    }
}