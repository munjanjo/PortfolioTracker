using Microsoft.EntityFrameworkCore;

namespace PortfolioTracker.Api.Data;

class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{

}