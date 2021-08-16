using ModelStd.DB.Stock;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceStd.IService
{
    public interface ISymbolGroupService
    {
        List<SymbolGroup> GetAllSymbolGroups();
    }
}
