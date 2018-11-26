using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetalogixDemoClient.MetalogixWcfService;
using MetalogixDemoClient.Model;
using System.Threading.Tasks;

namespace MetalogixTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ServiceTest
    {
        public ServiceTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private MetalogixDemoService.MetalogixDemoService testContextInstance =new MetalogixDemoService.MetalogixDemoService();

     

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public async Task TestServiceAddCompany()
        {
            MetalogixDemoService. CompanyWcfItem company = new MetalogixDemoService.CompanyWcfItem() { Name="sss", CompanyTypeEnum= (int)CompanyTypeEnum.Industry, ContryCode=1  };
           await testContextInstance.AddCompany(company);
        }
    }
}
