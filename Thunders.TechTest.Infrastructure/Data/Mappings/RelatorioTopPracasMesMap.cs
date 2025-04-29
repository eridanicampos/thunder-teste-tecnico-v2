using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunders.TechTest.Domain.Entities;

namespace Thunders.TechTest.Infrastructure.Data.Mappings
{
    public class RelatorioTopPracasMesMap : IEntityTypeConfiguration<RelatorioTopPracasMes>
    {
        public void Configure(EntityTypeBuilder<RelatorioTopPracasMes> builder)
        {
            builder.ToTable("relatorio_top_pracas_mes");

            builder.Property(x => x.NomePraca)
                .HasColumnName("nome_praca")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.ValorTotal)
                .HasColumnName("valor_total")
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder.Property(x => x.Ano)
                .HasColumnName("ano")
                .IsRequired();

            builder.Property(x => x.Mes)
                .HasColumnName("mes")
                .IsRequired();

            builder.Property(x => x.DataRelatorio)
                .HasColumnName("data_relatorio")
                .IsRequired();

            new EntityGuidMap<RelatorioTopPracasMes>().AddCommonConfiguration(builder);
        }
    }
}
