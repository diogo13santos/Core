using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Domain.Entities;

namespace Core.Infra.Data.Context.Mapping
{
    internal class ResourceMap : DbEntityConfiguration<Resource>
    {
        public override void Configure(EntityTypeBuilder<Resource> entity)
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).HasMaxLength(80).IsRequired();

            entity.HasMany(r => r.Privileges)
                .WithOne(p => p.Resource)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(r => r.Module)
                .WithMany(m => m.Resources)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
