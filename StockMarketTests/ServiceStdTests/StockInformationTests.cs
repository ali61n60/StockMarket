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
            StocksInformation stinfo = new StocksInformation();
            List<string> result = stinfo.GetAllStocksName();
            Assert.IsFalse(result.Count == 0);
        }
        
    }
}
