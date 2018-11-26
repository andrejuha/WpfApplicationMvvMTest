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
        public void ShowDetailsCommandTest()
        {
            MainViewModel mvm= new MainViewModel(_dataService);
            mvm.ShowDetailsCommand.Execute(3+ "|" + 100);
        }
    }
}
