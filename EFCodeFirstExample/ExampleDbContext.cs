using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstExample
{
    public class ExampleDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }


        public ExampleDbContext(DbContextOptions<ExampleDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

    }
}
