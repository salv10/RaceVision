using Microsoft.EntityFrameworkCore;
using RaceVision.Api.Models;

namespace RaceVision.Api.Data;

public class RaceVisionDbContext : DbContext
{
    public RaceVisionDbContext(DbContextOptions<RaceVisionDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
}