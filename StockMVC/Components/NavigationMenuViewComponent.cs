using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ModelStd;

namespace StockMVC.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        public string Invoke()
        {
            return "Hello from the Nav View Component";
        }
    }
}
