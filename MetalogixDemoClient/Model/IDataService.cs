using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        CompanyTypeItem GetTypeData(int ID);

        Task<IEnumerable<CompanyTypeItem>> GetAllTypeData();

        //Task<string> DeleteCompany(CompanyItem company);

        Task<CompanyItem> GetCompany(int Id,
        string companyName,
        string countryCode,
        string companyType);
    }
}
