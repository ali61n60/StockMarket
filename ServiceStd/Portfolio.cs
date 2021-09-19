using System.Collections.Generic;
using System.Linq;
using ModelStd.DB;
using RepositoryStd;

namespace ServiceStd
{
    public class Portfolio
    {
        public void GetPortfolio(int shareholderId)
        {
            Dictionary<int,int> shareholderPortfolio=new Dictionary<int, int>();
            StockDbContext stockDbContext=new StockDbContext();
           List<StockTrading> shareholderTrades= stockDbContext.StockTradings.Where(stockTrading => stockTrading.ShareholderId == shareholderId).ToList();
            foreach (StockTrading stockTrading in shareholderTrades)
            {
                if (!shareholderPortfolio.ContainsKey(stockTrading.SymbolId))
                {
                    shareholderPortfolio.Add(stockTrading.SymbolId,0);
                }
                shareholderPortfolio[stockTrading.SymbolId] += stockTrading.Volume;
            }

        }
    }
}
