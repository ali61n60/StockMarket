using ModelStd;
using System.Collections.Generic;

namespace ServiceStd.Indicators
{
    public class Volume
    {
        public int CalculateAverageVolume(List<PointData> data, int numberOfDays)
        {
            int volumeSum = 0;
            if (data.Count < numberOfDays || numberOfDays<0)
            {
                return 0;
            }

            for(int i = 0; i < numberOfDays; i++)
            {
                volumeSum += data[data.Count - 1 - i].Volume;
            }

            return volumeSum / numberOfDays;
        }
    }
}
