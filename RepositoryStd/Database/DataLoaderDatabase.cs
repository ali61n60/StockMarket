using Microsoft.EntityFrameworkCore;
using ModelStd;
using ModelStd.DB.Stock;
using ModelStd.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryStd.Database
{
    public class DataLoaderDatabase : IDataLoader
    {
        public Dictionary<string, List<PointData>> GetAllStocksData()
        {
            throw new NotImplementedException();
        }

        public List<PointData> GetStockData(string stockName)
        {
            List<PointData> listPointData = new List<PointData>();
            StockDbContext stockDbContext = new StockDbContext();
            var tradeDataForStockName= stockDbContext.TradeDatas
                .Include(tradeData => tradeData.StockInfo)
                .Where(tradeData => tradeData.StockInfo.NamePersian == stockName);

            foreach(TradeData tradeData in tradeDataForStockName)
            {                              
                listPointData.Add(tradeData.GetPointDate());                                             
            }

            listPointData.Sort((a, b) => a.Date.CompareTo(b.Date));
            
            return listPointData;
        }
    }
}
