using ModelStd;
using ModelStd.IRepository;
using System.Collections.Generic;
using ServiceStd.IOC;
using System.Linq;
using ServiceStd.IService;
using ModelStd.DB.Stock;
using RepositoryStd;

namespace ServiceStd
{
    public class SymbolService:ISymbolService
    {
        StockDbContext _stockDbContext;
        public SymbolService()
        {
            _stockDbContext = new StockDbContext();
        }
        public List<string> GetAllSymbolsName()
        {           
            List<string> allNames = new List<string>();
            allNames.AddRange(GetAllSymbols().Select(x => x.NamePersian));
            return allNames;
        }

        public List<PointData> GetSymbolTradeData(int symbolId)
        {
            IDataLoader dataLoader = Bootstrapper.container.GetInstance<IDataLoader>();
            return dataLoader.GetSymbolTradeData(symbolId);
        }

       public List<PointData> GetAdjustedSymbolTradekData(int symbolId)
        {
            IDataLoader dataLoader = Bootstrapper.container.GetInstance<IDataLoader>();
            //get stock trade data
            List<PointData> listPointData = dataLoader.GetSymbolTradeData(symbolId);
            //get stock dividend data
            List<Dividend> dividends = dataLoader.GetDividend(symbolId);
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

        public List<Symbol> GetAllSymbols()
        {
            List<Symbol> listStockInfo = _stockDbContext.Symbols.ToList();
                foreach (Symbol symbol in listStockInfo)
                {
                    symbol.SymbolGroup = _stockDbContext.SymbolGroups.Where(x => x.Id == symbol.GroupId).FirstOrDefault();
                }
                return listStockInfo;
        }
        
    }
}
