namespace MetalogixDemoClient.Model
{
    public class CompanyItem
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


}



    public enum CompanyTypeEnum
    {
        Industry,
        Navy,
        Telco,
        Other


    }
}