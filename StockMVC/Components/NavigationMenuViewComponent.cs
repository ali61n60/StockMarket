﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ModelStd;
using ModelStd.IRepository;
using ServiceStd.IOC;
using ServiceStd.IService;

namespace StockMVC.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        private ISymbolService _symbolService;

        public NavigationMenuViewComponent()
        {
            _symbolService = Bootstrapper.container.GetInstance<ISymbolService>();
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedSymbolGroup = RouteData?.Values["symbolGroup"];
            if (ViewBag.SelectedSymbolGroup == null)
                ViewBag.SelectedSymbolGroup = "-1";
            return View(_symbolService.GetAllSymbols()
                .Select(x => x.SymbolGroup)
                .Distinct()
                .OrderBy(x => x.Id));                             
        }
    }
}
