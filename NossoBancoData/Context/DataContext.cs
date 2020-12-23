using Microsoft.EntityFrameworkCore;
using NossoBancoDomain.Entities;

namespace NossoBancoData.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<PessoaFisica> PessoasFisica { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridica { get; set; }
        public DbSet<ContaEspecial> ContasEspeciais { get; set; }
        public DbSet<ContaPopanca> ContasPoupanca { get; set; }
    }
}