using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelStd.IRepository;
using ServiceStd.IOC;
using StockMVC.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockMVC.Controllers
{
    public class HomeController : Controller
    {
        ISymbolInfo _symbolInfo;
        public int PageSize = 10;

        public HomeController()
        {
             _symbolInfo = Bootstrapper.container.GetInstance<ISymbolInfo>();
        }

        // GET: /<controller>/
        public IActionResult Index(int productPage = 1)
        {
            //Get All Symbols data            
            List<string> symbolNames= _symbolInfo.GetAllSymbolsName();
            IEnumerable<string> symbols = symbolNames.Skip((productPage - 1) * PageSize).Take(PageSize);
            
            SymbolListViewModel viewModel = new SymbolListViewModel();
            viewModel.Symbols = symbols;
            viewModel.PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = symbolNames.Count()
            };
            viewModel.CurrentCategory = "NotDecidedYet";
            return View(viewModel);

            //returning static html files
            //return File("/html/demo.html", "text/html");
        }
    }
}
