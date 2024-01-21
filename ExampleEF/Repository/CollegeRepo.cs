
using ExampleEF.Entity;

namespace ExampleEF.Repository
{
    public class CollegeRepo : ICollegeRepo
    {
        public Mycontext context;
        public CollegeRepo(Mycontext context)
        {
            this.context = context; 
        }
        public void AddCollege(College admin)
        {
           context.colleges.Add(admin);
            context.SaveChanges();
        }

        public void DeleteCollege(int id)
        {
            College col = context.colleges.SingleOrDefault(s=>s.Equals(id));
            context.colleges.Remove(col);
            context.SaveChanges();
        }

        public List<College> Gettall()
        {
           List<College> ColList = context.colleges.ToList();
          
            return ColList;
        }

        public void UpdateCollege(College admin)
        {
            context.colleges.Update(admin);
            context.SaveChanges();
            
        }
    }
}
