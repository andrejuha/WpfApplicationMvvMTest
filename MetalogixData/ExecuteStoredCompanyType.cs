using MetalogixDemoClient.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalogixData
{
    public class ExecuteStoredCompanyType
    {
        public CompanyTypeItem InsertType(string Name,int CountryCode,int Company_Type)
        {
            //    Company companies;
            //    using (var db = new CompanyModel( ))
            //    {
            //        var name = new SqlParameter("@Name", Name);
            //        var countryCode = new SqlParameter("@Country_Code", CountryCode);
            //        var companyType = new SqlParameter("@Company_Type", Company_Type);

            //companies = db.Database.SqlQuery<Company>("dbo.usp_CompanyInsert @Name, @Country_Code", name, countryCode).SingleOrDefault();
            //    }
            //    return companies;

            throw new NotImplementedException();
        }
        public void UpdateType(CompanyTypeItem company)
        {
            //using (var db = new CompanyModel())
            //{
            //    var name = new SqlParameter("@Name", company.Name);
            //    var countryCode = new SqlParameter("@Country_Code", company.ContryCode);

            //    var companies = db.Database.SqlQuery<Company>("dbo.usp_CompanyUpdate @Name, @Country_Code", name, countryCode).SingleOrDefault();
            //}

            throw new NotImplementedException();

        }
       
        public async Task<IEnumerable<CompanyTypeItem>>  SelectTypeAll()
        {
          List<CompanyTypeItem> companyTypes=null;
            using (var db = new CompanyModel())
            {
                 companyTypes =await db.Database.SqlQuery<CompanyTypeItem>("usp_Company_TypeSelectAll").ToListAsync();
            }
            return companyTypes;
        }

        public CompanyTypeItem SelectType(int Id)
        {
            //CompanyView companies;
            //using (var db = new CompanyModel())
            //{
            //    var paramId = new SqlParameter("@Id", Id);
            //     companies = db.Database.SqlQuery<CompanyView>("usp_CompanyViewSelect @Id", paramId).SingleOrDefault();

            //}
            //return companies;
            throw new NotImplementedException();
        }

        public void DeleteType(int Id)
        {
            //using (var db = new CompanyModel())
            //{
            //    var name = new SqlParameter("@Id", Id);

            //    var companies = db.Database.SqlQuery<Company>("dbo.usp_CompanyDelete @Id", Id).SingleOrDefault();
            //}
            throw new NotImplementedException();

        }
    }
}
