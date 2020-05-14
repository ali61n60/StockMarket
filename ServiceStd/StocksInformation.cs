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
            ISymbolInfo stocksInfo = Bootstrapper.container.GetInstance<ISymbolInfo>();

            return stocksInfo.GetAllSymbolsName();
        }

        public List<PointData> GetStockData(string stockName)
        {
            IDataLoader dataLoader = Bootstrapper.container.GetInstance<IDataLoader>();
            return dataLoader.GetStockData(stockName);
        }
    }
}
