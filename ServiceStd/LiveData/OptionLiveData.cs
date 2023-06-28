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
        

        
        public async Task<BestLimitsResponse> GetBestLimitsAsync(string url)
        {
            try
            {
                WebRequest request = HttpWebRequest.Create(url);
                WebResponse response = await request.GetResponseAsync();
                Stream stream = response.GetResponseStream();
                StreamReader sreader = new StreamReader(stream, Encoding.UTF8);
                string responseString = sreader.ReadToEnd();
                BestLimits orders = JsonConvert.DeserializeObject<BestLimits>(responseString);
                return new BestLimitsResponse()
                {
                    bestLimits=orders,
                    IsResultOk = true,
                    Message = "OK"
                };
            }
            catch (Exception ex)
            {
                return new BestLimitsResponse()
                {                    
                    IsResultOk = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<ClosingPriceInfoResponse> GetClosingPriceInfoAsync(string url)
        {
            try
            {
                WebRequest request = HttpWebRequest.Create(url);
                WebResponse response = await request.GetResponseAsync();
                Stream stream = response.GetResponseStream();
                StreamReader sreader = new StreamReader(stream, Encoding.UTF8);
                string responseString = sreader.ReadToEnd();
                Root priceInfo = JsonConvert.DeserializeObject<Root>(responseString);
                return new ClosingPriceInfoResponse()
                {
                    closingPriceInfo=priceInfo.closingPriceInfo,
                    IsResultOk = true,
                    Message = "OK"
                };
            }
            catch (Exception ex)
            {
                return new ClosingPriceInfoResponse()
                {
                    IsResultOk = false,
                    Message = ex.Message
                };
            }
        }

        

       
    }

    
}
