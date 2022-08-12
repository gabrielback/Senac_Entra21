using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace Cadastro_Escolar
{
    internal class Professor:Pessoa
    {

        private double salario;


        public double Salario { get => salario; set => salario = value; }

        public override string ToString()
        {
            return $"\n\nProfessor: {getNome()}" +
                $"\nSalário: ${salario.ToString("F")}" +
                $"\nMatrícula do Professor: {getMatricula()}";
        }
=======
namespace ValidarCPF
{
    internal class Professor
    {
        private double salario;
        private int qntFilhos;

        public void AumentarSalario(double qte)
        {
            salario += qte;
        }
        public void AumentarFilhos(int qte)
        {
            qntFilhos += qte;
        }

>>>>>>> 4542b3e8006fd1150c18ed1a10352d2ef20c58cb
    }
}
