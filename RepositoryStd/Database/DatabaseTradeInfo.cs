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
            List<StockInfo> listStocksInfo = stockDbContext.StockInfos.ToList<StockInfo>();

            //for each stock search for csv file
            foreach(StockInfo stock in listStocksInfo)
            {                
                List<PointData> listTradeDataFileSystem =  dataLoaderFileSystem.GetStockData(stock.SymbolLatin);
                List<TradeData> listTradeDataDatabase = stockDbContext.TradeDatas.Where(tradeData => tradeData.StockId == stock.StockId).ToList<TradeData>();
                //add new data from file system to database
                foreach(PointData pointData in listTradeDataFileSystem)
                {
                    if(!listTradeDataDatabase.Any(tradeData=>tradeData.Date==pointData.Date))
                    {
                        TradeData newTradeData = new TradeData();
                        newTradeData.StockId = stock.StockId;
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
