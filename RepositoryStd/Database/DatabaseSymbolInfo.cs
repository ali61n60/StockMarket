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

        public List<Symbol> GetAllSymbols()
        {
           
            List<Symbol> listStockInfo = _stockDbContext.Symbols.ToList();
            foreach(Symbol symbol in listStockInfo)
            {
                symbol.SymbolGroup = _stockDbContext.SymbolGroups.Where(x => x.Id == symbol.GroupId).FirstOrDefault();
            }

           


            return listStockInfo;
        }       
    }
}
