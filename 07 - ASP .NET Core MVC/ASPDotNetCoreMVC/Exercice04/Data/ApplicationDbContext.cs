using Exercice04.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice04.Data
{
    public class ApplicationDbContext : DbContext
    {
        //protected ApplicationDbContext() // : base() // facultatif sur le ctor sans params
        //{
        //}

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\AspMvc;Integrated Security=True");
        }
    }
}
