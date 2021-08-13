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
        StockDbContext _stockDbContext = new StockDbContext();
        public Dictionary<string, List<PointData>> GetAllStocksData()
        {
            throw new NotImplementedException();
        }

        public List<Dividend> GetDividend(string stockName)
        {
            IQueryable<Dividend> dividend = _stockDbContext.Dividends
              .Include(d => d.Symbol)
              .Where(d => d.Symbol.NamePersian == stockName);

            return dividend.ToList<Dividend>();
        }

        public List<PointData> GetStockData(string stockName)
        {
            List<PointData> listPointData = new List<PointData>();
            
            var tradeDataForStockName= _stockDbContext.TradeDatas
                .Include(tradeData => tradeData.Symbol)
                .Where(tradeData => tradeData.Symbol.NamePersian == stockName);

            foreach(TradeData tradeData in tradeDataForStockName)
            {                              
                listPointData.Add(tradeData.GetPointDate());                                             
            }

            listPointData.Sort((a, b) => a.Date.CompareTo(b.Date));
            
            return listPointData;
        }

       
    }
}
