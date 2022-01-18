using Microsoft.AspNetCore.Mvc;

namespace StockMVC.Controllers
{
    public class RouteTestController : Controller
    {
        public IActionResult Index(int x,int z)
        {
            MyModelData myModelData = new MyModelData
            {
                A = x,
                B = z
            };
            return View(myModelData);
        }
    }

    public class MyModelData
    {
        public int A { get; set; }
        public int B { get; set; }
    }
}
