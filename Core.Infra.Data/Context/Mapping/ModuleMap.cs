using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Domain.Entities;

namespace Core.Infra.Data.Context.Mapping
{
    internal class ModuleMap : DbEntityConfiguration<Module>
    {
        public override void Configure(EntityTypeBuilder<Module> entity)
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).HasMaxLength(80).IsRequired();
            entity.Property(x => x.Status).IsRequired();

            entity.HasOne(m => m.SuperModule)
                .WithMany(m => m.ChildModules)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(m => m.Resources)
                .WithOne(r => r.Module)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
