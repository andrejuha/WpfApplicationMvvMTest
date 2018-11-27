using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetalogixDemoClient.ViewModel;
using MetalogixDemoClient.Model;

namespace MetalogixWpfClientTest
{
    [TestClass]
    public class ClientTest
    {
        IDataService _dataService;
        //public ClientTest(IDataService DataService)
        //{
        //    _dataService = DataService;
        //}
        public ClientTest()
        {
            _dataService = new DataService();
        }
        [TestMethod]
        public void FindCompanyTest()
        {
            MainViewModel mvm= new MainViewModel(_dataService);
            FindParams findParams = new FindParams() { CompanyId = 1, CountryCode = 100 };
            mvm.FindCompanyCommand.Execute(findParams);
        }
    }
}
