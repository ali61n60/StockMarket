﻿using ModelStd;
using ModelStd.IRepository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RepositoryStd.FileSystem
{
    public class DataLoader : IDataLoader
    {
        public List<PointData> GetStockData(string stockName)
        {
            List<PointData> listPointData;
            IStocksInfo stocksInfo = new StocksInfoHandWritten();
            List<string> allStocksName= stocksInfo.GetAllStocksName();
            if (!allStocksName.Contains(stockName))
                throw new Exception("stock name is not in the list");
            string fileName =stocksInfo.GetDirectoryPath()+stockName+".csv";

            listPointData = readData(fileName);

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
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    tempPoint = new PointData();
                    tempPoint.StockName = values[0];
                    tempPoint.Date = values[1];
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
            }
            return listA;
        }
    }
}
