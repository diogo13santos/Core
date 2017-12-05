using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Domain.Entities;

namespace Core.Infra.Data.Context.Mapping
{
    internal class RoleMap : DbEntityConfiguration<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> entity)
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).HasMaxLength(80).IsRequired();

            entity.HasMany(r => r.Users)
                .WithOne(u => u.Role)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(r => r.Privileges)
                .WithOne(p => p.Role)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
