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
        public void InsertCompany()
        {
            using (var db = new CompanyContext())
            {
                var name = new SqlParameter("@name", txtDepartment.text.trim());
        
        //to get this to work, you will need to change your select inside dbo.insert_department to include name in the resultset
                var department = db.Database.SqlQuery<Company>("dbo.insert_department @name", name).SingleOrDefault();

                //alternately, you can invoke SqlQuery on the DbSet itself:
                //var department = db.Departments.SqlQuery("dbo.insert_department @name", name).SingleOrDefault();

                int departmentID = department.DepartmentId;
            }

        }
        public void UpdateCompany()
        {


        }
    }
}
