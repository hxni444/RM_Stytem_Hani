using StaffApi.Models;

namespace StaffApi.Repository
{
    public interface IStaffRepo
    {
        public void AdStaff(Staff staff);
        public void UpdateStaff(Staff staff);
        public void DeleteStaff(string id);
        public List<Staff> GettALL(Staff staff);
        public List<Staff> GetStaffByStd(int std);

    }
}
