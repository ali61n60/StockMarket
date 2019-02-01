using ModelStd;
using ModelStd.IRepository;
using ServiceStd.IOC;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceStd
{
    public class StockStatictics
    {
        public double MaxPrice(string stockName,int numberOfDays)
        {
            double result = 0;
            IDataLoader dataLoader = Bootstrapper.container.GetInstance<IDataLoader>();
            List<PointData> stockData = dataLoader.GetStockData(stockName);

            if (stockData.Count == 0)
                return result;
            stockData.Sort((p1, p2) =>  p2.Date.CompareTo(p1.Date));
            for (int i=0;i<stockData.Count && i < numberOfDays; i++)
            {
                double tempMax = stockData[i].Max;
                if (tempMax > result)
                    result = tempMax;
            }

            return result;
        }

        public double MinPrice(string stockName, int numberOfDays)
        {
            double result = 10000000;
            IDataLoader dataLoader = Bootstrapper.container.GetInstance<IDataLoader>();
            List<PointData> stockData = dataLoader.GetStockData(stockName);

            if (stockData.Count == 0)
                return result;
            stockData.Sort((p1, p2) => p2.Date.CompareTo(p1.Date));
            for (int i = 0; i < stockData.Count && i < numberOfDays; i++)
            {
                double tempMin = stockData[i].Min;
                if (tempMin < result)
                    result = tempMin;
            }

            return result;
        }

        public double PriceChangePercent(string stockName, int numberOfDays)
        {
            double priceChange;
            double maxPrice = MaxPrice(stockName, numberOfDays);
            double minPrice = MinPrice(stockName, numberOfDays);
            priceChange = (maxPrice - minPrice)*100/maxPrice;


            return priceChange;
        }
    }
}
