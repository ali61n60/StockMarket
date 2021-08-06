using ModelStd;
using RepositoryStd.FileSystem;
using System.Collections.Generic;
using System.Linq;
using ModelStd.DB.Stock;

namespace RepositoryStd.Database
{
    public class DatabaseTradeInfo
    {
        public void InsertTradeInfoFromCSVFilesIntoDatabse()
        {
            DataLoaderFileSystem dataLoaderFileSystem = new DataLoaderFileSystem();
            StockDbContext stockDbContext = new StockDbContext();//todo use ioc
            List<Symbol> SymbolList = stockDbContext.Symbols.ToList<Symbol>();

            //for each stock search for csv file
            foreach(Symbol symbol in SymbolList)
            {                
                List<PointData> listTradeDataFileSystem =  dataLoaderFileSystem.GetStockData(symbol.SymbolLatin);
                List<TradeData> listTradeDataDatabase = stockDbContext.TradeDatas.Where(tradeData => tradeData.SymbolId == symbol.Id).ToList<TradeData>();
                //add new data from file system to database
                foreach(PointData pointData in listTradeDataFileSystem)
                {
                    if(!listTradeDataDatabase.Any(tradeData=>tradeData.Date==pointData.Date))
                    {
                        TradeData newTradeData = new TradeData();
                        newTradeData.SymbolId = symbol.Id;
                        newTradeData.FillFromPointData(pointData);
                        
                        listTradeDataDatabase.Add(newTradeData);
                        stockDbContext.TradeDatas.Add(newTradeData);
                    }
                }
            }
            
            stockDbContext.SaveChanges();
            
            //update data
        }
    }
}
