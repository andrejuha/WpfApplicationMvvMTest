using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalogixDemoClient.Model
{
    public interface IDataService
    {
        void GetData(Action<CompanyItem, Exception> callback);

        Task<IEnumerable<CompanyItem>> GetAllCompanies();

        Task<string> UpdateCompany(CompanyItem company);

        Task<string> AddCompany(CompanyItem company);

        //Task<string> DeleteCompany(CompanyItem company);

        Task<CompanyItem> GetCompany(int Id,
        string companyName,
        string countryCode,
        string companyType);
    }
}
