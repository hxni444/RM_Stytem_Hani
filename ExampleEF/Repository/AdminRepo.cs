using ExampleEF.Entity;

namespace ExampleEF.Repository
{
    public class AdminRepo
    {
        public Mycontext context;

        public AdminRepo(Mycontext context)
        {
            this.context = context;
        }

            public void AddAdmin(Admin admin)
            {
               context.admins.Add(admin);
                context.SaveChanges();
            }

            public void DeleteAdmin(int id)
            {
               Admin admin = context.admins.SingleOrDefault(s=>s.adminisId == id);
                context.admins.Remove(admin);
                context.SaveChanges();
            }

            public List<Admin> Gettall()
            {
                List<Admin> list = context.admins.ToList();
            return list;
                
            }

            public void UpdateAdmin(Admin admin)
            {
              context.admins.Update(admin);
            context.SaveChanges();
            }
        }

    }

