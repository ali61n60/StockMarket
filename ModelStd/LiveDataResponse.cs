using System;
using System.Collections.Generic;
using System.Text;

namespace ModelStd
{
    public class LiveDataResponse
    {
        public double LastPrice;
        public bool IsResultOk;
        public string Message;
        public QueueRoot Orders;
    }

    public class SymbolData
    {
        public string Time;
        public string A;
        public string TransactionPrice;
        public string Final;
        public string Sell;
        public string YesterdayFinal;
        public string MinDayPrice;
        public string MaxDayPrice;
        public string Counter;
        public string Volume;
        public string TransactionValue;
        public string Zero;
        public string DateEnglish;
        public string Time2;
        public string DateTime;
        public string State;
        public string NotDiscovered1;
        public string NotDiscovered2;
        public string NotDiscovered3;
        public string NotDiscovered4;
        public string NotDiscovered5;
        public string NotDiscovered6;
        public string NotDiscovered7;
        public string NotDiscovered8;
        public string NotDiscovered9;
        public string NotDiscovered10;
        public string NotDiscovered11;
        public string NotDiscovered12;
        public string NotDiscovered13;
        public string NotDiscovered14;
        public string OrderRow1;
        public string OrderRow2;
        public string OrderRow3;
        public string NotDiscovered15;
        public string NotDiscovered16;
        public string NotDiscovered17;
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class BestLimit
    {
        public int number { get; set; }
        public int qTitMeDem { get; set; }
        public int zOrdMeDem { get; set; }
        public double pMeDem { get; set; }
        public double pMeOf { get; set; }
        public int zOrdMeOf { get; set; }
        public int qTitMeOf { get; set; }
        public object insCode { get; set; }
    }

    public class QueueRoot
    {
        public List<BestLimit> bestLimits { get; set; }
    }

    
        //{"bestLimits":
        //               [{"number":1,"qTitMeDem":100,"zOrdMeDem":1,"pMeDem":57.000,"pMeOf":63.000,"zOrdMeOf":2,"qTitMeOf":550,"insCode":null},
        //                {"number":2,"qTitMeDem":1000,"zOrdMeDem":1,"pMeDem":51.000,"pMeOf":68.000,"zOrdMeOf":1,"qTitMeOf":200,"insCode":null},
        //                { "number":3,"qTitMeDem":500,"zOrdMeDem":1,"pMeDem":50.000,"pMeOf":69.000,"zOrdMeOf":1,"qTitMeOf":500,"insCode":null},
        //                { "number":4,"qTitMeDem":2000,"zOrdMeDem":2,"pMeDem":41.000,"pMeOf":73.000,"zOrdMeOf":1,"qTitMeOf":500,"insCode":null},
        //                { "number":5,"qTitMeDem":5000,"zOrdMeDem":5,"pMeDem":1.000,"pMeOf":75.000,"zOrdMeOf":1,"qTitMeOf":200,"insCode":null}]}
    
}
