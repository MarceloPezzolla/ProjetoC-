using NossoBancoDomain.Interfaces.Entities;

namespace NossoBancoDomain.Entities
{
    public class PessoaJuridica : Cliente
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
    }
}