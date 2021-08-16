using ModelStd;
using ModelStd.DB.Stock;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceStd.IService
{
    public interface ISymbolService
    {
        List<string> GetAllSymbolsName();
        List<Symbol> GetAllSymbols();
        List<PointData> GetSymbolTradeData(string symbolName);

        List<PointData> GetAdjustedSymbolTradekData(string symbolName);
       
    }
}
