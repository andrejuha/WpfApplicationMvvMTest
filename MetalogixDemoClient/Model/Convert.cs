using MetalogixDemoClient.MetalogixWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalogixDemoClient.Model
{
    public static class Convert
    {

        public static CompanyWcfItem ConvertCompanyItemToWcf(this CompanyItem ci)
        {
            return new CompanyWcfItem() { CompanyTypeEnum = (int)ci.CompanyTypeEnum, ContryCode = ci.ContryCode, CompanyTypeItem = ci.CompanyTypeItem.ConvertCompanyItemToWcf() , Id= ci.Id, Name = ci.Name};//CompanyTypeItem= ci.CompanyTypeItem
        }

        public static CompanyItem ConvertCompanyItemToData(this CompanyWcfItem ci)
        {
            return new CompanyItem() { CompanyTypeEnum = (CompanyTypeEnum)ci.CompanyTypeEnum, ContryCode = ci.ContryCode , Id=ci.Id, CompanyTypeItem= ci.CompanyTypeItem.ConvertCompanyItemToData(), Name= ci.Name};// = ci.CompanyTypeItem.ConvertCompanyItemToWcf() };//CompanyTypeItem= ci.CompanyTypeItem
        }

        public static CompanyWcfTypeItem ConvertCompanyItemToWcf(this CompanyTypeItem ci)
        {
            return new CompanyWcfTypeItem() {   Description= ci.Description, Name= ci.Description };
        }

        public static CompanyTypeItem ConvertCompanyItemToData(this CompanyWcfTypeItem ci)
        {
            return new CompanyTypeItem() { Description = ci.Description, Name = ci.Description };
        }

        public static IEnumerable<CompanyItem> ConvertCompanyItemToWcf(this CompanyWcfItem[] ci)
        {
            List<CompanyItem> CompanyItemList = new List<CompanyItem>();
            foreach (var ciItem in ci)
            {
                CompanyItemList.Add ( ciItem.ConvertCompanyItemToData());
            }
            return CompanyItemList.ToArray();
        }

        public static CompanyWcfItem[] ConvertCompanyItemData(this CompanyItem[] ci)
        {
            List<CompanyWcfItem> CompanyItemList = new List<CompanyWcfItem>();
            foreach (var ciItem in ci)
            {
                CompanyItemList.Add(ciItem.ConvertCompanyItemToWcf());
            }
            return CompanyItemList.ToArray();
        }
    }
}
