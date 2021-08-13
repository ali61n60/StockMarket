﻿using ModelStd;
using ModelStd.DB.Stock;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceStd.IService
{
    public interface IStockInfo
    {
        List<string> GetAllStocksName();
        List<PointData> GetStockData(string stockName);

        List<PointData> GetAdjustedStockData(string stockName);
        List<SymbolGroup> GetAllSymbolGroups();
    }
}