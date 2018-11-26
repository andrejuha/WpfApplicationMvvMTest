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
        void GetData(Action<CompanyWcfItem, Exception> callback);
        [OperationContract]
        Task<IEnumerable<CompanyWcfItem>> GetAllCompanies();
        [OperationContract]
        Task<string> UpdateCompany(CompanyWcfItem company);
        [OperationContract]
        Task<string> AddCompany(CompanyWcfItem company);

        //Task<string> DeleteCompany(CompanyWcfItem company);
        [OperationContract]
        Task<CompanyWcfItem> GetCompany(int Id,
        string companyName,
        string countryCode,
        string companyType);
        [OperationContract]
        Task<IEnumerable<CompanyWcfTypeItem>> GetAllTypeData();
        [OperationContract]
        CompanyWcfTypeItem GetTypeData(int ID);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompanyWcfItem
    {
        public CompanyWcfItem() { }
        public CompanyWcfItem(int ID, string Name, int CountryCode, int CompanyType)
        {
            this.Id = ID;
            this.Name = Name;
            this.ContryCode = ContryCode;
            this.CompanyTypeEnum = CompanyType;
        }
        [DataMember]
        public int Id { get;  set; }
        [DataMember]
        public string Name { get;  set; }
        [DataMember]
        public int ContryCode { get;  set; }
        [DataMember]
        public int CompanyTypeEnum { get; set; }
        [DataMember]
        public CompanyWcfTypeItem CompanyTypeItem { get; set; }
    }

    }
