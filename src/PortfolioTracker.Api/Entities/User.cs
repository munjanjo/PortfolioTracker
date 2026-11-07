namespace PortfolioTracker.Api.Entities;

public class User
{
    public int Id { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }

    public ICollection<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
    public UserRole Role { get; set; } = UserRole.User;
    public ICollection<WatchlistItem> WatchlistItems { get; set; } = new List<WatchlistItem>();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}