using ContactApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
#nullable disable
        public DbSet<Contact> Contacts { get; set; }
#nullable enable
    }
}
