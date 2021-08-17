﻿using ModelStd.DB.Stock;
using RepositoryStd;
using ServiceStd.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ServiceStd
{
    class SymbolGroupService : ISymbolGroupService
    {
        public List<SymbolGroup> GetAllSymbolGroups()
        {
            StockDbContext stockDbContext = new StockDbContext();
            return stockDbContext.SymbolGroups.ToList();
        }

        public List<Symbol> GetMembers(int groupId)
        {
            StockDbContext s = new StockDbContext();
            return s.Symbols.Where(sy => sy.GroupId == groupId).ToList();
        }
    }
}
