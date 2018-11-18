using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MetalogixDemoClient.Model;

namespace MetalogixDemoClient.Design
{
    public class DesignDataService : IDataService
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
            // Use this to create design time data

            var item = new CompanyItem(0,"designName",0, CompanyTypeEnum.Industry);
            callback(item, null);
        }

        public Task<string> UpdateCompany(CompanyItem company)
        {
            throw new NotImplementedException();
        }
    }
}