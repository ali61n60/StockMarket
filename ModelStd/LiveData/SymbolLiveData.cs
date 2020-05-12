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
            symbolData.Time = responseText;

            return symbolData;
        }

        
       


    }

    public class SymbolData
    {
        public string Time;
        public string TransactionPrice;
    }
}
