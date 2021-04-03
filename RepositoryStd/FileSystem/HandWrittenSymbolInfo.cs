using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ModelStd.IRepository;
using RepositoryStd.Database;

namespace RepositoryStd.FileSystem
{
    public class HandWrittenSymbolInfo : ISymbolInfo
    {
        public List<string> GetAllSymbolsName()
        {            
            string directory = Path.GetDirectoryName(DatabaseInfoClass.CsvFilesPath());
            IEnumerable<string> files = Directory.EnumerateFiles(directory, "*.*")
                .Where(s => s.EndsWith(".csv", StringComparison.OrdinalIgnoreCase)
                        || s.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase)
                        || s.EndsWith(".tiff ", StringComparison.OrdinalIgnoreCase));
            List<string> listStocksName = new List<string>();
            foreach(string fileName in files)
            {
                
                listStocksName.Add(Path.GetFileNameWithoutExtension(fileName));
            }
                
            
            return listStocksName;
        }

       
        
    }
}
