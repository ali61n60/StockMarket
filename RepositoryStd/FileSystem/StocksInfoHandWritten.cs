using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ModelStd.IRepository;

namespace RepositoryStd.FileSystem
{
    public class StocksInfoHandWritten : ISymbolInfo
    {
        public List<string> GetAllSymbolsName()
        {            
            string directory = Path.GetDirectoryName(CsvFilesPath());
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

       
        public string CsvFilesPath()
        {
            //return @"E:\Ali\Projects\Website\WebAliNejati\Last\StockMarket\RepositoryStd\FileSystem\CSVFiles\";//work
            //return @"C:\Users\test\Source\Repos\StockMarket\RepositoryStd\FileSystem\CSVFiles\";//desktop
            return @"C:\Users\ali\Source\Repos\ali61n60\StockMarket\RepositoryStd\FileSystem\CSVFiles\";//laptop
            //return @"C:\Users\test\Documents\TseClient 2.0\";
        }
    }
}
