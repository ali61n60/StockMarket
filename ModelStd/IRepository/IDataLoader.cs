using ModelStd.DB.Stock;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelStd.IRepository
{
    public interface IDataLoader
    {
        List<PointData> GetSymbolTradeData(int symbolId);    
        
        Dictionary<string, List<PointData>> GetAllStocksData();
        List<Dividend> GetDividend(int symbolId);
    }
}
