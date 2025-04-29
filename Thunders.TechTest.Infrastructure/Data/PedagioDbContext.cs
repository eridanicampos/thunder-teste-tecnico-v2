using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Thunders.TechTest.Domain.Entities;
using Thunders.TechTest.Infrastructure.Data.Mappings;

namespace Thunders.TechTest.Infrastructure.Data
{
    public class PedagioDbContext : DbContext
    {
        public PedagioDbContext(DbContextOptions<PedagioDbContext> options) : base(options) { }

        public DbSet<UtilizacaoPedagio> Utilizacoes { get; set; }
        public DbSet<Praca> Pracas { get; set; }

        public DbSet<RelatorioValorHoraCidade> RelatoriosValorHoraCidade { get; set; }
        public DbSet<RelatorioTopPracasMes> RelatoriosTopPracasMes { get; set; }
        public DbSet<RelatorioTiposVeiculosPraca> RelatoriosTiposVeiculosPraca { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PracaMap()); 
            modelBuilder.ApplyConfiguration(new UtilizacaoPedagioMap());
            modelBuilder.ApplyConfiguration(new RelatorioTiposVeiculosPracaMap());
            modelBuilder.ApplyConfiguration(new RelatorioTopPracasMesMap());
            modelBuilder.ApplyConfiguration(new RelatorioValorHoraCidadeMap());


            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
