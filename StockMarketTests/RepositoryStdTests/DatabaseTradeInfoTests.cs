using NUnit.Framework;
using RepositoryStd.Database;
using ServiceStd;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketTests.RepositoryStdTests
{
    [TestFixture]
    class DatabaseTradeInfoTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void UpdateDatabaseTradeInfoFromCSVFilesTest()
        {
            DatabaseTradeInfo databaseTradeInfo = new DatabaseTradeInfo();
            databaseTradeInfo.InsertTradeInfoFromCSVFilesIntoDatabse();
            Assert.IsFalse(0==1);
        }
        
    }
}
