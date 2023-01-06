using Microsoft.EntityFrameworkCore;
using SelectCityDemo.Data.Models;

namespace SelectCityDemo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    public DbSet<User> Users { get; set; }
}