namespace PortfolioTracker.Api.Entities;


public class Portfolio
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string BaseCurrency { get; set; }
    public int OwnerId { get; set; }
    public User Owner { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
