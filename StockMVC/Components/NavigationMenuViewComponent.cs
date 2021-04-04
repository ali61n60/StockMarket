using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ModelStd;
using ModelStd.IRepository;
using ServiceStd.IOC;

namespace StockMVC.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        private ISymbolInfo symbolInfo;

        public NavigationMenuViewComponent()
        {
            symbolInfo = Bootstrapper.container.GetInstance<ISymbolInfo>();
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedSymbolGroup = RouteData?.Values["symbolGroup"];
            if (ViewBag.SelectedSymbolGroup == null)
                ViewBag.SelectedSymbolGroup = "-1";
            return View(symbolInfo.GetAllSymbols()
                .Select(x => x.SymbolGroup)
                .Distinct()
                .OrderBy(x => x.Id));                             
        }
    }
}
