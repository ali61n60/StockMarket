using NUnit.Framework;
using ServiceStd;
using System;
using System.Collections.Generic;
using System.Text;

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
