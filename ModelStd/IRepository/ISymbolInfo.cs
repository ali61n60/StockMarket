using ModelStd.DB.Stock;
using System.Collections.Generic;

namespace ModelStd.IRepository
{
    public interface ISymbolInfo
    {
        List<Symbol> GetAllSymbolsName();        
    }

}
