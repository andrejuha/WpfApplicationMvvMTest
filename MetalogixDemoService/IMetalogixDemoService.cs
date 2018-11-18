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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMetalogixDemoService" in both code and config file together.
    [ServiceContract]
    public interface IMetalogixDemoService
    {

        [OperationContract]
        string GetData(int value);


        void GetData(Action<CompanyWcfItem, Exception> callback);

        Task<IEnumerable<CompanyWcfItem>> GetAllCompanies();

        Task<string> UpdateCompany(CompanyWcfItem company);

        Task<string> AddCompany(CompanyWcfItem company);

        //Task<string> DeleteCompany(CompanyWcfItem company);

        Task<CompanyWcfItem> GetCompany(int Id,
        string companyName,
        string countryCode,
        string companyType);


        [OperationContract]
        CompanyWcfItem GetDataUsingDataContract(CompanyWcfItem composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompanyWcfItem
    {
        public CompanyWcfItem(int ID, string Name, int CountryCode, int CompanyType)
        {
            this.Id = ID;
            this.Name = Name;
            this.ContryCode = ContryCode;
            this.CompanyTypeEnum = CompanyType;
        }
        [DataMember]
        public int Id { get; private set; }
        [DataMember]
        public string Name { get; private set; }
        [DataMember]
        public int ContryCode { get; private set; }
        [DataMember]
        public int CompanyTypeEnum { get; set; }
        [DataMember]
        public CompanyTypeItem CompanyTypeItem { get; set; }
    }

    }
