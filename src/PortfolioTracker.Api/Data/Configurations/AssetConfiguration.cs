using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortfolioTracker.Api.Entities;
namespace PortfolioTracker.Api.Data.Configurations;

public class AssetConfiguration : IEntityTypeConfiguration<Asset>
{
    public void Configure(EntityTypeBuilder<Asset> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Ticker).IsRequired().HasMaxLength(10);
        builder.HasIndex(a => a.Ticker).IsUnique();
        builder.Property(a => a.Name).IsRequired().HasMaxLength(200);
        builder.Property(a => a.Exchange).IsRequired().HasMaxLength(20);
        builder.Property(a => a.Currency).IsRequired().HasMaxLength(3);
    }
}