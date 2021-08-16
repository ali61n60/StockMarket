using ModelStd.DB.Stock;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceStd.IService
{
    public interface ISymbolGroup
    {
        List<SymbolGroup> GetAllSymbolGroups();
    }
}
