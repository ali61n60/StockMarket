using NUnit.Framework;
using ServiceStd;
using System.Collections.Generic;

namespace StockMarketTests.ServiceStdTests
{
    [TestFixture]
    class StockInformationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAllStocksName()
        {
            SymbolService stinfo = new SymbolService();
            List<string> result = stinfo.GetAllSymbolsName();
            Assert.IsFalse(result.Count == 0);
        }
        
    }
}
