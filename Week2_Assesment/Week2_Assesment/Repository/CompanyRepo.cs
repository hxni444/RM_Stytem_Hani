using Week2_Assesment.Model;

namespace Week2_Assesment.Repository
{
    public class CompanyRepo : ICompanyRepo
    {
        List<Company> CompanyList = new List<Company>();
        public void AddCompany(Company company)
        {
            try
            {
                CompanyList.Add(company);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteCompany(int Delid)
        {
            try
            {
                foreach (var k in CompanyList)
                {
                    if (k.companyId == Delid)
                    {
                        CompanyList.Remove(k);
                        break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Company> GetAllCompany()
        {
            try
            {
                return CompanyList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Company> GetAllCompanyByCity(string cityName)
        {
            try
            {
                List<Company> companies = new List<Company>();
                foreach (var k in CompanyList)
                {
                    if (k.city == cityName)
                    {
                        companies.Add(k);
                    }
                }
                return companies;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Company GetCompanyById(int id)
        {
            try
            {
                foreach (var k in CompanyList)
                {
                    if (k.companyId == id)
                    {
                        return k;
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
