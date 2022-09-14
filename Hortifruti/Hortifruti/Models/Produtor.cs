namespace Hortifruti.Models
{
    public class Produtor : Pessoa
    {
        public string CodProdutorRural { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool StatusProdutor { get; set; }

        public Produtor(string codProdutorRural, DateTime dataCadastro, bool statusProdutor)
        {
            CodProdutorRural = codProdutorRural;
            DataCadastro = dataCadastro;
            StatusProdutor = statusProdutor;


        }
    }
}
