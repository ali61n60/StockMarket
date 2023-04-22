using ModelStd;
using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;

namespace ServiceStd.LiveData
{
    public class SymbolLiveData
    {
        public string SymbolName { get; set; }
        public string SymbolUrl { get; }

        public SymbolLiveData(string url)
        {
            SymbolUrl = url;
        }

        

       
    }

   
}
