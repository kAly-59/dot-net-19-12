using Microsoft.EntityFrameworkCore;
using ExoPersonnage.Classes;

namespace Exercice01Personnage.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Personnage> Personnages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PersonnageDB;Trusted_Connection=True;");
        }
    }
}