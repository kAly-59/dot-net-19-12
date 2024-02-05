using Marmoset.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<MarmosetViewModel> Marmosets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configurations supplémentaires du modèle si nécessaire
    }
}
