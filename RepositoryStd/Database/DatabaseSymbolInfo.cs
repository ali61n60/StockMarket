﻿using ModelStd.DB.Stock;
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

        public List<string> GetAllSymbolsName()
        {
            List<string> listStockName = new List<string>();
            List<Symbol> listStockInfo = _stockDbContext.Symbols.ToList();

            foreach(Symbol stock in listStockInfo)
            {
                listStockName.Add(stock.NamePersian);
            }


            return listStockName;
        }

        public string CsvFilesPath()
        {
            throw new NotImplementedException("No Need For Directory. This is a database implementation, not a file system");
        }
    }
}