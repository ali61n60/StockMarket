using System;
using System.Threading.Tasks;

namespace ServiceStd.LiveData
{
    public class TseLiveData
    {
        public ReturnData GetPrice(string url)
        {
            try
            {
                SymbolLiveData symbolLiveData = new SymbolLiveData(url);
                Task<SymbolData> symbolDataTask = symbolLiveData.GetLiveDataAsync();

                SymbolData symbolData = symbolDataTask.Result;

                return new ReturnData()
                {
                    price = double.Parse(symbolData.TransactionPrice),
                    resultOk = true
                };
            }
            catch (Exception ex)
            {
                return new ReturnData()
                {
                    price = 1,
                    resultOk = false
                };
            }
        }
    }

    public class ReturnData
    {
        public double price;
        public bool resultOk;
    }
}
