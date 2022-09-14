namespace Hortifruti.Models
{
    public class Gestor : Pessoa
    {
        public int CodFuncionario { get; set; }

        public Gestor(int codFuncionario)
        {
            CodFuncionario = codFuncionario;
        }
    }
}
