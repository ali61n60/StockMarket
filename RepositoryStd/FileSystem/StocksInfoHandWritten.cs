using System.Collections.Generic;
using ModelStd.IRepository;

namespace RepositoryStd.FileSystem
{
    public class StocksInfoHandWritten : IStocksInfo
    {
        public List<string> GetAllStocksName()
        {
            List<string> listStocksName = new List<string>();
            listStocksName.Add("GDIR1");
            listStocksName.Add("PARK1");

            return listStocksName;
        }

       
        public string GetDirectoryPath()
        {
            return @"C:\Users\test\Documents\TseClient 2.0\";
        }
    }
}
