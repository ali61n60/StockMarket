using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ModelStd.LiveData;
using NUnit.Framework;

namespace StockMarketTests
{
    public class SymbolLiveDataTests
    {

        [Test]
        public void CanDownloadDataFromUrl()
        {
            //SymbolLiveData symbolLiveData = new SymbolLiveData("http://www.tsetmc.com/tsev2/data/instinfofast.aspx?i=26014913469567886&c=39+");
            SymbolLiveData symbolLiveData = new SymbolLiveData("http://www.tsetmc.com/tsev2/data/instinfodata.aspx?i=6110133418282108&c=44+");
            Task<SymbolData> symbolDataTask = symbolLiveData.GetLiveDataAsync();

            SymbolData symbolData = symbolDataTask.Result;

            Assert.That(symbolData.Time.Length > 1);
        }

    }
}
