using ModelStd;
using ModelStd.IRepository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace RepositoryStd.FileSystem
{
    public class DataLoaderFileSystem : IDataLoader
    {
        private static Dictionary<string, List<PointData>> allStocksData = new Dictionary<string, List<PointData>>();

        public void CreateRepository()
        {
            
        }

        public Dictionary<string, List<PointData>> GetAllStocksData()
        {
            throw new NotImplementedException();
        }

        public List<PointData> GetStockData(string stockName)
        {
            if (allStocksData.ContainsKey(stockName))
            {
                return allStocksData[stockName];
            }

            List<PointData> listPointData=new List<PointData>();
            IStocksInfo stocksInfo = new StocksInfoHandWritten();
            List<string> allStocksName= stocksInfo.GetAllStocksName();
            if (!allStocksName.Contains(stockName))
                return listPointData;

            string fileName =stocksInfo.GetDirectoryPath()+stockName+".csv";

            listPointData = readData(fileName);
            allStocksData.Add(stockName, listPointData);
            return listPointData;
        }  

        private List<PointData> readData(string fileName)
        {
            List<PointData> listA = new List<PointData>();
            using (var reader = new StreamReader(fileName, Encoding.Unicode))
            {
                PointData tempPoint;

                while (!reader.EndOfStream)
                {
                    try
                    {
                        string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    tempPoint = new PointData();
                    tempPoint.StockName = values[0];
                   
                        tempPoint.Date = DateTime.ParseExact(values[1], "yyyyMMdd", CultureInfo.InvariantCulture);
                    
                    
                    tempPoint.FirstPrice = values[2];
                    tempPoint.MaxPrice = values[3];
                    tempPoint.MinPrice = values[4];
                    tempPoint.FinalPrice = values[5];
                    tempPoint.Voume = values[6];
                    tempPoint.Value = values[7];
                    tempPoint.NumberOfDeals = values[8];
                    tempPoint.YesterdayPrice = values[9];
                    tempPoint.CompanyCode = values[10];
                    tempPoint.LatinName = values[11];
                    tempPoint.CompanyName = values[12];
                    tempPoint.Date2 = values[13];
                    tempPoint.LastPrice = values[14];
                    listA.Add(tempPoint);
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }
            }
           
            return listA;
        }
    }
}
