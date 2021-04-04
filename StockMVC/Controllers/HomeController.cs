using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelStd.DB.Stock;
using ModelStd.IRepository;
using ServiceStd.IOC;
using StockMVC.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockMVC.Controllers
{
    public class HomeController : Controller
    {
        ISymbolInfo _symbolInfo;
        public int PageSize = 4;

        public HomeController()
        {
             _symbolInfo = Bootstrapper.container.GetInstance<ISymbolInfo>();
        }

        // GET: /<controller>/
        public IActionResult Index(string symbolGroup, int symbolPage = 1)
        {
            //Get All Symbols data            
            List<Symbol> allSymbols = _symbolInfo.GetAllSymbols()
                                     .Where(s=> symbolGroup==null || s.SymbolGroup.Name==symbolGroup)
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
                            allSymbols.Where(s => s.SymbolGroup.Name == symbolGroup).Count()

            };
            viewModel.CurrentSymbolGroup = symbolGroup;
            return View(viewModel);

            //returning static html files
            //return File("/html/demo.html", "text/html");
        }
    }
}
