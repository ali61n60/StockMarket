using ModelStd;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStd.LiveData
{
    public class OptionLiveData : ILiveDataWorker
    {
        private string _url;

        public OptionLiveData(string url)
        {
            _url = url;
        }
        public async Task<LiveDataResponse> GetDataAsync()
        {
            try
            {
                QueueRoot queueRoot = await GetLiveDataAsync();

                return new LiveDataResponse()
                {
                    Orders=queueRoot,
                    IsResultOk = true,
                    Message = "OK"
                };
            }
            catch (Exception ex)
            {
                return new LiveDataResponse()
                {                    
                    IsResultOk = false,
                    Message = ex.Message
                };
            }
        }

        private async Task<QueueRoot> GetLiveDataAsync()
        {

            WebRequest request = HttpWebRequest.Create(_url);
            WebResponse response = await request.GetResponseAsync();
            Stream responseStream = response.GetResponseStream();
            responseStream = new GZipStream(responseStream, CompressionMode.Decompress);
            StreamReader reader = new StreamReader(responseStream);
            string responseText = reader.ReadToEnd();

            return parseResponseText(responseText);
        }

        private QueueRoot parseResponseText(string responseText)
        {
            QueueRoot orders = JsonConvert.DeserializeObject<QueueRoot>(responseText);
            return orders;
        }
    }

    
}
