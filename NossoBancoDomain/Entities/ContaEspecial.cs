using System;
using NossoBancoDomain.Interfaces.Entities;

namespace NossoBancoDomain.Entities
{
    public class ContaEspecial : Conta
    {
        public double Limite_Conta { get; set; }
        public double Juros { get; set; }
    }
}