﻿using MetalogixDemoClient.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalogixData
{
    public class ExecuteStored
    {
        public void InsertCompany(string Name,int CountryCode)
        {
            using (var db = new CompanyModel( ))
            {
                var name = new SqlParameter("@Name", Name);
                var countryCode = new SqlParameter("@Country_Code", CountryCode);

                var companies = db.Database.SqlQuery<Company>("dbo.usp_CompanyInsert @Name, @Country_Code", name, countryCode).SingleOrDefault();
            }

        }
        public void UpdateCompany(CompanyItem company)
        {
            using (var db = new CompanyModel())
            {
                var name = new SqlParameter("@Name", company.Name);
                var countryCode = new SqlParameter("@Country_Code", company.ContryCode);

                var companies = db.Database.SqlQuery<Company>("dbo.usp_CompanyUpdate @Name, @Country_Code", name, countryCode).SingleOrDefault();
            }

        }

        public CompanyView SelectCompany(int Id)
        {
            CompanyView companies;
            using (var db = new CompanyModel())
            {
                var paramId = new SqlParameter("@Id", Id);
                 companies = db.Database.SqlQuery<CompanyView>("usp_CompanyViewSelect @Id", paramId).SingleOrDefault();

            }
            return companies;
        }

        public void DeleteCompany(int Id)
        {
            using (var db = new CompanyModel())
            {
                var name = new SqlParameter("@Id", Id);

                var companies = db.Database.SqlQuery<Company>("dbo.usp_CompanyDelete @Id", Id).SingleOrDefault();
            }

        }
    }
}
