using ModelStd;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceStd.Indicators
{
    public class Averages
    {
        public List<PointData> MovingAverage(List<PointData> data, int number)
        {
            List<PointData> movingAverage = new List<PointData>();

            if (number < 0)
            {
                return movingAverage;
            }

            //for (int i = 0; i < number; i++)
            //{
            //    movingAverage.Add(PointData.Zero);
            //}
            for (int i = number; i < data.Count; i++)
            {
                double closeSum = 0, finalSum = 0, maxSum = 0, minSum = 0, openSum = 0, valueSum = 0;
                int numberOfDealsSum = 0, volumeSum = 0;
                PointData pointDataAverage = new PointData();

                for (int j = 0; j < number; j++)
                {
                    closeSum += data[i - j].Close;
                    finalSum += data[i - j].Final;
                    maxSum += data[i - j].Max;
                    minSum += data[i - j].Min;
                    numberOfDealsSum += data[i - j].NumberOfDeals;
                    openSum += data[i - j].Open;
                    valueSum += data[i - j].Value;
                    volumeSum += data[i - j].Volume;
                }

                pointDataAverage.Close = closeSum / number;
                pointDataAverage.Date = data[i].Date;
                pointDataAverage.Final = finalSum / number;
                pointDataAverage.Max = maxSum / number;
                pointDataAverage.Min = minSum / number;
                pointDataAverage.NumberOfDeals = (int)(numberOfDealsSum / number);
                pointDataAverage.Open = openSum / number;
                pointDataAverage.Value = valueSum / number;
                pointDataAverage.Volume = (int)(volumeSum / number);
                
                movingAverage.Add(pointDataAverage);
            }

            return movingAverage;
        }
    }
}
