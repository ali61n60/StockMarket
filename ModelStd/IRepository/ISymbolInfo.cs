using System;
using System.Collections.Generic;
using System.Text;

namespace ModelStd.IRepository
{
    public interface ISymbolInfo
    {
        List<string> GetAllSymbolsName();
        string CsvFilesPath();
    }

}
