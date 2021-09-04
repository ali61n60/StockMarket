using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMVC.Controllers
{
    public class RouteTestController : Controller
    {
        public IActionResult Index(int id=10)
        {
            return View(id);
        }
    }
}
