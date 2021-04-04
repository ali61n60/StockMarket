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
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(symbolInfo.GetAllSymbols()
                .Select(x => x.SymbolGroup.Name)
                .Distinct()
                .OrderBy(x => x));                             
        }
    }
}
