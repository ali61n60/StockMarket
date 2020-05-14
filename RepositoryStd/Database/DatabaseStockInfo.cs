using ModelStd.DB.Stock;
using ModelStd.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryStd.Database
{
    public class DatabaseStockInfo : ISymbolInfo
    {
        public List<string> GetAllSymbolsName()
        {
            List<string> listStockName = new List<string>();
            StockDbContext stockDbContext = new StockDbContext();
            List<Symbol> listStockInfo = stockDbContext.Symbols.ToList();

            foreach(Symbol stock in listStockInfo)
            {
                listStockName.Add(stock.NamePersian);
            }


            return listStockName;
        }

        public string GetDirectoryPath()
        {
            throw new NotImplementedException("No Need For Directory. This is a database implementation, not a file system");
        }
    }
}
