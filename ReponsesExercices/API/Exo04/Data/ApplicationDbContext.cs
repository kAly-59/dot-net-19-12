using Exo04.Model;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
#nullable disable
    public DbSet<Contact>? Contacts { get; set; }
#nullable enable
}
