using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortfolioTracker.Api.Entities;
namespace PortfolioTracker.Api.Data.Configurations;

public class PortfolioConfiguration : IEntityTypeConfiguration<Portfolio>
{
    public void Configure(EntityTypeBuilder<Portfolio> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
        builder.Property(p => p.BaseCurrency).IsRequired().HasMaxLength(3);
        builder.Property(p => p.CreatedAt).IsRequired();

        builder.HasOne(p => p.Owner)
            .WithMany(u => u.Portfolios)
            .HasForeignKey(p => p.OwnerId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasIndex(p => new { p.OwnerId, p.Name }).IsUnique();
    }


}