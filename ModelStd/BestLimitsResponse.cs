using System;
using System.Collections.Generic;
using System.Text;

namespace ModelStd
{
    public class BestLimitsResponse
    {       
        public bool IsResultOk;
        public string Message;
        public BestLimits bestLimits;
    }
    public class ClosingPriceInfoResponse
    {
        public bool IsResultOk;
        public string Message;
        public ClosingPriceInfo closingPriceInfo;
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


    //{"bestLimits":
    //               [{"number":1,"qTitMeDem":100,"zOrdMeDem":1,"pMeDem":57.000,"pMeOf":63.000,"zOrdMeOf":2,"qTitMeOf":550,"insCode":null},
    //                {"number":2,"qTitMeDem":1000,"zOrdMeDem":1,"pMeDem":51.000,"pMeOf":68.000,"zOrdMeOf":1,"qTitMeOf":200,"insCode":null},
    //                { "number":3,"qTitMeDem":500,"zOrdMeDem":1,"pMeDem":50.000,"pMeOf":69.000,"zOrdMeOf":1,"qTitMeOf":500,"insCode":null},
    //                { "number":4,"qTitMeDem":2000,"zOrdMeDem":2,"pMeDem":41.000,"pMeOf":73.000,"zOrdMeOf":1,"qTitMeOf":500,"insCode":null},
    //                { "number":5,"qTitMeDem":5000,"zOrdMeDem":5,"pMeDem":1.000,"pMeOf":75.000,"zOrdMeOf":1,"qTitMeOf":200,"insCode":null}]}
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

    public class BestLimits
    {
        public List<BestLimit> bestLimits { get; set; }
    }



    //{"closingPriceInfo":
    //                     {"instrumentState":{"dEven":0,"hEven":0,"insCode":null,"cEtaval":"A ","realHeven":0,"underSupervision":1,"cEtavalTitle":"مجاز"},
    //                     "instrument":null,
    //                     "lastHEven":123002,
    //                     "finalLastDate":20230419,
    //                     "nvt":0.0,
    //                     "mop":0,
    //                     "thirtyDayClosingHistory":null,
    //                     "priceChange":0.0,
    //                     "priceMin":1421.00,
    //                     "priceMax":1470.00,
    //                     "priceYesterday":1445.00,
    //                     "priceFirst":1440.00,
    //                     "last":true,
    //                     "id":0,
    //                     "insCode":"0",
    //                     "dEven":20230419,
    //                     "hEven":123002,
    //                     "pClosing":1440.00,
    //                     "iClose":false,
    //                     "yClose":false,
    //                     "pDrCotVal":1430.00,
    //                     "zTotTran":23070.0,
    //                     "qTotTran5J":1314559284.0,
    //                     "qTotCap":1893427257135.00}}

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ClosingPriceInfo
    {
        public InstrumentState instrumentState { get; set; }
        public object instrument { get; set; }
        public int lastHEven { get; set; }
        public int finalLastDate { get; set; }
        public double nvt { get; set; }
        public int mop { get; set; }
        public object thirtyDayClosingHistory { get; set; }
        public double priceChange { get; set; }
        public double priceMin { get; set; }
        public double priceMax { get; set; }
        public double priceYesterday { get; set; }
        public double priceFirst { get; set; }
        public bool last { get; set; }
        public int id { get; set; }
        public string insCode { get; set; }
        public int dEven { get; set; }
        public int hEven { get; set; }
        public double pClosing { get; set; }
        public bool iClose { get; set; }
        public bool yClose { get; set; }
        public double pDrCotVal { get; set; }
        public double zTotTran { get; set; }
        public double qTotTran5J { get; set; }
        public double qTotCap { get; set; }
    }

    public class InstrumentState
    {
        public int dEven { get; set; }
        public int hEven { get; set; }
        public object insCode { get; set; }
        public string cEtaval { get; set; }
        public int realHeven { get; set; }
        public int underSupervision { get; set; }
        public string cEtavalTitle { get; set; }
    }

    public class Root
    {
        public ClosingPriceInfo closingPriceInfo { get; set; }
    }




}
