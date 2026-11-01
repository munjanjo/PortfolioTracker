namespace PortfolioTracker.Api.Entities
{
    public class Asset
    {
        public int Id { get; set; }
        public required string Ticker { get; set; }
        public required string Name { get; set; }
        public required string Exchange { get; set; }
        public required string Currency { get; set; }

    }
}