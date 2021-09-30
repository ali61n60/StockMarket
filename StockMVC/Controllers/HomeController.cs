using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ModelStd.DB.Stock;
using ServiceStd.IOC;
using ServiceStd.IService;
using StockMVC.Models.ViewModels;
using Newtonsoft.Json;
using ModelStd;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockMVC.Controllers
{
    public class HomeController : Controller
    {
        readonly ISymbolService _symbolService;
        public int PageSize = 4;

        public HomeController()
        {
            _symbolService = Bootstrapper.container.GetInstance<ISymbolService>();
        }

        // GET: /<controller>/
        public IActionResult Index(string symbolGroup, int symbolPage = 1)
        {

            //return Redirect("~/chat");
            //Get All Symbols data               
            List<Symbol> allSymbols = _symbolService.GetAllSymbols()
                                     .Where(s=> symbolGroup==null || s.SymbolGroup.Id==int.Parse(symbolGroup))
                                     .ToList();
            
            IEnumerable<Symbol> symbols = allSymbols.Skip((symbolPage - 1) * PageSize).Take(PageSize);
            
            SymbolListViewModel viewModel = new SymbolListViewModel();
            viewModel.Symbols = symbols;
            viewModel.PagingInfo = new PagingInfo
            {
                CurrentPage = symbolPage,
                ItemsPerPage = PageSize,
                TotalItems = symbolGroup == null ?
                            allSymbols.Count() :
                            allSymbols.Count(s => s.SymbolGroup.Id == int.Parse(symbolGroup))

            };
            viewModel.CurrentSymbolGroup = symbolGroup;


            List<PointData> chartData = _symbolService.GetSymbolTradeData(1);
            List<int> dateTimes = new List<int>();
            List<double> finalPriceList = new List<double>();
            int i = 1;
            foreach(PointData p in chartData)
            {
                dateTimes.Add(i++);
                finalPriceList.Add(p.Final);
            }

            viewModel.ChartDate = JsonConvert.SerializeObject(dateTimes);
            viewModel.ChartFinalePrice= JsonConvert.SerializeObject(finalPriceList);

            return View(viewModel);
        }       
    }
}
