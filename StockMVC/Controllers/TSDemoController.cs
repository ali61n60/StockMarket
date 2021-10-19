using Microsoft.AspNetCore.Mvc;
using ModelStd.DB.Stock;
using ServiceStd.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StockMVC.Controllers
{
    public class TSDemoController : Controller
    {
        readonly ISymbolService _symbolService;

        public TSDemoController(ISymbolService symbolService)
        {
            _symbolService = symbolService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReactDemo()
        {
            List<Symbol> allSymbols = _symbolService.GetAllSymbols().Take(10).ToList();
            foreach (Symbol symbol in allSymbols)
            {
                symbol.SymbolGroup= null;
            }

            return View(model:JsonConvert.SerializeObject(allSymbols));
        }



    }
}
