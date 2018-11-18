using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MetalogixDemoClient.Model
{
    public class DataService : IDataService
    {
        public Task<string> AddCompany(CompanyItem company)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CompanyItem>> GetAllCompanies()
        {
            throw new NotImplementedException();
        }

        public Task<CompanyItem> GetCompany(int Id, string companyName, string countryCode, string companyType)
        {
            throw new NotImplementedException();
        }

        public void GetData(Action<CompanyItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new CompanyItem(0,"DDD", 1, CompanyTypeEnum.Industry );
            callback(item, null);
        }

        public Task<string> UpdateCompany(CompanyItem company)
        {
            throw new NotImplementedException();
        }
    }
}