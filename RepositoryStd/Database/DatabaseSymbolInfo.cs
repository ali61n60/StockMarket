using ModelStd.DB.Stock;
using ModelStd.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryStd.Database
{
    public class DatabaseSymbolInfo : ISymbolInfo
    {
        StockDbContext _stockDbContext;
        public DatabaseSymbolInfo(StockDbContext stockDbContext)
        {
            _stockDbContext = stockDbContext;
        }

        public List<Symbol> GetAllSymbolsName()
        {
            List<string> listStockName = new List<string>();
            List<Symbol> listStockInfo = _stockDbContext.Symbols.ToList();

            foreach(Symbol stock in listStockInfo)
            {
                listStockName.Add(stock.NamePersian);
            }


            return listStockInfo;
        }       
    }
}
