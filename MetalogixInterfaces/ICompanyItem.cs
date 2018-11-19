namespace MetalogixDemoService
{
    public interface ICompanyItem
    {
        int CompanyTypeEnum { get; set; }
        ICompanyTypeItem CompanyTypeItem1 { get; set; }
        int ContryCode { get; }
        int Id { get; }
        string Name { get; }
    }
}