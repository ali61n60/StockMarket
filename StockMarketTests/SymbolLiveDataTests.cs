using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ModelStd.LiveData;
using NUnit.Framework;
using RepositoryStd;
using System.Linq;
using ModelStd.DB.Stock;

namespace StockMarketTests
{
    public class SymbolLiveDataTests
    {

        [Test]
        public void CanDownloadDataFromUrl()
        {
            //SymbolLiveData symbolLiveData = new SymbolLiveData("("http://www.tsetmc.com/tsev2/data/instinfodata.aspx?i=6110133418282108&c=44+");
            StockDbContext stockDbContext =new StockDbContext();
            List<Symbol> symbols = stockDbContext.Symbols.ToList();
            List<LiveDataUrl> liveDataUrls= stockDbContext.LiveDataUrls.ToList();
            SymbolLiveData symbolLiveData = new SymbolLiveData(liveDataUrls.First(a=>a.SymbolId==1).Url);
            Task<SymbolData> symbolDataTask = symbolLiveData.GetLiveDataAsync();

            SymbolData symbolData = symbolDataTask.Result;

            Assert.That(symbolData.Time.Length > 1);
        }

    }
}
