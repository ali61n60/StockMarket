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
        StockDbContext stockDbContext = new StockDbContext();
        public Dictionary<string, List<PointData>> GetAllStocksData()
        {
            throw new NotImplementedException();
        }

        public List<PointData> GetStockData(string stockName)
        {
            List<PointData> listPointData = new List<PointData>();
            
            var tradeDataForStockName= stockDbContext.TradeDatas
                .Include(tradeData => tradeData.Symbol)
                .Where(tradeData => tradeData.Symbol.NamePersian == stockName);

            foreach(TradeData tradeData in tradeDataForStockName)
            {                              
                listPointData.Add(tradeData.GetPointDate());                                             
            }

            listPointData.Sort((a, b) => a.Date.CompareTo(b.Date));
            
            return listPointData;
        }

        public List<PointData> GetAdjustedStockData(string stockName)
        {
            List<PointData> listPointData = GetStockData(stockName);
            //adjusting data based on dividend
            var dividendDataForStockName= stockDbContext.Dividends
                .Include(dividend => dividend.Symbol)
                .Where(dividend => dividend.Symbol.NamePersian == stockName);
            List<double> allD = new List<double>();
            foreach(Dividend d in dividendDataForStockName)
            {
                foreach(PointData pointData in listPointData)
                {
                    if(d.Date<=pointData.Date)
                    {
                        pointData.Final += d.Value;
                    }
                }
            }

            //adjusting data based on capital increase


            return listPointData;
        }
    }
}
