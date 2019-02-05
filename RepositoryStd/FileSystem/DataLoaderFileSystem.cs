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
                    
                   
                        tempPoint.Date = DateTime.ParseExact(values[1], "yyyyMMdd", CultureInfo.InvariantCulture);
                    
                    
                    tempPoint.Open =double.Parse(values[2]);
                    tempPoint.Max = double.Parse(values[3]);
                    tempPoint.Min = double.Parse(values[4]);
                    tempPoint.Final = double.Parse(values[5]);
                    tempPoint.Volume = int.Parse(values[6]);
                    tempPoint.Value = double.Parse(values[7]);
                    tempPoint.NumberOfDeals = int.Parse(values[8]);
                   // tempPoint.YesterdayPrice = double.Parse(values[9]);
                    

                        if (values.Length < 11)
                        {
                            listA.Add(tempPoint);
                            continue;
                        }
                    
                   
                    tempPoint.Close = double.Parse(values[14] ?? "0");
                    listA.Add(tempPoint);

                    }
                    catch (Exception )
                    {
                        continue;
                    }
                }
            }
           
            return listA;
        }
    }
}
