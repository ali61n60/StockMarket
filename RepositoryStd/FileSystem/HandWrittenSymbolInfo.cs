using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ModelStd.DB.Stock;
using ModelStd.IRepository;
using RepositoryStd.Database;

namespace RepositoryStd.FileSystem
{
    public class HandWrittenSymbolInfo 
    {
        public List<Symbol> GetAllSymbols()
        {            
            string directory = Path.GetDirectoryName(DatabaseInfoClass.CsvFilesPath());
            IEnumerable<string> files = Directory.EnumerateFiles(directory, "*.*")
                .Where(s => s.EndsWith(".csv", StringComparison.OrdinalIgnoreCase)
                        || s.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase)
                        || s.EndsWith(".tiff ", StringComparison.OrdinalIgnoreCase));
            List<Symbol> listStocksName = new List<Symbol>();
            foreach(string fileName in files)
            {
                
                listStocksName.Add(new Symbol() { NamePersian = Path.GetFileNameWithoutExtension(fileName) });
            }
                
            
            return listStocksName;
        }

       
        
    }
}
