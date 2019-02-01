using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStd
{
    public class PointData
    {                
        public DateTime Date { get; set; }

        public double Open { get; set; }
        public double Close { get; set; }

        public double Min { get; set; }
        public double Max { get; set; }
        
        public double Final { get; set; }

        public int Volume { get; set; }
        public double Value { get; set; }

        public int NumberOfDeals { get; set; }
        public double YesterdayPrice { get; set; }        
               

    }
}
