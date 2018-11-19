using System;
using MetalogixDemoService;

namespace MetalogixDemoClient.Model
{
    public class CompanyItem//:ICompanyItem
    {
        public CompanyItem()
        {

        }
        public CompanyItem(int ID, string Name, int CountryCode, CompanyTypeEnum CompanyType)
        {
            this.Id = ID;
            this.Name = Name;
            this.ContryCode = ContryCode;
            this.CompanyTypeEnum = CompanyType;
        }

        public int Id { get;  set; }

        public string  Name { get;  set; }

        public int ContryCode { get;  set; }

        public CompanyTypeEnum CompanyTypeEnum { get; set; }

        public CompanyTypeItem CompanyTypeItem { get; set; }

        //int ICompanyItem.CompanyTypeEnum
        //{
        //    get
        //    {
        //        return (int)CompanyTypeEnum;
        //    }

        //    set
        //    {
        //        CompanyTypeEnum=(CompanyTypeEnum)value;
        //    }
        //}

        //ICompanyTypeItem ICompanyItem.CompanyTypeItem
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }

        //    set
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //int ICompanyItem.ContryCode
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //int ICompanyItem.Id
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //string ICompanyItem.Name
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }



    public enum CompanyTypeEnum
    {
        Industry,
        Navy,
        Telco,
        Other


    }
}