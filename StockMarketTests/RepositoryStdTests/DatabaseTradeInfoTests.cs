using NUnit.Framework;
using RepositoryStd.Database;

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
