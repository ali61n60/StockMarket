using System;
using System.Collections.Generic;
using System.Text;

namespace ModelStd.IRepository
{
    public interface IDataLoader
    {
        List<PointData> GetStockData(string stockName);
        List<PointData> GetAdjustedStockData(string stockName);
        Dictionary<string, List<PointData>> GetAllStocksData();
    }
}
