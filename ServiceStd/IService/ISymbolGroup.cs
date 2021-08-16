using ModelStd.DB.Stock;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceStd.IService
{
    interface ISymbolGroup
    {
        List<SymbolGroup> GetAllSymbolGroups();
    }
}
