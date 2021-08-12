using ModelStd;
using ModelStd.IRepository;
using System.Collections.Generic;
using ServiceStd.IOC;
using System.Linq;
using ServiceStd.IService;

namespace ServiceStd
{
    public class StocksInformation:IStockInfo
    {
        public List<string> GetAllStocksName()
        {
            ISymbolInfo stocksInfo = Bootstrapper.container.GetInstance<ISymbolInfo>();
            List<string> allNames = new List<string>();
            allNames.AddRange(stocksInfo.GetAllSymbols().Select(x => x.NamePersian));
            return allNames;
        }

        public List<PointData> GetStockData(string stockName)
        {
            IDataLoader dataLoader = Bootstrapper.container.GetInstance<IDataLoader>();
            return dataLoader.GetStockData(stockName);
        }

       public List<PointData> GetAdjustedStockData(string stockName)
        {
            IDataLoader dataLoader = Bootstrapper.container.GetInstance<IDataLoader>();
            return dataLoader.GetAdjustedStockData(stockName);
        }
    }
}
