using ModelStd.DB.Stock;
using RepositoryStd;
using ServiceStd.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceStd
{
    class SymbolGroupService : ISymbolGroup
    {
        public List<SymbolGroup> GetAllSymbolGroups()
        {
            StockDbContext stockDbContext = new StockDbContext();
            return stockDbContext.SymbolGroups.ToList();
        }
    }
}
