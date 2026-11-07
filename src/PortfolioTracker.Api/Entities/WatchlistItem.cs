namespace PortfolioTracker.Api.Entities;

public class WatchlistItem
{
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public int AssetId { get; set; }
    public Asset Asset { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}