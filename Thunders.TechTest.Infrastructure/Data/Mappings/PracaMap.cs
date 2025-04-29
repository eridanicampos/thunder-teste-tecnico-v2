using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Thunders.TechTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Thunders.TechTest.Infrastructure.Data.Mappings
{
    public class PracaMap : IEntityTypeConfiguration<Praca>
    {
        public void Configure(EntityTypeBuilder<Praca> builder)
        {
            builder.ToTable("pracas");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Cidade)
                .HasColumnName("cidade")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Estado)
                .HasConversion<string>()
                .HasColumnName("estado")
                .HasMaxLength(2)
                .IsRequired();

            new EntityGuidMap<Praca>().AddCommonConfiguration(builder);

        }
    }
}
