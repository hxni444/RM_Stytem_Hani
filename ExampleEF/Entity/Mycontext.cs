using Microsoft.EntityFrameworkCore;

namespace ExampleEF.Entity
{
    public class Mycontext:DbContext
    {
        public readonly IConfiguration config;
        public Mycontext(IConfiguration config)
        {
            this.config = config;
        }
        public DbSet<College> colleges { get; set; }
        public DbSet<Admin> admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("con"));
        }

    }
}
