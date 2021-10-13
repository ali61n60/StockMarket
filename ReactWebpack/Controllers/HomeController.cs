using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactWebpack.Controllers
{
    public class HomeController : Controller
    {
        public List<string> MyList = new List<string>() { "This is my first item", "This is my second item", "And here is the third item" };

        public IActionResult Index()
        {
            return View(MyList);
        }
    }
}

   
