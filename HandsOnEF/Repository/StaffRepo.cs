using HandsOnEF.Entity;
using HandsOnEFCodeFirst_Demo2.Entities;

namespace HandsOnEF.Repository
{
    public class StaffRepo : IRepository<Staff>
    {
        MyContext cont;
        public StaffRepo(MyContext cont)
        {
            this.cont = cont;
        }
        public void Add(Staff entity)
        {
           cont.staffs.Add(entity);
            cont.SaveChanges();
        }
        
        public void Delete(int id)
        {
            Staff stf = cont.staffs.SingleOrDefault(s => int.Parse(s.Id) == id);
            cont.staffs.Remove(stf);
            cont.SaveChanges();

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
            cont.SaveChanges();

        }
    }
}
