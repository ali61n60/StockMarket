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
        private readonly ISymbolService _symbolService;
        readonly ISymbolGroupService _symbolGroupService;

        public TSDemoController(ISymbolService symbolService, ISymbolGroupService symbolGroupService)
        {
            _symbolService = symbolService;
            _symbolGroupService = symbolGroupService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReactDemo()
        {
            ModelData modelData = new ModelData();

            List<Symbol> allSymbols = _symbolService.GetAllSymbols().ToList();
            foreach (Symbol symbol in allSymbols)
            {
                symbol.SymbolGroup= null;
            }
            modelData.AllSymbols = JsonConvert.SerializeObject(allSymbols);

            List<SymbolGroup> allSymbolGroups= _symbolGroupService.GetAllSymbolGroups();
            modelData.AllSymbolGroups = JsonConvert.SerializeObject(allSymbolGroups);

            return View(modelData);
        }
    }

    public class ModelData
    {
        public string AllSymbols { get; set; }
        public string AllSymbolGroups { get; set; }
    }
}
