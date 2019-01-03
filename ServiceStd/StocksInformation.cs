using ModelStd;
using ModelStd.IRepository;
using RepositoryStd.FileSystem;
using System.Collections.Generic;
using ServiceStd.IOC;

namespace ServiceStd
{
    public class StocksInformation
    {
        public List<string> GetAllStocksName()
        {
            IStocksInfo stocksInfo = Bootstrapper.container.GetInstance<IStocksInfo>();

            return stocksInfo.GetAllStocksName();
        }

        public List<PointData> GetStockData(string stockName)
        {
            IDataLoader dataLoader = Bootstrapper.container.GetInstance<IDataLoader>();
            return dataLoader.GetStockData(stockName);
        }
    }
}
