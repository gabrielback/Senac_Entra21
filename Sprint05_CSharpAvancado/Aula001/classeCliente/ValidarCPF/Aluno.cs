using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace MediaAluno
{
    internal class Aluno
    {
        private string Nome;
        private double Nota1;
        private double Nota2;
        private double Nota3;
        private string Endereco;
        DateTime DataNascimento;



        //Metodo construtor 
        public Aluno()
        {


        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }
        public string getNome()
        {
            return this.Nome;
        }


        public void setNota1(double nota1)
        {
            this.Nota1 = nota1;
        }

        public double getNota1()
        {
            return this.Nota1;
        }


        public void setNota2(double nota2)
        {
            this.Nota2 = nota2;
        }

        public double getNota2()
        {
            return this.Nota2;
        }


        public void setNota3(double nota3)
        {
            this.Nota3 = nota3;
        }

        public double getNota3()
        {
            return this.Nota3;
        }

        public void setDataNascimento(DateTime dataNascimento)
        {
            this.DataNascimento = dataNascimento;
        }

        public DateTime getDataNascimento()
        {
            return DataNascimento;
        }

        public void setEndereco(string endereco)
        {
            this.Endereco = endereco;
        }

        public string getEndereco()
        {
            return this.Endereco;
        }
         public double CalcularMedia()
        {   
            return ((Nota1 + Nota2 + Nota3) / 3);
        }

        public string VerificarSituacao()
        {
            if(this.CalcularMedia() >= 7.0)
            {
                return "Aprovado";
            }
            if(this.CalcularMedia() >= 5.0)
            {
                return "Em Recuperação";
            }
            else
            {
                return "Reprovado";
            }
        }

    }
}
