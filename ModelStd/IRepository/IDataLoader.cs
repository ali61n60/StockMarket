using ModelStd.DB.Stock;
using System.Collections.Generic;

namespace ModelStd.IRepository
{
    public interface IDataLoader
    {
        List<PointData> GetSymbolTradeData(int symbolId);    
        
        Dictionary<string, List<PointData>> GetAllStocksData();
        List<Dividend> GetDividend(int symbolId);
    }
}
