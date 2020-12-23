using System;
using NossoBancoDomain.Interfaces.Entities;

namespace NossoBancoDomain.Entities
{
    public class ContaPoupanca : Conta
    {
        public double Rendimento { get; set; }
        public DateTime Dt_Aniversario { get; set; }
    }
}