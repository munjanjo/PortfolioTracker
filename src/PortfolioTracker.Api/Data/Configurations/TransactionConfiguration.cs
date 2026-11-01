using PortfolioTracker.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PortfolioTracker.Api.Data.Configurations;

public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.TransactionType).HasMaxLength(10).HasConversion<string>().IsRequired();
        builder.Property(t => t.Quantity).IsRequired().HasPrecision(18, 8);
        builder.Property(t => t.Price).IsRequired().HasPrecision(18, 4);
        builder.Property(t => t.Fee).IsRequired().HasPrecision(18, 4);
        builder.Property(t => t.ExecutedAt).IsRequired();

        builder.HasOne(t => t.Portfolio)
            .WithMany(p => p.Transactions)
            .HasForeignKey(t => t.PortfolioId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(t => t.Asset)
            .WithMany()
            .HasForeignKey(t => t.AssetId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}