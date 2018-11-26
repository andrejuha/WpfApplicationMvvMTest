using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetalogixData;
using MetalogixDemoClient.Model;

namespace MetalogixTest
{
    [TestClass]
    public class DataTest
    {
        [TestMethod]
        public void TestStoredInsertCompany()
        {
            ExecuteStoredCompany execute=  new ExecuteStoredCompany();
            execute.InsertCompany("testName", 100,(int)CompanyTypeEnum.Telco);

        }

        [TestMethod]
        public void TestStoredSelectCompany()
        {
            ExecuteStoredCompany execute = new ExecuteStoredCompany();
            execute.SelectCompany( 1);

        }
        [TestMethod]
        public void TestStoredSelectTypeAll()
        {
            ExecuteStoredCompanyType execute = new ExecuteStoredCompanyType();
            execute.SelectTypeAll();

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
