using System;
namespace NossoBancoDomain.Interfaces.Entities
{
    public class Conta
    {
        public string NroConta { get; set; }
        public DateTime Dt_Abertura { get; set; }
        public DateTime Dt_Fechamento { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }
        public string Agencia { get; set; }
    }
}