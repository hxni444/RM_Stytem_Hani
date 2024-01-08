using Week2_Assesment.Model;

namespace Week2_Assesment.Repository
{
    public interface ICompanyRepo
    {
        public void AddCompany(Company company);
        public List<Company> GetAllCompany();
        public List<Company> GetAllCompanyByCity(string cityName);
        public Company GetCompanyById(int id);
        public void DeleteCompany(int Delid);



    }
}
