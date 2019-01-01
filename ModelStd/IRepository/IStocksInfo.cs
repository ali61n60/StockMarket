using System;
using System.Collections.Generic;
using System.Text;

namespace ModelStd.IRepository
{
    public interface IStocksInfo
    {
        List<string> GetAllStocksName();
    }
}
