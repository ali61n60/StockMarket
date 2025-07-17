using ModelStd;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStd.LiveData
{
    public interface ILiveDataWorker
    {
        Task<BestLimitsResponse> GetBestLimitsAsync(string url);
        Task<ClosingPriceInfoResponse> GetClosingPriceInfoAsync(string url);
        Task<SymbolData> GetLiveDataAsync(string url);
    }
}
