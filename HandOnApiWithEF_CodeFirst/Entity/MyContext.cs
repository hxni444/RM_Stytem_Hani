using Microsoft.EntityFrameworkCore;

namespace HandOnApiWithEF_CodeFirst.Entity
{
    public class MyContext : DbContext
    {
      public   DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=RMPLC4CE83617ZZ\SQL2022;Initial Catalog=test;User ID=sa;Password=Password123.;Trust Server Certificate=True");
        }
    }

}
