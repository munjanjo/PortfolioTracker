namespace PortfolioTracker.Api.Entities;


public class Portfolio
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string BaseCurrency { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
