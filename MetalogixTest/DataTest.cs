using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetalogixData;

namespace MetalogixTest
{
    [TestClass]
    public class DataTest
    {
        [TestMethod]
        public void TestStoredInsert()
        {
            ExecuteStored execute=  new ExecuteStored();
            execute.InsertCompany("testName", 100);

        }
    }
}
