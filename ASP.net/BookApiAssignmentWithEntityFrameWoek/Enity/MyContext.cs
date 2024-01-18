using Microsoft.EntityFrameworkCore;

namespace BookApiAssignmentWithEntityFrameWoek.Enity
{
    public class MyContext : DbContext
    {
        public readonly IConfiguration configobj;
        public MyContext(IConfiguration configobj)
        {
            this.configobj = configobj;
        }
        public DbSet<Book> books { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(configobj.GetConnectionString("MyCon"));
            //optionsBuilder.UseSqlServer(@"Data Source=RMPLC4CE83617ZZ\SQL2022;Initial Catalog=BookBD;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
         
        }

    }
}
