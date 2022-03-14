using Microsoft.EntityFrameworkCore;
using PrototipoEngSoftware.Dominio.ContaModule;
using System;

namespace PrototipoEngSoftware.Infra.EntityFramework
{
    public class ContaContext : DbContext
    {
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }

        public ContaContext(DbContextOptions options) : base(options)
        {

        }

    }
}
