﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ModelStd.DB.Stock;
using ModelStd.IRepository;
using ServiceStd.IOC;
using ServiceStd.IService;
using StockMVC.Models.ViewModels;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockMVC.Controllers
{
    public class HomeController : Controller
    {
        
        ISymbolService _symbolService;
        public int PageSize = 4;

        public HomeController()
        {
            _symbolService = Bootstrapper.container.GetInstance<ISymbolService>();
        }

        // GET: /<controller>/
        public IActionResult Index(string symbolGroup, int symbolPage = 1)
        {
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
                            allSymbols.Where(s => s.SymbolGroup.Id == int.Parse(symbolGroup)).Count()

            };
            viewModel.CurrentSymbolGroup = symbolGroup;
            //viewModel.ChartData=_symbolInfo.
            return View(viewModel);

            //returning static html files
            //return File("/html/demo.html", "text/html");
        }       
    }
}
