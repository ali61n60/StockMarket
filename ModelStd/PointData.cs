using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStd
{
    public class PointData
    {
        public static PointData Zero
        {
            get
            {
                PointData pointDataZero = new PointData();
                pointDataZero.Close = 0;
                pointDataZero.Final = 0;
                pointDataZero.Max = 0;
                pointDataZero.Min = 0;
                pointDataZero.Open = 0;
                pointDataZero.Value = 0;
                pointDataZero.Volume = 0;

                return pointDataZero; 
            }
        }
        public DateTime Date { get; set; }

        public double Open { get; set; }
        public double Close { get; set; }

        public double Min { get; set; }
        public double Max { get; set; }
        
        public double Final { get; set; }

        public int Volume { get; set; }
        public double Value { get; set; }

        public int NumberOfDeals { get; set; }

    }
}
