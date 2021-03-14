using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelStd.IRepository;
using ServiceStd.IOC;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //Get All Symbols data
            ISymbolInfo symbolInfo= Bootstrapper.container.GetInstance<ISymbolInfo>();
            List<string> symbolNames= symbolInfo.GetAllSymbolsName();

            return View(symbolNames);

            //returning static html files
            //return File("/html/demo.html", "text/html");
        }
    }
}
