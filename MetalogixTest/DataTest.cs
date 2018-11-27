using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetalogixData;
using MetalogixDemoClient.Model;
using System.Threading.Tasks;

namespace MetalogixTest
{
    [TestClass]
    public class DataTest
    {
        [TestMethod]
        public async Task  TestStoredInsertCompany()
        {
            ExecuteStoredCompany execute=  new ExecuteStoredCompany();
          await  execute.InsertCompany("testName", 100,(int)CompanyTypeEnum.Telco);

        }

        [TestMethod]
        public void TestStoredSelectCompany()
        {
            ExecuteStoredCompany execute = new ExecuteStoredCompany();
            execute.SelectCompany( 1);

        }
        [TestMethod]
        public async Task TestStoredSelectTypeAll()
        {
            ExecuteStoredCompanyType execute = new ExecuteStoredCompanyType();
           await execute.SelectTypeAll();

        }
        //[TestMethod]
        //public void TestStoredSelectAll()
        //{
        //    ExecuteStoredCompany execute = new ExecuteStoredCompany();
        //    execute.SelectCompany(1);

        //}

        //[TestMethod]
        //public void TestStoredSelectType()
        //{
        //    ExecuteStoredCompany execute = new ExecuteStoredCompany();
        //    execute.SelectCompany(1);

        //}


    }
}
