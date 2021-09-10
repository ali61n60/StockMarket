using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceStd.IService;
using System.Text.Json;
using Newtonsoft.Json;

namespace StockMVC.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SymbolController : ControllerBase
    {
        ISymbolService _symbolService;
        public SymbolController(ISymbolService symbolService)
        {
            _symbolService = symbolService;
        }
        public string AllSymbolNames()
        {
           // return JsonSerializer.Serialize(_symbolService.GetAllSymbolsName());

            return JsonConvert.SerializeObject(_symbolService.GetAllSymbolsName());

        }

        public string SayHello([FromQuery] string Name)
        {
            string ret = String.IsNullOrEmpty(Name) ? "A Name parameter is needed as query string. ie.: /sayhello?name=John" 
                : $"Hello {Name} !!!";
            return ret;
        }
    }
}
