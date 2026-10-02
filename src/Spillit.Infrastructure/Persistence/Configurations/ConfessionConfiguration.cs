using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spillit.Domain.Entities;

namespace Spillit.Infrastructure.Persistence.Configurations;

public class ConfessionConfiguration : IEntityTypeConfiguration<Confession>
{
    public void Configure(EntityTypeBuilder<Confession> builder)
    {
        builder.Property(c => c.Content)
               .IsRequired()
               .HasMaxLength(2000);

        builder.HasOne(c => c.Organization)
               .WithMany()
               .HasForeignKey(c => c.OrganizationId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(c => c.Department)
               .WithMany()
               .HasForeignKey(c => c.DepartmentId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(c => c.Comments)
               .WithOne(cm => cm.Confession)
               .HasForeignKey(cm => cm.ConfessionId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(c => c.Reactions)
               .WithOne(r => r.Confession)
               .HasForeignKey(r => r.ConfessionId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}