using ModelStd;
using ModelStd.IRepository;
using RepositoryStd.FileSystem;
using System.Collections.Generic;

namespace ServiceStd
{
    public class StocksInformation
    {
        public List<string> GetAllStocksName()
        {
            IStocksInfo stocksInfo = new StocksInfoHandWritten();

            return stocksInfo.GetAllStocksName();
        }

        public List<PointData> GetStockData(string stockName)
        {
            IDataLoader dataLoader = new DataLoaderFileSystem();
            return dataLoader.GetStockData(stockName);
        }
    }
}
