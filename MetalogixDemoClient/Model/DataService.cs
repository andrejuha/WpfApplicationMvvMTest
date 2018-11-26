using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MetalogixDemoClient.Model
{
    public class DataService : IDataService
    {
        MetalogixDemoClient.MetalogixWcfService.MetalogixDemoServiceClient GmetalogixDemoServiceClient;

        //public DataService(MetalogixDemoClient.MetalogixWcfService.IMetalogixDemoService MetalogixDemoService)
        //{
        //    GmetalogixDemoServiceClient = MetalogixDemoService;
        //}
        public DataService()
        {
            GmetalogixDemoServiceClient = new MetalogixWcfService.MetalogixDemoServiceClient();
        }

        public  Task<string> AddCompany(CompanyItem company)
        {
            MetalogixWcfService.AddCompanyRequest request = new MetalogixWcfService.AddCompanyRequest(company.ConvertCompanyItemToWcf());

            MetalogixWcfService.AddCompanyResponse response = GmetalogixDemoServiceClient.AddCompany(request);
             return Task.FromResult(response.AddCompanyResult);
         
            //GmetalogixDemoServiceClient. await  GmetalogixDemoServiceClient.AddCompanyAsync()
            
        }

        public Task<IEnumerable<CompanyItem>> GetAllCompanies()
        {
            MetalogixWcfService.GetAllCompaniesRequest request = new MetalogixWcfService.GetAllCompaniesRequest();

            MetalogixWcfService.GetAllCompaniesResponse response = GmetalogixDemoServiceClient.GetAllCompanies(request);
            return Task.FromResult(response.GetAllCompaniesResult.ConvertCompanyItemToWcf());
            
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