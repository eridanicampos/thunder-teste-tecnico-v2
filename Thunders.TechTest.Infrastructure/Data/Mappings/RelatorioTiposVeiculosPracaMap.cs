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
    public class RelatorioTiposVeiculosPracaMap : IEntityTypeConfiguration<RelatorioTiposVeiculosPraca>
    {
        public void Configure(EntityTypeBuilder<RelatorioTiposVeiculosPraca> builder)
        {
            builder.ToTable("relatorio_tipos_veiculos_praca");

            builder.Property(x => x.NomePraca)
                .HasColumnName("nome_praca")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.TipoVeiculo)
                .HasColumnName("tipo_veiculo")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.Quantidade)
                .HasColumnName("quantidade")
                .IsRequired();

            builder.Property(x => x.DataRelatorio)
                .HasColumnName("data_relatorio")
                .IsRequired();

            new EntityGuidMap<RelatorioTiposVeiculosPraca>().AddCommonConfiguration(builder);
        }
    }
}
