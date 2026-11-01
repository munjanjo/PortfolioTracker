namespace PortfolioTracker.Api.Entities;

public class Transaction
{
    public int Id { get; set; }
    public int PortfolioId { get; set; }
    public Portfolio Portfolio { get; set; } = null!;
    public int AssetId { get; set; }
    public Asset Asset { get; set; } = null!;
    public required TransactionType TransactionType { get; set; }
    public decimal Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Fee { get; set; }
    public DateTime ExecutedAt { get; set; }

}
