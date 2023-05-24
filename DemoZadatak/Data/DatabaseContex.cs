using DemoZadatak.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoZadatak.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PersonConfiguration());
        }
        public DbSet<Person> Person { get; set; }
    }
}
