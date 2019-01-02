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
            listStocksName.Add("GOMZ1");
            listStocksName.Add("PARS1");
            listStocksName.Add("PRDZ1");
            listStocksName.Add("PZGZ1");


            return listStocksName;
        }

       
        public string GetDirectoryPath()
        {
            return @"C:\Users\test\Documents\TseClient 2.0\";
        }
    }
}
