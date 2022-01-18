using System.Collections.Generic;
using System.Linq;
using ModelStd.DB.Stock;
using NUnit.Framework;
using RepositoryStd;
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

        [Test]
        public void SyncLocalDatabaseWithServer()
        {
            StockDbContext localContext = new StockDbContext("Data Source= .\\;Initial Catalog=StockDb;Persist Security Info=True;User ID=ayoobfar_ali;Password=119801;MultipleActiveResultSets=true");
            StockDbContext serverContext = new StockDbContext("Data Source = www.elecontrol.ir\\MSSQLSERVER2019; Initial Catalog = elecont1_data; Persist Security Info = True; User ID = elecont1_nejati; Password = Ali11980*; MultipleActiveResultSets = true");

            List<SymbolGroup> localSymbolGroup= localContext.SymbolGroups.ToList();
            List<SymbolGroup> serverSymbolGroup = serverContext.SymbolGroups.ToList();
            foreach (SymbolGroup symbol in localSymbolGroup)
            {
                if (!serverSymbolGroup.Any(s => s.Id == symbol.Id))
                {
                    serverContext.SymbolGroups.Add(symbol);
                }
            }

            List<Symbol> localSymbol = localContext.Symbols.ToList();
            List<Symbol> serverSymbol = serverContext.Symbols.ToList();
            foreach (Symbol symbol in localSymbol)
            {
                if (!serverSymbol.Any(s => s.Id == symbol.Id))
                {
                    serverContext.Symbols.Add(symbol);
                }
            }



            int numberOfChanges = serverContext.SaveChanges();
            return;

        }

    }
}
