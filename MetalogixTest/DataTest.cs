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
        public void TestStoredInsert()
        {
            ExecuteStored execute=  new ExecuteStored();
            execute.InsertCompany("testName", 100,(int)CompanyTypeEnum.Telco);

        }

        [TestMethod]
        public void TestStoredSelect()
        {
            ExecuteStored execute = new ExecuteStored();
            execute.SelectCompany( 1);

        }
    }
}
