using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Thunders.TechTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Thunders.TechTest.Infrastructure.Data.Mappings
{
    public class EntityGuidMap<T> where T : EntityGuid
    {
        public void AddCommonConfiguration(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(c => c.Id)
                .HasColumnName("id");

            new EntityMap<T>().AddCommonConfiguration(builder);
        }
    }
}
