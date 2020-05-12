using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ModelStd.LiveData
{
    public class SymbolLiveData
    {
        public string SymbolName { get; set; }
        public string SymbolUrl { get; }

        public SymbolLiveData(string url)
        {
            SymbolUrl = url;
        }

        public async Task<SymbolData> GetLiveDataAsync()
        {
           
            WebRequest request = HttpWebRequest.Create(SymbolUrl);
            WebResponse response = await request.GetResponseAsync();
            Stream responseStream = response.GetResponseStream();
            responseStream = new GZipStream(responseStream, CompressionMode.Decompress);
            StreamReader reader = new StreamReader(responseStream);
            string responseText = reader.ReadToEnd();

            


            return parseResponseText(responseText);
        }

        private SymbolData parseResponseText(string responseText)
        {
            SymbolData symbolData = new SymbolData();
            string[] splittedResponse = responseText.Split(new char[] { ',' }, StringSplitOptions.None);
            symbolData.Time= splittedResponse[0];
            symbolData.A=splittedResponse[1];
            symbolData.TransactionPrice=splittedResponse[2];
            symbolData.Final=splittedResponse[3];
            symbolData.Sell=splittedResponse[4];
            symbolData.YesterdayFinal = splittedResponse[5];
            symbolData.MinDayPrice = splittedResponse[6];
            symbolData.MaxDayPrice = splittedResponse[7];
            symbolData.Counter = splittedResponse[8];
            symbolData.Volume = splittedResponse[9];
            symbolData.TransactionValue = splittedResponse[10];
            symbolData.Zero = splittedResponse[11];
            symbolData.DateEnglish = splittedResponse[12];
            symbolData.Time2 = splittedResponse[13];
            symbolData.State = splittedResponse[14];
            symbolData.NotDiscovered1 = splittedResponse[15];
            symbolData.NotDiscovered2 = splittedResponse[16];
            symbolData.NotDiscovered3 = splittedResponse[17];
            symbolData.NotDiscovered4 = splittedResponse[18];
            symbolData.NotDiscovered5 = splittedResponse[19];
            symbolData.NotDiscovered6 = splittedResponse[20];
            symbolData.NotDiscovered7 = splittedResponse[21];
            symbolData.NotDiscovered8 = splittedResponse[22];
            symbolData.NotDiscovered9 = splittedResponse[23];
            symbolData.NotDiscovered10 = splittedResponse[24];
            symbolData.NotDiscovered11 = splittedResponse[25];
            symbolData.NotDiscovered12 = splittedResponse[26];
            symbolData.NotDiscovered13 = splittedResponse[27];
            symbolData.NotDiscovered14 = splittedResponse[28];
            symbolData.OrderRow1 = splittedResponse[29];
            symbolData.OrderRow2 = splittedResponse[30];
            symbolData.OrderRow3 = splittedResponse[31];
            symbolData.NotDiscovered15 = splittedResponse[32];
            symbolData.NotDiscovered16 = splittedResponse[33];
            symbolData.NotDiscovered17 = splittedResponse[34];

            return symbolData;
        }
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
}
