using ModelStd;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStd.LiveData
{
    public interface ILiveDataWorker
    {
        Task<LiveDataResponse> GetDataAsync();
    }
}
