using ModelStd.DB.Stock;
using System.Collections.Generic;

namespace ServiceStd.IService
{
    public interface ISymbolGroupService
    {
        List<SymbolGroup> GetAllSymbolGroups();
        List<Symbol> GetMembers(int groupId);
    }
}
