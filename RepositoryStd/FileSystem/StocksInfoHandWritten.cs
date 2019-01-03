using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ModelStd.IRepository;

namespace RepositoryStd.FileSystem
{
    public class StocksInfoHandWritten : IStocksInfo
    {
        public List<string> GetAllStocksName()
        {
            string directoryName = @"C:\Users\test\Documents\TseClient 2.0\";
            string directory = Path.GetDirectoryName(GetDirectoryPath());
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

       
        public string GetDirectoryPath()
        {
            return @"C:\Users\test\Documents\TseClient 2.0\";
        }
    }
}
