using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstruturaDeHeranca
{
    public class Funcionario:Pessoa
    {
        private decimal salario;
        private int qntfilhos;
        private DateTime dataAdmissao;
        private int codFuncionario;
        private string nroPis;

        public double AumentarSalario()
        {
            return 0;
        }

        public decimal Salario { get => salario; set => salario = value; }
        public int Qntfilhos { get => qntfilhos; set => qntfilhos = value; }
        public DateTime DataAdmissao { get => dataAdmissao; set => dataAdmissao = value; }
        public int CodFuncionario { get => codFuncionario; set => codFuncionario = value; }
        public string NroPis { get => nroPis; set => nroPis = value; }
    }
}