using ModelStd;
using ModelStd.IRepository;
using System.Collections.Generic;
using ServiceStd.IOC;
using System.Linq;
using ServiceStd.IService;
using ModelStd.DB.Stock;

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
            //get stock trade data
            List<PointData> listPointData= dataLoader.GetStockData(stockName);
            //get stock dividend data
            List<Dividend> dividends = dataLoader.GetDividend(stockName);
            //get stock capital increase data
            //compute adjusted data
            foreach (Dividend d in dividends)
            {
                double dividendFactor = 0;
                //find final price at dividend date and calculate dividend factor
                List<PointData> pointDataAfterDividendDate = listPointData.Where(p => p.Date > d.Date).ToList<PointData>();
                pointDataAfterDividendDate.Sort((a, b) => a.Date.CompareTo(b.Date));
                dividendFactor = d.Value/ pointDataAfterDividendDate.FirstOrDefault().Final;
                
                foreach (PointData pointData in listPointData)
                {   
                    if (d.Date < pointData.Date)
                    {
                        pointData.Final *=(1+dividendFactor);
                    }
                }
            }
            return listPointData;
            
        }

       


    }
}
