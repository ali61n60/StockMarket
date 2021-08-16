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

        public List<Dividend> GetDividend(int symbolId)
        {
            IQueryable<Dividend> dividend = _stockDbContext.Dividends
              .Include(d => d.Symbol)
              .Where(d => d.Symbol.Id == symbolId);

            return dividend.ToList<Dividend>();
        }

        public List<PointData> GetSymbolTradeData(int  symbolId)
        {
            List<PointData> listPointData = new List<PointData>();
            
            var tradeDataForStockName= _stockDbContext.TradeDatas
                .Include(tradeData => tradeData.Symbol)
                .Where(tradeData => tradeData.Symbol.Id ==symbolId );//Why NamePersian and not id

            foreach(TradeData tradeData in tradeDataForStockName)
            {                              
                listPointData.Add(tradeData.GetPointDate());                                             
            }

            listPointData.Sort((a, b) => a.Date.CompareTo(b.Date));
            
            return listPointData;
        }

       
    }
}
