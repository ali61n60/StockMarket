using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModelStd.DB;
using ModelStd.DB.Stock;
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
                if (!shareholderPortfolio.ContainsKey(stockTrading.StockId))
                {
                    shareholderPortfolio.Add(stockTrading.StockId,0);
                }
                shareholderPortfolio[stockTrading.StockId] += stockTrading.Volume;
            }

        }
    }
}
