using ModelStd;
using ModelStd.DB.Stock;
using System.Collections.Generic;

namespace ServiceStd.IService
{
    public interface ISymbolService
    {
        List<string> GetAllSymbolsName();
        List<Symbol> GetAllSymbols();
        List<PointData> GetSymbolTradeData(int symbolId);

        List<PointData> GetAdjustedSymbolTradekData(int symbolId);
        List<PointData> GetRatio(int symbolIdNumerator, int symbolIdDenominator, bool adjustedPrice=false);
       
    }
}
