using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstruturaDeHeranca
{
    public class Pessoa
    {
        private string nome;
        private string endereco;
        private string cpf;
        private DateTime dataNascimento;
        private string telefone;

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        public bool ValidarCpf()
        {
            return !string.IsNullOrWhiteSpace(nome);
        }
    }
}