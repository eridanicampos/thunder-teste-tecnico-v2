using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Thunders.TechTest.Domain.Entities;

namespace Thunders.TechTest.Infrastructure.Data.Mappings;

public class UtilizacaoPedagioMap : IEntityTypeConfiguration<UtilizacaoPedagio>
{
    public void Configure(EntityTypeBuilder<UtilizacaoPedagio> builder)
    {
        builder.ToTable("utilizacoes");

        builder.Property(x => x.DataHoraUtilizacao)
               .IsRequired().HasColumnName("data_hora_utilizacao");

        builder.Property(x => x.PracaId)
           .IsRequired()
           .HasColumnName("praca_id");

        builder.Property(x => x.ValorPago)
            .HasColumnType("decimal(10,2)")
            .IsRequired()
            .HasColumnName("valor_pago");

        builder.Property(x => x.TipoVeiculo)
            .HasConversion<string>()
            .IsRequired()
            .HasColumnName("tipo_veiculo");

        builder.HasOne(x => x.Praca)
            .WithMany()
            .HasForeignKey(x => x.PracaId)
            .OnDelete(DeleteBehavior.Restrict);

        new EntityGuidMap<UtilizacaoPedagio>().AddCommonConfiguration(builder);

    }
}
