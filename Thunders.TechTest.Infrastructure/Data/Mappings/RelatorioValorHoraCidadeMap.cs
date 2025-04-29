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
    public class RelatorioValorHoraCidadeMap : IEntityTypeConfiguration<RelatorioValorHoraCidade>
    {
        public void Configure(EntityTypeBuilder<RelatorioValorHoraCidade> builder)
        {
            builder.ToTable("relatorio_valor_hora_cidade");

            builder.Property(x => x.Cidade)
                .HasColumnName("cidade")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Hora)
                .HasColumnName("hora")
                .IsRequired();

            builder.Property(x => x.ValorTotal)
                .HasColumnName("valor_total")
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder.Property(x => x.DataRelatorio)
                .HasColumnName("data_relatorio")
                .IsRequired();

            new EntityGuidMap<RelatorioValorHoraCidade>().AddCommonConfiguration(builder);
        }
    }
}
