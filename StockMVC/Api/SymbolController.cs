﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ModelStd;
using ServiceStd.IService;
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

        public string GetSymbolTradeData([FromQuery] int symbolId)
        {
            List<PointData> tradeData=  _symbolService.GetSymbolTradeData(symbolId);
            return JsonConvert.SerializeObject(tradeData);
        }

        public string SayHello([FromQuery] string Name)
        {
            string ret = String.IsNullOrEmpty(Name) ? "A Name parameter is needed as query string. ie.: /sayhello?name=John" 
                : $"Hello {Name} !!!";
            return ret;
        }
    }
}
