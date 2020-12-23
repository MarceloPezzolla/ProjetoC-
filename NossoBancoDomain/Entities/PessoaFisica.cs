using System;
using NossoBancoDomain.Interfaces.Entities;

namespace NossoBancoDomain.Entities
{
    public class PessoaFisica : Cliente
    {
        public string Nome { get; set; }
        public DateTime Dt_Nascimento { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }
    }
}