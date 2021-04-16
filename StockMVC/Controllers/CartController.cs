using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelStd.Carts;
using ModelStd.DB.Stock;
using ModelStd.Infrastructure;
using ModelStd.IRepository;
using ServiceStd.IOC;
using StockMVC.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockMVC.Controllers
{
    public class CartController : Controller
    {
        ISymbolInfo _symbolInfo;

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public CartController()
        {
            _symbolInfo = Bootstrapper.container.GetInstance<ISymbolInfo>();
        }

        [HttpGet]
        public IActionResult CartAction(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            return View(new CartViewModel() { Cart = Cart, ReturnUrl = ReturnUrl });
        }

        [HttpPost]
        public IActionResult CartAction(long Id, string returnUrl)
        {
            Symbol symbol = _symbolInfo.GetAllSymbols()
                .FirstOrDefault(s => s.Id == Id);
            if (symbol != null) symbol.SymbolGroup = null;
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(symbol, 1);
            HttpContext.Session.SetJson("cart", Cart);
            return View(new CartViewModel() { Cart = Cart, ReturnUrl = returnUrl });
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
