using HandsOnEF.Entity;
using HandsOnEFCodeFirst_Demo2.Entities;

namespace HandsOnEF.Repository
{
    public class IStaff : IRepository<Staff>
    {
        MyContext cont = new MyContext();
        public void Add(Staff entity)
        {
           cont.staffs.Add(entity);
        }
        
        public void Delete(int id)
        {
            Staff stf = cont.staffs.SingleOrDefault(s => int.Parse(s.Id) == id);
            cont.staffs.Remove(stf);
        }

        public List<Staff> GetALl()
        {
            return cont.staffs.ToList();
        }

        public Staff GetById(int id)
        {
           return cont.staffs.SingleOrDefault(s => int.Parse(s.Id) == id);
        }

        public void Update(Staff entity)
        {
            cont.staffs.Update(entity);
        }
    }
}
