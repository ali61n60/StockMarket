using ModelStd;
using ModelStd.IRepository;
using RepositoryStd.FileSystem;
using System.Collections.Generic;
using ServiceStd.IOC;
using System.Linq;

namespace ServiceStd
{
    public class StocksInformation
    {
        public List<string> GetAllStocksName()
        {
            ISymbolInfo stocksInfo = Bootstrapper.container.GetInstance<ISymbolInfo>();
            List<string> allNames = new List<string>();
            allNames.AddRange(stocksInfo.GetAllSymbolsName().Select(x => x.NamePersian));
            return allNames;
        }

        public List<PointData> GetStockData(string stockName)
        {
            IDataLoader dataLoader = Bootstrapper.container.GetInstance<IDataLoader>();
            return dataLoader.GetStockData(stockName);
        }
    }
}
