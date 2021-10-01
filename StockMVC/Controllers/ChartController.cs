using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelStd;
using Newtonsoft.Json;
using ServiceStd.IService;
using StockMVC.Models.ViewModels;

namespace StockMVC.Controllers
{
    public class ChartController : Controller
    {
        readonly ISymbolService _symbolService;

        public ChartController(ISymbolService symbolService)
        {
            _symbolService = symbolService;
        }
        public IActionResult Index()
        {
            ChartData viewModel = new ChartData();

            List<PointData> chartData = _symbolService.GetSymbolTradeData(1);
            List<int> dateTimes = new List<int>();
            List<double> finalPriceList = new List<double>();
            int i = 1;
            foreach (PointData p in chartData)
            {
                dateTimes.Add(i++);
                finalPriceList.Add(p.Final);
            }

            viewModel.ChartDate = JsonConvert.SerializeObject(dateTimes);
            viewModel.ChartFinalePrice = JsonConvert.SerializeObject(finalPriceList);

           
            return View(viewModel);
        }
    }
}
