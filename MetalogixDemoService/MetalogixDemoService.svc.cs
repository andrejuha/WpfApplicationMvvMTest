using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace MetalogixDemoService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MetalogixDemoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MetalogixDemoService.svc or MetalogixDemoService.svc.cs at the Solution Explorer and start debugging.
    public class MetalogixDemoService : IMetalogixDemoService
    {
        public Task<string> AddCompany(CompanyWcfItem company)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CompanyWcfItem>> GetAllCompanies()
        {
            throw new NotImplementedException();
        }

        public Task<CompanyWcfItem> GetCompany(int Id, string companyName, string countryCode, string companyType)
        {
            throw new NotImplementedException();
        }

        public void GetData(Action<CompanyWcfItem, Exception> callback)
        {
            throw new NotImplementedException();
        }

        public string GetData(int value)//getAllCompanies();
        {
            return string.Format("You entered: {0}", value);
        }

        public CompanyWcfItem GetDataUsingDataContract(CompanyWcfItem composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            //if (composite.BoolValue)
            //{
            //    composite.StringValue += "Suffix";
            //}
            return composite;
        }

        public Task<string> UpdateCompany(CompanyWcfItem company)
        {
            throw new NotImplementedException();
        }
    }
}
