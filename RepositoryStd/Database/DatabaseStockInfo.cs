using ModelStd.DB;
using ModelStd.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryStd.Database
{
    public class DatabaseStockInfo : IStocksInfo
    {
        public List<string> GetAllStocksName()
        {
            List<string> listStockName = new List<string>();
            StockDbContext stockDbContext = new StockDbContext();
            List<StockInfo> listStockInfo = stockDbContext.StockInfos.ToList();

            foreach(StockInfo stock in listStockInfo)
            {
                listStockName.Add(stock.NamePersian);
            }


            return listStockName;
        }

        public string GetDirectoryPath()
        {
            throw new NotImplementedException("No Need For Directory. This is a database implementation, not a file system");
        }
    }
}
