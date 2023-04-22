using ModelStd;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStd.LiveData
{
    interface ILiveData
    {
        Task<LiveDataResponse> GetPriceAsync();
    }
}
