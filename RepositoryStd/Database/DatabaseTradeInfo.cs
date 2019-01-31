using ModelStd;
using ModelStd.DB;
using RepositoryStd.FileSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;



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
                        newTradeData.Date = pointData.Date;
                        newTradeData.Close =double.Parse(pointData.LastPrice);
                        newTradeData.Final= double.Parse(pointData.FinalPrice);
                        newTradeData.Max = double.Parse(pointData.MaxPrice);
                        newTradeData.Min = double.Parse(pointData.MinPrice);
                        newTradeData.Open = double.Parse(pointData.FirstPrice);
                        newTradeData.Value = double.Parse(pointData.Value);
                        newTradeData.Volume = int.Parse(pointData.Voume);
                        newTradeData.NumberOfDeals = int.Parse(pointData.NumberOfDeals);

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
