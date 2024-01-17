using HandsOnEFCodeFirst_Demo2.Entities;
using Microsoft.EntityFrameworkCore;

namespace HandsOnEF.Entity
{
    public class MyContext:DbContext
    {
     public readonly IConfiguration configuration;
        public MyContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public DbSet<Student> students {  get; set; }
        public DbSet<Mark> marks { get; set; }
        public DbSet<Staff> staffs  { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyConnection"));
          // optionsBuilder.UseSqlServer(@"Data Source=RMPLC4CE83617ZZ\SQL2022;Initial Catalog=SMSDBSE;User ID=sa;Password=Password123.;Trust Server Certificate=True");
           // optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-12J1PAR\SQLEXPRESS;Initial Catalog=PostroDb;Integrated Security=True;Trust Server Certificate=True");

        }
    }
}
