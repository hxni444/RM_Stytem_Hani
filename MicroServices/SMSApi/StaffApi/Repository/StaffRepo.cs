using StaffApi.Models;

namespace StaffApi.Repository
{
    public class StaffRepo : IStaffRepo
    {
        List<Staff> staffs= new List<Staff>();  
        public void AdStaff(Staff staff)
        {
            staffs.Add(staff);
        }

        public void DeleteStaff(string id)
        {
           Staff stf = staffs.Where(s=> s.Id == id).SingleOrDefault();
           staffs.Remove(stf);
        }

        public List<Staff> GetStaffByStd(int std)
        {
            List<Staff> staffWithStd = new List<Staff>();
           foreach (var staff in staffs)
            {
                foreach(var k in staff.std)
                {
                    if (k == std)
                    {
                        staffWithStd.Add(staff);
                    }
                }
            }
            return staffWithStd;
        }

        public List<Staff> GettALL(Staff staff)
        {
            return staffs;
        }

        public void UpdateStaff(Staff staff)
        {
           foreach(var k in staffs)
            {
                k.Id = staff.Id;
                k.std = staff.std;
                k.subject = staff.subject;
                k.Name = staff.Name;
            }
        }
    }
}
